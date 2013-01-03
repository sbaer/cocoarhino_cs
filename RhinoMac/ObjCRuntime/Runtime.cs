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
    
    public static void RegisterAssembly (Assembly a) {
      var attributes = a.GetCustomAttributes (typeof (RequiredFrameworkAttribute), false);
      //string basePath = Path.Combine (AppDomain.CurrentDomain.BaseDirectory, "..");
      string assloc = Assembly.GetExecutingAssembly().Location;
      string assdir = Path.GetDirectoryName(assloc);
      string basePath = Path.Combine (assdir, "..");
      foreach (var attribute in attributes) {
        var requiredFramework = (RequiredFrameworkAttribute)attribute;
        string libPath;
        string libName = requiredFramework.Name;
        
        if (libName.Contains (".dylib")) {
          libPath = Path.Combine (basePath, "Resources");
        }
        else {
          libPath = Path.Combine (basePath, "Frameworks");
          libPath = Path.Combine (libPath, libName);
          libName = libName.Replace (".frameworks", "");
        }
        libPath = Path.Combine (libPath, libName);
        
//        if (Dlfcn.dlopen (libPath, 0) == IntPtr.Zero)
//          throw new Exception (string.Format ("Unable to load required framework: '{0}'", requiredFramework.Name),
//                               new Exception (Dlfcn.dlerror()));
      }
      
      if (assemblies == null) {
        assemblies = new List <Assembly> ();
        //Class.Register (typeof (NSObject));
      }
      
      assemblies.Add (a);
      
//      foreach (Type type in a.GetTypes ()) {
//        if (type.IsSubclassOf (typeof (NSObject)) && !Attribute.IsDefined (type, typeof (ModelAttribute), false))
//          Class.Register (type);
 //     }
    }
    
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
    /*
    public static void ConnectMethod (MethodInfo method, Selector selector) {
      if (method == null)
        throw new ArgumentNullException ("method");
      if (selector == null)
        throw new ArgumentNullException ("selector");
      var type = method.DeclaringType;
      
      if (!Class.IsCustomType (type))
        throw new ArgumentException ("Cannot late bind methods on core types");
      
      var ea = new ExportAttribute (selector.Name);
      var klass = new Class (type);
      
      Class.RegisterMethod (method, ea, type, klass.Handle);
    }
    */
  }
}
