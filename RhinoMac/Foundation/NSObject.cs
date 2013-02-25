using System;
using System.Reflection;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using RhinoMac.ObjCRuntime;

namespace RhinoMac.Foundation
{
  public class NSObjectFlag {
    public static readonly NSObjectFlag Empty = null;
    
    NSObjectFlag () {}
  }
  
  [StructLayout(LayoutKind.Sequential)]
  public partial class NSObject : IDisposable
  {
    public static readonly Assembly MonoMacAssembly = typeof (NSObject).Assembly;
    
    static IntPtr selAlloc = Selector.GetHandle ("alloc");
    static IntPtr selAwakeFromNib = Selector.GetHandle ("awakeFromNib");
    static IntPtr selDoesNotRecognizeSelector = Selector.GetHandle ("doesNotRecognizeSelector:");
    static IntPtr selPerformSelectorOnMainThreadWithObjectWaitUntilDone = Selector.GetHandle ("performSelectorOnMainThread:withObject:waitUntilDone:");
    static IntPtr selPerformSelectorWithObjectAfterDelay = Selector.GetHandle ("performSelector:withObject:afterDelay:");
    static IntPtr selRelease = Selector.GetHandle ("release");
    static IntPtr selRespondsToSelector = Selector.GetHandle ("respondsToSelector:");

    private IntPtr handle;
    private IntPtr super;
    private IntPtr gchandle;
    private object lock_obj = new object ();
    
#if COREBUILD
    static IntPtr class_ptr = Class.GetHandle ("NSObject");
    public virtual IntPtr ClassHandle  { get { return class_ptr; } }
#endif
    protected bool IsDirectBinding;
    
    public NSObject () {
      AllocIfNeeded ();
      InitializeObject ();
    }
    
    // This is just here as a constructor chain that can will
    // only do Init at the most derived class.
    public NSObject (NSObjectFlag x) : this ()
    {
    }
    
    public NSObject (IntPtr handle) {
      this.handle = handle;
      InitializeObject ();
      Retain ();
    }
    
    ~NSObject () {
      Dispose (false);
    }
    
    public void Dispose () {
      Dispose (true);
      GC.SuppressFinalize (this);
    }
    
    public virtual bool RespondsToSelector (Selector sel) {
      if (sel == null)
        throw new ArgumentNullException ("sel");
      if (IsDirectBinding) {
        return Messaging.bool_objc_msgSend_intptr (Handle, selRespondsToSelector, sel.Handle);
      } else {
        return Messaging.bool_objc_msgSendSuper_intptr (SuperHandle, selRespondsToSelector, sel.Handle);
      }
    }
    
    public virtual void DoesNotRecognizeSelector (Selector sel) {
      if (sel == null)
        throw new ArgumentNullException ("sel");
      Console.WriteLine ("CRITICAL WARNING: [{0} {1}] is not recognized", this.GetType (), sel.Name);
      
      Messaging.void_objc_msgSendSuper_intptr (SuperHandle, selDoesNotRecognizeSelector, sel.Handle);
    }
    
    private void InitializeObject () {
      IsDirectBinding = (this.GetType ().Assembly == NSObject.MonoMacAssembly);
      Runtime.RegisterNSObject (this, handle);
      
#if !OBJECT_REF_TRACKING
      gchandle = GCHandle.ToIntPtr (GCHandle.Alloc (this));
#endif
    }
    
    protected virtual void Dispose (bool disposing) {
      if (handle != IntPtr.Zero) {
        Runtime.UnregisterNSObject (handle);
        if (disposing) {
          if (Class.IsCustomType (this.GetType ()))
            Messaging.void_objc_msgSendSuper (SuperHandle, selRelease);
          else
            Messaging.void_objc_msgSend (handle, selRelease);
          
          if (super != IntPtr.Zero) {
            Marshal.FreeHGlobal (super);
            super = IntPtr.Zero;
          }
        } else {
          if (Class.IsCustomType (this.GetType ())) {
            MonoMac_Disposer.AddSuper (SuperHandle);
          } else {
            MonoMac_Disposer.AddDirect (handle);
            if (super != IntPtr.Zero) {
              Marshal.FreeHGlobal (super);
              super = IntPtr.Zero;
            }
          }
        }
        handle = IntPtr.Zero;
      }
    }
    
#if OBJECT_REF_TRACKING
    internal void Release () {
      Messaging.void_objc_msgSend (handle, selRelease);
    }
    
