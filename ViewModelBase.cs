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
      UnsafeNativeMethods.RUI_RegisterActionCallback(m_perform_action);
      m_handle = UnsafeNativeMethods.RUI_CreateWindow(WindowName);
      m_all_controllers.Add(m_handle, this);
    }

    public string WindowName { get; private set; }

    public void ShowModal()
    {
      UnsafeNativeMethods.RUI_ShowModalWindow(m_handle);
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
    internal delegate void PerformActionCallback(IntPtr handle, [MarshalAs(UnmanagedType.LPWStr)]string name);
    
    
    static Dictionary<IntPtr, ViewModelBase> m_all_controllers = new Dictionary<IntPtr, ViewModelBase>();
    static GetBoolValueCallback m_getbool_callback = GetBoolCalledFromC;
    static SetBoolValueCallback m_setbool_callback = SetBoolCalledFromC;
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
    
    static void PerformActionCalledFromC(IntPtr handle, string name)
    {
      if( m_all_controllers.ContainsKey(handle) )
      {
        var item = m_all_controllers[handle];
        var method = item.GetType().GetMethod("PerformAction");
        if( method!=null )
          method.Invoke(item, new object[]{name});
        //item.PerformAction(name);
      }
    }

  }
}

