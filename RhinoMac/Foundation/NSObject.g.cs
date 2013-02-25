using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.ComponentModel;
using RhinoMac.Foundation;
using RhinoMac.ObjCRuntime;

namespace RhinoMac.Foundation {
	public unsafe partial class NSObject  {
		[CompilerGenerated]
		static readonly IntPtr selDescription = Selector.GetHandle ("description");
		[CompilerGenerated]
		static readonly IntPtr selDebugDescription = Selector.GetHandle ("debugDescription");
		[CompilerGenerated]
		static readonly IntPtr selRemoveObserverForKeyPath_ = Selector.GetHandle ("removeObserver:forKeyPath:");
		[CompilerGenerated]
		static readonly IntPtr selWillChangeValueForKey_ = Selector.GetHandle ("willChangeValueForKey:");
		[CompilerGenerated]
		static readonly IntPtr selDidChangeValueForKey_ = Selector.GetHandle ("didChangeValueForKey:");
		[CompilerGenerated]
		static readonly IntPtr selAutomaticallyNotifiesObserversForKey_ = Selector.GetHandle ("automaticallyNotifiesObserversForKey:");
		[CompilerGenerated]
		static readonly IntPtr selValueForKey_ = Selector.GetHandle ("valueForKey:");
		[CompilerGenerated]
		static readonly IntPtr selSetValueForKey_ = Selector.GetHandle ("setValue:forKey:");
		[CompilerGenerated]
		static readonly IntPtr selValueForKeyPath_ = Selector.GetHandle ("valueForKeyPath:");
		[CompilerGenerated]
		static readonly IntPtr selSetValueForKeyPath_ = Selector.GetHandle ("setValue:forKeyPath:");
		[CompilerGenerated]
		static readonly IntPtr selValueForUndefinedKey_ = Selector.GetHandle ("valueForUndefinedKey:");
		[CompilerGenerated]
		static readonly IntPtr selSetValueForUndefinedKey_ = Selector.GetHandle ("setValue:forUndefinedKey:");
		[CompilerGenerated]
		static readonly IntPtr selSetNilValueForKey_ = Selector.GetHandle ("setNilValueForKey:");
		[CompilerGenerated]
		static readonly IntPtr selValueClassForBinding_ = Selector.GetHandle ("valueClassForBinding:");
		[CompilerGenerated]
		static readonly IntPtr selUnbind_ = Selector.GetHandle ("unbind:");
		[CompilerGenerated]
		static readonly IntPtr selDefaultPlaceholderForMarkerWithBinding_ = Selector.GetHandle ("defaultPlaceholderForMarker:withBinding:");
		[CompilerGenerated]
		static readonly IntPtr selSetDefaultPlaceholderForMarkerWithBinding_ = Selector.GetHandle ("setDefaultPlaceholder:forMarker:withBinding:");
		[CompilerGenerated]
		static readonly IntPtr selObjectDidEndEditing_ = Selector.GetHandle ("objectDidEndEditing:");
		[CompilerGenerated]
		static readonly IntPtr selCommitEditing = Selector.GetHandle ("commitEditing");
		[CompilerGenerated]
		static readonly IntPtr selCommitEditingWithDelegateDidCommitSelectorContextInfo_ = Selector.GetHandle ("commitEditingWithDelegate:didCommitSelector:contextInfo:");
		[CompilerGenerated]
		static readonly IntPtr selCopy = Selector.GetHandle ("copy");
		[CompilerGenerated]
		static readonly IntPtr selMutableCopy = Selector.GetHandle ("mutableCopy");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("NSObject");
		
		public virtual IntPtr ClassHandle { get { return class_ptr; } }

