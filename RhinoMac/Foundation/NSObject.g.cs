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

namespace RhinoMac.Foundation {
	[Register("NSObject", true)]
	public unsafe partial class NSObject  {
		[CompilerGenerated]
		static readonly IntPtr selDescription = Selector.GetHandle ("description");
		[CompilerGenerated]
		static readonly IntPtr selDebugDescription = Selector.GetHandle ("debugDescription");
		[CompilerGenerated]
		static readonly IntPtr selObserveValueForKeyPathOfObjectChangeContext_ = Selector.GetHandle ("observeValueForKeyPath:ofObject:change:context:");
		[CompilerGenerated]
		static readonly IntPtr selAddObserverForKeyPathOptionsContext_ = Selector.GetHandle ("addObserver:forKeyPath:options:context:");
		[CompilerGenerated]
		static readonly IntPtr selRemoveObserverForKeyPath_ = Selector.GetHandle ("removeObserver:forKeyPath:");
		[CompilerGenerated]
		static readonly IntPtr selWillChangeValueForKey_ = Selector.GetHandle ("willChangeValueForKey:");
		[CompilerGenerated]
		static readonly IntPtr selDidChangeValueForKey_ = Selector.GetHandle ("didChangeValueForKey:");
		[CompilerGenerated]
		static readonly IntPtr selWillChangeValuesAtIndexesForKey_ = Selector.GetHandle ("willChange:valuesAtIndexes:forKey:");
		[CompilerGenerated]
		static readonly IntPtr selDidChangeValuesAtIndexesForKey_ = Selector.GetHandle ("didChange:valuesAtIndexes:forKey:");
		[CompilerGenerated]
		static readonly IntPtr selWillChangeValueForKeyWithSetMutationUsingObjects_ = Selector.GetHandle ("willChangeValueForKey:withSetMutation:usingObjects:");
		[CompilerGenerated]
		static readonly IntPtr selDidChangeValueForKeyWithSetMutationUsingObjects_ = Selector.GetHandle ("didChangeValueForKey:withSetMutation:usingObjects:");
		[CompilerGenerated]
		static readonly IntPtr selKeyPathsForValuesAffectingValueForKey_ = Selector.GetHandle ("keyPathsForValuesAffectingValueForKey:");
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
		static readonly IntPtr selDictionaryWithValuesForKeys_ = Selector.GetHandle ("dictionaryWithValuesForKeys:");
		[CompilerGenerated]
		static readonly IntPtr selSetValuesForKeysWithDictionary_ = Selector.GetHandle ("setValuesForKeysWithDictionary:");
		[CompilerGenerated]
		static readonly IntPtr selExposedBindings = Selector.GetHandle ("exposedBindings");
		[CompilerGenerated]
		static readonly IntPtr selValueClassForBinding_ = Selector.GetHandle ("valueClassForBinding:");
		[CompilerGenerated]
		static readonly IntPtr selBindToObjectWithKeyPathOptions_ = Selector.GetHandle ("bind:toObject:withKeyPath:options:");
		[CompilerGenerated]
		static readonly IntPtr selUnbind_ = Selector.GetHandle ("unbind:");
		[CompilerGenerated]
		static readonly IntPtr selInfoForBinding_ = Selector.GetHandle ("infoForBinding:");
		[CompilerGenerated]
		static readonly IntPtr selOptionDescriptionsForBinding_ = Selector.GetHandle ("optionDescriptionsForBinding:");
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
		/*
		[Export ("observeValueForKeyPath:ofObject:change:context:")]
		public virtual void ObserveValue (NSString keyPath, NSObject ofObject, NSDictionary change, global::System.IntPtr context)
		{
			if (keyPath == null)
				throw new ArgumentNullException ("keyPath");
			if (ofObject == null)
				throw new ArgumentNullException ("ofObject");
			if (change == null)
				throw new ArgumentNullException ("change");
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, selObserveValueForKeyPathOfObjectChangeContext_, keyPath.Handle, ofObject.Handle, change.Handle, context);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, selObserveValueForKeyPathOfObjectChangeContext_, keyPath.Handle, ofObject.Handle, change.Handle, context);
			}
		}
		
		[Export ("addObserver:forKeyPath:options:context:")]
		public virtual void AddObserver (NSObject observer, NSString keyPath, NSKeyValueObservingOptions options, global::System.IntPtr context)
		{
			if (observer == null)
				throw new ArgumentNullException ("observer");
			if (keyPath == null)
				throw new ArgumentNullException ("keyPath");
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_int_IntPtr (this.Handle, selAddObserverForKeyPathOptionsContext_, observer.Handle, keyPath.Handle, (int)options, context);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_int_IntPtr (this.SuperHandle, selAddObserverForKeyPathOptionsContext_, observer.Handle, keyPath.Handle, (int)options, context);
			}
		}
		*/
		[Export ("removeObserver:forKeyPath:")]
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
		
