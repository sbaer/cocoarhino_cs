using System;
using System.Reflection;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.IO;
using RhinoMac.Foundation;

namespace RhinoMac.ObjCRuntime {
  
  public static class Runtime {
    static List <Assembly> assemblies;
    static Dictionary <IntPtr, WeakReference> object_map = new Dictionary <IntPtr, WeakReference> ();
    static object lock_obj = new object ();
    static IntPtr selClass = Selector.GetHandle ("class");

    internal static List<Assembly> GetAssemblies () {
      if (assemblies == null) {
        var this_assembly = typeof (Runtime).Assembly.GetName ();
        assemblies = new List <Assembly> ();
        
        foreach (Assembly a in AppDomain.CurrentDomain.GetAssemblies ()){
          
          var refs = a.GetReferencedAssemblies ();
          foreach (var aref in refs){
            if (aref == this_assembly)
              assemblies.Add (a);
          }
        }
      }
      
      return assemblies;
    }
    
    internal static void UnregisterNSObject (IntPtr ptr) {
      lock (lock_obj) {
        object_map.Remove (ptr);
      }
    }
    
    internal static void RegisterNSObject (NSObject obj, IntPtr ptr) {
      lock (lock_obj) {
        object_map [ptr] = new WeakReference (obj);
        obj.Handle = ptr;
      }
    }
    
    public static NSObject TryGetNSObject (IntPtr ptr) {
      lock (lock_obj) {
        WeakReference reference;
        if (object_map.TryGetValue (ptr, out reference))
          return (NSObject) reference.Target;
      }
      
      return null;
    }
    
    public static NSObject GetNSObject (IntPtr ptr) {
      Type type;
      
      if (ptr == IntPtr.Zero)
        return null;
      
      lock (lock_obj) {
        WeakReference reference;
        if (object_map.TryGetValue (ptr, out reference)) {
          NSObject target = (NSObject) reference.Target;
          
          if (target != null)
            return target;
        }
      }
      
      type = Class.Lookup (Messaging.intptr_objc_msgSend (ptr, selClass));
      
      if (type != null) {
        return (NSObject) Activator.CreateInstance (type, new object[] { ptr });
      } else {
        Console.WriteLine ("WARNING: Cannot find type for {0} ({1}) using NSObject", new Class (ptr).Name, ptr);
        return new NSObject (ptr);
      }
    }
  }
}
