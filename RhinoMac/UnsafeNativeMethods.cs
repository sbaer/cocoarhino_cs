using System;
using System.Runtime.InteropServices;

namespace RhinoMac
{
  [System.Security.SuppressUnmanagedCodeSecurity]
  static class UnsafeNativeMethods
  {
    const string nativelib = "__Internal";
    
    [DllImport(nativelib, CallingConvention = CallingConvention.Cdecl)]
    public static extern void RUI_RegisterBoolCallbacks(Interop.GetBoolValueCallback getFunc,
                                                        Interop.SetBoolValueCallback setFunc);

    [DllImport(nativelib, CallingConvention = CallingConvention.Cdecl)]
    public static extern void RUI_RegisterStringCallbacks(Interop.GetStringValueCallback getFunc,
                                                          Interop.SetStringValueCallback setFunc);

    [DllImport(nativelib, CallingConvention = CallingConvention.Cdecl)]
    public static extern void RUI_RegisterActionCallback (Interop.PerformActionCallback actionFunc);

    [DllImport(nativelib, CallingConvention = CallingConvention.Cdecl)]
    public static extern void RUI_RegisterWindowWillCloseCallback(Interop.WindowWillCloseCallback willCloseFunc);

    [DllImport(nativelib, CallingConvention = CallingConvention.Cdecl)]
    public static extern void RUI_RegisterPropertyTypeCallback(Interop.PropertyTypeCallback propertyTypeFunc);

    [DllImport(nativelib, CallingConvention = CallingConvention.Cdecl)]
    public static extern void RUI_RegisterActionExistsCallback(Interop.ActionExistsCallback actionExistsFunc);

    [DllImport(nativelib, CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr RUI_CreateWindow([MarshalAs(UnmanagedType.LPWStr)]string nib);

    [DllImport(nativelib, CallingConvention = CallingConvention.Cdecl)]
    public static extern void RUI_ValueChanged(IntPtr handle, [MarshalAs(UnmanagedType.LPWStr)]string value);

    [DllImport(nativelib, CallingConvention = CallingConvention.Cdecl)]
    public static extern void RUI_ShowModalWindow(IntPtr controller);
    
    [DllImport(nativelib, CallingConvention = CallingConvention.Cdecl)]
    public static extern void RUI_ShowWindow(IntPtr handle);

    [DllImport(nativelib, CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr RUI_GetWindow(IntPtr createWindowHandle);


    const string LIBOBJC_DYLIB = "/usr/lib/libobjc.dylib";
    
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static uint uint_objc_msgSend (IntPtr receiver, IntPtr selector);
    
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static int int_objc_msgSend (IntPtr receiver, IntPtr selector);

    [DllImport (LIBOBJC_DYLIB, EntryPoint="sel_registerName")]
    public extern static IntPtr GetHandle (string name);

  }
}