		[Export ("willChangeValueForKey:")]
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
		
		[Export ("didChangeValueForKey:")]
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
		/*
		[Export ("willChange:valuesAtIndexes:forKey:")]
		public virtual void WillChange (NSKeyValueChange changeKind, NSIndexSet indexes, NSString forKey)
		{
			if (indexes == null)
				throw new ArgumentNullException ("indexes");
			if (forKey == null)
				throw new ArgumentNullException ("forKey");
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_int_IntPtr_IntPtr (this.Handle, selWillChangeValuesAtIndexesForKey_, (int)changeKind, indexes.Handle, forKey.Handle);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_int_IntPtr_IntPtr (this.SuperHandle, selWillChangeValuesAtIndexesForKey_, (int)changeKind, indexes.Handle, forKey.Handle);
			}
		}
		
		[Export ("didChange:valuesAtIndexes:forKey:")]
		public virtual void DidChange (NSKeyValueChange changeKind, NSIndexSet indexes, NSString forKey)
		{
			if (indexes == null)
				throw new ArgumentNullException ("indexes");
			if (forKey == null)
				throw new ArgumentNullException ("forKey");
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_int_IntPtr_IntPtr (this.Handle, selDidChangeValuesAtIndexesForKey_, (int)changeKind, indexes.Handle, forKey.Handle);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_int_IntPtr_IntPtr (this.SuperHandle, selDidChangeValuesAtIndexesForKey_, (int)changeKind, indexes.Handle, forKey.Handle);
			}
		}
		
		[Export ("willChangeValueForKey:withSetMutation:usingObjects:")]
		public virtual void WillChange (NSString forKey, NSKeyValueSetMutationKind mutationKind, NSSet objects)
		{
			if (forKey == null)
				throw new ArgumentNullException ("forKey");
			if (objects == null)
				throw new ArgumentNullException ("objects");
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_int_IntPtr (this.Handle, selWillChangeValueForKeyWithSetMutationUsingObjects_, forKey.Handle, (int)mutationKind, objects.Handle);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_int_IntPtr (this.SuperHandle, selWillChangeValueForKeyWithSetMutationUsingObjects_, forKey.Handle, (int)mutationKind, objects.Handle);
			}
		}
		
		[Export ("didChangeValueForKey:withSetMutation:usingObjects:")]
		public virtual void DidChange (NSString forKey, NSKeyValueSetMutationKind mutationKind, NSSet objects)
		{
			if (forKey == null)
				throw new ArgumentNullException ("forKey");
			if (objects == null)
				throw new ArgumentNullException ("objects");
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_int_IntPtr (this.Handle, selDidChangeValueForKeyWithSetMutationUsingObjects_, forKey.Handle, (int)mutationKind, objects.Handle);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_int_IntPtr (this.SuperHandle, selDidChangeValueForKeyWithSetMutationUsingObjects_, forKey.Handle, (int)mutationKind, objects.Handle);
			}
		}
		
		[Export ("keyPathsForValuesAffectingValueForKey:")]
		public static NSSet GetKeyPathsForValuesAffecting (NSString key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			return (NSSet) Runtime.GetNSObject (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selKeyPathsForValuesAffectingValueForKey_, key.Handle));
		}
		*/
		[Export ("automaticallyNotifiesObserversForKey:")]
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
		
		[Export ("valueForKey:")]
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
		
		[Export ("setValue:forKey:")]
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
		
		[Export ("valueForKeyPath:")]
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
		
		[Export ("setValue:forKeyPath:")]
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
		
		[Export ("valueForUndefinedKey:")]
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
		
		[Export ("setValue:forUndefinedKey:")]
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
		
