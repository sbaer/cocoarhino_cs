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
	[Register("NSWindowController", true)]
	public unsafe partial class NSWindowController : NSResponder {
		[CompilerGenerated]
		static readonly IntPtr selWindowNibName = Selector.GetHandle ("windowNibName");
		[CompilerGenerated]
		static readonly IntPtr selWindowNibPath = Selector.GetHandle ("windowNibPath");
		[CompilerGenerated]
		static readonly IntPtr selOwner = Selector.GetHandle ("owner");
		[CompilerGenerated]
		static readonly IntPtr selWindowFrameAutosaveName = Selector.GetHandle ("windowFrameAutosaveName");
		[CompilerGenerated]
		static readonly IntPtr selSetWindowFrameAutosaveName_ = Selector.GetHandle ("setWindowFrameAutosaveName:");
		[CompilerGenerated]
		static readonly IntPtr selShouldCascadeWindows = Selector.GetHandle ("shouldCascadeWindows");
		[CompilerGenerated]
		static readonly IntPtr selSetShouldCascadeWindows_ = Selector.GetHandle ("setShouldCascadeWindows:");
		[CompilerGenerated]
		static readonly IntPtr selDocument = Selector.GetHandle ("document");
		[CompilerGenerated]
		static readonly IntPtr selSetDocument_ = Selector.GetHandle ("setDocument:");
		[CompilerGenerated]
		static readonly IntPtr selShouldCloseDocument = Selector.GetHandle ("shouldCloseDocument");
		[CompilerGenerated]
		static readonly IntPtr selSetShouldCloseDocument_ = Selector.GetHandle ("setShouldCloseDocument:");
		[CompilerGenerated]
		static readonly IntPtr selWindow = Selector.GetHandle ("window");
		[CompilerGenerated]
		static readonly IntPtr selSetWindow_ = Selector.GetHandle ("setWindow:");
		[CompilerGenerated]
		static readonly IntPtr selIsWindowLoaded = Selector.GetHandle ("isWindowLoaded");
		[CompilerGenerated]
		static readonly IntPtr selSetIsWindowLoaded_ = Selector.GetHandle ("setIsWindowLoaded:");
		[CompilerGenerated]
		static readonly IntPtr selInitWithWindow_ = Selector.GetHandle ("initWithWindow:");
		[CompilerGenerated]
		static readonly IntPtr selInitWithWindowNibName_ = Selector.GetHandle ("initWithWindowNibName:");
		[CompilerGenerated]
		static readonly IntPtr selInitWithWindowNibNameOwner_ = Selector.GetHandle ("initWithWindowNibName:owner:");
		[CompilerGenerated]
		static readonly IntPtr selSetDocumentEdited_ = Selector.GetHandle ("setDocumentEdited:");
		[CompilerGenerated]
		static readonly IntPtr selSynchronizeWindowTitleWithDocumentName = Selector.GetHandle ("synchronizeWindowTitleWithDocumentName");
		[CompilerGenerated]
		static readonly IntPtr selWindowTitleForDocumentDisplayName_ = Selector.GetHandle ("windowTitleForDocumentDisplayName:");
		[CompilerGenerated]
		static readonly IntPtr selClose = Selector.GetHandle ("close");
		[CompilerGenerated]
		static readonly IntPtr selShowWindow_ = Selector.GetHandle ("showWindow:");
		[CompilerGenerated]
		static readonly IntPtr selWindowWillLoad = Selector.GetHandle ("windowWillLoad");
		[CompilerGenerated]
		static readonly IntPtr selWindowDidLoad = Selector.GetHandle ("windowDidLoad");
		[CompilerGenerated]
		static readonly IntPtr selLoadWindow = Selector.GetHandle ("loadWindow");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("NSWindowController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[EditorBrowsable (EditorBrowsableState.Advanced)]

		[Export ("init")]
		public  NSWindowController () : base (NSObjectFlag.Empty)
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
		public NSWindowController (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				Handle = RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle);
			} else {
				Handle = RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle);
			}
		}
