using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace RhinoMac
{
  /*
  static class Selector
  {
    public static IntPtr GetHandle(string name)
    {
      return UnsafeNativeMethods.GetHandle(name);
    }
  }
  */

  static class Interop
  {
    public static void RegisterRhinoWindowController(IntPtr pController, INotifyPropertyChanged viewmodel)
    {
      m_all_controllers.Add(pController, viewmodel);
    }
    
    public static void Init()
    {
      UnsafeNativeMethods.RUI_RegisterBoolCallbacks(m_getbool_callback, m_setbool_callback);
      UnsafeNativeMethods.RUI_RegisterStringCallbacks(m_getstring_callback, m_setstring_callback);
      UnsafeNativeMethods.RUI_RegisterActionCallback(m_perform_action);
      UnsafeNativeMethods.RUI_RegisterWindowWillCloseCallback(m_willclose_callback);
      UnsafeNativeMethods.RUI_RegisterPropertyTypeCallback(m_propertytype_callback);
      UnsafeNativeMethods.RUI_RegisterActionExistsCallback(m_actionexists_callback);
    }
    
    internal delegate int GetBoolValueCallback(IntPtr handle, [MarshalAs(UnmanagedType.LPWStr)]string name);
    internal delegate void SetBoolValueCallback(IntPtr handle, [MarshalAs(UnmanagedType.LPWStr)]string name, int value);
    [return: MarshalAs(UnmanagedType.LPWStr)]
    internal delegate string GetStringValueCallback(IntPtr handle, [MarshalAs(UnmanagedType.LPWStr)]string name);
    internal delegate void SetStringValueCallback(IntPtr handle, [MarshalAs(UnmanagedType.LPWStr)]string name, [MarshalAs(UnmanagedType.LPWStr)]string value);
    internal delegate void PerformActionCallback(IntPtr handle, [MarshalAs(UnmanagedType.LPWStr)]string name);
    internal delegate void WindowWillCloseCallback(IntPtr handle);
    internal delegate int PropertyTypeCallback(IntPtr handle, [MarshalAs(UnmanagedType.LPWStr)]string name);
    internal delegate int ActionExistsCallback(IntPtr handle, [MarshalAs(UnmanagedType.LPWStr)]string name);
    
    
    static Dictionary<IntPtr, INotifyPropertyChanged> m_all_controllers = new Dictionary<IntPtr, INotifyPropertyChanged>();
    static GetBoolValueCallback m_getbool_callback = GetBoolCalledFromC;
    static SetBoolValueCallback m_setbool_callback = SetBoolCalledFromC;
    static GetStringValueCallback m_getstring_callback = GetStringCalledFromC;
    static SetStringValueCallback m_setstring_callback = SetStringCalledFromC;
    static PerformActionCallback m_perform_action = PerformActionCalledFromC;
    static WindowWillCloseCallback m_willclose_callback = WindowWillCloseCalledFromC;
    static PropertyTypeCallback m_propertytype_callback = PropertyTypeCalledFromC;
    static ActionExistsCallback m_actionexists_callback = ActionExistsCalledFromC;
    
    static int GetBoolCalledFromC(IntPtr pController, string name)
    {
      int rc = 0;
      if( m_all_controllers.ContainsKey(pController) )
      {
        var item = m_all_controllers[pController];
        var prop = item.GetType().GetProperty(name);
        if( prop!=null )
        {
          bool b = (bool)prop.GetValue(item, null);
          rc = b?1:0;
        }
      }
      return rc;
    }
    
    static string GetStringCalledFromC(IntPtr pController, string name)
    {
      string rc = null;
      if( m_all_controllers.ContainsKey(pController) )
      {
        var item = m_all_controllers[pController];
        var prop = item.GetType().GetProperty(name);
        if( prop!=null )
        {
          rc = prop.GetValue(item, null).ToString();
        }
      }
      return rc;
    }
    
    static void SetBoolCalledFromC(IntPtr pController, string name, int value)
    {
      if( m_all_controllers.ContainsKey(pController) )
      {
        var item = m_all_controllers[pController];
        var prop = item.GetType().GetProperty(name);
        if( prop!=null )
          prop.SetValue(item, value!=0, null);
      }
    }
    
    static void SetStringCalledFromC(IntPtr pController, string name, string value)
    {
      if( m_all_controllers.ContainsKey(pController) )
      {
        var item = m_all_controllers[pController];
        var prop = item.GetType().GetProperty(name);
        if( prop!=null )
          prop.SetValue(item, value, null);
      }
    }
    
    static void PerformActionCalledFromC(IntPtr pController, string name)
    {
      if( m_all_controllers.ContainsKey(pController) )
      {
        var item = m_all_controllers[pController];
        var method = item.GetType().GetMethod(name);
        if( method!=null )
          method.Invoke(item, null);
      }
    }
    
    static void WindowWillCloseCalledFromC(IntPtr pController)
    {
      m_all_controllers.Remove(pController);
    }
    
    enum PropertyType : int
    {
      ruitypePropertyDoesNotExist = -1,
      ruitypeUnknown = 0,
      ruitypeBoolean,
      ruitypeString,
    }
    static int PropertyTypeCalledFromC(IntPtr pController, string name)
    {
      PropertyType rc = PropertyType.ruitypePropertyDoesNotExist;
      if( m_all_controllers.ContainsKey(pController) )
      {
        var item = m_all_controllers[pController];
        var prop = item.GetType().GetProperty(name);
        if( prop!=null )
        {
          rc = PropertyType.ruitypeUnknown;
          if( prop.PropertyType == typeof(bool) )
            rc = PropertyType.ruitypeBoolean;
          else if(prop.PropertyType == typeof(string) )
            rc = PropertyType.ruitypeString;
        }
      }
      return (int)rc;
    }
    
    static int ActionExistsCalledFromC(IntPtr pController, string name)
    {
      int rc = 0;
      if( m_all_controllers.ContainsKey(pController) )
      {
        var item = m_all_controllers[pController];
        var method = item.GetType().GetMethod(name);
        if( method!=null )
          rc = 1;
      }
      return rc;
    }
    
  }
}