		[Export ("setNilValueForKey:")]
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
		/*
		[Export ("dictionaryWithValuesForKeys:")]
		public virtual NSDictionary GetDictionaryOfValuesFromKeys (NSString[] keys)
		{
			if (keys == null)
				throw new ArgumentNullException ("keys");
			var nsa_keys = NSArray.FromNSObjects (keys);
			
			NSDictionary ret;
			if (IsDirectBinding) {
				ret = (NSDictionary) Runtime.GetNSObject (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selDictionaryWithValuesForKeys_, nsa_keys.Handle));
			} else {
				ret = (NSDictionary) Runtime.GetNSObject (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selDictionaryWithValuesForKeys_, nsa_keys.Handle));
			}
			nsa_keys.Dispose ();
			
			return ret;
		}
		
		[Export ("setValuesForKeysWithDictionary:")]
		public virtual void SetValuesForKeysWithDictionary (NSDictionary keyedValues)
		{
			if (keyedValues == null)
				throw new ArgumentNullException ("keyedValues");
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetValuesForKeysWithDictionary_, keyedValues.Handle);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetValuesForKeysWithDictionary_, keyedValues.Handle);
			}
		}

		[Export ("exposedBindings")]
		public virtual NSString[] ExposedBindings ()
		{
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<RhinoMac.Foundation.NSString>(RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selExposedBindings));
			} else {
				return NSArray.ArrayFromHandle<RhinoMac.Foundation.NSString>(RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selExposedBindings));
			}
		}
		*/
		[Export ("valueClassForBinding:")]
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
		/*
		[Export ("bind:toObject:withKeyPath:options:")]
		public virtual void Bind (string binding, NSObject observable, string keyPath, NSDictionary options)
		{
			if (binding == null)
				throw new ArgumentNullException ("binding");
			if (observable == null)
				throw new ArgumentNullException ("observable");
			if (keyPath == null)
				throw new ArgumentNullException ("keyPath");
			var nsbinding = NSString.CreateNative (binding);
			var nskeyPath = NSString.CreateNative (keyPath);
			
			if (IsDirectBinding) {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, selBindToObjectWithKeyPathOptions_, nsbinding, observable.Handle, nskeyPath, options == null ? IntPtr.Zero : options.Handle);
			} else {
				RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, selBindToObjectWithKeyPathOptions_, nsbinding, observable.Handle, nskeyPath, options == null ? IntPtr.Zero : options.Handle);
			}
			NSString.ReleaseNative (nsbinding);
			NSString.ReleaseNative (nskeyPath);
			
		}
		*/
		[Export ("unbind:")]
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
		/*
		[Export ("infoForBinding:")]
		public virtual NSDictionary BindingInfo (string binding)
		{
			if (binding == null)
				throw new ArgumentNullException ("binding");
			var nsbinding = NSString.CreateNative (binding);
			
			NSDictionary ret;
			if (IsDirectBinding) {
				ret = (NSDictionary) Runtime.GetNSObject (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInfoForBinding_, nsbinding));
			} else {
				ret = (NSDictionary) Runtime.GetNSObject (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInfoForBinding_, nsbinding));
			}
			NSString.ReleaseNative (nsbinding);
			
			return ret;
		}

		[Export ("optionDescriptionsForBinding:")]
		public virtual NSObject[] BindingOptionDescriptions (string aBinding)
		{
			if (aBinding == null)
				throw new ArgumentNullException ("aBinding");
			var nsaBinding = NSString.CreateNative (aBinding);
			
			NSObject[] ret;
			if (IsDirectBinding) {
				ret = NSArray.ArrayFromHandle<RhinoMac.Foundation.NSObject>(RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selOptionDescriptionsForBinding_, nsaBinding));
			} else {
				ret = NSArray.ArrayFromHandle<RhinoMac.Foundation.NSObject>(RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selOptionDescriptionsForBinding_, nsaBinding));
			}
			NSString.ReleaseNative (nsaBinding);
			
			return ret;
		}
		*/
		[Export ("defaultPlaceholderForMarker:withBinding:")]
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
		
		[Export ("setDefaultPlaceholder:forMarker:withBinding:")]
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
		
		[Export ("objectDidEndEditing:")]
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
		
		[Export ("commitEditing")]
		public virtual bool CommitEditing ()
		{
			if (IsDirectBinding) {
				return RhinoMac.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selCommitEditing);
			} else {
				return RhinoMac.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selCommitEditing);
			}
		}
		
		[Export ("commitEditingWithDelegate:didCommitSelector:contextInfo:")]
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
		
		[Export ("copy")]
		public virtual NSObject Copy ()
		{
			if (IsDirectBinding) {
				return (NSObject) Runtime.GetNSObject (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCopy));
			} else {
				return (NSObject) Runtime.GetNSObject (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selCopy));
			}
		}
		
		[Export ("mutableCopy")]
		public virtual NSObject MutableCopy ()
		{
			if (IsDirectBinding) {
				return (NSObject) Runtime.GetNSObject (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selMutableCopy));
			} else {
				return (NSObject) Runtime.GetNSObject (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selMutableCopy));
			}
		}
		
		public virtual string Description {
			[Export ("description")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDescription));
				} else {
					return NSString.FromHandle (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDescription));
				}
			}
			
		}
		
		public virtual string DebugDescription {
			[Export ("debugDescription")]
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
