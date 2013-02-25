using System;
using System.Runtime.InteropServices;
using RhinoMac.ObjCRuntime;

namespace RhinoMac.Foundation
{
  public class NSString : NSObject
  {
    static readonly IntPtr selLength = Selector.GetHandle ("length");
    static readonly IntPtr selCharacterAtIndex_ = Selector.GetHandle ("characterAtIndex:");
    static readonly IntPtr selHash = Selector.GetHandle ("hash");
    static readonly IntPtr selIsEqualToString_ = Selector.GetHandle ("isEqualToString:");

    static readonly IntPtr class_ptr = Class.GetHandle ("NSString");
    
    public override IntPtr ClassHandle { get { return class_ptr; } }

    static IntPtr selUTF8String = Selector.sel_registerName ("UTF8String");
    static IntPtr selInitWithCharactersLength = Selector.sel_registerName ("initWithCharacters:length:");
    
    public static IntPtr CreateNative (string str)
    {
      if (str == null)
        return IntPtr.Zero;
      
      unsafe {
        fixed (char *ptrFirstChar = str){
          var handle = Messaging.intptr_objc_msgSend (class_ptr, Selector.Alloc);
          handle = Messaging.intptr_objc_msgsend_intptr_int (handle, selInitWithCharactersLength, (IntPtr) ptrFirstChar, str.Length);
          return handle;
        }
      }
    }
    
    public static void ReleaseNative (IntPtr handle)
    {
      if (handle == IntPtr.Zero)
        return;
      Messaging.void_objc_msgSend (handle, Selector.Release);
    }
    
    

    public NSString (string str) {
      if (str == null)
        throw new ArgumentNullException ("str");
      
      unsafe {
        fixed (char *ptrFirstChar = str){
          Handle = Messaging.intptr_objc_msgsend_intptr_int (Handle, selInitWithCharactersLength, (IntPtr) ptrFirstChar, str.Length);
        }
      }
    }

    public unsafe override string ToString ()
    {
      return FromHandle (Handle);
    }
    
    public static implicit operator string (NSString str)
    {
      if (((object) str) == null)
        return null;
      return str.ToString ();
    }
    
    public static explicit operator NSString (string str)
    {
      if (str == null)
        return null;
      return new NSString (str);
    }
    
    public unsafe static string FromHandle (IntPtr usrhandle)
    {
      if (usrhandle == IntPtr.Zero)
        return null;
      
      return Marshal.PtrToStringAuto (Messaging.intptr_objc_msgSend (usrhandle, selUTF8String));
    }
    
    public static bool Equals (NSString a, NSString b)
    {
      if ((a as object) == (b as object))
        return true;
      
      if (((object) a) == null || ((object) b) == null)
        return false;
      
      if (a.Handle == b.Handle)
        return true;
      return a.IsEqualTo (b.Handle);
    }
    
    public static bool operator == (NSString a, NSString b)
    {
      return Equals (a, b);
    }
    
    public static bool operator != (NSString a, NSString b)
    {
      return !Equals (a, b);
    }
    
    public override bool Equals (Object obj)
    {
      return Equals (this, obj as NSString);
    }
    
    public override int GetHashCode ()
    {
      return (int) this.Handle;
    }



