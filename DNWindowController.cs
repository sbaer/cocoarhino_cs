using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace CocoaRhino_CS
{
  public class DNWindowController
  {
    const string _Check1Name = "check1";
    const string _Check2Name = "check2";
    const string _Check3Name = "check3";
    const string _PushMeName = "pushme";
    const string _WindowName = "DNWindow";
    IntPtr m_handle;

    public DNWindowController()
    {
      UnsafeNativeMethods.RUI_RegisterBoolCallbacks(m_getbool_callback, m_setbool_callback);
      UnsafeNativeMethods.RUI_RegisterActionCallback(m_perform_action);
      m_handle = UnsafeNativeMethods.RUI_CreateWindow(_WindowName);
      m_all_controllers.Add(m_handle, this);
    }
    
    public void ShowModal()
    {
      UnsafeNativeMethods.RUI_ShowModalWindow(m_handle);
    }
    
    bool m_check1 = false;
    bool m_check2 = true;
    bool m_check3 = false;
    public bool Check1
    {
      get
      {
        return m_check1;
      }
      set
      {
        if( m_check1!=value )
        {
          m_check1 = value;
          UnsafeNativeMethods.RUI_ValueChanged(m_handle, _Check1Name);
        }
      }
    }

    public bool Check2
    {
      get
      {
        return m_check2;
      }
      set
      {
        if( m_check2!=value )
        {
          m_check2 = value;
          UnsafeNativeMethods.RUI_ValueChanged(m_handle, _Check2Name);
        }
      }
    }
    
    public bool Check3
    {
      get
      {
        return m_check3;
      }
      set
      {
        if( m_check3!=value )
        {
          m_check3 = value;
          UnsafeNativeMethods.RUI_ValueChanged(m_handle, _Check3Name);
        }
      }
    }
    
    static int pushmeIdx=0;
    public void PerformAction(string name)
    {
      if( name==_PushMeName )
      {
        // Toggle the value of one of the check boxes
        if (++pushmeIdx > 3)
          pushmeIdx = 1;
        if (pushmeIdx == 1) {
          Check1 = !Check1;
        }
        if (pushmeIdx == 2) {
          Check2 = !Check2;
        }
        if (pushmeIdx == 3) {
          Check3 = !Check3;
        }
      }
    }
    
    
    
    
    internal delegate int GetBoolValueCallback(IntPtr handle, [MarshalAs(UnmanagedType.LPWStr)]string name);
    internal delegate void SetBoolValueCallback(IntPtr handle, [MarshalAs(UnmanagedType.LPWStr)]string name, int value);
    internal delegate void PerformActionCallback(IntPtr handle, [MarshalAs(UnmanagedType.LPWStr)]string name);
    
    
    static Dictionary<IntPtr, DNWindowController> m_all_controllers = new Dictionary<IntPtr, DNWindowController>();
    static GetBoolValueCallback m_getbool_callback = GetBoolCalledFromC;
    static SetBoolValueCallback m_setbool_callback = SetBoolCalledFromC;
    static PerformActionCallback m_perform_action = PerformActionCalledFromC;
    
    static int GetBoolCalledFromC(IntPtr handle, string name)
    {
      int rc = 0;
      if( m_all_controllers.ContainsKey(handle) )
      {
        var item = m_all_controllers[handle];
        if( name==_Check1Name )
          rc = item.Check1?1:0;
        else if( name==_Check2Name )
          rc = item.Check2?1:0;
        else if( name==_Check3Name )
          rc = item.Check3?1:0;
      }
      return rc;
    }
    
    static void SetBoolCalledFromC(IntPtr handle, string name, int value)
    {
      if( m_all_controllers.ContainsKey(handle) )
      {
        var item = m_all_controllers[handle];
        if( name==_Check1Name )
          item.Check1 = value!=0;
        else if( name==_Check2Name )
          item.Check2 = value!=0;
        else if( name==_Check3Name )
          item.Check3 = value!=0;
      }
    }
    
    static void PerformActionCalledFromC(IntPtr handle, string name)
    {
      if( m_all_controllers.ContainsKey(handle) )
      {
        var item = m_all_controllers[handle];
        item.PerformAction(name);
      }
    }
  }
}

