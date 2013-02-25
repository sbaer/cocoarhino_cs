using System;

namespace RhinoMac.AppKit
{
  public class NSWindow : NSResponder
  {
    public NSWindow(IntPtr pWindow) : base(pWindow)
    {
    }

    /// <summary>
    /// Provides the window number of the window's window device. 
    /// Each window device in an application is given a unique window number—note
    /// that this isn’t the same as the global window number assigned by the
    /// window server. This number can be used to identify the window device with
    /// the orderWindow:relativeTo: method and in the Application Kit function
    /// NSWindowList. If the window doesn’t have a window device, the value
    /// returned will be equal to or less than 0.
    /// </summary>
    /// <value>the window number of the window's window device</value>
    public int WindowNumber
    {
      get { return ObjCRuntime.SendingMessages.SendInt(Handle, "windowNumber"); }
    }
  }
}