*/
		[EditorBrowsable (EditorBrowsableState.Advanced)]

		public NSWindowController (NSObjectFlag t) : base (t) {}

		[EditorBrowsable (EditorBrowsableState.Advanced)]

		public NSWindowController (IntPtr handle) : base (handle) {}

		[Export ("initWithWindow:")]
		public NSWindowController (NSWindow window)
			: base (NSObjectFlag.Empty)
		{
			if (window == null)
				throw new ArgumentNullException ("window");
			if (IsDirectBinding) {
				Handle = RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithWindow_, window.Handle);
			} else {
				Handle = RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithWindow_, window.Handle);
			}
		}
		
		[Export ("initWithWindowNibName:")]
		public NSWindowController (string windowNibName)
			: base (NSObjectFlag.Empty)
		{
			if (windowNibName == null)
				throw new ArgumentNullException ("windowNibName");
			var nswindowNibName = NSString.CreateNative (windowNibName);
			
			if (IsDirectBinding) {
				Handle = RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithWindowNibName_, nswindowNibName);
			} else {
				Handle = RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithWindowNibName_, nswindowNibName);
			}
			NSString.ReleaseNative (nswindowNibName);
			
		}
		
		[Export ("initWithWindowNibName:owner:")]
		public NSWindowController (string windowNibName, NSObject owner)
			: base (NSObjectFlag.Empty)
		{
			if (windowNibName == null)
				throw new ArgumentNullException ("windowNibName");
			if (owner == null)
				throw new ArgumentNullException ("owner");
			var nswindowNibName = NSString.CreateNative (windowNibName);
			
			if (IsDirectBinding) {
				Handle = RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithWindowNibNameOwner_, nswindowNibName, owner.Handle);
			} else {
				Handle = RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithWindowNibNameOwner_, nswindowNibName, owner.Handle);
			}
			NSString.ReleaseNative (nswindowNibName);
			
		}
		
		[Export ("setDocumentEdited:")]
		public virtual void SetDocumentEdited (bool dirtyFlag)
		{
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetDocumentEdited_, dirtyFlag);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetDocumentEdited_, dirtyFlag);
			}
		}
		
		[Export ("synchronizeWindowTitleWithDocumentName")]
		public virtual void SynchronizeWindowTitleWithDocumentName ()
		{
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selSynchronizeWindowTitleWithDocumentName);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selSynchronizeWindowTitleWithDocumentName);
			}
		}
		
		[Export ("windowTitleForDocumentDisplayName:")]
		public virtual string WindowTitleForDocumentDisplayName (string displayName)
		{
			if (displayName == null)
				throw new ArgumentNullException ("displayName");
			var nsdisplayName = NSString.CreateNative (displayName);
			
			string ret;
			if (IsDirectBinding) {
				ret = NSString.FromHandle (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selWindowTitleForDocumentDisplayName_, nsdisplayName));
			} else {
				ret = NSString.FromHandle (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selWindowTitleForDocumentDisplayName_, nsdisplayName));
			}
			NSString.ReleaseNative (nsdisplayName);
			
			return ret;
		}
		
		[Export ("close")]
		public virtual void Close ()
		{
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selClose);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selClose);
			}
		}
		
		[Export ("showWindow:")]
		public virtual void ShowWindow (NSObject sender)
		{
			if (sender == null)
				throw new ArgumentNullException ("sender");
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selShowWindow_, sender.Handle);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selShowWindow_, sender.Handle);
			}
		}
		
		[Export ("windowWillLoad")]
		public virtual void WindowWillLoad ()
		{
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selWindowWillLoad);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selWindowWillLoad);
			}
		}
		
		[Export ("windowDidLoad")]
		public virtual void WindowDidLoad ()
		{
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selWindowDidLoad);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selWindowDidLoad);
			}
		}
		
		[Export ("loadWindow")]
		public virtual void LoadWindow ()
		{
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selLoadWindow);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selLoadWindow);
			}
		}
		
		public virtual string WindowNibName {
			[Export ("windowNibName")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selWindowNibName));
				} else {
					return NSString.FromHandle (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selWindowNibName));
				}
			}
			
		}
		
		public virtual string WindowNibPath {
			[Export ("windowNibPath")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selWindowNibPath));
				} else {
					return NSString.FromHandle (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selWindowNibPath));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Owner_var;
		public virtual NSObject Owner {
			[Export ("owner")]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = (NSObject) Runtime.GetNSObject (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selOwner));
				} else {
					ret = (NSObject) Runtime.GetNSObject (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selOwner));
				}
				__mt_Owner_var = ret;
				return ret;
			}
			
		}
		
		public virtual string WindowFrameAutosaveName {
			[Export ("windowFrameAutosaveName")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selWindowFrameAutosaveName));
				} else {
					return NSString.FromHandle (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selWindowFrameAutosaveName));
				}
			}
			
			[Export ("setWindowFrameAutosaveName:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetWindowFrameAutosaveName_, nsvalue);
				} else {
					RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetWindowFrameAutosaveName_, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		public virtual bool ShouldCascadeWindows {
			[Export ("shouldCascadeWindows")]
			get {
				if (IsDirectBinding) {
					return RhinoMac.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShouldCascadeWindows);
				} else {
					return RhinoMac.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selShouldCascadeWindows);
				}
			}
			
			[Export ("setShouldCascadeWindows:")]
			set {
				if (IsDirectBinding) {
					RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShouldCascadeWindows_, value);
				} else {
					RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetShouldCascadeWindows_, value);
				}
			}
		}
		/*
		[CompilerGenerated]
		object __mt_Document_var;
		public virtual NSDocument Document {
			[Export ("document")]
			get {
				NSDocument ret;
				if (IsDirectBinding) {
					ret = (NSDocument) Runtime.GetNSObject (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDocument));
				} else {
					ret = (NSDocument) Runtime.GetNSObject (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDocument));
				}
				__mt_Document_var = ret;
				return ret;
			}
			
			[Export ("setDocument:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDocument_, value.Handle);
				} else {
					RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDocument_, value.Handle);
				}
				__mt_Document_var = value;
			}
		}
		*/
		public virtual bool ShouldCloseDocument {
			[Export ("shouldCloseDocument")]
			get {
				if (IsDirectBinding) {
					return RhinoMac.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShouldCloseDocument);
				} else {
					return RhinoMac.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selShouldCloseDocument);
				}
			}
			
			[Export ("setShouldCloseDocument:")]
			set {
				if (IsDirectBinding) {
					RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShouldCloseDocument_, value);
				} else {
					RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetShouldCloseDocument_, value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_Window_var;
		public virtual NSWindow Window {
			[Export ("window")]
			get {
				NSWindow ret;
				if (IsDirectBinding) {
					ret = (NSWindow) Runtime.GetNSObject (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selWindow));
				} else {
					ret = (NSWindow) Runtime.GetNSObject (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selWindow));
				}
				__mt_Window_var = ret;
				return ret;
			}
			
			[Export ("setWindow:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetWindow_, value.Handle);
				} else {
					RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetWindow_, value.Handle);
				}
				__mt_Window_var = value;
			}
		}
		
		public virtual bool IsWindowLoaded {
			[Export ("isWindowLoaded")]
			get {
				if (IsDirectBinding) {
					return RhinoMac.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsWindowLoaded);
				} else {
					return RhinoMac.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsWindowLoaded);
				}
			}
			
			[Export ("setIsWindowLoaded:")]
			set {
				if (IsDirectBinding) {
					RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetIsWindowLoaded_, value);
				} else {
					RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetIsWindowLoaded_, value);
				}
			}
		}
		
		protected override void Dispose (bool disposing)
		{
			__mt_Owner_var = null;
			//__mt_Document_var = null;
			__mt_Window_var = null;
			base.Dispose (disposing);
		}
	} /* class NSWindowController */
}