    public virtual void RemoveObserver (NSObject observer, NSString keyPath)
		{
			if (observer == null)
				throw new ArgumentNullException ("observer");
			if (keyPath == null)
				throw new ArgumentNullException ("keyPath");
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selRemoveObserverForKeyPath_, observer.Handle, keyPath.Handle);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selRemoveObserverForKeyPath_, observer.Handle, keyPath.Handle);
			}
		}
		
		public virtual void WillChangeValue (string forKey)
		{
			if (forKey == null)
				throw new ArgumentNullException ("forKey");
			var nsforKey = NSString.CreateNative (forKey);
			
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selWillChangeValueForKey_, nsforKey);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selWillChangeValueForKey_, nsforKey);
			}
			NSString.ReleaseNative (nsforKey);
		}
		
		public virtual void DidChangeValue (string forKey)
		{
			if (forKey == null)
				throw new ArgumentNullException ("forKey");
			var nsforKey = NSString.CreateNative (forKey);
			
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selDidChangeValueForKey_, nsforKey);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selDidChangeValueForKey_, nsforKey);
			}
			NSString.ReleaseNative (nsforKey);
			
		}

    public static bool AutomaticallyNotifiesObserversForKey (string key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			bool ret;
			ret = RhinoMac.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (class_ptr, selAutomaticallyNotifiesObserversForKey_, nskey);
			NSString.ReleaseNative (nskey);
			
			return ret;
		}
		
		public virtual NSObject ValueForKey (NSString key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			if (IsDirectBinding) {
				return (NSObject) Runtime.GetNSObject (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selValueForKey_, key.Handle));
			} else {
				return (NSObject) Runtime.GetNSObject (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selValueForKey_, key.Handle));
			}
		}
		
		public virtual void SetValueForKey (NSObject value, NSString key)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			if (key == null)
				throw new ArgumentNullException ("key");
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selSetValueForKey_, value.Handle, key.Handle);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selSetValueForKey_, value.Handle, key.Handle);
			}
		}
		
		public virtual NSObject ValueForKeyPath (NSString keyPath)
		{
			if (keyPath == null)
				throw new ArgumentNullException ("keyPath");
			if (IsDirectBinding) {
				return (NSObject) Runtime.GetNSObject (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selValueForKeyPath_, keyPath.Handle));
			} else {
				return (NSObject) Runtime.GetNSObject (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selValueForKeyPath_, keyPath.Handle));
			}
		}
		
		public virtual void SetValueForKeyPath (NSObject value, NSString keyPath)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			if (keyPath == null)
				throw new ArgumentNullException ("keyPath");
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selSetValueForKeyPath_, value.Handle, keyPath.Handle);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selSetValueForKeyPath_, value.Handle, keyPath.Handle);
			}
		}
		
		public virtual NSObject ValueForUndefinedKey (NSString key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			if (IsDirectBinding) {
				return (NSObject) Runtime.GetNSObject (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selValueForUndefinedKey_, key.Handle));
			} else {
				return (NSObject) Runtime.GetNSObject (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selValueForUndefinedKey_, key.Handle));
			}
		}
		
		public virtual void SetValueForUndefinedKey (NSObject value, NSString undefinedKey)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			if (undefinedKey == null)
				throw new ArgumentNullException ("undefinedKey");
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selSetValueForUndefinedKey_, value.Handle, undefinedKey.Handle);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selSetValueForUndefinedKey_, value.Handle, undefinedKey.Handle);
			}
		}
		
		public virtual void SetNilValueForKey (NSString key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetNilValueForKey_, key.Handle);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetNilValueForKey_, key.Handle);
			}
		}

    public virtual Class BindingValueClass (string binding)
		{
			if (binding == null)
				throw new ArgumentNullException ("binding");
			var nsbinding = NSString.CreateNative (binding);
			
			Class ret;
			if (IsDirectBinding) {
				ret = new Class (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selValueClassForBinding_, nsbinding));
			} else {
				ret = new Class (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selValueClassForBinding_, nsbinding));
			}
			NSString.ReleaseNative (nsbinding);
			
			return ret;
		}

    public virtual void Unbind (string binding)
		{
			if (binding == null)
				throw new ArgumentNullException ("binding");
			var nsbinding = NSString.CreateNative (binding);
			
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selUnbind_, nsbinding);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selUnbind_, nsbinding);
			}
			NSString.ReleaseNative (nsbinding);
			
		}

    public static NSObject GetDefaultPlaceholder (NSObject marker, string binding)
		{
			if (marker == null)
				throw new ArgumentNullException ("marker");
			if (binding == null)
				throw new ArgumentNullException ("binding");
			var nsbinding = NSString.CreateNative (binding);
			
			NSObject ret;
			ret = (NSObject) Runtime.GetNSObject (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selDefaultPlaceholderForMarkerWithBinding_, marker.Handle, nsbinding));
			NSString.ReleaseNative (nsbinding);
			
			return ret;
		}
		
		public static NSObject SetDefaultPlaceholder (NSObject placeholder, NSObject marker, string binding)
		{
			if (placeholder == null)
				throw new ArgumentNullException ("placeholder");
			if (marker == null)
				throw new ArgumentNullException ("marker");
			if (binding == null)
				throw new ArgumentNullException ("binding");
			var nsbinding = NSString.CreateNative (binding);
			
			NSObject ret;
			ret = (NSObject) Runtime.GetNSObject (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selSetDefaultPlaceholderForMarkerWithBinding_, placeholder.Handle, marker.Handle, nsbinding));
			NSString.ReleaseNative (nsbinding);
			
			return ret;
		}
		
		public virtual void ObjectDidEndEditing (NSObject editor)
		{
			if (editor == null)
				throw new ArgumentNullException ("editor");
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selObjectDidEndEditing_, editor.Handle);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selObjectDidEndEditing_, editor.Handle);
			}
		}
		
		public virtual bool CommitEditing ()
		{
			if (IsDirectBinding) {
				return RhinoMac.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selCommitEditing);
			} else {
				return RhinoMac.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selCommitEditing);
			}
		}
		
		public virtual void CommitEditing (NSObject objDelegate, Selector didCommitSelector, global::System.IntPtr contextInfo)
		{
			if (objDelegate == null)
				throw new ArgumentNullException ("objDelegate");
			if (didCommitSelector == null)
				throw new ArgumentNullException ("didCommitSelector");
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, selCommitEditingWithDelegateDidCommitSelectorContextInfo_, objDelegate.Handle, didCommitSelector.Handle, contextInfo);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, selCommitEditingWithDelegateDidCommitSelectorContextInfo_, objDelegate.Handle, didCommitSelector.Handle, contextInfo);
			}
		}
		
		public virtual NSObject Copy ()
		{
			if (IsDirectBinding) {
				return (NSObject) Runtime.GetNSObject (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCopy));
			} else {
				return (NSObject) Runtime.GetNSObject (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selCopy));
			}
		}
		
		public virtual NSObject MutableCopy ()
		{
			if (IsDirectBinding) {
				return (NSObject) Runtime.GetNSObject (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selMutableCopy));
			} else {
				return (NSObject) Runtime.GetNSObject (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selMutableCopy));
			}
		}
		
		public virtual string Description {
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDescription));
				} else {
					return NSString.FromHandle (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDescription));
				}
			}
			
		}
		
		public virtual string DebugDescription {
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDebugDescription));
				} else {
					return NSString.FromHandle (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDebugDescription));
				}
			}
			
		}
		/*
		[CompilerGenerated]
		static readonly IntPtr Foundation_libraryHandle = Dlfcn.dlopen (Constants.FoundationLibrary, 0);
		[CompilerGenerated]
		static NSString _ChangeKindKey;
		public static NSString ChangeKindKey {
			get {
				if (_ChangeKindKey == null)
					_ChangeKindKey = Dlfcn.GetStringConstant (Foundation_libraryHandle, "NSKeyValueChangeKindKey");
				return _ChangeKindKey;
			}
		}
		[CompilerGenerated]
		static NSString _ChangeNewKey;
		public static NSString ChangeNewKey {
			get {
				if (_ChangeNewKey == null)
					_ChangeNewKey = Dlfcn.GetStringConstant (Foundation_libraryHandle, "NSKeyValueChangeNewKey");
				return _ChangeNewKey;
			}
		}
		[CompilerGenerated]
		static NSString _ChangeOldKey;
		public static NSString ChangeOldKey {
			get {
				if (_ChangeOldKey == null)
					_ChangeOldKey = Dlfcn.GetStringConstant (Foundation_libraryHandle, "NSKeyValueChangeOldKey");
				return _ChangeOldKey;
			}
		}
		[CompilerGenerated]
		static NSString _ChangeIndexesKey;
		public static NSString ChangeIndexesKey {
			get {
				if (_ChangeIndexesKey == null)
					_ChangeIndexesKey = Dlfcn.GetStringConstant (Foundation_libraryHandle, "NSKeyValueChangeIndexesKey");
				return _ChangeIndexesKey;
			}
		}
		[CompilerGenerated]
		static NSString _ChangeNotificationIsPriorKey;
		public static NSString ChangeNotificationIsPriorKey {
			get {
				if (_ChangeNotificationIsPriorKey == null)
					_ChangeNotificationIsPriorKey = Dlfcn.GetStringConstant (Foundation_libraryHandle, "NSKeyValueChangeNotificationIsPriorKey");
				return _ChangeNotificationIsPriorKey;
			}
		}
  */  
	} /* class NSObject */
}