    internal void Retain () {
      Messaging.void_objc_msgSend (handle, selRetain);
    }
    
    [Export ("release")]
    internal void NativeRelease () {
      lock (lock_obj) {
        uint count = Messaging.UInt32_objc_msgSend (handle, selRetainCount);
        Messaging.void_objc_msgSendSuper (SuperHandle, selRelease);
        
        if (count == 2) {
          if (gchandle != IntPtr.Zero) {
            GCHandle h = (GCHandle) gchandle;
            h.Free ();
            gchandle = IntPtr.Zero;
          } else {
            Console.WriteLine ("[NativeRelease ERROR]: type: {0} handle: {1} count: {2} gchandle: {3}", this.GetType (), (int) handle, count, gchandle);
          }
        }
      }
    }
    
    [Export ("retain")]
    internal IntPtr NativeRetain () {
      lock (lock_obj) {
        uint count = Messaging.UInt32_objc_msgSend (handle, selRetainCount);
        Messaging.void_objc_msgSendSuper (SuperHandle, selRetain);
        
        if (count == 1) {
          if (gchandle == IntPtr.Zero) {
            gchandle = GCHandle.ToIntPtr (GCHandle.Alloc (this));
          } else {
            Console.WriteLine ("[NativeRetain ERROR]: type: {0} handle: {1} count: {2} gchandle: {3}", this.GetType (), (int) handle, count, gchandle);
          }
        }
      }
      
      return handle;
    }
#else
    internal void Release () {}
    internal IntPtr Retain () {
      return IntPtr.Zero;
    }
#endif
    
