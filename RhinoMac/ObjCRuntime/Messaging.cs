using System;
using System.Runtime.InteropServices;
using System.Drawing;

namespace RhinoMac.ObjCRuntime
{
  public static partial class Messaging
  {
    const string LIBOBJC_DYLIB = "/usr/lib/libobjc.dylib";
    
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static uint uint_objc_msgSend (IntPtr receiver, IntPtr selector);
    
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static int int_objc_msgSend (IntPtr receiver, IntPtr selector);
    
    /* void returns */
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend (IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_intptr (IntPtr receiver, IntPtr selector, IntPtr arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_bool (IntPtr receiver, IntPtr selector, bool arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_rbool (IntPtr receiver, IntPtr selector, ref bool arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_rint (IntPtr receiver, IntPtr selector, ref int arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_rfloat (IntPtr receiver, IntPtr selector, ref float arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_rdouble (IntPtr receiver, IntPtr selector, ref double arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_rintptr (IntPtr receiver, IntPtr selector, ref IntPtr arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_cgsize (IntPtr receiver, IntPtr selector, SizeF arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_cgpoint (IntPtr receiver, IntPtr selector, PointF arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_cgrect (IntPtr receiver, IntPtr selector, RectangleF arg1);
//    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
//    public extern static void void_objc_msgSend_nsrange (IntPtr receiver, IntPtr selector, NSRange arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_intptr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_cgpoint_intptr (IntPtr receiver, IntPtr selector, PointF arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_intptr_intptr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, bool arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_intptr_intptr_float (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, float arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_intptr_intptr_double (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, double arg3);
    
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper (IntPtr [] super, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_intptr (IntPtr receiver, IntPtr selector, IntPtr arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_cgsize (IntPtr receiver, IntPtr selector, SizeF arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_cgrect (IntPtr receiver, IntPtr selector, RectangleF arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_intptr_intptr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, bool arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_intptr_intptr_float (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, float arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_intptr_intptr_double (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, double arg3);
    
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void void_objc_msgSend_stret_rcgsize (ref SizeF stret, IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void void_objc_msgSend_stret_rcgrect (ref RectangleF stret, IntPtr receiver, IntPtr selector);
//    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
//    public extern static void void_objc_msgSend_stret_rnsrange (ref NSRange stret, IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void void_objc_msgSend_stret_rcgsize_cgpoint_intptr (ref SizeF stret, IntPtr receiver, IntPtr selector, PointF arg1, IntPtr arg2);
    
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void void_objc_msgSendSuper_stret_rcgrect (ref RectangleF stret, IntPtr receiver, IntPtr selector);
    
    /* intptr returns */
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr intptr_objc_msgSend (IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr intptr_objc_msgSend_intptr (IntPtr receiver, IntPtr selector, IntPtr arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]    
    public extern static IntPtr intptr_objc_msgsend_intptr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2);
    
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr intptr_objc_msgSend_float (IntPtr receiver, IntPtr selector, float arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr intptr_objc_msgSend_cgrect (IntPtr receiver, IntPtr selector, RectangleF arg1);
    
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr intptr_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr intptr_objc_msgSendSuper_cgrect (IntPtr receiver, IntPtr selector, RectangleF arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr intptr_objc_msgSendSuper_intptr (IntPtr receiver, IntPtr selector, IntPtr arg1);
    
    /* bool returns */
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend (IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_intptr (IntPtr receiver, IntPtr selector, IntPtr arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_intptr (IntPtr receiver, IntPtr selector, IntPtr arg1);
    
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static SizeF cgsize_objc_msgSend_cgpoint_intptr (IntPtr receiver, IntPtr selector, PointF arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static SizeF cgsize_objc_msgSend (IntPtr receiver, IntPtr selector);
    
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static Boolean Boolean_objc_msgSend_IntPtr_Double_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, Double arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static Boolean Boolean_objc_msgSendSuper_IntPtr_Double_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, Double arg2, IntPtr arg3);

    ///////////
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend (IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static int int_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_int (IntPtr receiver, IntPtr selector, int arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_int (IntPtr receiver, IntPtr selector, int arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static float float_objc_msgSend (IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static float float_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_float (IntPtr receiver, IntPtr selector, float arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_float (IntPtr receiver, IntPtr selector, float arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.Double Double_objc_msgSend (IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.Double Double_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_Double (IntPtr receiver, IntPtr selector, global::System.Double arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_Double (IntPtr receiver, IntPtr selector, global::System.Double arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.IntPtr IntPtr_objc_msgSend_Double_int (IntPtr receiver, IntPtr selector, global::System.Double arg1, int arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.IntPtr IntPtr_objc_msgSendSuper_Double_int (IntPtr receiver, IntPtr selector, global::System.Double arg1, int arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_float (IntPtr receiver, IntPtr selector, IntPtr arg1, float arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_float (IntPtr receiver, IntPtr selector, IntPtr arg1, float arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static float float_objc_msgSend_IntPtr_float (IntPtr receiver, IntPtr selector, IntPtr arg1, float arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static float float_objc_msgSendSuper_IntPtr_float (IntPtr receiver, IntPtr selector, IntPtr arg1, float arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_bool (IntPtr receiver, IntPtr selector, bool arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, global::System.IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, global::System.IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_int (IntPtr receiver, IntPtr selector, int arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_int (IntPtr receiver, IntPtr selector, int arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static int int_objc_msgSend_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static int int_objc_msgSendSuper_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static int int_objc_msgSend_int (IntPtr receiver, IntPtr selector, int arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static int int_objc_msgSendSuper_int (IntPtr receiver, IntPtr selector, int arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, global::System.IntPtr arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, global::System.IntPtr arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_UInt64_IntPtr_IntPtr_bool (IntPtr receiver, IntPtr selector, global::System.UInt64 arg1, IntPtr arg2, IntPtr arg3, bool arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_UInt64_IntPtr_IntPtr_bool (IntPtr receiver, IntPtr selector, global::System.UInt64 arg1, IntPtr arg2, IntPtr arg3, bool arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_UInt64_IntPtr (IntPtr receiver, IntPtr selector, global::System.UInt64 arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_UInt64_IntPtr (IntPtr receiver, IntPtr selector, global::System.UInt64 arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, bool arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, bool arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static int int_objc_msgSend_IntPtr_IntPtr_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, bool arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static int int_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, bool arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void PointF_objc_msgSend_stret (out global::System.Drawing.PointF retval, IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void PointF_objc_msgSendSuper_stret (out global::System.Drawing.PointF retval, IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.Drawing.PointF PointF_objc_msgSend (IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.Drawing.PointF PointF_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void RectangleF_objc_msgSend_stret (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void RectangleF_objc_msgSendSuper_stret (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_RectangleF (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_RectangleF (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_RectangleF_float_float (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, float arg2, float arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_RectangleF_float_float (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, float arg2, float arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_RectangleF (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_RectangleF (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_PointF_PointF (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, global::System.Drawing.PointF arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_PointF_PointF (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, global::System.Drawing.PointF arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_PointF (IntPtr receiver, IntPtr selector, global::System.IntPtr arg1, global::System.Drawing.PointF arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_PointF (IntPtr receiver, IntPtr selector, global::System.IntPtr arg1, global::System.Drawing.PointF arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_PointF (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_PointF (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_PointF_PointF_PointF (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, global::System.Drawing.PointF arg2, global::System.Drawing.PointF arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_PointF_PointF_PointF (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, global::System.Drawing.PointF arg2, global::System.Drawing.PointF arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_out_Int32_out_Single (IntPtr receiver, IntPtr selector, global::System.IntPtr arg1, out int arg2, out float arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_out_Int32_out_Single (IntPtr receiver, IntPtr selector, global::System.IntPtr arg1, out int arg2, out float arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_int_float (IntPtr receiver, IntPtr selector, global::System.IntPtr arg1, int arg2, float arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_int_float (IntPtr receiver, IntPtr selector, global::System.IntPtr arg1, int arg2, float arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static int int_objc_msgSend_int_IntPtr (IntPtr receiver, IntPtr selector, int arg1, global::System.IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static int int_objc_msgSendSuper_int_IntPtr (IntPtr receiver, IntPtr selector, int arg1, global::System.IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_PointF_float_float_float_bool (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, float arg2, float arg3, float arg4, bool arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_PointF_float_float_float_bool (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, float arg2, float arg3, float arg4, bool arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_PointF_float_float_float (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, float arg2, float arg3, float arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_PointF_float_float_float (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, float arg2, float arg3, float arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_PointF_PointF_float (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, global::System.Drawing.PointF arg2, float arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_PointF_PointF_float (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, global::System.Drawing.PointF arg2, float arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_UInt32_IntPtr (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_UInt32_IntPtr (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_int_IntPtr (IntPtr receiver, IntPtr selector, global::System.IntPtr arg1, int arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_int_IntPtr (IntPtr receiver, IntPtr selector, global::System.IntPtr arg1, int arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_RectangleF_float_float (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, float arg2, float arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_RectangleF_float_float (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, float arg2, float arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_PointF (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_PointF (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_int_int_int_int_bool_bool_IntPtr_int_int (IntPtr receiver, IntPtr selector, global::System.IntPtr arg1, int arg2, int arg3, int arg4, int arg5, bool arg6, bool arg7, IntPtr arg8, int arg9, int arg10);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_int_int_int_int_bool_bool_IntPtr_int_int (IntPtr receiver, IntPtr selector, global::System.IntPtr arg1, int arg2, int arg3, int arg4, int arg5, bool arg6, bool arg7, IntPtr arg8, int arg9, int arg10);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_int_int_int_int_bool_bool_IntPtr_int_int_int (IntPtr receiver, IntPtr selector, global::System.IntPtr arg1, int arg2, int arg3, int arg4, int arg5, bool arg6, bool arg7, IntPtr arg8, int arg9, int arg10, int arg11);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_int_int_int_int_bool_bool_IntPtr_int_int_int (IntPtr receiver, IntPtr selector, global::System.IntPtr arg1, int arg2, int arg3, int arg4, int arg5, bool arg6, bool arg7, IntPtr arg8, int arg9, int arg10, int arg11);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_int_float (IntPtr receiver, IntPtr selector, int arg1, float arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_int_float (IntPtr receiver, IntPtr selector, int arg1, float arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_int_float (IntPtr receiver, IntPtr selector, int arg1, float arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_int_float (IntPtr receiver, IntPtr selector, int arg1, float arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_IntPtr_int_float (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, float arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_int_float (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, float arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_int (IntPtr receiver, IntPtr selector, int arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_int (IntPtr receiver, IntPtr selector, int arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_float_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, float arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_float_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, float arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static int int_objc_msgSend_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static int int_objc_msgSendSuper_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, int arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, int arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_int_int (IntPtr receiver, IntPtr selector, int arg1, int arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_int_int (IntPtr receiver, IntPtr selector, int arg1, int arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_int_IntPtr (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_int_IntPtr (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void SizeF_objc_msgSend_stret (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void SizeF_objc_msgSendSuper_stret (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.Drawing.SizeF SizeF_objc_msgSend (IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.Drawing.SizeF SizeF_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_SizeF (IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_SizeF (IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_int_int (IntPtr receiver, IntPtr selector, int arg1, int arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_int_int (IntPtr receiver, IntPtr selector, int arg1, int arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void RectangleF_objc_msgSend_stret_int (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, int arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void RectangleF_objc_msgSendSuper_stret_int (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, int arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_int_RectangleF (IntPtr receiver, IntPtr selector, int arg1, global::System.Drawing.RectangleF arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_int_RectangleF (IntPtr receiver, IntPtr selector, int arg1, global::System.Drawing.RectangleF arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void RectangleF_objc_msgSend_stret_int_int (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, int arg1, int arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void RectangleF_objc_msgSendSuper_stret_int_int (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, int arg1, int arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_out_Int32_out_Int32_PointF (IntPtr receiver, IntPtr selector, out int arg1, out int arg2, global::System.Drawing.PointF arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_out_Int32_out_Int32_PointF (IntPtr receiver, IntPtr selector, out int arg1, out int arg2, global::System.Drawing.PointF arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static float float_objc_msgSend_float (IntPtr receiver, IntPtr selector, float arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static float float_objc_msgSendSuper_float (IntPtr receiver, IntPtr selector, float arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_float_int (IntPtr receiver, IntPtr selector, float arg1, int arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_float_int (IntPtr receiver, IntPtr selector, float arg1, int arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static float float_objc_msgSend_int (IntPtr receiver, IntPtr selector, int arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static float float_objc_msgSendSuper_int (IntPtr receiver, IntPtr selector, int arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_IntPtr_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_IntPtr_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_UInt32_bool (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, bool arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_UInt32_bool (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, bool arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static int int_objc_msgSend_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static int int_objc_msgSendSuper_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static int int_objc_msgSend_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static int int_objc_msgSendSuper_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_IntPtr_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static float float_objc_msgSend_IntPtr_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, int arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static float float_objc_msgSendSuper_IntPtr_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, int arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_IntPtr_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, int arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_IntPtr_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, int arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_IntPtr_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_IntPtr_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_IntPtr_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, int arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_IntPtr_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, int arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static float float_objc_msgSend_IntPtr_int_bool_float (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, bool arg3, float arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static float float_objc_msgSendSuper_IntPtr_int_bool_float (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, bool arg3, float arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static float float_objc_msgSend_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static float float_objc_msgSendSuper_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_IntPtr_IntPtr_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_IntPtr_IntPtr_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, int arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, int arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.UInt32 UInt32_objc_msgSend_IntPtr_IntPtr_out_Int32_out_Int32_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, out int arg3, out int arg4, int arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.UInt32 UInt32_objc_msgSendSuper_IntPtr_IntPtr_out_Int32_out_Int32_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, out int arg3, out int arg4, int arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_IntPtr_IntPtr_int_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, int arg4, int arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_IntPtr_IntPtr_int_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, int arg4, int arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_IntPtr_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, int arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, int arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static int int_objc_msgSend_IntPtr_int_int_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, int arg3, int arg4, IntPtr arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static int int_objc_msgSendSuper_IntPtr_int_int_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, int arg3, int arg4, IntPtr arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.UInt32 UInt32_objc_msgSend (IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.UInt32 UInt32_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_UInt32 (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_UInt32 (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_float_float (IntPtr receiver, IntPtr selector, float arg1, float arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_float_float (IntPtr receiver, IntPtr selector, float arg1, float arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_out_Single_out_Single (IntPtr receiver, IntPtr selector, out float arg1, out float arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_out_Single_out_Single (IntPtr receiver, IntPtr selector, out float arg1, out float arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_RectangleF_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_RectangleF_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void RectangleF_objc_msgSend_stret_IntPtr_RectangleF_IntPtr (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void RectangleF_objc_msgSendSuper_stret_IntPtr_RectangleF_IntPtr (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_RectangleF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_RectangleF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_RectangleF (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_RectangleF (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.IntPtr IntPtr_objc_msgSend_SizeF_int_bool_bool (IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1, int arg2, bool arg3, bool arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.IntPtr IntPtr_objc_msgSendSuper_SizeF_int_bool_bool (IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1, int arg2, bool arg3, bool arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void RectangleF_objc_msgSend_stret_RectangleF (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void RectangleF_objc_msgSendSuper_stret_RectangleF (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void SizeF_objc_msgSend_stret_RectangleF (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void SizeF_objc_msgSendSuper_stret_RectangleF (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.Drawing.SizeF SizeF_objc_msgSend_RectangleF (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.Drawing.SizeF SizeF_objc_msgSendSuper_RectangleF (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_RectangleF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_RectangleF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_bool_RectangleF_IntPtr (IntPtr receiver, IntPtr selector, bool arg1, global::System.Drawing.RectangleF arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_bool_RectangleF_IntPtr (IntPtr receiver, IntPtr selector, bool arg1, global::System.Drawing.RectangleF arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_PointF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_PointF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_PointF_PointF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, global::System.Drawing.PointF arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_PointF_PointF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, global::System.Drawing.PointF arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_PointF_PointF_IntPtr_bool (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, global::System.Drawing.PointF arg2, IntPtr arg3, bool arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_PointF_PointF_IntPtr_bool (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, global::System.Drawing.PointF arg2, IntPtr arg3, bool arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_IntPtr_RectangleF_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2, IntPtr arg3, bool arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_IntPtr_RectangleF_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2, IntPtr arg3, bool arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_RectangleF_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_RectangleF_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_RectangleF_IntPtr_IntPtr_IntPtr_int_int (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, int arg5, int arg6);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_RectangleF_IntPtr_IntPtr_IntPtr_int_int (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, int arg5, int arg6);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_IntPtr_RectangleF_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_RectangleF_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static int int_objc_msgSend_IntPtr_RectangleF_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static int int_objc_msgSendSuper_IntPtr_RectangleF_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void RectangleF_objc_msgSend_stret_RectangleF_IntPtr (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void RectangleF_objc_msgSendSuper_stret_RectangleF_IntPtr (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void PointF_objc_msgSend_stret_PointF (out global::System.Drawing.PointF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void PointF_objc_msgSendSuper_stret_PointF (out global::System.Drawing.PointF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.Drawing.PointF PointF_objc_msgSend_PointF (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.Drawing.PointF PointF_objc_msgSendSuper_PointF (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.UInt32 UInt32_objc_msgSend_bool (IntPtr receiver, IntPtr selector, bool arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.UInt32 UInt32_objc_msgSendSuper_bool (IntPtr receiver, IntPtr selector, bool arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_PointF_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.PointF arg2, global::System.UInt32 arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_PointF_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.PointF arg2, global::System.UInt32 arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_PointF_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.PointF arg2, bool arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_PointF_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.PointF arg2, bool arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.UInt32 UInt32_objc_msgSend_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.UInt32 UInt32_objc_msgSendSuper_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.UInt32 UInt32_objc_msgSend_IntPtr_IntPtr_out_Int32_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, out int arg3, int arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.UInt32 UInt32_objc_msgSendSuper_IntPtr_IntPtr_out_Int32_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, out int arg3, int arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_IntPtr_IntPtr_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, int arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_IntPtr_IntPtr_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, int arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_float_float (IntPtr receiver, IntPtr selector, float arg1, float arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_float_float (IntPtr receiver, IntPtr selector, float arg1, float arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_float_float_float_float (IntPtr receiver, IntPtr selector, float arg1, float arg2, float arg3, float arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_float_float_float_float (IntPtr receiver, IntPtr selector, float arg1, float arg2, float arg3, float arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_float_float_float_float_float (IntPtr receiver, IntPtr selector, float arg1, float arg2, float arg3, float arg4, float arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_float_float_float_float_float (IntPtr receiver, IntPtr selector, float arg1, float arg2, float arg3, float arg4, float arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_float (IntPtr receiver, IntPtr selector, float arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_float (IntPtr receiver, IntPtr selector, float arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_UInt32 (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_UInt32 (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_float_IntPtr (IntPtr receiver, IntPtr selector, float arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_float_IntPtr (IntPtr receiver, IntPtr selector, float arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_out_Single_out_Single_out_Single_out_Single (IntPtr receiver, IntPtr selector, out float arg1, out float arg2, out float arg3, out float arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_out_Single_out_Single_out_Single_out_Single (IntPtr receiver, IntPtr selector, out float arg1, out float arg2, out float arg3, out float arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_out_Single_out_Single_out_Single_out_Single_out_Single (IntPtr receiver, IntPtr selector, out float arg1, out float arg2, out float arg3, out float arg4, out float arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_out_Single_out_Single_out_Single_out_Single_out_Single (IntPtr receiver, IntPtr selector, out float arg1, out float arg2, out float arg3, out float arg4, out float arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_IntPtr_PointF (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.PointF arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_PointF (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.PointF arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_PointF (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, global::System.Drawing.PointF arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_PointF (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, global::System.Drawing.PointF arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_IntPtr_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Double arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_IntPtr_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Double arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_IntPtr_IntPtr_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, IntPtr arg4, IntPtr arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_IntPtr_IntPtr_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, IntPtr arg4, IntPtr arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, IntPtr arg4, IntPtr arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, IntPtr arg4, IntPtr arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_int_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, IntPtr arg3, global::System.IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_int_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, IntPtr arg3, global::System.IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_IntPtr_int_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, IntPtr arg4, IntPtr arg5, global::System.IntPtr arg6);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_IntPtr_int_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, IntPtr arg4, IntPtr arg5, global::System.IntPtr arg6);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_bool_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, IntPtr arg3, IntPtr arg4, global::System.IntPtr arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_bool_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, IntPtr arg3, IntPtr arg4, global::System.IntPtr arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_bool_IntPtr (IntPtr receiver, IntPtr selector, bool arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_bool_IntPtr (IntPtr receiver, IntPtr selector, bool arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_IntPtr_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_IntPtr_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_bool_IntPtr (IntPtr receiver, IntPtr selector, bool arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_bool_IntPtr (IntPtr receiver, IntPtr selector, bool arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_IntPtr_bool_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_bool_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_bool_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_bool_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_int_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_int_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.IntPtr IntPtr_objc_msgSend_SizeF_int (IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1, int arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.IntPtr IntPtr_objc_msgSendSuper_SizeF_int (IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1, int arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void SizeF_objc_msgSend_stret_IntPtr_SizeF (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.SizeF arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void SizeF_objc_msgSendSuper_stret_IntPtr_SizeF (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.SizeF arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.Drawing.SizeF SizeF_objc_msgSend_IntPtr_SizeF (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.SizeF arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.Drawing.SizeF SizeF_objc_msgSendSuper_IntPtr_SizeF (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.SizeF arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_IntPtr_float (IntPtr receiver, IntPtr selector, IntPtr arg1, float arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_float (IntPtr receiver, IntPtr selector, IntPtr arg1, float arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void RectangleF_objc_msgSend_stret_UInt32 (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, global::System.UInt32 arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void RectangleF_objc_msgSendSuper_stret_UInt32 (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, global::System.UInt32 arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void SizeF_objc_msgSend_stret_UInt32 (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, global::System.UInt32 arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void SizeF_objc_msgSendSuper_stret_UInt32 (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, global::System.UInt32 arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.Drawing.SizeF SizeF_objc_msgSend_UInt32 (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.Drawing.SizeF SizeF_objc_msgSendSuper_UInt32 (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_IntPtr_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_IntPtr_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_bool (IntPtr receiver, IntPtr selector, bool arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_bool (IntPtr receiver, IntPtr selector, bool arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_IntPtr_int_int_float (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, int arg3, float arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_int_int_float (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, int arg3, float arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.IntPtr IntPtr_objc_msgSend_RectangleF_int_IntPtr_int_int (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, int arg2, IntPtr arg3, int arg4, int arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.IntPtr IntPtr_objc_msgSendSuper_RectangleF_int_IntPtr_int_int (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, int arg2, IntPtr arg3, int arg4, int arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_int_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, int arg3, int arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_int_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, int arg3, int arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_PointF_PointF_int (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, global::System.Drawing.PointF arg2, int arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_PointF_PointF_int (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, global::System.Drawing.PointF arg2, int arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_RectangleF_float (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, float arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_RectangleF_float (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, float arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_PointF_float_PointF_float_int (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, float arg2, global::System.Drawing.PointF arg3, float arg4, int arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_PointF_float_PointF_float_int (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, float arg2, global::System.Drawing.PointF arg3, float arg4, int arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_RectangleF_PointF (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, global::System.Drawing.PointF arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_RectangleF_PointF (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, global::System.Drawing.PointF arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_out_Single_int (IntPtr receiver, IntPtr selector, IntPtr arg1, out float arg2, int arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_out_Single_int (IntPtr receiver, IntPtr selector, IntPtr arg1, out float arg2, int arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.UInt16 UInt16_objc_msgSend (IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.UInt16 UInt16_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static short short_objc_msgSend (IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static short short_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.Int64 Int64_objc_msgSend (IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.Int64 Int64_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_Double_Double (IntPtr receiver, IntPtr selector, global::System.Double arg1, global::System.Double arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_Double_Double (IntPtr receiver, IntPtr selector, global::System.Double arg1, global::System.Double arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_int_PointF_UInt32_Double_int_IntPtr_int_int_float (IntPtr receiver, IntPtr selector, int arg1, global::System.Drawing.PointF arg2, global::System.UInt32 arg3, global::System.Double arg4, int arg5, IntPtr arg6, int arg7, int arg8, float arg9);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_int_PointF_UInt32_Double_int_IntPtr_int_int_float (IntPtr receiver, IntPtr selector, int arg1, global::System.Drawing.PointF arg2, global::System.UInt32 arg3, global::System.Double arg4, int arg5, IntPtr arg6, int arg7, int arg8, float arg9);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_int_PointF_UInt32_Double_int_IntPtr_IntPtr_IntPtr_bool_UInt16 (IntPtr receiver, IntPtr selector, int arg1, global::System.Drawing.PointF arg2, global::System.UInt32 arg3, global::System.Double arg4, int arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8, bool arg9, global::System.UInt16 arg10);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_int_PointF_UInt32_Double_int_IntPtr_IntPtr_IntPtr_bool_UInt16 (IntPtr receiver, IntPtr selector, int arg1, global::System.Drawing.PointF arg2, global::System.UInt32 arg3, global::System.Double arg4, int arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8, bool arg9, global::System.UInt16 arg10);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_int_PointF_UInt32_Double_int_IntPtr_int_int_IntPtr (IntPtr receiver, IntPtr selector, int arg1, global::System.Drawing.PointF arg2, global::System.UInt32 arg3, global::System.Double arg4, int arg5, IntPtr arg6, int arg7, int arg8, global::System.IntPtr arg9);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_int_PointF_UInt32_Double_int_IntPtr_int_int_IntPtr (IntPtr receiver, IntPtr selector, int arg1, global::System.Drawing.PointF arg2, global::System.UInt32 arg3, global::System.Double arg4, int arg5, IntPtr arg6, int arg7, int arg8, global::System.IntPtr arg9);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_int_PointF_UInt32_Double_int_IntPtr_short_int_int (IntPtr receiver, IntPtr selector, int arg1, global::System.Drawing.PointF arg2, global::System.UInt32 arg3, global::System.Double arg4, int arg5, IntPtr arg6, short arg7, int arg8, int arg9);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_int_PointF_UInt32_Double_int_IntPtr_short_int_int (IntPtr receiver, IntPtr selector, int arg1, global::System.Drawing.PointF arg2, global::System.UInt32 arg3, global::System.Double arg4, int arg5, IntPtr arg6, short arg7, int arg8, int arg9);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_UInt64_IntPtr (IntPtr receiver, IntPtr selector, global::System.UInt64 arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_UInt64_IntPtr (IntPtr receiver, IntPtr selector, global::System.UInt64 arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_int_float_float_IntPtr (IntPtr receiver, IntPtr selector, int arg1, float arg2, float arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_int_float_float_IntPtr (IntPtr receiver, IntPtr selector, int arg1, float arg2, float arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_IntPtr_PointF_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.PointF arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_IntPtr_PointF_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.PointF arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_IntPtr_IntPtr_int_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, bool arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_IntPtr_IntPtr_int_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, bool arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void RectangleF_objc_msgSend_stret_IntPtr_IntPtr (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void RectangleF_objc_msgSendSuper_stret_IntPtr_IntPtr (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static int int_objc_msgSend_PointF (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static int int_objc_msgSendSuper_PointF (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void PointF_objc_msgSend_stret_IntPtr (out global::System.Drawing.PointF retval, IntPtr receiver, IntPtr selector, IntPtr arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void PointF_objc_msgSendSuper_stret_IntPtr (out global::System.Drawing.PointF retval, IntPtr receiver, IntPtr selector, IntPtr arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.Drawing.PointF PointF_objc_msgSend_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.Drawing.PointF PointF_objc_msgSendSuper_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_RectangleF_IntPtr_int_int (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2, int arg3, int arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_RectangleF_IntPtr_int_int (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2, int arg3, int arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.IntPtr IntPtr_objc_msgSend_out_Int32_int_int (IntPtr receiver, IntPtr selector, out int arg1, int arg2, int arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.IntPtr IntPtr_objc_msgSendSuper_out_Int32_int_int (IntPtr receiver, IntPtr selector, out int arg1, int arg2, int arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.IntPtr IntPtr_objc_msgSend_int_int_int_int_int (IntPtr receiver, IntPtr selector, int arg1, int arg2, int arg3, int arg4, int arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.IntPtr IntPtr_objc_msgSendSuper_int_int_int_int_int (IntPtr receiver, IntPtr selector, int arg1, int arg2, int arg3, int arg4, int arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_int_IntPtr_int (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, int arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_int_IntPtr_int (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, int arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6, global::System.IntPtr arg7);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6, global::System.IntPtr arg7);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, global::System.IntPtr arg6);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, global::System.IntPtr arg6);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static int int_objc_msgSend_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static int int_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, bool arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, bool arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_bool (IntPtr receiver, IntPtr selector, bool arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_bool (IntPtr receiver, IntPtr selector, bool arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static float float_objc_msgSend_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static float float_objc_msgSendSuper_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.UInt32 UInt32_objc_msgSend_IntPtr_IntPtr_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, int arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.UInt32 UInt32_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, int arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_IntPtr_IntPtr_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, int arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, int arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_IntPtr_PointF (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.PointF arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_IntPtr_PointF (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.PointF arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.IntPtr IntPtr_objc_msgSend_SizeF (IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.IntPtr IntPtr_objc_msgSendSuper_SizeF (IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_PointF_RectangleF_int_float (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, global::System.Drawing.RectangleF arg2, int arg3, float arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_PointF_RectangleF_int_float (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, global::System.Drawing.RectangleF arg2, int arg3, float arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_RectangleF_RectangleF_int_float (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, global::System.Drawing.RectangleF arg2, int arg3, float arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_RectangleF_RectangleF_int_float (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, global::System.Drawing.RectangleF arg2, int arg3, float arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_RectangleF_RectangleF_int_float_bool_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, global::System.Drawing.RectangleF arg2, int arg3, float arg4, bool arg5, IntPtr arg6);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_RectangleF_RectangleF_int_float_bool_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, global::System.Drawing.RectangleF arg2, int arg3, float arg4, bool arg5, IntPtr arg6);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_IntPtr_RectangleF (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_IntPtr_RectangleF (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_SizeF (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.SizeF arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_SizeF (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.SizeF arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_RectangleF_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_RectangleF_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_RectangleF_RectangleF_IntPtr_IntPtr_bool (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, global::System.Drawing.RectangleF arg2, IntPtr arg3, IntPtr arg4, bool arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_RectangleF_RectangleF_IntPtr_IntPtr_bool (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, global::System.Drawing.RectangleF arg2, IntPtr arg3, IntPtr arg4, bool arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void SizeF_objc_msgSend_stret_IntPtr (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, IntPtr arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void SizeF_objc_msgSendSuper_stret_IntPtr (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, IntPtr arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.Drawing.SizeF SizeF_objc_msgSend_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.Drawing.SizeF SizeF_objc_msgSendSuper_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_RectangleF (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_RectangleF (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_RectangleF_RectangleF_int_float_bool_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, global::System.Drawing.RectangleF arg2, int arg3, float arg4, bool arg5, IntPtr arg6);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_RectangleF_RectangleF_int_float_bool_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, global::System.Drawing.RectangleF arg2, int arg3, float arg4, bool arg5, IntPtr arg6);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_int_int_int_bool (IntPtr receiver, IntPtr selector, int arg1, int arg2, int arg3, bool arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_int_int_int_bool (IntPtr receiver, IntPtr selector, int arg1, int arg2, int arg3, bool arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_int_int_int (IntPtr receiver, IntPtr selector, int arg1, int arg2, int arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_int_int_int (IntPtr receiver, IntPtr selector, int arg1, int arg2, int arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_out_Int32_out_Int32 (IntPtr receiver, IntPtr selector, out int arg1, out int arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_out_Int32_out_Int32 (IntPtr receiver, IntPtr selector, out int arg1, out int arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_out_Int32_out_Int32_IntPtr (IntPtr receiver, IntPtr selector, out int arg1, out int arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_out_Int32_out_Int32_IntPtr (IntPtr receiver, IntPtr selector, out int arg1, out int arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_int_IntPtr (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_int_IntPtr (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_bool_int_int (IntPtr receiver, IntPtr selector, bool arg1, int arg2, int arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_bool_int_int (IntPtr receiver, IntPtr selector, bool arg1, int arg2, int arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.Double Double_objc_msgSend_int (IntPtr receiver, IntPtr selector, int arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.Double Double_objc_msgSendSuper_int (IntPtr receiver, IntPtr selector, int arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_IntPtr_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_IntPtr_int_int_IntPtr_int_float_float (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, int arg3, IntPtr arg4, int arg5, float arg6, float arg7);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_int_int_IntPtr_int_float_float (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, int arg3, IntPtr arg4, int arg5, float arg6, float arg7);
/*    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_NSRange (IntPtr receiver, IntPtr selector, NSRange arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_NSRange (IntPtr receiver, IntPtr selector, NSRange arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_int_NSRange_int_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, NSRange arg3, int arg4, NSRange arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_int_NSRange_int_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, NSRange arg3, int arg4, NSRange arg5);
*/    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_UInt32_int_int (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, int arg2, int arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_UInt32_int_int (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, int arg2, int arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_int_UInt32 (IntPtr receiver, IntPtr selector, int arg1, global::System.UInt32 arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_int_UInt32 (IntPtr receiver, IntPtr selector, int arg1, global::System.UInt32 arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.UInt32 UInt32_objc_msgSend_int_bool (IntPtr receiver, IntPtr selector, int arg1, bool arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.UInt32 UInt32_objc_msgSendSuper_int_bool (IntPtr receiver, IntPtr selector, int arg1, bool arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.UInt32 UInt32_objc_msgSend_int (IntPtr receiver, IntPtr selector, int arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.UInt32 UInt32_objc_msgSendSuper_int (IntPtr receiver, IntPtr selector, int arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static int int_objc_msgSend_int_int (IntPtr receiver, IntPtr selector, int arg1, int arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static int int_objc_msgSendSuper_int_int (IntPtr receiver, IntPtr selector, int arg1, int arg2);
/*    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static int int_objc_msgSend_NSRange_IntPtr_UInt32_int_bool (IntPtr receiver, IntPtr selector, NSRange arg1, global::System.IntPtr arg2, global::System.UInt32 arg3, int arg4, bool arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static int int_objc_msgSendSuper_NSRange_IntPtr_UInt32_int_bool (IntPtr receiver, IntPtr selector, NSRange arg1, global::System.IntPtr arg2, global::System.UInt32 arg3, int arg4, bool arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static int int_objc_msgSend_NSRange_IntPtr_UInt32_int_bool_UInt16 (IntPtr receiver, IntPtr selector, NSRange arg1, global::System.IntPtr arg2, global::System.UInt32 arg3, int arg4, bool arg5, global::System.UInt16 arg6);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static int int_objc_msgSendSuper_NSRange_IntPtr_UInt32_int_bool_UInt16 (IntPtr receiver, IntPtr selector, NSRange arg1, global::System.IntPtr arg2, global::System.UInt32 arg3, int arg4, bool arg5, global::System.UInt16 arg6);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.UInt32 UInt32_objc_msgSend_IntPtr_NSRange (IntPtr receiver, IntPtr selector, global::System.IntPtr arg1, NSRange arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.UInt32 UInt32_objc_msgSendSuper_IntPtr_NSRange (IntPtr receiver, IntPtr selector, global::System.IntPtr arg1, NSRange arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_RectangleF_NSRange_RectangleF (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, NSRange arg2, global::System.Drawing.RectangleF arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_RectangleF_NSRange_RectangleF (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, NSRange arg2, global::System.Drawing.RectangleF arg3);
*/    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_RectangleF_RectangleF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, global::System.Drawing.RectangleF arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_RectangleF_RectangleF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, global::System.Drawing.RectangleF arg2, IntPtr arg3);
/*    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_PointF_NSRange (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, NSRange arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_PointF_NSRange (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, NSRange arg2);
*/    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_bool_int (IntPtr receiver, IntPtr selector, bool arg1, int arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_bool_int (IntPtr receiver, IntPtr selector, bool arg1, int arg2);
/*    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_SizeF_NSRange (IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1, NSRange arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_SizeF_NSRange (IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1, NSRange arg2);
*/    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void RectangleF_objc_msgSend_stret_IntPtr (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, IntPtr arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void RectangleF_objc_msgSendSuper_stret_IntPtr (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, IntPtr arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void PointF_objc_msgSend_stret_int (out global::System.Drawing.PointF retval, IntPtr receiver, IntPtr selector, int arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void PointF_objc_msgSendSuper_stret_int (out global::System.Drawing.PointF retval, IntPtr receiver, IntPtr selector, int arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.Drawing.PointF PointF_objc_msgSend_int (IntPtr receiver, IntPtr selector, int arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.Drawing.PointF PointF_objc_msgSendSuper_int (IntPtr receiver, IntPtr selector, int arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void SizeF_objc_msgSend_stret_int (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, int arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void SizeF_objc_msgSendSuper_stret_int (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, int arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.Drawing.SizeF SizeF_objc_msgSend_int (IntPtr receiver, IntPtr selector, int arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.Drawing.SizeF SizeF_objc_msgSendSuper_int (IntPtr receiver, IntPtr selector, int arg1);
/*    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_RectangleF_IntPtr_NSRange (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2, NSRange arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_RectangleF_IntPtr_NSRange (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2, NSRange arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void RectangleF_objc_msgSend_stret_IntPtr_NSRange (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void RectangleF_objc_msgSendSuper_stret_IntPtr_NSRange (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void NSRange_objc_msgSend_stret_IntPtr (out NSRange retval, IntPtr receiver, IntPtr selector, IntPtr arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void NSRange_objc_msgSendSuper_stret_IntPtr (out NSRange retval, IntPtr receiver, IntPtr selector, IntPtr arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static NSRange NSRange_objc_msgSend_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static NSRange NSRange_objc_msgSendSuper_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void NSRange_objc_msgSend_stret_int (out NSRange retval, IntPtr receiver, IntPtr selector, int arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void NSRange_objc_msgSendSuper_stret_int (out NSRange retval, IntPtr receiver, IntPtr selector, int arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static NSRange NSRange_objc_msgSend_int (IntPtr receiver, IntPtr selector, int arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static NSRange NSRange_objc_msgSendSuper_int (IntPtr receiver, IntPtr selector, int arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void RectangleF_objc_msgSend_stret_NSRange_IntPtr (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void RectangleF_objc_msgSendSuper_stret_NSRange_IntPtr (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void NSRange_objc_msgSend_stret_RectangleF_IntPtr (out NSRange retval, IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void NSRange_objc_msgSendSuper_stret_RectangleF_IntPtr (out NSRange retval, IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static NSRange NSRange_objc_msgSend_RectangleF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static NSRange NSRange_objc_msgSendSuper_RectangleF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2);
*/    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.UInt32 UInt32_objc_msgSend_PointF_IntPtr_float (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, IntPtr arg2, float arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.UInt32 UInt32_objc_msgSendSuper_PointF_IntPtr_float (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, IntPtr arg2, float arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.UInt32 UInt32_objc_msgSend_PointF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.UInt32 UInt32_objc_msgSendSuper_PointF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static float float_objc_msgSend_PointF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static float float_objc_msgSendSuper_PointF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.UInt32 UInt32_objc_msgSend_int_bool_bool_float_UInt32 (IntPtr receiver, IntPtr selector, int arg1, bool arg2, bool arg3, float arg4, global::System.UInt32 arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.UInt32 UInt32_objc_msgSendSuper_int_bool_bool_float_UInt32 (IntPtr receiver, IntPtr selector, int arg1, bool arg2, bool arg3, float arg4, global::System.UInt32 arg5);
/*    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_IntPtr_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, NSRange arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_IntPtr_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, NSRange arg3);
*/    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static float float_objc_msgSend_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static float float_objc_msgSendSuper_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_bool_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, bool arg3, int arg4, global::System.IntPtr arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_bool_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, bool arg3, int arg4, global::System.IntPtr arg5);
/*    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_NSRange_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, NSRange arg4, int arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_NSRange_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, NSRange arg4, int arg5);
*/    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_PointF_RectangleF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, global::System.Drawing.RectangleF arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_PointF_RectangleF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, global::System.Drawing.RectangleF arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.UInt32 UInt32_objc_msgSend_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.UInt32 UInt32_objc_msgSendSuper_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_RectangleF_IntPtr_int (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2, int arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_RectangleF_IntPtr_int (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2, int arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.IntPtr IntPtr_objc_msgSend_RectangleF_bool (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, bool arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.IntPtr IntPtr_objc_msgSendSuper_RectangleF_bool (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, bool arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void SizeF_objc_msgSend_stret_IntPtr_IntPtr (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void SizeF_objc_msgSendSuper_stret_IntPtr_IntPtr (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.Drawing.SizeF SizeF_objc_msgSend_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.Drawing.SizeF SizeF_objc_msgSendSuper_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);
/*    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void NSRange_objc_msgSend_stret (out NSRange retval, IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void NSRange_objc_msgSendSuper_stret (out NSRange retval, IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static NSRange NSRange_objc_msgSend (IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static NSRange NSRange_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
*/    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_IntPtr_RectangleF_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2, IntPtr arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_RectangleF_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2, IntPtr arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_float_IntPtr_PointF (IntPtr receiver, IntPtr selector, IntPtr arg1, float arg2, IntPtr arg3, global::System.Drawing.PointF arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_float_IntPtr_PointF (IntPtr receiver, IntPtr selector, IntPtr arg1, float arg2, IntPtr arg3, global::System.Drawing.PointF arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_IntPtr_float_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, float arg3, IntPtr arg4, IntPtr arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_IntPtr_float_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, float arg3, IntPtr arg4, IntPtr arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void RectangleF_objc_msgSend_stret_RectangleF_Int64 (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, global::System.Int64 arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void RectangleF_objc_msgSendSuper_stret_RectangleF_Int64 (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, global::System.Int64 arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_int_bool (IntPtr receiver, IntPtr selector, int arg1, bool arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_int_bool (IntPtr receiver, IntPtr selector, int arg1, bool arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_RectangleF_bool (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, bool arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_RectangleF_bool (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, bool arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static float float_objc_msgSend_int_int (IntPtr receiver, IntPtr selector, int arg1, int arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static float float_objc_msgSendSuper_int_int (IntPtr receiver, IntPtr selector, int arg1, int arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void SizeF_objc_msgSend_stret_SizeF_bool_bool_int (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1, bool arg2, bool arg3, int arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void SizeF_objc_msgSendSuper_stret_SizeF_bool_bool_int (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1, bool arg2, bool arg3, int arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.Drawing.SizeF SizeF_objc_msgSend_SizeF_bool_bool_int (IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1, bool arg2, bool arg3, int arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.Drawing.SizeF SizeF_objc_msgSendSuper_SizeF_bool_bool_int (IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1, bool arg2, bool arg3, int arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void SizeF_objc_msgSend_stret_SizeF_IntPtr_IntPtr_int_int_int (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1, IntPtr arg2, IntPtr arg3, int arg4, int arg5, int arg6);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void SizeF_objc_msgSendSuper_stret_SizeF_IntPtr_IntPtr_int_int_int (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1, IntPtr arg2, IntPtr arg3, int arg4, int arg5, int arg6);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.Drawing.SizeF SizeF_objc_msgSend_SizeF_IntPtr_IntPtr_int_int_int (IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1, IntPtr arg2, IntPtr arg3, int arg4, int arg5, int arg6);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.Drawing.SizeF SizeF_objc_msgSendSuper_SizeF_IntPtr_IntPtr_int_int_int (IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1, IntPtr arg2, IntPtr arg3, int arg4, int arg5, int arg6);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_int_RectangleF_IntPtr (IntPtr receiver, IntPtr selector, int arg1, global::System.Drawing.RectangleF arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_int_RectangleF_IntPtr (IntPtr receiver, IntPtr selector, int arg1, global::System.Drawing.RectangleF arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.Double Double_objc_msgSend_Double (IntPtr receiver, IntPtr selector, global::System.Double arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.Double Double_objc_msgSendSuper_Double (IntPtr receiver, IntPtr selector, global::System.Double arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void RectangleF_objc_msgSend_stret_bool (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, bool arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void RectangleF_objc_msgSendSuper_stret_bool (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, bool arg1);
/*    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_NSRange_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_NSRange_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, IntPtr arg3);
*/    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_short (IntPtr receiver, IntPtr selector, IntPtr arg1, short arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_short (IntPtr receiver, IntPtr selector, IntPtr arg1, short arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_UInt32_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, IntPtr arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_UInt32_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, IntPtr arg3, IntPtr arg4);
/*    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void NSRange_objc_msgSend_stret_IntPtr_int_IntPtr_bool_int_int (out NSRange retval, IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3, bool arg4, int arg5, int arg6);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void NSRange_objc_msgSendSuper_stret_IntPtr_int_IntPtr_bool_int_int (out NSRange retval, IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3, bool arg4, int arg5, int arg6);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static NSRange NSRange_objc_msgSend_IntPtr_int_IntPtr_bool_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3, bool arg4, int arg5, int arg6);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static NSRange NSRange_objc_msgSendSuper_IntPtr_int_IntPtr_bool_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3, bool arg4, int arg5, int arg6);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void NSRange_objc_msgSend_stret_IntPtr_int (out NSRange retval, IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void NSRange_objc_msgSendSuper_stret_IntPtr_int (out NSRange retval, IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static NSRange NSRange_objc_msgSend_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static NSRange NSRange_objc_msgSendSuper_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void NSRange_objc_msgSend_stret_IntPtr_int_IntPtr_bool_int_IntPtr (out NSRange retval, IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3, bool arg4, int arg5, IntPtr arg6);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void NSRange_objc_msgSendSuper_stret_IntPtr_int_IntPtr_bool_int_IntPtr (out NSRange retval, IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3, bool arg4, int arg5, IntPtr arg6);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static NSRange NSRange_objc_msgSend_IntPtr_int_IntPtr_bool_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3, bool arg4, int arg5, IntPtr arg6);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static NSRange NSRange_objc_msgSendSuper_IntPtr_int_IntPtr_bool_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3, bool arg4, int arg5, IntPtr arg6);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_IntPtr_NSRange_UInt64_IntPtr_int_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, global::System.UInt64 arg3, IntPtr arg4, int arg5, IntPtr arg6, int arg7);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_NSRange_UInt64_IntPtr_int_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, global::System.UInt64 arg3, IntPtr arg4, int arg5, IntPtr arg6, int arg7);
*/    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_PointF_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, global::System.Drawing.PointF arg4, IntPtr arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_PointF_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, global::System.Drawing.PointF arg4, IntPtr arg5);
/*    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_NSRange_IntPtr_IntPtr_int (IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2, IntPtr arg3, int arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_NSRange_IntPtr_IntPtr_int (IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2, IntPtr arg3, int arg4);
*/    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static float float_objc_msgSend_IntPtr_float_int (IntPtr receiver, IntPtr selector, IntPtr arg1, float arg2, int arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static float float_objc_msgSendSuper_IntPtr_float_int (IntPtr receiver, IntPtr selector, IntPtr arg1, float arg2, int arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_SizeF (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.SizeF arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_SizeF (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.SizeF arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void RectangleF_objc_msgSend_stret_IntPtr_RectangleF_RectangleF_int (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2, global::System.Drawing.RectangleF arg3, int arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void RectangleF_objc_msgSendSuper_stret_IntPtr_RectangleF_RectangleF_int (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2, global::System.Drawing.RectangleF arg3, int arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void RectangleF_objc_msgSend_stret_IntPtr_int (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void RectangleF_objc_msgSendSuper_stret_IntPtr_int (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static int int_objc_msgSend_UInt64 (IntPtr receiver, IntPtr selector, global::System.UInt64 arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static int int_objc_msgSendSuper_UInt64 (IntPtr receiver, IntPtr selector, global::System.UInt64 arg1);
/*    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void NSEdgeInsets_objc_msgSend_stret (out global::MonoMac.AppKit.NSEdgeInsets retval, IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void NSEdgeInsets_objc_msgSendSuper_stret (out global::MonoMac.AppKit.NSEdgeInsets retval, IntPtr receiver, IntPtr selector);
*/    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void PointF_objc_msgSend_stret_PointF_IntPtr (out global::System.Drawing.PointF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void PointF_objc_msgSendSuper_stret_PointF_IntPtr (out global::System.Drawing.PointF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.Drawing.PointF PointF_objc_msgSend_PointF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.Drawing.PointF PointF_objc_msgSendSuper_PointF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void SizeF_objc_msgSend_stret_SizeF_IntPtr (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void SizeF_objc_msgSendSuper_stret_SizeF_IntPtr (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.Drawing.SizeF SizeF_objc_msgSend_SizeF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.Drawing.SizeF SizeF_objc_msgSendSuper_SizeF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void SizeF_objc_msgSend_stret_SizeF (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void SizeF_objc_msgSendSuper_stret_SizeF (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.Drawing.SizeF SizeF_objc_msgSend_SizeF (IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.Drawing.SizeF SizeF_objc_msgSendSuper_SizeF (IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_RectangleF_SizeF (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, global::System.Drawing.SizeF arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_RectangleF_SizeF (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, global::System.Drawing.SizeF arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_PointF (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_PointF (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_PointF_RectangleF (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, global::System.Drawing.RectangleF arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_PointF_RectangleF (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, global::System.Drawing.RectangleF arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static int int_objc_msgSend_RectangleF_IntPtr_IntPtr_bool (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2, global::System.IntPtr arg3, bool arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static int int_objc_msgSendSuper_RectangleF_IntPtr_IntPtr_bool (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2, global::System.IntPtr arg3, bool arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static int int_objc_msgSend_RectangleF_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2, global::System.IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static int int_objc_msgSendSuper_RectangleF_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2, global::System.IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_PointF_SizeF_IntPtr_IntPtr_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.PointF arg2, global::System.Drawing.SizeF arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6, bool arg7);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_PointF_SizeF_IntPtr_IntPtr_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.PointF arg2, global::System.Drawing.SizeF arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6, bool arg7);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_IntPtr_RectangleF_bool_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2, bool arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_IntPtr_RectangleF_bool_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2, bool arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_IntPtr_RectangleF_IntPtr_bool_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2, IntPtr arg3, bool arg4, IntPtr arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_IntPtr_RectangleF_IntPtr_bool_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2, IntPtr arg3, bool arg4, IntPtr arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_float_float_float_float (IntPtr receiver, IntPtr selector, float arg1, float arg2, float arg3, float arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_float_float_float_float (IntPtr receiver, IntPtr selector, float arg1, float arg2, float arg3, float arg4);
/*    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_out_NSRange (IntPtr receiver, IntPtr selector, out NSRange arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_out_NSRange (IntPtr receiver, IntPtr selector, out NSRange arg1);
*/    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void PointF_objc_msgSend_stret_RectangleF (out global::System.Drawing.PointF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void PointF_objc_msgSendSuper_stret_RectangleF (out global::System.Drawing.PointF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.Drawing.PointF PointF_objc_msgSend_RectangleF (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.Drawing.PointF PointF_objc_msgSendSuper_RectangleF (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1);
/*    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void NSRange_objc_msgSend_stret_RectangleF (out NSRange retval, IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void NSRange_objc_msgSendSuper_stret_RectangleF (out NSRange retval, IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static NSRange NSRange_objc_msgSend_RectangleF (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static NSRange NSRange_objc_msgSendSuper_RectangleF (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1);
*/    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_int_int_IntPtr_bool (IntPtr receiver, IntPtr selector, int arg1, int arg2, IntPtr arg3, bool arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_int_int_IntPtr_bool (IntPtr receiver, IntPtr selector, int arg1, int arg2, IntPtr arg3, bool arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_int_int_bool (IntPtr receiver, IntPtr selector, int arg1, int arg2, bool arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_int_int_bool (IntPtr receiver, IntPtr selector, int arg1, int arg2, bool arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_int_bool (IntPtr receiver, IntPtr selector, int arg1, bool arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_int_bool (IntPtr receiver, IntPtr selector, int arg1, bool arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_IntPtr_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, int arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, int arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static int int_objc_msgSend_IntPtr_int_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, int arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static int int_objc_msgSendSuper_IntPtr_int_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, int arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.UInt32 UInt32_objc_msgSend_IntPtr_IntPtr_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, int arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.UInt32 UInt32_objc_msgSendSuper_IntPtr_IntPtr_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, int arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_IntPtr_PointF_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Drawing.PointF arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_IntPtr_PointF_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Drawing.PointF arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_IntPtr_PointF_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Drawing.PointF arg3, global::System.UInt32 arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_IntPtr_PointF_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Drawing.PointF arg3, global::System.UInt32 arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_RectangleF_IntPtr_bool_int (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2, bool arg3, int arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_RectangleF_IntPtr_bool_int (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2, bool arg3, int arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_bool_RectangleF (IntPtr receiver, IntPtr selector, bool arg1, global::System.Drawing.RectangleF arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_bool_RectangleF (IntPtr receiver, IntPtr selector, bool arg1, global::System.Drawing.RectangleF arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void SizeF_objc_msgSend_stret_bool (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, bool arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void SizeF_objc_msgSendSuper_stret_bool (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, bool arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.Drawing.SizeF SizeF_objc_msgSend_bool (IntPtr receiver, IntPtr selector, bool arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.Drawing.SizeF SizeF_objc_msgSendSuper_bool (IntPtr receiver, IntPtr selector, bool arg1);
/*    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_NSRange_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_NSRange_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_NSRange (IntPtr receiver, IntPtr selector, NSRange arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_NSRange (IntPtr receiver, IntPtr selector, NSRange arg1);
*/    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_RectangleF_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2, global::System.UInt32 arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_RectangleF_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2, global::System.UInt32 arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_RectangleF_IntPtr_UInt32_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2, global::System.UInt32 arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_RectangleF_IntPtr_UInt32_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2, global::System.UInt32 arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_IntPtr_RectangleF_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2, IntPtr arg3, global::System.UInt32 arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_IntPtr_RectangleF_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2, IntPtr arg3, global::System.UInt32 arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_IntPtr_RectangleF_IntPtr_UInt32_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2, IntPtr arg3, global::System.UInt32 arg4, bool arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_IntPtr_RectangleF_IntPtr_UInt32_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2, IntPtr arg3, global::System.UInt32 arg4, bool arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void RectangleF_objc_msgSend_stret_IntPtr_RectangleF_PointF_UInt32 (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2, global::System.Drawing.PointF arg3, global::System.UInt32 arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void RectangleF_objc_msgSendSuper_stret_IntPtr_RectangleF_PointF_UInt32 (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2, global::System.Drawing.PointF arg3, global::System.UInt32 arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_float_int_int (IntPtr receiver, IntPtr selector, float arg1, int arg2, int arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_float_int_int (IntPtr receiver, IntPtr selector, float arg1, int arg2, int arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_float_int_int_int (IntPtr receiver, IntPtr selector, float arg1, int arg2, int arg3, int arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_float_int_int_int (IntPtr receiver, IntPtr selector, float arg1, int arg2, int arg3, int arg4);
/*    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void RectangleF_objc_msgSend_stret_PointF_RectangleF_IntPtr_NSRange (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, global::System.Drawing.RectangleF arg2, IntPtr arg3, NSRange arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void RectangleF_objc_msgSendSuper_stret_PointF_RectangleF_IntPtr_NSRange (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, global::System.Drawing.RectangleF arg2, IntPtr arg3, NSRange arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void RectangleF_objc_msgSend_stret_RectangleF_RectangleF_IntPtr_NSRange (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, global::System.Drawing.RectangleF arg2, IntPtr arg3, NSRange arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void RectangleF_objc_msgSendSuper_stret_RectangleF_RectangleF_IntPtr_NSRange (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, global::System.Drawing.RectangleF arg2, IntPtr arg3, NSRange arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_RectangleF_IntPtr_NSRange_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2, NSRange arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_RectangleF_IntPtr_NSRange_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2, NSRange arg3, IntPtr arg4);
*/    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_int_int_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, int arg3, int arg4, int arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_int_int_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, int arg3, int arg4, int arg5);
/*    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void RectangleF_objc_msgSend_stret_IntPtr_PointF_RectangleF_IntPtr_NSRange (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.PointF arg2, global::System.Drawing.RectangleF arg3, IntPtr arg4, NSRange arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void RectangleF_objc_msgSendSuper_stret_IntPtr_PointF_RectangleF_IntPtr_NSRange (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.PointF arg2, global::System.Drawing.RectangleF arg3, IntPtr arg4, NSRange arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void RectangleF_objc_msgSend_stret_IntPtr_RectangleF_RectangleF_IntPtr_NSRange (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2, global::System.Drawing.RectangleF arg3, IntPtr arg4, NSRange arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void RectangleF_objc_msgSendSuper_stret_IntPtr_RectangleF_RectangleF_IntPtr_NSRange (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2, global::System.Drawing.RectangleF arg3, IntPtr arg4, NSRange arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_RectangleF_IntPtr_NSRange_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2, IntPtr arg3, NSRange arg4, IntPtr arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_RectangleF_IntPtr_NSRange_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2, IntPtr arg3, NSRange arg4, IntPtr arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_UInt32_NSRange_int (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, NSRange arg2, int arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_UInt32_NSRange_int (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, NSRange arg2, int arg3);
*/    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.IntPtr IntPtr_objc_msgSend_int_float_IntPtr (IntPtr receiver, IntPtr selector, int arg1, float arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.IntPtr IntPtr_objc_msgSendSuper_int_float_IntPtr (IntPtr receiver, IntPtr selector, int arg1, float arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.UInt64 UInt64_objc_msgSend (IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.UInt64 UInt64_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_UInt64 (IntPtr receiver, IntPtr selector, global::System.UInt64 arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_UInt64 (IntPtr receiver, IntPtr selector, global::System.UInt64 arg1);
 /*   [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_int_NSRange (IntPtr receiver, IntPtr selector, int arg1, NSRange arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_int_NSRange (IntPtr receiver, IntPtr selector, int arg1, NSRange arg2);
*/    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static float float_objc_msgSend_IntPtr_IntPtr_float (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, float arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static float float_objc_msgSendSuper_IntPtr_IntPtr_float (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, float arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_RectangleF_IntPtr_bool (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2, bool arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_RectangleF_IntPtr_bool (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, IntPtr arg2, bool arg3);
/*    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void NSRange_objc_msgSend_stret_NSRange_int (out NSRange retval, IntPtr receiver, IntPtr selector, NSRange arg1, int arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void NSRange_objc_msgSendSuper_stret_NSRange_int (out NSRange retval, IntPtr receiver, IntPtr selector, NSRange arg1, int arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static NSRange NSRange_objc_msgSend_NSRange_int (IntPtr receiver, IntPtr selector, NSRange arg1, int arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static NSRange NSRange_objc_msgSendSuper_NSRange_int (IntPtr receiver, IntPtr selector, NSRange arg1, int arg2);
*/    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.UInt32 UInt32_objc_msgSend_PointF (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.UInt32 UInt32_objc_msgSendSuper_PointF (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1);
/*    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_NSRange_int (IntPtr receiver, IntPtr selector, NSRange arg1, int arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_NSRange_int (IntPtr receiver, IntPtr selector, NSRange arg1, int arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_NSRange_int_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, int arg3, bool arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_NSRange_int_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, int arg3, bool arg4);
*/    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_int_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, bool arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_int_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, bool arg3);
/*    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_NSRange_int_bool (IntPtr receiver, IntPtr selector, NSRange arg1, int arg2, bool arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_NSRange_int_bool (IntPtr receiver, IntPtr selector, NSRange arg1, int arg2, bool arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_NSRange_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_NSRange_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void NSRange_objc_msgSend_stret_NSRange (out NSRange retval, IntPtr receiver, IntPtr selector, NSRange arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void NSRange_objc_msgSendSuper_stret_NSRange (out NSRange retval, IntPtr receiver, IntPtr selector, NSRange arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static NSRange NSRange_objc_msgSend_NSRange (IntPtr receiver, IntPtr selector, NSRange arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static NSRange NSRange_objc_msgSendSuper_NSRange (IntPtr receiver, IntPtr selector, NSRange arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_NSRange_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, IntPtr arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_NSRange_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, IntPtr arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_IntPtr_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_NSRange_UInt64_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, global::System.UInt64 arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_NSRange_UInt64_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, global::System.UInt64 arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_NSRange_UInt64_IntPtr_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, global::System.UInt64 arg3, IntPtr arg4, IntPtr arg5, int arg6);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_NSRange_UInt64_IntPtr_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, global::System.UInt64 arg3, IntPtr arg4, IntPtr arg5, int arg6);
*/    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_IntPtr_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.UInt32 arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_IntPtr_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.UInt32 arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_IntPtr_RectangleF_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Drawing.RectangleF arg3, global::System.UInt32 arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_IntPtr_RectangleF_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Drawing.RectangleF arg3, global::System.UInt32 arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.UInt32 arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.UInt32 arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_IntPtr_IntPtr_UInt32_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.UInt32 arg3, IntPtr arg4, IntPtr arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_IntPtr_IntPtr_UInt32_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.UInt32 arg3, IntPtr arg4, IntPtr arg5);
/*    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void NSRange_objc_msgSend_stret_IntPtr_NSRange_NSRange (out NSRange retval, IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, NSRange arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void NSRange_objc_msgSendSuper_stret_IntPtr_NSRange_NSRange (out NSRange retval, IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, NSRange arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static NSRange NSRange_objc_msgSend_IntPtr_NSRange_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, NSRange arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static NSRange NSRange_objc_msgSendSuper_IntPtr_NSRange_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, NSRange arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_NSRange_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, NSRange arg3, int arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_NSRange_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, NSRange arg3, int arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_IntPtr_NSRange_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_IntPtr_NSRange_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static int int_objc_msgSend_IntPtr_int_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, NSRange arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static int int_objc_msgSendSuper_IntPtr_int_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, NSRange arg3);
*/    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, global::System.UInt32 arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, global::System.UInt32 arg4);
/*    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_IntPtr_NSRange_IntPtr_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, IntPtr arg3, global::System.UInt64 arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_NSRange_IntPtr_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, IntPtr arg3, global::System.UInt64 arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_IntPtr_NSRange_UInt64_IntPtr_IntPtr_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, global::System.UInt64 arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6, int arg7);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_NSRange_UInt64_IntPtr_IntPtr_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, global::System.UInt64 arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6, int arg7);
*/    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_IntPtr_RectangleF_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Drawing.RectangleF arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_IntPtr_RectangleF_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Drawing.RectangleF arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, int arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, int arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.IntPtr IntPtr_objc_msgSend_RectangleF_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, int arg2, IntPtr arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.IntPtr IntPtr_objc_msgSendSuper_RectangleF_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, int arg2, IntPtr arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void RectangleF_objc_msgSend_stret_RectangleF_int (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, int arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void RectangleF_objc_msgSendSuper_stret_RectangleF_int (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, int arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.IntPtr IntPtr_objc_msgSend_RectangleF_int_int_bool (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, int arg2, int arg3, bool arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.IntPtr IntPtr_objc_msgSendSuper_RectangleF_int_int_bool (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, int arg2, int arg3, bool arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.IntPtr IntPtr_objc_msgSend_RectangleF_int_int_bool_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, int arg2, int arg3, bool arg4, IntPtr arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.IntPtr IntPtr_objc_msgSendSuper_RectangleF_int_int_bool_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, int arg2, int arg3, bool arg4, IntPtr arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.Double Double_objc_msgSend_RectangleF (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.Double Double_objc_msgSendSuper_RectangleF (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_RectangleF_bool_bool (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, bool arg2, bool arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_RectangleF_bool_bool (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, bool arg2, bool arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_UInt64 (IntPtr receiver, IntPtr selector, global::System.UInt64 arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_UInt64 (IntPtr receiver, IntPtr selector, global::System.UInt64 arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static int int_objc_msgSend_PointF_int (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, int arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static int int_objc_msgSendSuper_PointF_int (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, int arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void RectangleF_objc_msgSend_stret_IntPtr_RectangleF (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void RectangleF_objc_msgSendSuper_stret_IntPtr_RectangleF (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void RectangleF_objc_msgSend_stret_IntPtr_IntPtr_RectangleF (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Drawing.RectangleF arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void RectangleF_objc_msgSendSuper_stret_IntPtr_IntPtr_RectangleF (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Drawing.RectangleF arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_IntPtr_IntPtr_PointF_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Drawing.PointF arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_IntPtr_IntPtr_PointF_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Drawing.PointF arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Double arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Double arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void SizeF_objc_msgSend_stret_IntPtr_SizeF_SizeF (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.SizeF arg2, global::System.Drawing.SizeF arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void SizeF_objc_msgSendSuper_stret_IntPtr_SizeF_SizeF (out global::System.Drawing.SizeF retval, IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.SizeF arg2, global::System.Drawing.SizeF arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.Drawing.SizeF SizeF_objc_msgSend_IntPtr_SizeF_SizeF (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.SizeF arg2, global::System.Drawing.SizeF arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.Drawing.SizeF SizeF_objc_msgSendSuper_IntPtr_SizeF_SizeF (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.SizeF arg2, global::System.Drawing.SizeF arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_IntPtr_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, bool arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_IntPtr_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, bool arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_IntPtr_bool_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, bool arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_IntPtr_bool_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, bool arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_IntPtr_out_Boolean_out_Boolean_out_Boolean_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, out bool arg2, out bool arg3, out bool arg4, IntPtr arg5, IntPtr arg6);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_IntPtr_out_Boolean_out_Boolean_out_Boolean_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, out bool arg2, out bool arg3, out bool arg4, IntPtr arg5, IntPtr arg6);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, int arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, int arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.Double Double_objc_msgSend_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.Double Double_objc_msgSendSuper_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_int_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, IntPtr arg4, int arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_int_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, IntPtr arg4, int arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_UInt32_int_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, int arg3, IntPtr arg4, int arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt32_int_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, int arg3, IntPtr arg4, int arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static int int_objc_msgSend_IntPtr_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static int int_objc_msgSendSuper_IntPtr_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_IntPtr_int_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3, int arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_int_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3, int arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_RectangleF (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Drawing.RectangleF arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_RectangleF (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Drawing.RectangleF arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_bool_IntPtr (IntPtr receiver, IntPtr selector, bool arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_bool_IntPtr (IntPtr receiver, IntPtr selector, bool arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_UInt32_IntPtr (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_UInt32_IntPtr (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, IntPtr arg2);
/*    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void CGAffineTransform_objc_msgSend_stret (out CGAffineTransform retval, IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void CGAffineTransform_objc_msgSendSuper_stret (out CGAffineTransform retval, IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_CGAffineTransform (IntPtr receiver, IntPtr selector, CGAffineTransform arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_CGAffineTransform (IntPtr receiver, IntPtr selector, CGAffineTransform arg1);
*/    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_int_bool_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, int arg5, bool arg6, IntPtr arg7);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_int_bool_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, int arg5, bool arg6, IntPtr arg7);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_int_bool_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, int arg5, bool arg6, IntPtr arg7, IntPtr arg8);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_int_bool_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, int arg5, bool arg6, IntPtr arg7, IntPtr arg8);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_float_PointF (IntPtr receiver, IntPtr selector, float arg1, global::System.Drawing.PointF arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_float_PointF (IntPtr receiver, IntPtr selector, float arg1, global::System.Drawing.PointF arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_int_IntPtr (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_int_IntPtr (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2);
/*    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void QTTime_objc_msgSend_stret (out global::MonoMac.QTKit.QTTime retval, IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void QTTime_objc_msgSendSuper_stret (out global::MonoMac.QTKit.QTTime retval, IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_QTTime (IntPtr receiver, IntPtr selector, global::MonoMac.QTKit.QTTime arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_QTTime (IntPtr receiver, IntPtr selector, global::MonoMac.QTKit.QTTime arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_QTTimeRange_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::MonoMac.QTKit.QTTimeRange arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_QTTimeRange_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::MonoMac.QTKit.QTTimeRange arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_QTTimeRange_IntPtr (IntPtr receiver, IntPtr selector, global::MonoMac.QTKit.QTTimeRange arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_QTTimeRange_IntPtr (IntPtr receiver, IntPtr selector, global::MonoMac.QTKit.QTTimeRange arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_QTTime (IntPtr receiver, IntPtr selector, global::MonoMac.QTKit.QTTime arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_QTTime (IntPtr receiver, IntPtr selector, global::MonoMac.QTKit.QTTime arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.IntPtr IntPtr_objc_msgSend_QTTime_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, global::MonoMac.QTKit.QTTime arg1, IntPtr arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.IntPtr IntPtr_objc_msgSendSuper_QTTime_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, global::MonoMac.QTKit.QTTime arg1, IntPtr arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_QTTimeRange (IntPtr receiver, IntPtr selector, global::MonoMac.QTKit.QTTimeRange arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_QTTimeRange (IntPtr receiver, IntPtr selector, global::MonoMac.QTKit.QTTimeRange arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_QTTimeRange_QTTime (IntPtr receiver, IntPtr selector, IntPtr arg1, global::MonoMac.QTKit.QTTimeRange arg2, global::MonoMac.QTKit.QTTime arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_QTTimeRange_QTTime (IntPtr receiver, IntPtr selector, IntPtr arg1, global::MonoMac.QTKit.QTTimeRange arg2, global::MonoMac.QTKit.QTTime arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_QTTimeRange_QTTimeRange (IntPtr receiver, IntPtr selector, IntPtr arg1, global::MonoMac.QTKit.QTTimeRange arg2, global::MonoMac.QTKit.QTTimeRange arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_QTTimeRange_QTTimeRange (IntPtr receiver, IntPtr selector, IntPtr arg1, global::MonoMac.QTKit.QTTimeRange arg2, global::MonoMac.QTKit.QTTimeRange arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_QTTimeRange_QTTime (IntPtr receiver, IntPtr selector, global::MonoMac.QTKit.QTTimeRange arg1, global::MonoMac.QTKit.QTTime arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_QTTimeRange_QTTime (IntPtr receiver, IntPtr selector, global::MonoMac.QTKit.QTTimeRange arg1, global::MonoMac.QTKit.QTTime arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_QTTime_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::MonoMac.QTKit.QTTime arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_QTTime_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::MonoMac.QTKit.QTTime arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_IntPtr_QTTimeRange_QTTime (IntPtr receiver, IntPtr selector, IntPtr arg1, global::MonoMac.QTKit.QTTimeRange arg2, global::MonoMac.QTKit.QTTime arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_QTTimeRange_QTTime (IntPtr receiver, IntPtr selector, IntPtr arg1, global::MonoMac.QTKit.QTTimeRange arg2, global::MonoMac.QTKit.QTTime arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_IntPtr_QTTimeRange_QTTimeRange (IntPtr receiver, IntPtr selector, IntPtr arg1, global::MonoMac.QTKit.QTTimeRange arg2, global::MonoMac.QTKit.QTTimeRange arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_QTTimeRange_QTTimeRange (IntPtr receiver, IntPtr selector, IntPtr arg1, global::MonoMac.QTKit.QTTimeRange arg2, global::MonoMac.QTKit.QTTimeRange arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void QTTime_objc_msgSend_stret_int (out global::MonoMac.QTKit.QTTime retval, IntPtr receiver, IntPtr selector, int arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void QTTime_objc_msgSendSuper_stret_int (out global::MonoMac.QTKit.QTTime retval, IntPtr receiver, IntPtr selector, int arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static int int_objc_msgSend_QTTime (IntPtr receiver, IntPtr selector, global::MonoMac.QTKit.QTTime arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static int int_objc_msgSendSuper_QTTime (IntPtr receiver, IntPtr selector, global::MonoMac.QTKit.QTTime arg1);
*/    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_SizeF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_SizeF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.IntPtr IntPtr_objc_msgSend_int_PointF_IntPtr (IntPtr receiver, IntPtr selector, int arg1, global::System.Drawing.PointF arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.IntPtr IntPtr_objc_msgSendSuper_int_PointF_IntPtr (IntPtr receiver, IntPtr selector, int arg1, global::System.Drawing.PointF arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_IntPtr_PointF_IntPtr_PointF (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.PointF arg2, IntPtr arg3, global::System.Drawing.PointF arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_PointF_IntPtr_PointF (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.PointF arg2, IntPtr arg3, global::System.Drawing.PointF arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_RectangleF_int (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, int arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_RectangleF_int (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, int arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_PointF_PointF (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, global::System.Drawing.PointF arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_PointF_PointF (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, global::System.Drawing.PointF arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_bool_int (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, int arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_bool_int (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, int arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_PointF_bool (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, bool arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_PointF_bool (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, bool arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.UInt32 UInt32_objc_msgSend_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.UInt32 UInt32_objc_msgSendSuper_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static int int_objc_msgSend_IntPtr_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.UInt32 arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static int int_objc_msgSendSuper_IntPtr_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.UInt32 arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static short short_objc_msgSend_int_IntPtr (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static short short_objc_msgSendSuper_int_IntPtr (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static short short_objc_msgSend_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static short short_objc_msgSendSuper_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static short short_objc_msgSend_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static short short_objc_msgSendSuper_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_UInt32_UInt32 (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, global::System.UInt32 arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_UInt32_UInt32 (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, global::System.UInt32 arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_UInt32_UInt32 (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, global::System.UInt32 arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_UInt32_UInt32 (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, global::System.UInt32 arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_UInt32_UInt32_IntPtr (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, global::System.UInt32 arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_UInt32_UInt32_IntPtr (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, global::System.UInt32 arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_IntPtr_bool_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_IntPtr_bool_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_bool_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, bool arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_bool_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, bool arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_IntPtr_Double_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Double arg3, IntPtr arg4, IntPtr arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_IntPtr_Double_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Double arg3, IntPtr arg4, IntPtr arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Double arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Double arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_RectangleF (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_RectangleF (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.UInt32 arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.UInt32 arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_UInt32_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_UInt32_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.UInt32 UInt32_objc_msgSend_IntPtr_PointF (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.PointF arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.UInt32 UInt32_objc_msgSendSuper_IntPtr_PointF (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.PointF arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_UInt32_PointF_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, global::System.Drawing.PointF arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_UInt32_PointF_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, global::System.Drawing.PointF arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_IntPtr_bool_bool_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, bool arg3, bool arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_IntPtr_bool_bool_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, bool arg3, bool arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_Int64 (IntPtr receiver, IntPtr selector, global::System.Int64 arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_Int64 (IntPtr receiver, IntPtr selector, global::System.Int64 arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static float float_objc_msgSend_UInt32 (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static float float_objc_msgSendSuper_UInt32 (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_Double (IntPtr receiver, IntPtr selector, global::System.Double arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_Double (IntPtr receiver, IntPtr selector, global::System.Double arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_Double_float (IntPtr receiver, IntPtr selector, global::System.Double arg1, float arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_Double_float (IntPtr receiver, IntPtr selector, global::System.Double arg1, float arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_bool_int_IntPtr (IntPtr receiver, IntPtr selector, bool arg1, int arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_bool_int_IntPtr (IntPtr receiver, IntPtr selector, bool arg1, int arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_Double_IntPtr (IntPtr receiver, IntPtr selector, global::System.Double arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_Double_IntPtr (IntPtr receiver, IntPtr selector, global::System.Double arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_float_IntPtr (IntPtr receiver, IntPtr selector, float arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_float_IntPtr (IntPtr receiver, IntPtr selector, float arg1, IntPtr arg2);
/*    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void CMTime_objc_msgSend_stret (out global::MonoMac.CoreMedia.CMTime retval, IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void CMTime_objc_msgSendSuper_stret (out global::MonoMac.CoreMedia.CMTime retval, IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_CMTime (IntPtr receiver, IntPtr selector, global::MonoMac.CoreMedia.CMTime arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_CMTime (IntPtr receiver, IntPtr selector, global::MonoMac.CoreMedia.CMTime arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_CMTime_out_CMTime_IntPtr (IntPtr receiver, IntPtr selector, global::MonoMac.CoreMedia.CMTime arg1, out global::MonoMac.CoreMedia.CMTime arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_CMTime_out_CMTime_IntPtr (IntPtr receiver, IntPtr selector, global::MonoMac.CoreMedia.CMTime arg1, out global::MonoMac.CoreMedia.CMTime arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void CMTimeRange_objc_msgSend_stret (out global::MonoMac.CoreMedia.CMTimeRange retval, IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void CMTimeRange_objc_msgSendSuper_stret (out global::MonoMac.CoreMedia.CMTimeRange retval, IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_CMTimeRange (IntPtr receiver, IntPtr selector, global::MonoMac.CoreMedia.CMTimeRange arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_CMTimeRange (IntPtr receiver, IntPtr selector, global::MonoMac.CoreMedia.CMTimeRange arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_IntPtr_CMTime (IntPtr receiver, IntPtr selector, IntPtr arg1, global::MonoMac.CoreMedia.CMTime arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_IntPtr_CMTime (IntPtr receiver, IntPtr selector, IntPtr arg1, global::MonoMac.CoreMedia.CMTime arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_CMTime (IntPtr receiver, IntPtr selector, global::MonoMac.CoreMedia.CMTime arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_CMTime (IntPtr receiver, IntPtr selector, global::MonoMac.CoreMedia.CMTime arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void CMTime_objc_msgSend_stret_CMTime (out global::MonoMac.CoreMedia.CMTime retval, IntPtr receiver, IntPtr selector, global::MonoMac.CoreMedia.CMTime arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void CMTime_objc_msgSendSuper_stret_CMTime (out global::MonoMac.CoreMedia.CMTime retval, IntPtr receiver, IntPtr selector, global::MonoMac.CoreMedia.CMTime arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_CMTimeRange_IntPtr_CMTime_IntPtr (IntPtr receiver, IntPtr selector, global::MonoMac.CoreMedia.CMTimeRange arg1, IntPtr arg2, global::MonoMac.CoreMedia.CMTime arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_CMTimeRange_IntPtr_CMTime_IntPtr (IntPtr receiver, IntPtr selector, global::MonoMac.CoreMedia.CMTimeRange arg1, IntPtr arg2, global::MonoMac.CoreMedia.CMTime arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_CMTimeRange_CMTime (IntPtr receiver, IntPtr selector, global::MonoMac.CoreMedia.CMTimeRange arg1, global::MonoMac.CoreMedia.CMTime arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_CMTimeRange_CMTime (IntPtr receiver, IntPtr selector, global::MonoMac.CoreMedia.CMTimeRange arg1, global::MonoMac.CoreMedia.CMTime arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_IntPtr_IntPtr_CMTime_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::MonoMac.CoreMedia.CMTime arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_IntPtr_IntPtr_CMTime_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::MonoMac.CoreMedia.CMTime arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void CMTimeMapping_objc_msgSend_stret (out global::MonoMac.CoreMedia.CMTimeMapping retval, IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void CMTimeMapping_objc_msgSendSuper_stret (out global::MonoMac.CoreMedia.CMTimeMapping retval, IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_int_CMTimeRange_CMTimeRange (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, global::MonoMac.CoreMedia.CMTimeRange arg3, global::MonoMac.CoreMedia.CMTimeRange arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_int_CMTimeRange_CMTimeRange (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, global::MonoMac.CoreMedia.CMTimeRange arg3, global::MonoMac.CoreMedia.CMTimeRange arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.IntPtr IntPtr_objc_msgSend_CMTimeRange (IntPtr receiver, IntPtr selector, global::MonoMac.CoreMedia.CMTimeRange arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.IntPtr IntPtr_objc_msgSendSuper_CMTimeRange (IntPtr receiver, IntPtr selector, global::MonoMac.CoreMedia.CMTimeRange arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_CMTime_float_float_CMTimeRange (IntPtr receiver, IntPtr selector, global::MonoMac.CoreMedia.CMTime arg1, float arg2, float arg3, global::MonoMac.CoreMedia.CMTimeRange arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_CMTime_float_float_CMTimeRange (IntPtr receiver, IntPtr selector, global::MonoMac.CoreMedia.CMTime arg1, float arg2, float arg3, global::MonoMac.CoreMedia.CMTimeRange arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_float_float_CMTimeRange (IntPtr receiver, IntPtr selector, float arg1, float arg2, global::MonoMac.CoreMedia.CMTimeRange arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_float_float_CMTimeRange (IntPtr receiver, IntPtr selector, float arg1, float arg2, global::MonoMac.CoreMedia.CMTimeRange arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_float_CMTime (IntPtr receiver, IntPtr selector, float arg1, global::MonoMac.CoreMedia.CMTime arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_float_CMTime (IntPtr receiver, IntPtr selector, float arg1, global::MonoMac.CoreMedia.CMTime arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_IntPtr_CMTimeRange_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::MonoMac.CoreMedia.CMTimeRange arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_IntPtr_CMTimeRange_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::MonoMac.CoreMedia.CMTimeRange arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_IntPtr_CMTimeRange (IntPtr receiver, IntPtr selector, IntPtr arg1, global::MonoMac.CoreMedia.CMTimeRange arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_IntPtr_CMTimeRange (IntPtr receiver, IntPtr selector, IntPtr arg1, global::MonoMac.CoreMedia.CMTimeRange arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_CMTime_CGAffineTransform_CGAffineTransform_CMTimeRange (IntPtr receiver, IntPtr selector, global::MonoMac.CoreMedia.CMTime arg1, CGAffineTransform arg2, CGAffineTransform arg3, global::MonoMac.CoreMedia.CMTimeRange arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_CMTime_CGAffineTransform_CGAffineTransform_CMTimeRange (IntPtr receiver, IntPtr selector, global::MonoMac.CoreMedia.CMTime arg1, CGAffineTransform arg2, CGAffineTransform arg3, global::MonoMac.CoreMedia.CMTimeRange arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_CGAffineTransform_CGAffineTransform_CMTimeRange (IntPtr receiver, IntPtr selector, CGAffineTransform arg1, CGAffineTransform arg2, global::MonoMac.CoreMedia.CMTimeRange arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_CGAffineTransform_CGAffineTransform_CMTimeRange (IntPtr receiver, IntPtr selector, CGAffineTransform arg1, CGAffineTransform arg2, global::MonoMac.CoreMedia.CMTimeRange arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_CGAffineTransform_CMTime (IntPtr receiver, IntPtr selector, CGAffineTransform arg1, global::MonoMac.CoreMedia.CMTime arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_CGAffineTransform_CMTime (IntPtr receiver, IntPtr selector, CGAffineTransform arg1, global::MonoMac.CoreMedia.CMTime arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_CMTime_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, global::MonoMac.CoreMedia.CMTime arg1, IntPtr arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_CMTime_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, global::MonoMac.CoreMedia.CMTime arg1, IntPtr arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_CMTime_CMTime_CMTime (IntPtr receiver, IntPtr selector, global::MonoMac.CoreMedia.CMTime arg1, global::MonoMac.CoreMedia.CMTime arg2, global::MonoMac.CoreMedia.CMTime arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_CMTime_CMTime_CMTime (IntPtr receiver, IntPtr selector, global::MonoMac.CoreMedia.CMTime arg1, global::MonoMac.CoreMedia.CMTime arg2, global::MonoMac.CoreMedia.CMTime arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_CMTime_IntPtr (IntPtr receiver, IntPtr selector, global::MonoMac.CoreMedia.CMTime arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_CMTime_IntPtr (IntPtr receiver, IntPtr selector, global::MonoMac.CoreMedia.CMTime arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_CMTime_CMTime_CMTime_IntPtr (IntPtr receiver, IntPtr selector, global::MonoMac.CoreMedia.CMTime arg1, global::MonoMac.CoreMedia.CMTime arg2, global::MonoMac.CoreMedia.CMTime arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_CMTime_CMTime_CMTime_IntPtr (IntPtr receiver, IntPtr selector, global::MonoMac.CoreMedia.CMTime arg1, global::MonoMac.CoreMedia.CMTime arg2, global::MonoMac.CoreMedia.CMTime arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_float_CMTime_CMTime (IntPtr receiver, IntPtr selector, float arg1, global::MonoMac.CoreMedia.CMTime arg2, global::MonoMac.CoreMedia.CMTime arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_float_CMTime_CMTime (IntPtr receiver, IntPtr selector, float arg1, global::MonoMac.CoreMedia.CMTime arg2, global::MonoMac.CoreMedia.CMTime arg3);
*/    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_float_IntPtr (IntPtr receiver, IntPtr selector, float arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_float_IntPtr (IntPtr receiver, IntPtr selector, float arg1, IntPtr arg2);
/*    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_CMTimeRange (IntPtr receiver, IntPtr selector, IntPtr arg1, global::MonoMac.CoreMedia.CMTimeRange arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_CMTimeRange (IntPtr receiver, IntPtr selector, IntPtr arg1, global::MonoMac.CoreMedia.CMTimeRange arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_CMTime (IntPtr receiver, IntPtr selector, global::MonoMac.CoreMedia.CMTime arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_CMTime (IntPtr receiver, IntPtr selector, global::MonoMac.CoreMedia.CMTime arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_CMTime_CMTime_CMTime (IntPtr receiver, IntPtr selector, global::MonoMac.CoreMedia.CMTime arg1, global::MonoMac.CoreMedia.CMTime arg2, global::MonoMac.CoreMedia.CMTime arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_CMTime_CMTime_CMTime (IntPtr receiver, IntPtr selector, global::MonoMac.CoreMedia.CMTime arg1, global::MonoMac.CoreMedia.CMTime arg2, global::MonoMac.CoreMedia.CMTime arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void CMTime_objc_msgSend_stret_Double (out global::MonoMac.CoreMedia.CMTime retval, IntPtr receiver, IntPtr selector, global::System.Double arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void CMTime_objc_msgSendSuper_stret_Double (out global::MonoMac.CoreMedia.CMTime retval, IntPtr receiver, IntPtr selector, global::System.Double arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void CMTime_objc_msgSend_stret_Int64 (out global::MonoMac.CoreMedia.CMTime retval, IntPtr receiver, IntPtr selector, global::System.Int64 arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void CMTime_objc_msgSendSuper_stret_Int64 (out global::MonoMac.CoreMedia.CMTime retval, IntPtr receiver, IntPtr selector, global::System.Int64 arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_CMTime_out_CMTime (IntPtr receiver, IntPtr selector, global::MonoMac.CoreMedia.CMTime arg1, out global::MonoMac.CoreMedia.CMTime arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_CMTime_out_CMTime (IntPtr receiver, IntPtr selector, global::MonoMac.CoreMedia.CMTime arg1, out global::MonoMac.CoreMedia.CMTime arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_int_out_NSRange (IntPtr receiver, IntPtr selector, int arg1, out NSRange arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_int_out_NSRange (IntPtr receiver, IntPtr selector, int arg1, out NSRange arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_IntPtr_int_out_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, out NSRange arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_int_out_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, out NSRange arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_int_out_NSRange_NSRange (IntPtr receiver, IntPtr selector, int arg1, out NSRange arg2, NSRange arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_int_out_NSRange_NSRange (IntPtr receiver, IntPtr selector, int arg1, out NSRange arg2, NSRange arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_IntPtr_int_out_NSRange_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, out NSRange arg3, NSRange arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_int_out_NSRange_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, out NSRange arg3, NSRange arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_NSRange_int_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, int arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_NSRange_int_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, int arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_NSRange_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, int arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_NSRange_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, int arg3, IntPtr arg4);
*/    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_RectangleF_UInt32 (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, global::System.UInt32 arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_RectangleF_UInt32 (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, global::System.UInt32 arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_Char (IntPtr receiver, IntPtr selector, global::System.Char arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_Char (IntPtr receiver, IntPtr selector, global::System.Char arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_byte (IntPtr receiver, IntPtr selector, byte arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_byte (IntPtr receiver, IntPtr selector, byte arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_UInt32 (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_UInt32 (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_Double_IntPtr (IntPtr receiver, IntPtr selector, global::System.Double arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_Double_IntPtr (IntPtr receiver, IntPtr selector, global::System.Double arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_Int64_IntPtr (IntPtr receiver, IntPtr selector, global::System.Int64 arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_Int64_IntPtr (IntPtr receiver, IntPtr selector, global::System.Int64 arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.Int64 Int64_objc_msgSend_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.Int64 Int64_objc_msgSendSuper_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_int_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, int arg4, int arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_int_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, int arg4, int arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_IntPtr_UInt32_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt32_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, global::System.IntPtr arg1, global::System.UInt32 arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, global::System.IntPtr arg1, global::System.UInt32 arg2);
/*    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void NSRange_objc_msgSend_stret_IntPtr_int_NSRange (out NSRange retval, IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, NSRange arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void NSRange_objc_msgSendSuper_stret_IntPtr_int_NSRange (out NSRange retval, IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, NSRange arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static NSRange NSRange_objc_msgSend_IntPtr_int_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, NSRange arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static NSRange NSRange_objc_msgSendSuper_IntPtr_int_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, NSRange arg3);
*/    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_Int64_int (IntPtr receiver, IntPtr selector, global::System.Int64 arg1, int arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_Int64_int (IntPtr receiver, IntPtr selector, global::System.Int64 arg1, int arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_Int64 (IntPtr receiver, IntPtr selector, global::System.Int64 arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_Int64 (IntPtr receiver, IntPtr selector, global::System.Int64 arg1);
    [DllImport ("__Internal", EntryPoint="monotouch_IntPtr_objc_msgSend_IntPtr")]
    public extern static global::System.IntPtr monotouch_IntPtr_objc_msgSend_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);
    [DllImport ("__Internal", EntryPoint="monotouch_IntPtr_objc_msgSendSuper_IntPtr")]
    public extern static global::System.IntPtr monotouch_IntPtr_objc_msgSendSuper_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_Double (IntPtr receiver, IntPtr selector, global::System.Double arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_Double (IntPtr receiver, IntPtr selector, global::System.Double arg1);
/*    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_NSRange_int (IntPtr receiver, IntPtr selector, NSRange arg1, int arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_NSRange_int (IntPtr receiver, IntPtr selector, NSRange arg1, int arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_NSRange_IntPtr_int_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2, int arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_NSRange_IntPtr_int_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2, int arg3, IntPtr arg4);
*/    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_int_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, global::System.IntPtr arg3, global::System.IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_int_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, global::System.IntPtr arg3, global::System.IntPtr arg4);
/*    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_NSRange_IntPtr_int_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2, int arg3, global::System.IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_NSRange_IntPtr_int_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2, int arg3, global::System.IntPtr arg4);
*/    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_int_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, global::System.IntPtr arg3, global::System.IntPtr arg4, global::System.IntPtr arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_int_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, global::System.IntPtr arg3, global::System.IntPtr arg4, global::System.IntPtr arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_Double_IntPtr_IntPtr_IntPtr_bool (IntPtr receiver, IntPtr selector, global::System.Double arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, bool arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_Double_IntPtr_IntPtr_IntPtr_bool (IntPtr receiver, IntPtr selector, global::System.Double arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, bool arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_Double_IntPtr_IntPtr_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Double arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, bool arg6);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_Double_IntPtr_IntPtr_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Double arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, bool arg6);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_int_IntPtr_out_Boolean_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3, out bool arg4, IntPtr arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_int_IntPtr_out_Boolean_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3, out bool arg4, IntPtr arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.IntPtr IntPtr_objc_msgSend_UInt32_UInt32_IntPtr (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, global::System.UInt32 arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.IntPtr IntPtr_objc_msgSendSuper_UInt32_UInt32_IntPtr (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, global::System.UInt32 arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_int_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_int_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_Int64_Int64_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Int64 arg2, global::System.Int64 arg3, global::System.Int64 arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_Int64_Int64_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Int64 arg2, global::System.Int64 arg3, global::System.Int64 arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_Int64_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Int64 arg2, global::System.Int64 arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_Int64_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Int64 arg2, global::System.Int64 arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_int_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_int_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_int_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, global::System.Double arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_int_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, global::System.Double arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void RectangleF_objc_msgSend_stret_SizeF_UInt32_IntPtr (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1, global::System.UInt32 arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void RectangleF_objc_msgSendSuper_stret_SizeF_UInt32_IntPtr (out global::System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1, global::System.UInt32 arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_PointF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_PointF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.PointF arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_RectangleF_UInt32_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, global::System.UInt32 arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_RectangleF_UInt32_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, global::System.UInt32 arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.Char Char_objc_msgSend_int (IntPtr receiver, IntPtr selector, int arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.Char Char_objc_msgSendSuper_int (IntPtr receiver, IntPtr selector, int arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static int int_objc_msgSend_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static int int_objc_msgSendSuper_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2);
/*    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static int int_objc_msgSend_IntPtr_UInt32_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, NSRange arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static int int_objc_msgSendSuper_IntPtr_UInt32_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, NSRange arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static int int_objc_msgSend_IntPtr_UInt32_NSRange_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, NSRange arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static int int_objc_msgSendSuper_IntPtr_UInt32_NSRange_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, NSRange arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_NSRange_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_NSRange_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2);
*/    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, IntPtr arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.UInt32 UInt32_objc_msgSend_UInt32 (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.UInt32 UInt32_objc_msgSendSuper_UInt32 (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static int int_objc_msgSend_IntPtr_IntPtr_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static int int_objc_msgSendSuper_IntPtr_IntPtr_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, int arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, int arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_IntPtr_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, bool arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, bool arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_int_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, int arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_int_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, int arg3, IntPtr arg4);
/*    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_CMTimeMapping (IntPtr receiver, IntPtr selector, global::MonoMac.CoreMedia.CMTimeMapping arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_CMTimeMapping (IntPtr receiver, IntPtr selector, global::MonoMac.CoreMedia.CMTimeMapping arg1);
*/    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.SByte SByte_objc_msgSend (IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.SByte SByte_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static byte byte_objc_msgSend (IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static byte byte_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
/*    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void NSDecimal_objc_msgSend_stret (out NSDecimal retval, IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void NSDecimal_objc_msgSendSuper_stret (out NSDecimal retval, IntPtr receiver, IntPtr selector);
*/    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.IntPtr IntPtr_objc_msgSend_SByte (IntPtr receiver, IntPtr selector, global::System.SByte arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.IntPtr IntPtr_objc_msgSendSuper_SByte (IntPtr receiver, IntPtr selector, global::System.SByte arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.IntPtr IntPtr_objc_msgSend_byte (IntPtr receiver, IntPtr selector, byte arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.IntPtr IntPtr_objc_msgSendSuper_byte (IntPtr receiver, IntPtr selector, byte arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.IntPtr IntPtr_objc_msgSend_short (IntPtr receiver, IntPtr selector, short arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.IntPtr IntPtr_objc_msgSendSuper_short (IntPtr receiver, IntPtr selector, short arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.IntPtr IntPtr_objc_msgSend_UInt16 (IntPtr receiver, IntPtr selector, global::System.UInt16 arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.IntPtr IntPtr_objc_msgSendSuper_UInt16 (IntPtr receiver, IntPtr selector, global::System.UInt16 arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.IntPtr IntPtr_objc_msgSend_Int64_short_bool (IntPtr receiver, IntPtr selector, global::System.Int64 arg1, short arg2, bool arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.IntPtr IntPtr_objc_msgSendSuper_Int64_short_bool (IntPtr receiver, IntPtr selector, global::System.Int64 arg1, short arg2, bool arg3);
/*    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.IntPtr IntPtr_objc_msgSend_NSDecimal (IntPtr receiver, IntPtr selector, NSDecimal arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.IntPtr IntPtr_objc_msgSendSuper_NSDecimal (IntPtr receiver, IntPtr selector, NSDecimal arg1);
*/    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_int_IntPtr_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3, int arg4, IntPtr arg5, IntPtr arg6);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_int_IntPtr_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3, int arg4, IntPtr arg5, IntPtr arg6);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_IntPtr_bool_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, IntPtr arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_IntPtr_bool_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, IntPtr arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_int_int_IntPtr_bool_IntPtr (IntPtr receiver, IntPtr selector, int arg1, int arg2, IntPtr arg3, bool arg4, IntPtr arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_int_int_IntPtr_bool_IntPtr (IntPtr receiver, IntPtr selector, int arg1, int arg2, IntPtr arg3, bool arg4, IntPtr arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_IntPtr_IntPtr_IntPtr_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, int arg4, IntPtr arg5, IntPtr arg6);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, int arg4, IntPtr arg5, IntPtr arg6);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_bool_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, bool arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_bool_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, bool arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_IntPtr_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Int64 arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_IntPtr_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Int64 arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_int_IntPtr_int_float_float (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, int arg3, float arg4, float arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_int_IntPtr_int_float_float (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, int arg3, float arg4, float arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_int_IntPtr_int_float (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, int arg3, float arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_int_IntPtr_int_float (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, int arg3, float arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_int_IntPtr_int (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, int arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_int_IntPtr_int (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, int arg3);
/*    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void CATransform3D_objc_msgSend_stret (out global::MonoMac.CoreAnimation.CATransform3D retval, IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void CATransform3D_objc_msgSendSuper_stret (out global::MonoMac.CoreAnimation.CATransform3D retval, IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_CATransform3D (IntPtr receiver, IntPtr selector, global::MonoMac.CoreAnimation.CATransform3D arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_CATransform3D (IntPtr receiver, IntPtr selector, global::MonoMac.CoreAnimation.CATransform3D arg1);
*/    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.Double Double_objc_msgSend_Double_IntPtr (IntPtr receiver, IntPtr selector, global::System.Double arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.Double Double_objc_msgSendSuper_Double_IntPtr (IntPtr receiver, IntPtr selector, global::System.Double arg1, IntPtr arg2);
/*    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_IntPtr_IntPtr_Double_CVTimeStamp (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Double arg3, global::MonoMac.CoreVideo.CVTimeStamp arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_IntPtr_IntPtr_Double_CVTimeStamp (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Double arg3, global::MonoMac.CoreVideo.CVTimeStamp arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_IntPtr_Double_CVTimeStamp (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Double arg3, global::MonoMac.CoreVideo.CVTimeStamp arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_IntPtr_Double_CVTimeStamp (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.Double arg3, global::MonoMac.CoreVideo.CVTimeStamp arg4);
*/    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_IntPtr_IntPtr_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, int arg4, IntPtr arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, int arg4, IntPtr arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_IntPtr_UInt32_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.UInt32 arg3, int arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_IntPtr_UInt32_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.UInt32 arg3, int arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.UInt64 arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, global::System.UInt64 arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt64 arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt64 arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.IntPtr IntPtr_objc_msgSend_IntPtr_UInt32_UInt32_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, global::System.UInt32 arg3, IntPtr arg4, IntPtr arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt32_UInt32_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.UInt32 arg2, global::System.UInt32 arg3, IntPtr arg4, IntPtr arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static bool bool_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static bool bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_float_float_float (IntPtr receiver, IntPtr selector, float arg1, float arg2, float arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_float_float_float (IntPtr receiver, IntPtr selector, float arg1, float arg2, float arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_PointF_RectangleF (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.PointF arg2, global::System.Drawing.RectangleF arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_PointF_RectangleF (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.PointF arg2, global::System.Drawing.RectangleF arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_RectangleF_RectangleF (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2, global::System.Drawing.RectangleF arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_RectangleF_RectangleF (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2, global::System.Drawing.RectangleF arg3);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_IntPtr_RectangleF_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2, int arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_RectangleF_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2, int arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_SizeF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_SizeF_IntPtr (IntPtr receiver, IntPtr selector, global::System.Drawing.SizeF arg1, IntPtr arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static void void_objc_msgSend_IntPtr_IntPtr_int_RectangleF_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.IntPtr arg2, int arg3, global::System.Drawing.RectangleF arg4, int arg5, IntPtr arg6);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static void void_objc_msgSendSuper_IntPtr_IntPtr_int_RectangleF_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.IntPtr arg2, int arg3, global::System.Drawing.RectangleF arg4, int arg5, IntPtr arg6);
/*    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_CGAffineTransform_bool (IntPtr receiver, IntPtr selector, CGAffineTransform arg1, bool arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_CGAffineTransform_bool (IntPtr receiver, IntPtr selector, CGAffineTransform arg1, bool arg2);
*/    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_Rectangle (IntPtr receiver, IntPtr selector, global::System.Drawing.Rectangle arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_Rectangle (IntPtr receiver, IntPtr selector, global::System.Drawing.Rectangle arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_IntPtr_int_SizeF_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, global::System.Drawing.SizeF arg3, int arg4, IntPtr arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_int_SizeF_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, global::System.Drawing.SizeF arg3, int arg4, IntPtr arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_UInt32_SizeF_bool_IntPtr (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, global::System.Drawing.SizeF arg2, bool arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_UInt32_SizeF_bool_IntPtr (IntPtr receiver, IntPtr selector, global::System.UInt32 arg1, global::System.Drawing.SizeF arg2, bool arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.IntPtr IntPtr_objc_msgSend_int_SizeF_bool_IntPtr (IntPtr receiver, IntPtr selector, int arg1, global::System.Drawing.SizeF arg2, bool arg3, IntPtr arg4);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.IntPtr IntPtr_objc_msgSendSuper_int_SizeF_bool_IntPtr (IntPtr receiver, IntPtr selector, int arg1, global::System.Drawing.SizeF arg2, bool arg3, IntPtr arg4);
/*    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_CGAffineTransform (IntPtr receiver, IntPtr selector, CGAffineTransform arg1);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_CGAffineTransform (IntPtr receiver, IntPtr selector, CGAffineTransform arg1);
*/    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static IntPtr IntPtr_objc_msgSend_RectangleF_int (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, int arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static IntPtr IntPtr_objc_msgSendSuper_RectangleF_int (IntPtr receiver, IntPtr selector, global::System.Drawing.RectangleF arg1, int arg2);
/*    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
    public extern static void CLLocationCoordinate2D_objc_msgSend_stret (out global::MonoMac.CoreLocation.CLLocationCoordinate2D retval, IntPtr receiver, IntPtr selector);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
    public extern static void CLLocationCoordinate2D_objc_msgSendSuper_stret (out global::MonoMac.CoreLocation.CLLocationCoordinate2D retval, IntPtr receiver, IntPtr selector);
*/    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.IntPtr IntPtr_objc_msgSend_Double_Double (IntPtr receiver, IntPtr selector, global::System.Double arg1, global::System.Double arg2);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.IntPtr IntPtr_objc_msgSendSuper_Double_Double (IntPtr receiver, IntPtr selector, global::System.Double arg1, global::System.Double arg2);
/*    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.IntPtr IntPtr_objc_msgSend_CLLocationCoordinate2D_Double_Double_Double_IntPtr (IntPtr receiver, IntPtr selector, global::MonoMac.CoreLocation.CLLocationCoordinate2D arg1, global::System.Double arg2, global::System.Double arg3, global::System.Double arg4, IntPtr arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.IntPtr IntPtr_objc_msgSendSuper_CLLocationCoordinate2D_Double_Double_Double_IntPtr (IntPtr receiver, IntPtr selector, global::MonoMac.CoreLocation.CLLocationCoordinate2D arg1, global::System.Double arg2, global::System.Double arg3, global::System.Double arg4, IntPtr arg5);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
    public extern static global::System.IntPtr IntPtr_objc_msgSend_CLLocationCoordinate2D_Double_Double_Double_Double_Double_IntPtr (IntPtr receiver, IntPtr selector, global::MonoMac.CoreLocation.CLLocationCoordinate2D arg1, global::System.Double arg2, global::System.Double arg3, global::System.Double arg4, global::System.Double arg5, global::System.Double arg6, IntPtr arg7);
    [DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
    public extern static global::System.IntPtr IntPtr_objc_msgSendSuper_CLLocationCoordinate2D_Double_Double_Double_Double_Double_IntPtr (IntPtr receiver, IntPtr selector, global::MonoMac.CoreLocation.CLLocationCoordinate2D arg1, global::System.Double arg2, global::System.Double arg3, global::System.Double arg4, global::System.Double arg5, global::System.Double arg6, IntPtr arg7);
*/
  
  }
}
