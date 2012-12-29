using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace CocoaRhino_CS
{
  public abstract class ViewModelBase : INotifyPropertyChanged
  {
    IntPtr m_handle = IntPtr.Zero;

    protected ViewModelBase(string windowName)
    {
      WindowName = windowName;
      UnsafeNativeMethods.RUI_RegisterBoolCallbacks(m_getbool_callback, m_setbool_callback);
      UnsafeNativeMethods.RUI_RegisterStringCallbacks(m_getstring_callback, m_setstring_callback);
      UnsafeNativeMethods.RUI_RegisterActionCallback(m_perform_action);
    }

    public string WindowName { get; private set; }

    public void ShowModal()
    {
      string ass_loc = GetType().Assembly.Location;
      string ass_dir = System.IO.Path.GetDirectoryName(ass_loc);
      string nib = System.IO.Path.Combine(ass_dir, "CocoaRhinoWindow.nib");
    

      if( m_handle==IntPtr.Zero )
      {
        m_handle = UnsafeNativeMethods.RUI_CreateWindow(nib);
        m_all_controllers.Add(m_handle, this);
      }
      UnsafeNativeMethods.RUI_ShowModalWindow(m_handle);
      m_all_controllers.Remove(m_handle);
      m_handle = IntPtr.Zero;
    }


    /// <summary>
    /// Raised when a property on this object has a new value
    /// </summary>
    public event PropertyChangedEventHandler PropertyChanged;

    /// <summary>
    /// Raises the property changed event.
    /// </summary>
    /// <param name='propertyName'>
    /// Property name.
    /// </param>
    protected virtual void OnPropertyChanged(string propertyName)
    {
      if( PropertyChanged!=null )
      {
        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
      }
      if( m_handle!=IntPtr.Zero )
        UnsafeNativeMethods.RUI_ValueChanged(m_handle, propertyName.ToLowerInvariant());
    }

    internal delegate int GetBoolValueCallback(IntPtr handle, [MarshalAs(UnmanagedType.LPWStr)]string name);
    internal delegate void SetBoolValueCallback(IntPtr handle, [MarshalAs(UnmanagedType.LPWStr)]string name, int value);
    [return: MarshalAs(UnmanagedType.LPWStr)]
    internal delegate string GetStringValueCallback(IntPtr handle, [MarshalAs(UnmanagedType.LPWStr)]string name);
    internal delegate void SetStringValueCallback(IntPtr handle, [MarshalAs(UnmanagedType.LPWStr)]string name, [MarshalAs(UnmanagedType.LPWStr)]string value);
    internal delegate void PerformActionCallback(IntPtr handle, [MarshalAs(UnmanagedType.LPWStr)]string name);
    
    
    static Dictionary<IntPtr, ViewModelBase> m_all_controllers = new Dictionary<IntPtr, ViewModelBase>();
    static GetBoolValueCallback m_getbool_callback = GetBoolCalledFromC;
    static SetBoolValueCallback m_setbool_callback = SetBoolCalledFromC;
    static GetStringValueCallback m_getstring_callback = GetStringCalledFromC;
    static SetStringValueCallback m_setstring_callback = SetStringCalledFromC;
    static PerformActionCallback m_perform_action = PerformActionCalledFromC;
    
    static int GetBoolCalledFromC(IntPtr handle, string name)
    {
      int rc = 0;
      if( m_all_controllers.ContainsKey(handle) )
      {
        var item = m_all_controllers[handle];
        var prop = item.GetType().GetProperty(name);
        if( prop!=null )
        {
          bool b = (bool)prop.GetValue(item, null);
          rc = b?1:0;
        }
      }
      return rc;
    }
    
    static string GetStringCalledFromC(IntPtr handle, string name)
    {
      string rc = null;
      if( m_all_controllers.ContainsKey(handle) )
      {
        var item = m_all_controllers[handle];
        var prop = item.GetType().GetProperty(name);
        if( prop!=null )
        {
          rc = prop.GetValue(item, null).ToString();
        }
      }
      return rc;
    }

    static void SetBoolCalledFromC(IntPtr handle, string name, int value)
    {
      if( m_all_controllers.ContainsKey(handle) )
      {
        var item = m_all_controllers[handle];
        var prop = item.GetType().GetProperty(name);
        if( prop!=null )
          prop.SetValue(item, value!=0, null);
      }
    }
    
    static void SetStringCalledFromC(IntPtr handle, string name, string value)
    {
      if( m_all_controllers.ContainsKey(handle) )
      {
        var item = m_all_controllers[handle];
        var prop = item.GetType().GetProperty(name);
        if( prop!=null )
          prop.SetValue(item, value, null);
      }
    }

    static void PerformActionCalledFromC(IntPtr handle, string name)
    {
      if( m_all_controllers.ContainsKey(handle) )
      {
        var item = m_all_controllers[handle];
        var method = item.GetType().GetMethod(name);
        if( method!=null )
          method.Invoke(item, null);
      }
    }

  }
}