    public IntPtr SuperHandle {
      get {
        if (super == IntPtr.Zero) {
          super = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (objc_super)));
          objc_super sup = new objc_super ();
          sup.receiver = handle;
          // Find the threshold class
          sup.super = ClassHandle;
          Marshal.StructureToPtr (sup, super, false);
        }
        return super;
      }
    }
    
    public IntPtr Handle {
      get { return handle; }
      set {
        if (handle != value) {
          Runtime.UnregisterNSObject (handle);
          handle = value;
          Runtime.RegisterNSObject (this, handle);
        }
      }
    }
    
    private void AllocIfNeeded () {
      if (handle == IntPtr.Zero)
        handle = Messaging.intptr_objc_msgSend (new Class (this.GetType ()).Handle, selAlloc);
    }
    
    private IntPtr GetObjCIvar (string name) {
      IntPtr native = IntPtr.Zero;
      
      object_getInstanceVariable (handle, name, ref native);
      
      return native;
    }
    
    public NSObject GetNativeField (string name) {
      IntPtr field = GetObjCIvar (name);
      
      if (field == IntPtr.Zero)
        return null;
      return Runtime.GetNSObject (field);
    }
    
    private void SetObjCIvar (string name, IntPtr value) {
      object_setInstanceVariable (handle, name, value);
    }
    
    public void SetNativeField (string name, NSObject value) {
      if (value == null)
        SetObjCIvar (name, IntPtr.Zero);
      else
        SetObjCIvar (name, value.Handle);
    }
    
    internal void SetAsProxy () {
      IsDirectBinding = true;
    }
    
    public virtual void PerformSelector (Selector sel, NSObject obj, double delay) {
      if (sel == null)
        throw new ArgumentNullException ("sel");
      if (IsDirectBinding) {
        Messaging.void_objc_msgSend_intptr_intptr_double (this.Handle, selPerformSelectorWithObjectAfterDelay, sel.Handle, obj == null ? IntPtr.Zero : obj.Handle, delay);
      } else {
        Messaging.void_objc_msgSendSuper_intptr_intptr_double (this.SuperHandle, selPerformSelectorWithObjectAfterDelay, sel.Handle, obj == null ? IntPtr.Zero : obj.Handle, delay);
      }
    }
    
    [DllImport ("/usr/lib/libobjc.dylib")]
    extern static void object_getInstanceVariable (IntPtr obj, string name, ref IntPtr val);
    [DllImport ("/usr/lib/libobjc.dylib")]
    extern static void object_setInstanceVariable (IntPtr obj, string name, IntPtr val);
    
    private struct objc_super {
      public IntPtr receiver;
      public IntPtr super;
    }
    
    public virtual void AwakeFromNib ()
    {
      if (IsDirectBinding) {
        Messaging.void_objc_msgSend (this.Handle, selAwakeFromNib);
      } else {
        Messaging.void_objc_msgSendSuper (this.SuperHandle, selAwakeFromNib);
      }
    }
    
    private void InvokeOnMainThread (Selector sel, NSObject obj, bool wait)
    {
      Messaging.void_objc_msgSend_intptr_intptr_bool (this.Handle, selPerformSelectorOnMainThreadWithObjectWaitUntilDone, sel.Handle, obj == null ? IntPtr.Zero : obj.Handle, wait);
    }
    
    public void BeginInvokeOnMainThread (Selector sel, NSObject obj)
    {
      InvokeOnMainThread (sel, obj, false);
    }
    
    public void InvokeOnMainThread (Selector sel, NSObject obj)
    {
      InvokeOnMainThread (sel, obj, true);
    }
    
    public void BeginInvokeOnMainThread (NSAction action)
    {
      var d = new NSAsyncActionDispatcher (action);
      Messaging.void_objc_msgSend_intptr_intptr_bool (d.Handle, selPerformSelectorOnMainThreadWithObjectWaitUntilDone, 
                                                      NSActionDispatcher.Selector.Handle, d.Handle, false);
    }
    
    public void InvokeOnMainThread (NSAction action)
    {
      var d = new NSActionDispatcher (action);
      Messaging.void_objc_msgSend_intptr_intptr_bool (d.Handle, selPerformSelectorOnMainThreadWithObjectWaitUntilDone, 
                                                      NSActionDispatcher.Selector.Handle, d.Handle, true);
      GC.KeepAlive (d);
    }
    
    
    internal class MonoMac_Disposer : NSObject {
      static readonly List <IntPtr> direct_handles = new List<IntPtr> ();
      static readonly List <IntPtr> super_handles = new List<IntPtr> ();
      static readonly object lock_obj = new object ();
      static readonly IntPtr class_ptr = Class.GetHandle ("__MonoMac_Disposer");
      static readonly IntPtr selDrain = Selector.sel_registerName ("drain:");
      static readonly IntPtr selPerformSelectorOnMainThreadWithObjectWaitUntilDone = Selector.sel_registerName ("performSelectorOnMainThread:withObject:waitUntilDone:");
      
      private MonoMac_Disposer () { }
      
      internal static void AddDirect (IntPtr handle) {
        Add (direct_handles, handle);
      }
      
      internal static void AddSuper (IntPtr handle) {
        Add (super_handles, handle);
      }
      
      static void Add (List<IntPtr> list, IntPtr handle)
      {
        bool call_drain;
        lock (lock_obj) {
          list.Add (handle);
          call_drain = list.Count == 1;
        }
        if (!call_drain)
          return;
        
        Messaging.void_objc_msgSend_intptr_intptr_bool (class_ptr, selPerformSelectorOnMainThreadWithObjectWaitUntilDone, selDrain, IntPtr.Zero, false);
      }
      
      internal static void Drain (NSObject ctx) {
        List<IntPtr> direct = null;
        List<IntPtr> super = null;
        
        lock (lock_obj) {
          if (direct_handles.Count > 0) {
            direct = new List<IntPtr> (direct_handles);
            direct_handles.Clear ();
          }
          
          if (super_handles.Count > 0) {
            super = new List<IntPtr> (super_handles);
            super_handles.Clear ();
          }
        }
        
        if (super != null)
        foreach (IntPtr x in super) {
          Messaging.void_objc_msgSendSuper (x, selRelease);
          Marshal.FreeHGlobal (x);
        }
        if (direct != null)
          foreach (IntPtr x in direct)
            Messaging.void_objc_msgSend (x, selRelease);
      }
    }
  }
}
