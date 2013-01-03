using System;
using System.Runtime.InteropServices;

namespace RhinoMac.ObjCRuntime {
  public class Selector : IEquatable<Selector>
  {
    public static readonly IntPtr Init = Selector.GetHandle ("init");
    public static readonly IntPtr InitWithCoder = Selector.GetHandle ("initWithCoder:");
    static IntPtr MethodSignatureForSelector = Selector.GetHandle ("methodSignatureForSelector:");
    static IntPtr FrameLength = Selector.GetHandle ("frameLength");
    internal static IntPtr Alloc = Selector.GetHandle ("alloc");
    internal static IntPtr Release = Selector.GetHandle ("release");
    
    internal IntPtr handle;
    
    public Selector (IntPtr sel) {
      if (!sel_isMapped (sel))
        throw new ArgumentException ("sel is not a selector handle.");
      
      this.handle = sel;
    }
    
    public Selector (string name, bool alloc) {
      if (alloc) {
        IntPtr selstr_ptr = Marshal.StringToHGlobalAuto (name);
        handle = sel_registerName (selstr_ptr);
        
        if (selstr_ptr != sel_getName (handle))
          Marshal.FreeHGlobal (selstr_ptr);
      } else {
        handle = sel_registerName (name);
      }
    }
    
    public Selector (string name) : this (name, false) {}
    
    public static int GetFrameLength (IntPtr @this, IntPtr sel)
    {
      IntPtr sig = Messaging.IntPtr_objc_msgSend_IntPtr (@this, MethodSignatureForSelector, sel);
      return Messaging.int_objc_msgSend (sig, FrameLength);
    }
    
    public IntPtr Handle {
      get { return handle; }
    }
    
    public string Name {
      get { return Marshal.PtrToStringAuto (sel_getName (handle)); }
    }
    
    public static Selector Register (IntPtr handle) {
      return new Selector (handle);
    }
    
    public static bool operator!= (Selector left, Selector right) {
      if (((object)left) == null)
        return (((object)right) != null);
      if (((object)right) == null)
        return true;
      
      return !sel_isEqual (left.handle, right.handle);
    }
    
    public static bool operator== (Selector left, Selector right) {
      if (((object)left) == null)
        return (((object)right) == null);
      if (((object)right) == null)
        return false;
      
      return sel_isEqual (left.handle, right.handle);
    }
    
    public override bool Equals (object right) {
      if (right == null)
        return false;
      
      if (right is Selector)
        return Equals ((Selector) right);
      
      return false;
    }
    
    public bool Equals (Selector right) {
      if (right == null)
        return false;
      
      return sel_isEqual (handle, right.handle);
    }
    
    public override int GetHashCode () {
      return (int) handle;
    }
    
    [DllImport ("/usr/lib/libobjc.dylib")]
    extern static IntPtr sel_getName (IntPtr sel);
    [DllImport ("/usr/lib/libobjc.dylib")]
    extern static IntPtr sel_registerName (IntPtr name);
    [DllImport ("/usr/lib/libobjc.dylib")]
    internal extern static IntPtr sel_registerName (string name);
    [DllImport ("/usr/lib/libobjc.dylib", EntryPoint="sel_registerName")]
    public extern static IntPtr GetHandle (string name);
    [DllImport ("/usr/lib/libobjc.dylib")]
    extern static bool sel_isMapped (IntPtr sel);
    [DllImport ("/usr/lib/libobjc.dylib")]
    extern static bool sel_isEqual (IntPtr lhs, IntPtr rhs);
  }
}
