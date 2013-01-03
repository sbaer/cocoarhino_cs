//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.ComponentModel;
//using RhinoMac.CoreFoundation;
using RhinoMac.Foundation;
using RhinoMac.ObjCRuntime;
//using RhinoMac.CoreGraphics;
//using RhinoMac.CoreAnimation;
//using RhinoMac.CoreLocation;
//using RhinoMac.QTKit;
//using RhinoMac.CoreVideo;
//using RhinoMac.CoreMedia;
//using RhinoMac.OpenGL;

namespace RhinoMac.AppKit {
	[Register("NSResponder", true)]
	public unsafe partial class NSResponder : NSObject {
		[CompilerGenerated]
		static readonly IntPtr selNextResponder = Selector.GetHandle ("nextResponder");
		[CompilerGenerated]
		static readonly IntPtr selSetNextResponder_ = Selector.GetHandle ("setNextResponder:");
		[CompilerGenerated]
		static readonly IntPtr selMenu = Selector.GetHandle ("menu");
		[CompilerGenerated]
		static readonly IntPtr selSetMenu_ = Selector.GetHandle ("setMenu:");
		[CompilerGenerated]
		static readonly IntPtr selTryToPerformWith_ = Selector.GetHandle ("tryToPerform:with:");
		[CompilerGenerated]
		static readonly IntPtr selPerformKeyEquivalent_ = Selector.GetHandle ("performKeyEquivalent:");
		[CompilerGenerated]
		static readonly IntPtr selValidRequestorForSendTypeReturnType_ = Selector.GetHandle ("validRequestorForSendType:returnType:");
		[CompilerGenerated]
		static readonly IntPtr selMouseDown_ = Selector.GetHandle ("mouseDown:");
		[CompilerGenerated]
		static readonly IntPtr selRightMouseDown_ = Selector.GetHandle ("rightMouseDown:");
		[CompilerGenerated]
		static readonly IntPtr selOtherMouseDown_ = Selector.GetHandle ("otherMouseDown:");
		[CompilerGenerated]
		static readonly IntPtr selMouseUp_ = Selector.GetHandle ("mouseUp:");
		[CompilerGenerated]
		static readonly IntPtr selRightMouseUp_ = Selector.GetHandle ("rightMouseUp:");
		[CompilerGenerated]
		static readonly IntPtr selOtherMouseUp_ = Selector.GetHandle ("otherMouseUp:");
		[CompilerGenerated]
		static readonly IntPtr selMouseMoved_ = Selector.GetHandle ("mouseMoved:");
		[CompilerGenerated]
		static readonly IntPtr selMouseDragged_ = Selector.GetHandle ("mouseDragged:");
		[CompilerGenerated]
		static readonly IntPtr selScrollWheel_ = Selector.GetHandle ("scrollWheel:");
		[CompilerGenerated]
		static readonly IntPtr selRightMouseDragged_ = Selector.GetHandle ("rightMouseDragged:");
		[CompilerGenerated]
		static readonly IntPtr selOtherMouseDragged_ = Selector.GetHandle ("otherMouseDragged:");
		[CompilerGenerated]
		static readonly IntPtr selMouseEntered_ = Selector.GetHandle ("mouseEntered:");
		[CompilerGenerated]
		static readonly IntPtr selMouseExited_ = Selector.GetHandle ("mouseExited:");
		[CompilerGenerated]
		static readonly IntPtr selKeyDown_ = Selector.GetHandle ("keyDown:");
		[CompilerGenerated]
		static readonly IntPtr selKeyUp_ = Selector.GetHandle ("keyUp:");
		[CompilerGenerated]
		static readonly IntPtr selFlagsChanged_ = Selector.GetHandle ("flagsChanged:");
		[CompilerGenerated]
		static readonly IntPtr selTabletPoint_ = Selector.GetHandle ("tabletPoint:");
		[CompilerGenerated]
		static readonly IntPtr selTabletProximity_ = Selector.GetHandle ("tabletProximity:");
		[CompilerGenerated]
		static readonly IntPtr selCursorUpdate_ = Selector.GetHandle ("cursorUpdate:");
		[CompilerGenerated]
		static readonly IntPtr selMagnifyWithEvent_ = Selector.GetHandle ("magnifyWithEvent:");
		[CompilerGenerated]
		static readonly IntPtr selRotateWithEvent_ = Selector.GetHandle ("rotateWithEvent:");
		[CompilerGenerated]
		static readonly IntPtr selSwipeWithEvent_ = Selector.GetHandle ("swipeWithEvent:");
		[CompilerGenerated]
		static readonly IntPtr selBeginGestureWithEvent_ = Selector.GetHandle ("beginGestureWithEvent:");
		[CompilerGenerated]
		static readonly IntPtr selEndGestureWithEvent_ = Selector.GetHandle ("endGestureWithEvent:");
		[CompilerGenerated]
		static readonly IntPtr selTouchesBeganWithEvent_ = Selector.GetHandle ("touchesBeganWithEvent:");
		[CompilerGenerated]
		static readonly IntPtr selTouchesMovedWithEvent_ = Selector.GetHandle ("touchesMovedWithEvent:");
		[CompilerGenerated]
		static readonly IntPtr selTouchesEndedWithEvent_ = Selector.GetHandle ("touchesEndedWithEvent:");
		[CompilerGenerated]
		static readonly IntPtr selTouchesCancelledWithEvent_ = Selector.GetHandle ("touchesCancelledWithEvent:");
		[CompilerGenerated]
		static readonly IntPtr selNoResponderFor_ = Selector.GetHandle ("noResponderFor:");
		[CompilerGenerated]
		static readonly IntPtr selAcceptsFirstResponder = Selector.GetHandle ("acceptsFirstResponder");
		[CompilerGenerated]
		static readonly IntPtr selBecomeFirstResponder = Selector.GetHandle ("becomeFirstResponder");
		[CompilerGenerated]
		static readonly IntPtr selResignFirstResponder = Selector.GetHandle ("resignFirstResponder");
		[CompilerGenerated]
		static readonly IntPtr selInterpretKeyEvents_ = Selector.GetHandle ("interpretKeyEvents:");
		[CompilerGenerated]
		static readonly IntPtr selFlushBufferedKeyEvents = Selector.GetHandle ("flushBufferedKeyEvents");
		[CompilerGenerated]
		static readonly IntPtr selShowContextHelp_ = Selector.GetHandle ("showContextHelp:");
		[CompilerGenerated]
		static readonly IntPtr selHelpRequested_ = Selector.GetHandle ("helpRequested:");
		[CompilerGenerated]
		static readonly IntPtr selShouldBeTreatedAsInkEvent_ = Selector.GetHandle ("shouldBeTreatedAsInkEvent:");
		[CompilerGenerated]
		static readonly IntPtr selEncodeRestorableStateWithCoder_ = Selector.GetHandle ("encodeRestorableStateWithCoder:");
		[CompilerGenerated]
		static readonly IntPtr selRestoreStateWithCoder_ = Selector.GetHandle ("restoreStateWithCoder:");
		[CompilerGenerated]
		static readonly IntPtr selInvalidateRestorableState = Selector.GetHandle ("invalidateRestorableState");
		[CompilerGenerated]
		static readonly IntPtr selRestorableStateKeyPaths = Selector.GetHandle ("restorableStateKeyPaths");
		[CompilerGenerated]
		static readonly IntPtr selWantsForwardedScrollEventsForAxis_ = Selector.GetHandle ("wantsForwardedScrollEventsForAxis:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("NSResponder");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[EditorBrowsable (EditorBrowsableState.Advanced)]

		[Export ("init")]
		public  NSResponder () : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				Handle = RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.Init);
			} else {
				Handle = RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.Init);
			}
		}
    /*
		[EditorBrowsable (EditorBrowsableState.Advanced)]

		[Export ("initWithCoder:")]
		public NSResponder (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				Handle = RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle);
			} else {
				Handle = RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle);
			}
		}
*/
		[EditorBrowsable (EditorBrowsableState.Advanced)]

		public NSResponder (NSObjectFlag t) : base (t) {}

		[EditorBrowsable (EditorBrowsableState.Advanced)]

		public NSResponder (IntPtr handle) : base (handle) {}

		[Export ("tryToPerform:with:")]
		public virtual bool TryToPerformwith (Selector anAction, NSObject anObject)
		{
			if (anAction == null)
				throw new ArgumentNullException ("anAction");
			if (anObject == null)
				throw new ArgumentNullException ("anObject");
			if (IsDirectBinding) {
				return RhinoMac.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, selTryToPerformWith_, anAction.Handle, anObject.Handle);
			} else {
				return RhinoMac.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selTryToPerformWith_, anAction.Handle, anObject.Handle);
			}
		}
		/*
		[Export ("performKeyEquivalent:")]
		public virtual bool PerformKeyEquivalent (NSEvent theEvent)
		{
			if (theEvent == null)
				throw new ArgumentNullException ("theEvent");
			if (IsDirectBinding) {
				return RhinoMac.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selPerformKeyEquivalent_, theEvent.Handle);
			} else {
				return RhinoMac.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selPerformKeyEquivalent_, theEvent.Handle);
			}
		}
		*/
		[Export ("validRequestorForSendType:returnType:")]
		public virtual NSObject ValidRequestorForSendTypereturnType (string sendType, string returnType)
		{
			if (sendType == null)
				throw new ArgumentNullException ("sendType");
			if (returnType == null)
				throw new ArgumentNullException ("returnType");
			var nssendType = NSString.CreateNative (sendType);
			var nsreturnType = NSString.CreateNative (returnType);
			
			NSObject ret;
			if (IsDirectBinding) {
				ret = (NSObject) Runtime.GetNSObject (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selValidRequestorForSendTypeReturnType_, nssendType, nsreturnType));
			} else {
				ret = (NSObject) Runtime.GetNSObject (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selValidRequestorForSendTypeReturnType_, nssendType, nsreturnType));
			}
			NSString.ReleaseNative (nssendType);
			NSString.ReleaseNative (nsreturnType);
			
			return ret;
		}
		/*
		[Export ("mouseDown:")]
		public virtual void MouseDown (NSEvent theEvent)
		{
			if (theEvent == null)
				throw new ArgumentNullException ("theEvent");
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selMouseDown_, theEvent.Handle);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selMouseDown_, theEvent.Handle);
			}
		}
		
		[Export ("rightMouseDown:")]
		public virtual void RightMouseDown (NSEvent theEvent)
		{
			if (theEvent == null)
				throw new ArgumentNullException ("theEvent");
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selRightMouseDown_, theEvent.Handle);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selRightMouseDown_, theEvent.Handle);
			}
		}
		
		[Export ("otherMouseDown:")]
		public virtual void OtherMouseDown (NSEvent theEvent)
		{
			if (theEvent == null)
				throw new ArgumentNullException ("theEvent");
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selOtherMouseDown_, theEvent.Handle);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selOtherMouseDown_, theEvent.Handle);
			}
		}
		
		[Export ("mouseUp:")]
		public virtual void MouseUp (NSEvent theEvent)
		{
			if (theEvent == null)
				throw new ArgumentNullException ("theEvent");
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selMouseUp_, theEvent.Handle);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selMouseUp_, theEvent.Handle);
			}
		}
		
		[Export ("rightMouseUp:")]
		public virtual void RightMouseUp (NSEvent theEvent)
		{
			if (theEvent == null)
				throw new ArgumentNullException ("theEvent");
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selRightMouseUp_, theEvent.Handle);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selRightMouseUp_, theEvent.Handle);
			}
		}
		
		[Export ("otherMouseUp:")]
		public virtual void OtherMouseUp (NSEvent theEvent)
		{
			if (theEvent == null)
				throw new ArgumentNullException ("theEvent");
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selOtherMouseUp_, theEvent.Handle);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selOtherMouseUp_, theEvent.Handle);
			}
		}
		
		[Export ("mouseMoved:")]
		public virtual void MouseMoved (NSEvent theEvent)
		{
			if (theEvent == null)
				throw new ArgumentNullException ("theEvent");
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selMouseMoved_, theEvent.Handle);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selMouseMoved_, theEvent.Handle);
			}
		}
		
		[Export ("mouseDragged:")]
		public virtual void MouseDragged (NSEvent theEvent)
		{
			if (theEvent == null)
				throw new ArgumentNullException ("theEvent");
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selMouseDragged_, theEvent.Handle);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selMouseDragged_, theEvent.Handle);
			}
		}
		
		[Export ("scrollWheel:")]
		public virtual void ScrollWheel (NSEvent theEvent)
		{
			if (theEvent == null)
				throw new ArgumentNullException ("theEvent");
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selScrollWheel_, theEvent.Handle);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selScrollWheel_, theEvent.Handle);
			}
		}
		
		[Export ("rightMouseDragged:")]
		public virtual void RightMouseDragged (NSEvent theEvent)
		{
			if (theEvent == null)
				throw new ArgumentNullException ("theEvent");
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selRightMouseDragged_, theEvent.Handle);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selRightMouseDragged_, theEvent.Handle);
			}
		}
		
		[Export ("otherMouseDragged:")]
		public virtual void OtherMouseDragged (NSEvent theEvent)
		{
			if (theEvent == null)
				throw new ArgumentNullException ("theEvent");
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selOtherMouseDragged_, theEvent.Handle);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selOtherMouseDragged_, theEvent.Handle);
			}
		}
		
		[Export ("mouseEntered:")]
		public virtual void MouseEntered (NSEvent theEvent)
		{
			if (theEvent == null)
				throw new ArgumentNullException ("theEvent");
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selMouseEntered_, theEvent.Handle);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selMouseEntered_, theEvent.Handle);
			}
		}
		
		[Export ("mouseExited:")]
		public virtual void MouseExited (NSEvent theEvent)
		{
			if (theEvent == null)
				throw new ArgumentNullException ("theEvent");
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selMouseExited_, theEvent.Handle);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selMouseExited_, theEvent.Handle);
			}
		}
		
		[Export ("keyDown:")]
		public virtual void KeyDown (NSEvent theEvent)
		{
			if (theEvent == null)
				throw new ArgumentNullException ("theEvent");
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selKeyDown_, theEvent.Handle);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selKeyDown_, theEvent.Handle);
			}
		}
		
		[Export ("keyUp:")]
		public virtual void KeyUp (NSEvent theEvent)
		{
			if (theEvent == null)
				throw new ArgumentNullException ("theEvent");
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selKeyUp_, theEvent.Handle);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selKeyUp_, theEvent.Handle);
			}
		}
		
		[Export ("flagsChanged:")]
		public virtual void FlagsChanged (NSEvent theEvent)
		{
			if (theEvent == null)
				throw new ArgumentNullException ("theEvent");
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selFlagsChanged_, theEvent.Handle);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selFlagsChanged_, theEvent.Handle);
			}
		}
		
		[Export ("tabletPoint:")]
		public virtual void TabletPoint (NSEvent theEvent)
		{
			if (theEvent == null)
				throw new ArgumentNullException ("theEvent");
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selTabletPoint_, theEvent.Handle);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selTabletPoint_, theEvent.Handle);
			}
		}
		
		[Export ("tabletProximity:")]
		public virtual void TabletProximity (NSEvent theEvent)
		{
			if (theEvent == null)
				throw new ArgumentNullException ("theEvent");
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selTabletProximity_, theEvent.Handle);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selTabletProximity_, theEvent.Handle);
			}
		}
		
		[Export ("cursorUpdate:")]
		public virtual void CursorUpdate (NSEvent theEvent)
		{
			if (theEvent == null)
				throw new ArgumentNullException ("theEvent");
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selCursorUpdate_, theEvent.Handle);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selCursorUpdate_, theEvent.Handle);
			}
		}
		
		[Export ("magnifyWithEvent:")]
		public virtual void MagnifyWithEvent (NSEvent theEvent)
		{
			if (theEvent == null)
				throw new ArgumentNullException ("theEvent");
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selMagnifyWithEvent_, theEvent.Handle);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selMagnifyWithEvent_, theEvent.Handle);
			}
		}
		
		[Export ("rotateWithEvent:")]
		public virtual void RotateWithEvent (NSEvent theEvent)
		{
			if (theEvent == null)
				throw new ArgumentNullException ("theEvent");
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selRotateWithEvent_, theEvent.Handle);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selRotateWithEvent_, theEvent.Handle);
			}
		}
		
		[Export ("swipeWithEvent:")]
		public virtual void SwipeWithEvent (NSEvent theEvent)
		{
			if (theEvent == null)
				throw new ArgumentNullException ("theEvent");
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSwipeWithEvent_, theEvent.Handle);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSwipeWithEvent_, theEvent.Handle);
			}
		}
		
		[Export ("beginGestureWithEvent:")]
		public virtual void BeginGestureWithEvent (NSEvent theEvent)
		{
			if (theEvent == null)
				throw new ArgumentNullException ("theEvent");
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selBeginGestureWithEvent_, theEvent.Handle);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selBeginGestureWithEvent_, theEvent.Handle);
			}
		}
		
		[Export ("endGestureWithEvent:")]
		public virtual void EndGestureWithEvent (NSEvent theEvent)
		{
			if (theEvent == null)
				throw new ArgumentNullException ("theEvent");
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selEndGestureWithEvent_, theEvent.Handle);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selEndGestureWithEvent_, theEvent.Handle);
			}
		}
		
		[Export ("touchesBeganWithEvent:")]
		public virtual void TouchesBeganWithEvent (NSEvent theEvent)
		{
			if (theEvent == null)
				throw new ArgumentNullException ("theEvent");
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selTouchesBeganWithEvent_, theEvent.Handle);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selTouchesBeganWithEvent_, theEvent.Handle);
			}
		}
		
		[Export ("touchesMovedWithEvent:")]
		public virtual void TouchesMovedWithEvent (NSEvent theEvent)
		{
			if (theEvent == null)
				throw new ArgumentNullException ("theEvent");
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selTouchesMovedWithEvent_, theEvent.Handle);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selTouchesMovedWithEvent_, theEvent.Handle);
			}
		}
		
		[Export ("touchesEndedWithEvent:")]
		public virtual void TouchesEndedWithEvent (NSEvent theEvent)
		{
			if (theEvent == null)
				throw new ArgumentNullException ("theEvent");
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selTouchesEndedWithEvent_, theEvent.Handle);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selTouchesEndedWithEvent_, theEvent.Handle);
			}
		}
		
		[Export ("touchesCancelledWithEvent:")]
		public virtual void TouchesCancelledWithEvent (NSEvent theEvent)
		{
			if (theEvent == null)
				throw new ArgumentNullException ("theEvent");
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selTouchesCancelledWithEvent_, theEvent.Handle);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selTouchesCancelledWithEvent_, theEvent.Handle);
			}
		}
		*/
		[Export ("noResponderFor:")]
		public virtual void NoResponderFor (Selector eventSelector)
		{
			if (eventSelector == null)
				throw new ArgumentNullException ("eventSelector");
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selNoResponderFor_, eventSelector.Handle);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selNoResponderFor_, eventSelector.Handle);
			}
		}
		
		[Export ("acceptsFirstResponder")]
		public virtual bool AcceptsFirstResponder ()
		{
			if (IsDirectBinding) {
				return RhinoMac.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAcceptsFirstResponder);
			} else {
				return RhinoMac.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selAcceptsFirstResponder);
			}
		}
		
		[Export ("becomeFirstResponder")]
		public virtual bool BecomeFirstResponder ()
		{
			if (IsDirectBinding) {
				return RhinoMac.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selBecomeFirstResponder);
			} else {
				return RhinoMac.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selBecomeFirstResponder);
			}
		}
		
		[Export ("resignFirstResponder")]
		public virtual bool ResignFirstResponder ()
		{
			if (IsDirectBinding) {
				return RhinoMac.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selResignFirstResponder);
			} else {
				return RhinoMac.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selResignFirstResponder);
			}
		}
		/*
		[Export ("interpretKeyEvents:")]
		public virtual void InterpretKeyEvents (NSEvent[] eventArray)
		{
			if (eventArray == null)
				throw new ArgumentNullException ("eventArray");
			var nsa_eventArray = NSArray.FromNSObjects (eventArray);
			
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selInterpretKeyEvents_, nsa_eventArray.Handle);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selInterpretKeyEvents_, nsa_eventArray.Handle);
			}
			nsa_eventArray.Dispose ();
			
		}
		*/
		[Export ("flushBufferedKeyEvents")]
		public virtual void FlushBufferedKeyEvents ()
		{
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selFlushBufferedKeyEvents);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selFlushBufferedKeyEvents);
			}
		}
		
		[Export ("showContextHelp:")]
		public virtual void ShowContextHelp (NSObject sender)
		{
			if (sender == null)
				throw new ArgumentNullException ("sender");
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selShowContextHelp_, sender.Handle);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selShowContextHelp_, sender.Handle);
			}
		}
		/*
		[Export ("helpRequested:")]
		public virtual void HelpRequested (NSEvent theEventPtr)
		{
			if (theEventPtr == null)
				throw new ArgumentNullException ("theEventPtr");
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selHelpRequested_, theEventPtr.Handle);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selHelpRequested_, theEventPtr.Handle);
			}
		}
		
		[Export ("shouldBeTreatedAsInkEvent:")]
		public virtual bool ShouldBeTreatedAsInkEvent (NSEvent theEvent)
		{
			if (theEvent == null)
				throw new ArgumentNullException ("theEvent");
			if (IsDirectBinding) {
				return RhinoMac.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selShouldBeTreatedAsInkEvent_, theEvent.Handle);
			} else {
				return RhinoMac.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selShouldBeTreatedAsInkEvent_, theEvent.Handle);
			}
		}
		
		[Export ("encodeRestorableStateWithCoder:")]
		public virtual void EncodeRestorableState (NSCoder coder)
		{
			if (coder == null)
				throw new ArgumentNullException ("coder");
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selEncodeRestorableStateWithCoder_, coder.Handle);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selEncodeRestorableStateWithCoder_, coder.Handle);
			}
		}
		
		[Export ("restoreStateWithCoder:")]
		public virtual void RestoreState (NSCoder coder)
		{
			if (coder == null)
				throw new ArgumentNullException ("coder");
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selRestoreStateWithCoder_, coder.Handle);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selRestoreStateWithCoder_, coder.Handle);
			}
		}
		*/
		[Export ("invalidateRestorableState")]
		public virtual void InvalidateRestorableState ()
		{
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selInvalidateRestorableState);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selInvalidateRestorableState);
			}
		}
		/*
		[Export ("restorableStateKeyPaths")]
		public static global::System.String[] RestorableStateKeyPaths ()
		{
			return NSArray.StringArrayFromHandle (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selRestorableStateKeyPaths));
		}
		*/
		[Export ("wantsForwardedScrollEventsForAxis:")]
		public virtual bool WantsForwardedScrollEventsForAxis (NSEventGestureAxis axis)
		{
			if (IsDirectBinding) {
				return RhinoMac.ObjCRuntime.Messaging.bool_objc_msgSend_int (this.Handle, selWantsForwardedScrollEventsForAxis_, (int)axis);
			} else {
				return RhinoMac.ObjCRuntime.Messaging.bool_objc_msgSendSuper_int (this.SuperHandle, selWantsForwardedScrollEventsForAxis_, (int)axis);
			}
		}
		
		[CompilerGenerated]
		object __mt_NextResponder_var;
		public virtual NSResponder NextResponder {
			[Export ("nextResponder")]
			get {
				NSResponder ret;
				if (IsDirectBinding) {
					ret = (NSResponder) Runtime.GetNSObject (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selNextResponder));
				} else {
					ret = (NSResponder) Runtime.GetNSObject (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selNextResponder));
				}
				__mt_NextResponder_var = ret;
				return ret;
			}
			
			[Export ("setNextResponder:")]
			set {
				if (IsDirectBinding) {
					RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetNextResponder_, value == null ? IntPtr.Zero : value.Handle);
				} else {
					RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetNextResponder_, value == null ? IntPtr.Zero : value.Handle);
				}
				__mt_NextResponder_var = value;
			}
		}
		/*
		[CompilerGenerated]
		object __mt_Menu_var;
		public virtual NSMenu Menu {
			[Export ("menu")]
			get {
				NSMenu ret;
				if (IsDirectBinding) {
					ret = (NSMenu) Runtime.GetNSObject (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selMenu));
				} else {
					ret = (NSMenu) Runtime.GetNSObject (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selMenu));
				}
				__mt_Menu_var = ret;
				return ret;
			}
			
			[Export ("setMenu:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetMenu_, value.Handle);
				} else {
					RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetMenu_, value.Handle);
				}
				__mt_Menu_var = value;
			}
		}
		*/
		protected override void Dispose (bool disposing)
		{
			__mt_NextResponder_var = null;
			//__mt_Menu_var = null;
			base.Dispose (disposing);
		}
	} /* class NSResponder */
}
