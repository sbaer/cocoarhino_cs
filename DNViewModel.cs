using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace CocoaRhino_CS
{
  public class DNViewModel : ViewModelBase
  {
    const string _Check1Name = "check1";
    const string _Check2Name = "check2";
    const string _Check3Name = "check3";
    const string _PushMeName = "pushme";

    public DNViewModel() : base("DNWindow")
    {
    }
    

    bool m_check1 = false;
    bool m_check2 = true;
    bool m_check3 = false;
    public bool check1
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
          OnPropertyChanged("check1");
        }
      }
    }

    public bool check2
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
          OnPropertyChanged("check2");
        }
      }
    }
    
    public bool check3
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
          OnPropertyChanged("check3");
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
          check1 = !check1;
        }
        if (pushmeIdx == 2) {
          check2 = !check2;
        }
        if (pushmeIdx == 3) {
          check3 = !check3;
        }
      }
    }
    
    
    
    
  }
}

