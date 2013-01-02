using System;
using System.Runtime.InteropServices;

namespace CocoaRhino_CS
{
  [System.Security.SuppressUnmanagedCodeSecurity]
  static class UnsafeNativeMethods
  {
    const string nativelib = "__Internal";
    
    [DllImport(nativelib, CallingConvention = CallingConvention.Cdecl)]
    public static extern void RUI_RegisterBoolCallbacks(ViewModelBase.GetBoolValueCallback getFunc,
                                                        ViewModelBase.SetBoolValueCallback setFunc);

    [DllImport(nativelib, CallingConvention = CallingConvention.Cdecl)]
    public static extern void RUI_RegisterStringCallbacks(ViewModelBase.GetStringValueCallback getFunc,
                                                          ViewModelBase.SetStringValueCallback setFunc);

    [DllImport(nativelib, CallingConvention = CallingConvention.Cdecl)]
    public static extern void RUI_RegisterActionCallback (ViewModelBase.PerformActionCallback actionFunc);

    [DllImport(nativelib, CallingConvention = CallingConvention.Cdecl)]
    public static extern void RUI_RegisterWindowWillCloseCallback(ViewModelBase.WindowWillCloseCallback willCloseFunc);

    [DllImport(nativelib, CallingConvention = CallingConvention.Cdecl)]
    public static extern void RUI_RegisterPropertyTypeCallback(ViewModelBase.PropertyTypeCallback propertyTypeFunc);

    [DllImport(nativelib, CallingConvention = CallingConvention.Cdecl)]
    public static extern void RUI_RegisterActionExistsCallback(ViewModelBase.ActionExistsCallback actionExistsFunc);

    [DllImport(nativelib, CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr RUI_CreateWindow([MarshalAs(UnmanagedType.LPWStr)]string nib);

    [DllImport(nativelib, CallingConvention = CallingConvention.Cdecl)]
    public static extern void RUI_ValueChanged(IntPtr handle, [MarshalAs(UnmanagedType.LPWStr)]string value);

    [DllImport(nativelib, CallingConvention = CallingConvention.Cdecl)]
    public static extern void RUI_ShowModalWindow(IntPtr controller);
    
    [DllImport(nativelib, CallingConvention = CallingConvention.Cdecl)]
    public static extern void ShowWindow(IntPtr handle);

    [DllImport(nativelib, CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr RUI_GetWindow(IntPtr createWindowHandle);
  }
}