    public  NSString () : base (NSObjectFlag.Empty)
    {
      if (IsDirectBinding) {
        Handle = RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.Init);
      } else {
        Handle = RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.Init);
      }
    }

    internal NSString (NSObjectFlag t) : base (t) {}
    
    public NSString (IntPtr handle) : base (handle) {}

    public virtual global::System.Char _characterAtIndex (int index)
    {
      if (IsDirectBinding) {
        return RhinoMac.ObjCRuntime.Messaging.Char_objc_msgSend_int (this.Handle, selCharacterAtIndex_, index);
      } else {
        return RhinoMac.ObjCRuntime.Messaging.Char_objc_msgSendSuper_int (this.SuperHandle, selCharacterAtIndex_, index);
      }
    }
    
    internal virtual int Hash ()
    {
      if (IsDirectBinding) {
        return RhinoMac.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selHash);
      } else {
        return RhinoMac.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selHash);
      }
    }
    
    internal virtual bool IsEqualTo (global::System.IntPtr handle)
    {
      if (IsDirectBinding) {
        return RhinoMac.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selIsEqualToString_, handle);
      } else {
        return RhinoMac.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selIsEqualToString_, handle);
      }
    }
    /*
    public virtual NSComparisonResult Compare (NSString aString)
    {
      if (aString == null)
        throw new ArgumentNullException ("aString");
      if (IsDirectBinding) {
        return (NSComparisonResult) RhinoMac.ObjCRuntime.Messaging.int_objc_msgSend_IntPtr (this.Handle, selCompare_, aString.Handle);
      } else {
        return (NSComparisonResult) RhinoMac.ObjCRuntime.Messaging.int_objc_msgSendSuper_IntPtr (this.SuperHandle, selCompare_, aString.Handle);
      }
    }
    
    public virtual NSComparisonResult Compare (NSString aString, NSStringCompareOptions mask)
    {
      if (aString == null)
        throw new ArgumentNullException ("aString");
      if (IsDirectBinding) {
        return (NSComparisonResult) RhinoMac.ObjCRuntime.Messaging.int_objc_msgSend_IntPtr_UInt32 (this.Handle, selCompareOptions_, aString.Handle, (UInt32)mask);
      } else {
        return (NSComparisonResult) RhinoMac.ObjCRuntime.Messaging.int_objc_msgSendSuper_IntPtr_UInt32 (this.SuperHandle, selCompareOptions_, aString.Handle, (UInt32)mask);
      }
    }
    
    public virtual NSComparisonResult Compare (NSString aString, NSStringCompareOptions mask, NSRange range)
    {
      if (aString == null)
        throw new ArgumentNullException ("aString");
      if (IsDirectBinding) {
        return (NSComparisonResult) RhinoMac.ObjCRuntime.Messaging.int_objc_msgSend_IntPtr_UInt32_NSRange (this.Handle, selCompareOptionsRange_, aString.Handle, (UInt32)mask, range);
      } else {
        return (NSComparisonResult) RhinoMac.ObjCRuntime.Messaging.int_objc_msgSendSuper_IntPtr_UInt32_NSRange (this.SuperHandle, selCompareOptionsRange_, aString.Handle, (UInt32)mask, range);
      }
    }
    
    public virtual NSComparisonResult Compare (NSString aString, NSStringCompareOptions mask, NSRange range, NSLocale locale)
    {
      if (aString == null)
        throw new ArgumentNullException ("aString");
      if (IsDirectBinding) {
        return (NSComparisonResult) RhinoMac.ObjCRuntime.Messaging.int_objc_msgSend_IntPtr_UInt32_NSRange_IntPtr (this.Handle, selCompareOptionsRangeLocale_, aString.Handle, (UInt32)mask, range, locale == null ? IntPtr.Zero : locale.Handle);
      } else {
        return (NSComparisonResult) RhinoMac.ObjCRuntime.Messaging.int_objc_msgSendSuper_IntPtr_UInt32_NSRange_IntPtr (this.SuperHandle, selCompareOptionsRangeLocale_, aString.Handle, (UInt32)mask, range, locale == null ? IntPtr.Zero : locale.Handle);
      }
    }
    
    public virtual NSString Replace (NSRange range, NSString replacement)
    {
      if (replacement == null)
        throw new ArgumentNullException ("replacement");
      if (IsDirectBinding) {
        return (NSString) Runtime.GetNSObject (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend_NSRange_IntPtr (this.Handle, selStringByReplacingCharactersInRangeWithString_, range, replacement.Handle));
      } else {
        return (NSString) Runtime.GetNSObject (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NSRange_IntPtr (this.SuperHandle, selStringByReplacingCharactersInRangeWithString_, range, replacement.Handle));
      }
    }
    
    public virtual string Capitalize (NSLocale locale)
    {
      if (locale == null)
        throw new ArgumentNullException ("locale");
      if (IsDirectBinding) {
        return NSString.FromHandle (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selCapitalizedStringWithLocale_, locale.Handle));
      } else {
        return NSString.FromHandle (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selCapitalizedStringWithLocale_, locale.Handle));
      }
    }
    
    public virtual string ToLower (NSLocale locale)
    {
      if (locale == null)
        throw new ArgumentNullException ("locale");
      if (IsDirectBinding) {
        return NSString.FromHandle (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selLowercaseStringWithLocale_, locale.Handle));
      } else {
        return NSString.FromHandle (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selLowercaseStringWithLocale_, locale.Handle));
      }
    }
    
    public virtual string ToUpper (NSLocale locale)
    {
      if (locale == null)
        throw new ArgumentNullException ("locale");
      if (IsDirectBinding) {
        return NSString.FromHandle (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selUppercaseStringWithLocale_, locale.Handle));
      } else {
        return NSString.FromHandle (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selUppercaseStringWithLocale_, locale.Handle));
      }
    }
    */
    public virtual int Length {
      get {
        if (IsDirectBinding) {
          return RhinoMac.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selLength);
        } else {
          return RhinoMac.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selLength);
        }
      }
    }
  } 
}
