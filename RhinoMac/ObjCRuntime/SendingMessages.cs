using System;

namespace RhinoMac.ObjCRuntime
{
  public static class SendingMessages
  {
    public static int SendInt(IntPtr receiver, string nameStr)
    {
      IntPtr selector = UnsafeNativeMethods.sel_registerName(nameStr);
      return UnsafeNativeMethods.objc_msgSend_int(receiver, selector);
    }
  }
}

