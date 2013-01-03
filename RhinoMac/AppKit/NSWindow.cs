using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using RhinoMac.ObjCRuntime;
using RhinoMac.Foundation;
using System.Runtime.CompilerServices;

namespace RhinoMac.AppKit
{
  public class NSWindow : RhinoMac.Foundation.NSObject
  {
    readonly IntPtr m_pWindow;
    public NSWindow(IntPtr pWindow) : base(pWindow)
    {
      m_pWindow = pWindow;
    }
    
    public int WindowNumber
    {
      get
      {
        IntPtr selWindowNumber = Selector.GetHandle ("windowNumber");
        int rc = UnsafeNativeMethods.int_objc_msgSend (m_pWindow, selWindowNumber);
        return rc;
      }
    }
    
    [CompilerGenerated]
    static readonly IntPtr selDefaultDepthLimit = Selector.GetHandle ("defaultDepthLimit");
    [CompilerGenerated]
    static readonly IntPtr selTitle = Selector.GetHandle ("title");
    [CompilerGenerated]
    static readonly IntPtr selSetTitle_ = Selector.GetHandle ("setTitle:");
    [CompilerGenerated]
    static readonly IntPtr selRepresentedURL = Selector.GetHandle ("representedURL");
    [CompilerGenerated]
    static readonly IntPtr selSetRepresentedURL_ = Selector.GetHandle ("setRepresentedURL:");
    [CompilerGenerated]
    static readonly IntPtr selRepresentedFilename = Selector.GetHandle ("representedFilename");
    [CompilerGenerated]
    static readonly IntPtr selSetRepresentedFilename_ = Selector.GetHandle ("setRepresentedFilename:");
    [CompilerGenerated]
    static readonly IntPtr selIsExcludedFromWindowsMenu = Selector.GetHandle ("isExcludedFromWindowsMenu");
    [CompilerGenerated]
    static readonly IntPtr selContentView = Selector.GetHandle ("contentView");
    [CompilerGenerated]
    static readonly IntPtr selSetContentView_ = Selector.GetHandle ("setContentView:");
    [CompilerGenerated]
    static readonly IntPtr selDelegate = Selector.GetHandle ("delegate");
    [CompilerGenerated]
    static readonly IntPtr selSetDelegate_ = Selector.GetHandle ("setDelegate:");
    [CompilerGenerated]
    static readonly IntPtr selWindowNumber = Selector.GetHandle ("windowNumber");
    [CompilerGenerated]
    static readonly IntPtr selStyleMask = Selector.GetHandle ("styleMask");
    [CompilerGenerated]
    static readonly IntPtr selSetStyleMask_ = Selector.GetHandle ("setStyleMask:");
    [CompilerGenerated]
    static readonly IntPtr selFrame = Selector.GetHandle ("frame");
    [CompilerGenerated]
    static readonly IntPtr selInLiveResize = Selector.GetHandle ("inLiveResize");
    [CompilerGenerated]
    static readonly IntPtr selShowsResizeIndicator = Selector.GetHandle ("showsResizeIndicator");
    [CompilerGenerated]
    static readonly IntPtr selSetShowsResizeIndicator_ = Selector.GetHandle ("setShowsResizeIndicator:");
    [CompilerGenerated]
    static readonly IntPtr selResizeIncrements = Selector.GetHandle ("resizeIncrements");
    [CompilerGenerated]
    static readonly IntPtr selSetResizeIncrements_ = Selector.GetHandle ("setResizeIncrements:");
    [CompilerGenerated]
    static readonly IntPtr selAspectRatio = Selector.GetHandle ("aspectRatio");
    [CompilerGenerated]
    static readonly IntPtr selSetAspectRatio_ = Selector.GetHandle ("setAspectRatio:");
    [CompilerGenerated]
    static readonly IntPtr selContentResizeIncrements = Selector.GetHandle ("contentResizeIncrements");
    [CompilerGenerated]
    static readonly IntPtr selSetContentResizeIncrements_ = Selector.GetHandle ("setContentResizeIncrements:");
    [CompilerGenerated]
    static readonly IntPtr selContentAspectRatio = Selector.GetHandle ("contentAspectRatio");
    [CompilerGenerated]
    static readonly IntPtr selSetContentAspectRatio_ = Selector.GetHandle ("setContentAspectRatio:");
    [CompilerGenerated]
    static readonly IntPtr selIsFlushWindowDisabled = Selector.GetHandle ("isFlushWindowDisabled");
    [CompilerGenerated]
    static readonly IntPtr selViewsNeedDisplay = Selector.GetHandle ("viewsNeedDisplay");
    [CompilerGenerated]
    static readonly IntPtr selSetViewsNeedDisplay_ = Selector.GetHandle ("setViewsNeedDisplay:");
    [CompilerGenerated]
    static readonly IntPtr selIsAutodisplay = Selector.GetHandle ("isAutodisplay");
    [CompilerGenerated]
    static readonly IntPtr selSetAutodisplay_ = Selector.GetHandle ("setAutodisplay:");
    [CompilerGenerated]
    static readonly IntPtr selPreservesContentDuringLiveResize = Selector.GetHandle ("preservesContentDuringLiveResize");
    [CompilerGenerated]
    static readonly IntPtr selSetPreservesContentDuringLiveResize_ = Selector.GetHandle ("setPreservesContentDuringLiveResize:");
    [CompilerGenerated]
    static readonly IntPtr selFirstResponder = Selector.GetHandle ("firstResponder");
    [CompilerGenerated]
    static readonly IntPtr selResizeFlags = Selector.GetHandle ("resizeFlags");
    [CompilerGenerated]
    static readonly IntPtr selIsReleasedWhenClosed = Selector.GetHandle ("isReleasedWhenClosed");
    [CompilerGenerated]
    static readonly IntPtr selSetReleasedWhenClosed_ = Selector.GetHandle ("setReleasedWhenClosed:");
    [CompilerGenerated]
    static readonly IntPtr selIsZoomed = Selector.GetHandle ("isZoomed");
    [CompilerGenerated]
    static readonly IntPtr selIsMiniaturized = Selector.GetHandle ("isMiniaturized");
    [CompilerGenerated]
    static readonly IntPtr selBackgroundColor = Selector.GetHandle ("backgroundColor");
    [CompilerGenerated]
    static readonly IntPtr selSetBackgroundColor_ = Selector.GetHandle ("setBackgroundColor:");
    [CompilerGenerated]
    static readonly IntPtr selIsMovable = Selector.GetHandle ("isMovable");
    [CompilerGenerated]
    static readonly IntPtr selSetMovable_ = Selector.GetHandle ("setMovable:");
    [CompilerGenerated]
    static readonly IntPtr selIsMovableByWindowBackground = Selector.GetHandle ("isMovableByWindowBackground");
    [CompilerGenerated]
    static readonly IntPtr selSetMovableByWindowBackground_ = Selector.GetHandle ("setMovableByWindowBackground:");
    [CompilerGenerated]
    static readonly IntPtr selHidesOnDeactivate = Selector.GetHandle ("hidesOnDeactivate");
    [CompilerGenerated]
    static readonly IntPtr selSetHidesOnDeactivate_ = Selector.GetHandle ("setHidesOnDeactivate:");
    [CompilerGenerated]
    static readonly IntPtr selCanHide = Selector.GetHandle ("canHide");
    [CompilerGenerated]
    static readonly IntPtr selSetCanHide_ = Selector.GetHandle ("setCanHide:");
    [CompilerGenerated]
    static readonly IntPtr selMiniwindowImage = Selector.GetHandle ("miniwindowImage");
    [CompilerGenerated]
    static readonly IntPtr selSetMiniwindowImage_ = Selector.GetHandle ("setMiniwindowImage:");
    [CompilerGenerated]
    static readonly IntPtr selMiniwindowTitle = Selector.GetHandle ("miniwindowTitle");
    [CompilerGenerated]
    static readonly IntPtr selSetMiniwindowTitle_ = Selector.GetHandle ("setMiniwindowTitle:");
    [CompilerGenerated]
    static readonly IntPtr selDockTile = Selector.GetHandle ("dockTile");
    [CompilerGenerated]
    static readonly IntPtr selIsDocumentEdited = Selector.GetHandle ("isDocumentEdited");
    [CompilerGenerated]
    static readonly IntPtr selSetDocumentEdited_ = Selector.GetHandle ("setDocumentEdited:");
    [CompilerGenerated]
    static readonly IntPtr selIsVisible = Selector.GetHandle ("isVisible");
    [CompilerGenerated]
    static readonly IntPtr selSetIsVisible_ = Selector.GetHandle ("setIsVisible:");
    [CompilerGenerated]
    static readonly IntPtr selIsKeyWindow = Selector.GetHandle ("isKeyWindow");
    [CompilerGenerated]
    static readonly IntPtr selSetIsKeyWindow_ = Selector.GetHandle ("setIsKeyWindow:");
    [CompilerGenerated]
    static readonly IntPtr selIsMainWindow = Selector.GetHandle ("isMainWindow");
    [CompilerGenerated]
    static readonly IntPtr selSetIsMainWindow_ = Selector.GetHandle ("setIsMainWindow:");
    [CompilerGenerated]
    static readonly IntPtr selCanBecomeKeyWindow = Selector.GetHandle ("canBecomeKeyWindow");
    [CompilerGenerated]
    static readonly IntPtr selCanBecomeMainWindow = Selector.GetHandle ("canBecomeMainWindow");
    [CompilerGenerated]
    static readonly IntPtr selPreventsApplicationTerminationWhenModal = Selector.GetHandle ("preventsApplicationTerminationWhenModal");
    [CompilerGenerated]
    static readonly IntPtr selSetPreventsApplicationTerminationWhenModal_ = Selector.GetHandle ("setPreventsApplicationTerminationWhenModal:");
    [CompilerGenerated]
    static readonly IntPtr selIsOneShot = Selector.GetHandle ("isOneShot");
    [CompilerGenerated]
    static readonly IntPtr selAreCursorRectsEnabled = Selector.GetHandle ("areCursorRectsEnabled");
    [CompilerGenerated]
    static readonly IntPtr selAllowsToolTipsWhenApplicationIsInactive = Selector.GetHandle ("allowsToolTipsWhenApplicationIsInactive");
    [CompilerGenerated]
    static readonly IntPtr selSetAllowsToolTipsWhenApplicationIsInactive_ = Selector.GetHandle ("setAllowsToolTipsWhenApplicationIsInactive:");
    [CompilerGenerated]
    static readonly IntPtr selBackingType = Selector.GetHandle ("backingType");
    [CompilerGenerated]
    static readonly IntPtr selSetBackingType_ = Selector.GetHandle ("setBackingType:");
    [CompilerGenerated]
    static readonly IntPtr selLevel = Selector.GetHandle ("level");
    [CompilerGenerated]
    static readonly IntPtr selSetLevel_ = Selector.GetHandle ("setLevel:");
    [CompilerGenerated]
    static readonly IntPtr selDepthLimit = Selector.GetHandle ("depthLimit");
    [CompilerGenerated]
    static readonly IntPtr selSetDepthLimit_ = Selector.GetHandle ("setDepthLimit:");
    [CompilerGenerated]
    static readonly IntPtr selHasDynamicDepthLimit = Selector.GetHandle ("hasDynamicDepthLimit");
    [CompilerGenerated]
    static readonly IntPtr selSetDynamicDepthLimit_ = Selector.GetHandle ("setDynamicDepthLimit:");
    [CompilerGenerated]
    static readonly IntPtr selScreen = Selector.GetHandle ("screen");
    [CompilerGenerated]
    static readonly IntPtr selDeepestScreen = Selector.GetHandle ("deepestScreen");
    [CompilerGenerated]
    static readonly IntPtr selCanStoreColor = Selector.GetHandle ("canStoreColor");
    [CompilerGenerated]
    static readonly IntPtr selHasShadow = Selector.GetHandle ("hasShadow");
    [CompilerGenerated]
    static readonly IntPtr selSetHasShadow_ = Selector.GetHandle ("setHasShadow:");
    [CompilerGenerated]
    static readonly IntPtr selAlphaValue = Selector.GetHandle ("alphaValue");
    [CompilerGenerated]
    static readonly IntPtr selSetAlphaValue_ = Selector.GetHandle ("setAlphaValue:");
    [CompilerGenerated]
    static readonly IntPtr selIsOpaque = Selector.GetHandle ("isOpaque");
    [CompilerGenerated]
    static readonly IntPtr selSetOpaque_ = Selector.GetHandle ("setOpaque:");
    [CompilerGenerated]
    static readonly IntPtr selSharingType = Selector.GetHandle ("sharingType");
    [CompilerGenerated]
    static readonly IntPtr selSetSharingType_ = Selector.GetHandle ("setSharingType:");
    [CompilerGenerated]
    static readonly IntPtr selPreferredBackingLocation = Selector.GetHandle ("preferredBackingLocation");
    [CompilerGenerated]
    static readonly IntPtr selSetPreferredBackingLocation_ = Selector.GetHandle ("setPreferredBackingLocation:");
    [CompilerGenerated]
    static readonly IntPtr selBackingLocation = Selector.GetHandle ("backingLocation");
    [CompilerGenerated]
    static readonly IntPtr selAllowsConcurrentViewDrawing = Selector.GetHandle ("allowsConcurrentViewDrawing");
    [CompilerGenerated]
    static readonly IntPtr selSetAllowsConcurrentViewDrawing_ = Selector.GetHandle ("setAllowsConcurrentViewDrawing:");
    [CompilerGenerated]
    static readonly IntPtr selDisplaysWhenScreenProfileChanges = Selector.GetHandle ("displaysWhenScreenProfileChanges");
    [CompilerGenerated]
    static readonly IntPtr selSetDisplaysWhenScreenProfileChanges_ = Selector.GetHandle ("setDisplaysWhenScreenProfileChanges:");
    [CompilerGenerated]
    static readonly IntPtr selCanBecomeVisibleWithoutLogin = Selector.GetHandle ("canBecomeVisibleWithoutLogin");
    [CompilerGenerated]
    static readonly IntPtr selSetCanBecomeVisibleWithoutLogin_ = Selector.GetHandle ("setCanBecomeVisibleWithoutLogin:");
    [CompilerGenerated]
    static readonly IntPtr selCollectionBehavior = Selector.GetHandle ("collectionBehavior");
    [CompilerGenerated]
    static readonly IntPtr selSetCollectionBehavior_ = Selector.GetHandle ("setCollectionBehavior:");
    [CompilerGenerated]
    static readonly IntPtr selIsOnActiveSpace = Selector.GetHandle ("isOnActiveSpace");
    [CompilerGenerated]
    static readonly IntPtr selFrameAutosaveName = Selector.GetHandle ("frameAutosaveName");
    [CompilerGenerated]
    static readonly IntPtr selSetFrameAutosaveName_ = Selector.GetHandle ("setFrameAutosaveName:");
    [CompilerGenerated]
    static readonly IntPtr selMinSize = Selector.GetHandle ("minSize");
    [CompilerGenerated]
    static readonly IntPtr selSetMinSize_ = Selector.GetHandle ("setMinSize:");
    [CompilerGenerated]
    static readonly IntPtr selMaxSize = Selector.GetHandle ("maxSize");
    [CompilerGenerated]
    static readonly IntPtr selSetMaxSize_ = Selector.GetHandle ("setMaxSize:");
    [CompilerGenerated]
    static readonly IntPtr selContentMinSize = Selector.GetHandle ("contentMinSize");
    [CompilerGenerated]
    static readonly IntPtr selSetContentMinSize_ = Selector.GetHandle ("setContentMinSize:");
    [CompilerGenerated]
    static readonly IntPtr selContentMaxSize = Selector.GetHandle ("contentMaxSize");
    [CompilerGenerated]
    static readonly IntPtr selSetContentMaxSize_ = Selector.GetHandle ("setContentMaxSize:");
    [CompilerGenerated]
    static readonly IntPtr selAcceptsMouseMovedEvents = Selector.GetHandle ("acceptsMouseMovedEvents");
    [CompilerGenerated]
    static readonly IntPtr selSetAcceptsMouseMovedEvents_ = Selector.GetHandle ("setAcceptsMouseMovedEvents:");
    [CompilerGenerated]
    static readonly IntPtr selIgnoresMouseEvents = Selector.GetHandle ("ignoresMouseEvents");
    [CompilerGenerated]
    static readonly IntPtr selSetIgnoresMouseEvents_ = Selector.GetHandle ("setIgnoresMouseEvents:");
    [CompilerGenerated]
    static readonly IntPtr selDeviceDescription = Selector.GetHandle ("deviceDescription");
    [CompilerGenerated]
    static readonly IntPtr selMouseLocationOutsideOfEventStream = Selector.GetHandle ("mouseLocationOutsideOfEventStream");
    [CompilerGenerated]
    static readonly IntPtr selWindowController = Selector.GetHandle ("windowController");
    [CompilerGenerated]
    static readonly IntPtr selSetWindowController_ = Selector.GetHandle ("setWindowController:");
    [CompilerGenerated]
    static readonly IntPtr selIsSheet = Selector.GetHandle ("isSheet");
    [CompilerGenerated]
    static readonly IntPtr selAttachedSheet = Selector.GetHandle ("attachedSheet");
    [CompilerGenerated]
    static readonly IntPtr selChildWindows = Selector.GetHandle ("childWindows");
    [CompilerGenerated]
    static readonly IntPtr selParentWindow = Selector.GetHandle ("parentWindow");
    [CompilerGenerated]
    static readonly IntPtr selSetParentWindow_ = Selector.GetHandle ("setParentWindow:");
    [CompilerGenerated]
    static readonly IntPtr selGraphicsContext = Selector.GetHandle ("graphicsContext");
    [CompilerGenerated]
    static readonly IntPtr selUserSpaceScaleFactor = Selector.GetHandle ("userSpaceScaleFactor");
    [CompilerGenerated]
    static readonly IntPtr selColorSpace = Selector.GetHandle ("colorSpace");
    [CompilerGenerated]
    static readonly IntPtr selSetColorSpace_ = Selector.GetHandle ("setColorSpace:");
    [CompilerGenerated]
    static readonly IntPtr selInitialFirstResponder = Selector.GetHandle ("initialFirstResponder");
    [CompilerGenerated]
    static readonly IntPtr selDefaultButtonCell = Selector.GetHandle ("defaultButtonCell");
    [CompilerGenerated]
    static readonly IntPtr selSetDefaultButtonCell_ = Selector.GetHandle ("setDefaultButtonCell:");
    [CompilerGenerated]
    static readonly IntPtr selAutorecalculatesKeyViewLoop = Selector.GetHandle ("autorecalculatesKeyViewLoop");
    [CompilerGenerated]
    static readonly IntPtr selSetAutorecalculatesKeyViewLoop_ = Selector.GetHandle ("setAutorecalculatesKeyViewLoop:");
    [CompilerGenerated]
    static readonly IntPtr selToolbar = Selector.GetHandle ("toolbar");
    [CompilerGenerated]
    static readonly IntPtr selSetToolbar_ = Selector.GetHandle ("setToolbar:");
    [CompilerGenerated]
    static readonly IntPtr selShowsToolbarButton = Selector.GetHandle ("showsToolbarButton");
    [CompilerGenerated]
    static readonly IntPtr selSetShowsToolbarButton_ = Selector.GetHandle ("setShowsToolbarButton:");
    [CompilerGenerated]
    static readonly IntPtr selWindowRef = Selector.GetHandle ("windowRef");
    [CompilerGenerated]
    static readonly IntPtr selIsRestorable = Selector.GetHandle ("isRestorable");
    [CompilerGenerated]
    static readonly IntPtr selSetRestorable_ = Selector.GetHandle ("setRestorable:");
    [CompilerGenerated]
    static readonly IntPtr selRestorationClass = Selector.GetHandle ("restorationClass");
    [CompilerGenerated]
    static readonly IntPtr selSetRestorationClass_ = Selector.GetHandle ("setRestorationClass:");
    [CompilerGenerated]
    static readonly IntPtr selBackingScaleFactor = Selector.GetHandle ("backingScaleFactor");
    [CompilerGenerated]
    static readonly IntPtr selAnimationBehavior = Selector.GetHandle ("animationBehavior");
    [CompilerGenerated]
    static readonly IntPtr selSetAnimationBehavior_ = Selector.GetHandle ("setAnimationBehavior:");
    [CompilerGenerated]
    static readonly IntPtr selIdentifier = Selector.GetHandle ("identifier");
    [CompilerGenerated]
    static readonly IntPtr selAnimator = Selector.GetHandle ("animator");
    [CompilerGenerated]
    static readonly IntPtr selAnimations = Selector.GetHandle ("animations");
    [CompilerGenerated]
    static readonly IntPtr selSetAnimations_ = Selector.GetHandle ("setAnimations:");
    [CompilerGenerated]
    static readonly IntPtr selFrameRectForContentRectStyleMask_ = Selector.GetHandle ("frameRectForContentRect:styleMask:");
    [CompilerGenerated]
    static readonly IntPtr selContentRectForFrameRectStyleMask_ = Selector.GetHandle ("contentRectForFrameRect:styleMask:");
    [CompilerGenerated]
    static readonly IntPtr selMinFrameWidthWithTitleStyleMask_ = Selector.GetHandle ("minFrameWidthWithTitle:styleMask:");
    [CompilerGenerated]
    static readonly IntPtr selFrameRectForContentRect_ = Selector.GetHandle ("frameRectForContentRect:");
    [CompilerGenerated]
    static readonly IntPtr selContentRectForFrameRect_ = Selector.GetHandle ("contentRectForFrameRect:");
    [CompilerGenerated]
    static readonly IntPtr selInitWithContentRectStyleMaskBackingDefer_ = Selector.GetHandle ("initWithContentRect:styleMask:backing:defer:");
    [CompilerGenerated]
    static readonly IntPtr selInitWithContentRectStyleMaskBackingDeferScreen_ = Selector.GetHandle ("initWithContentRect:styleMask:backing:defer:screen:");
    [CompilerGenerated]
    static readonly IntPtr selSetTitleWithRepresentedFilename_ = Selector.GetHandle ("setTitleWithRepresentedFilename:");
    [CompilerGenerated]
    static readonly IntPtr selSetExcludedFromWindowsMenu_ = Selector.GetHandle ("setExcludedFromWindowsMenu:");
    [CompilerGenerated]
    static readonly IntPtr selFieldEditorForObject_ = Selector.GetHandle ("fieldEditor:forObject:");
    [CompilerGenerated]
    static readonly IntPtr selEndEditingFor_ = Selector.GetHandle ("endEditingFor:");
    [CompilerGenerated]
    static readonly IntPtr selConstrainFrameRectToScreen_ = Selector.GetHandle ("constrainFrameRect:toScreen:");
    [CompilerGenerated]
    static readonly IntPtr selSetFrameDisplay_ = Selector.GetHandle ("setFrame:display:");
    [CompilerGenerated]
    static readonly IntPtr selSetContentSize_ = Selector.GetHandle ("setContentSize:");
    [CompilerGenerated]
    static readonly IntPtr selSetFrameOrigin_ = Selector.GetHandle ("setFrameOrigin:");
    [CompilerGenerated]
    static readonly IntPtr selSetFrameTopLeftPoint_ = Selector.GetHandle ("setFrameTopLeftPoint:");
    [CompilerGenerated]
    static readonly IntPtr selCascadeTopLeftFromPoint_ = Selector.GetHandle ("cascadeTopLeftFromPoint:");
    [CompilerGenerated]
    static readonly IntPtr selAnimationResizeTime_ = Selector.GetHandle ("animationResizeTime:");
    [CompilerGenerated]
    static readonly IntPtr selSetFrameDisplayAnimate_ = Selector.GetHandle ("setFrame:display:animate:");
    [CompilerGenerated]
    static readonly IntPtr selUseOptimizedDrawing_ = Selector.GetHandle ("useOptimizedDrawing:");
    [CompilerGenerated]
    static readonly IntPtr selDisableFlushWindow = Selector.GetHandle ("disableFlushWindow");
    [CompilerGenerated]
    static readonly IntPtr selEnableFlushWindow = Selector.GetHandle ("enableFlushWindow");
    [CompilerGenerated]
    static readonly IntPtr selFlushWindow = Selector.GetHandle ("flushWindow");
    [CompilerGenerated]
    static readonly IntPtr selFlushWindowIfNeeded = Selector.GetHandle ("flushWindowIfNeeded");
    [CompilerGenerated]
    static readonly IntPtr selDisplayIfNeeded = Selector.GetHandle ("displayIfNeeded");
    [CompilerGenerated]
    static readonly IntPtr selDisplay = Selector.GetHandle ("display");
    [CompilerGenerated]
    static readonly IntPtr selUpdate = Selector.GetHandle ("update");
    [CompilerGenerated]
    static readonly IntPtr selMakeFirstResponder_ = Selector.GetHandle ("makeFirstResponder:");
    [CompilerGenerated]
    static readonly IntPtr selKeyDown_ = Selector.GetHandle ("keyDown:");
    [CompilerGenerated]
    static readonly IntPtr selClose = Selector.GetHandle ("close");
    [CompilerGenerated]
    static readonly IntPtr selMiniaturize_ = Selector.GetHandle ("miniaturize:");
    [CompilerGenerated]
    static readonly IntPtr selDeminiaturize_ = Selector.GetHandle ("deminiaturize:");
    [CompilerGenerated]
    static readonly IntPtr selZoom_ = Selector.GetHandle ("zoom:");
    [CompilerGenerated]
    static readonly IntPtr selTryToPerformWith_ = Selector.GetHandle ("tryToPerform:with:");
    [CompilerGenerated]
    static readonly IntPtr selValidRequestorForSendTypeReturnType_ = Selector.GetHandle ("validRequestorForSendType:returnType:");
    [CompilerGenerated]
    static readonly IntPtr selSetContentBorderThicknessForEdge_ = Selector.GetHandle ("setContentBorderThickness:forEdge:");
    [CompilerGenerated]
    static readonly IntPtr selContentBorderThicknessForEdge_ = Selector.GetHandle ("contentBorderThicknessForEdge:");
    [CompilerGenerated]
    static readonly IntPtr selSetAutorecalculatesContentBorderThicknessForEdge_ = Selector.GetHandle ("setAutorecalculatesContentBorderThickness:forEdge:");
    [CompilerGenerated]
    static readonly IntPtr selAutorecalculatesContentBorderThicknessForEdge_ = Selector.GetHandle ("autorecalculatesContentBorderThicknessForEdge:");
    [CompilerGenerated]
    static readonly IntPtr selCenter = Selector.GetHandle ("center");
    [CompilerGenerated]
    static readonly IntPtr selMakeKeyAndOrderFront_ = Selector.GetHandle ("makeKeyAndOrderFront:");
    [CompilerGenerated]
    static readonly IntPtr selOrderFront_ = Selector.GetHandle ("orderFront:");
    [CompilerGenerated]
    static readonly IntPtr selOrderBack_ = Selector.GetHandle ("orderBack:");
    [CompilerGenerated]
    static readonly IntPtr selOrderOut_ = Selector.GetHandle ("orderOut:");
    [CompilerGenerated]
    static readonly IntPtr selOrderWindowRelativeTo_ = Selector.GetHandle ("orderWindow:relativeTo:");
    [CompilerGenerated]
    static readonly IntPtr selOrderFrontRegardless = Selector.GetHandle ("orderFrontRegardless");
    [CompilerGenerated]
    static readonly IntPtr selMakeKeyWindow = Selector.GetHandle ("makeKeyWindow");
    [CompilerGenerated]
    static readonly IntPtr selMakeMainWindow = Selector.GetHandle ("makeMainWindow");
    [CompilerGenerated]
    static readonly IntPtr selBecomeKeyWindow = Selector.GetHandle ("becomeKeyWindow");
    [CompilerGenerated]
    static readonly IntPtr selResignKeyWindow = Selector.GetHandle ("resignKeyWindow");
    [CompilerGenerated]
    static readonly IntPtr selBecomeMainWindow = Selector.GetHandle ("becomeMainWindow");
    [CompilerGenerated]
    static readonly IntPtr selResignMainWindow = Selector.GetHandle ("resignMainWindow");
    [CompilerGenerated]
    static readonly IntPtr selWorksWhenModal = Selector.GetHandle ("worksWhenModal");
    [CompilerGenerated]
    static readonly IntPtr selConvertBaseToScreen_ = Selector.GetHandle ("convertBaseToScreen:");
    [CompilerGenerated]
    static readonly IntPtr selConvertScreenToBase_ = Selector.GetHandle ("convertScreenToBase:");
    [CompilerGenerated]
    static readonly IntPtr selPerformClose_ = Selector.GetHandle ("performClose:");
    [CompilerGenerated]
    static readonly IntPtr selPerformMiniaturize_ = Selector.GetHandle ("performMiniaturize:");
    [CompilerGenerated]
    static readonly IntPtr selPerformZoom_ = Selector.GetHandle ("performZoom:");
    [CompilerGenerated]
    static readonly IntPtr selGState = Selector.GetHandle ("gState");
    [CompilerGenerated]
    static readonly IntPtr selSetOneShot_ = Selector.GetHandle ("setOneShot:");
    [CompilerGenerated]
    static readonly IntPtr selDataWithEPSInsideRect_ = Selector.GetHandle ("dataWithEPSInsideRect:");
    [CompilerGenerated]
    static readonly IntPtr selDataWithPDFInsideRect_ = Selector.GetHandle ("dataWithPDFInsideRect:");
    [CompilerGenerated]
    static readonly IntPtr selPrint_ = Selector.GetHandle ("print:");
    [CompilerGenerated]
    static readonly IntPtr selDisableCursorRects = Selector.GetHandle ("disableCursorRects");
    [CompilerGenerated]
    static readonly IntPtr selEnableCursorRects = Selector.GetHandle ("enableCursorRects");
    [CompilerGenerated]
    static readonly IntPtr selDiscardCursorRects = Selector.GetHandle ("discardCursorRects");
    [CompilerGenerated]
    static readonly IntPtr selInvalidateCursorRectsForView_ = Selector.GetHandle ("invalidateCursorRectsForView:");
    [CompilerGenerated]
    static readonly IntPtr selResetCursorRects = Selector.GetHandle ("resetCursorRects");
    [CompilerGenerated]
    static readonly IntPtr selInvalidateShadow = Selector.GetHandle ("invalidateShadow");
    [CompilerGenerated]
    static readonly IntPtr selDisableScreenUpdatesUntilFlush = Selector.GetHandle ("disableScreenUpdatesUntilFlush");
    [CompilerGenerated]
    static readonly IntPtr selStringWithSavedFrame = Selector.GetHandle ("stringWithSavedFrame");
    [CompilerGenerated]
    static readonly IntPtr selSetFrameFromString_ = Selector.GetHandle ("setFrameFromString:");
    [CompilerGenerated]
    static readonly IntPtr selSaveFrameUsingName_ = Selector.GetHandle ("saveFrameUsingName:");
    [CompilerGenerated]
    static readonly IntPtr selSetFrameUsingNameForce_ = Selector.GetHandle ("setFrameUsingName:force:");
    [CompilerGenerated]
    static readonly IntPtr selSetFrameUsingName_ = Selector.GetHandle ("setFrameUsingName:");
    [CompilerGenerated]
    static readonly IntPtr selRemoveFrameUsingName_ = Selector.GetHandle ("removeFrameUsingName:");
    [CompilerGenerated]
    static readonly IntPtr selCacheImageInRect_ = Selector.GetHandle ("cacheImageInRect:");
    [CompilerGenerated]
    static readonly IntPtr selRestoreCachedImage = Selector.GetHandle ("restoreCachedImage");
    [CompilerGenerated]
    static readonly IntPtr selDiscardCachedImage = Selector.GetHandle ("discardCachedImage");
    [CompilerGenerated]
    static readonly IntPtr selNextEventMatchingMask_ = Selector.GetHandle ("nextEventMatchingMask:");
    [CompilerGenerated]
    static readonly IntPtr selNextEventMatchingMaskUntilDateInModeDequeue_ = Selector.GetHandle ("nextEventMatchingMask:untilDate:inMode:dequeue:");
    [CompilerGenerated]
    static readonly IntPtr selDiscardEventsMatchingMaskBeforeEvent_ = Selector.GetHandle ("discardEventsMatchingMask:beforeEvent:");
    [CompilerGenerated]
    static readonly IntPtr selPostEventAtStart_ = Selector.GetHandle ("postEvent:atStart:");
    [CompilerGenerated]
    static readonly IntPtr selCurrentEvent = Selector.GetHandle ("currentEvent");
    [CompilerGenerated]
    static readonly IntPtr selSendEvent_ = Selector.GetHandle ("sendEvent:");
    [CompilerGenerated]
    static readonly IntPtr selMenuChanged_ = Selector.GetHandle ("menuChanged:");
    [CompilerGenerated]
    static readonly IntPtr selStandardWindowButtonForStyleMask_ = Selector.GetHandle ("standardWindowButton:forStyleMask:");
    [CompilerGenerated]
    static readonly IntPtr selStandardWindowButton_ = Selector.GetHandle ("standardWindowButton:");
    [CompilerGenerated]
    static readonly IntPtr selAddChildWindowOrdered_ = Selector.GetHandle ("addChildWindow:ordered:");
    [CompilerGenerated]
    static readonly IntPtr selRemoveChildWindow_ = Selector.GetHandle ("removeChildWindow:");
    [CompilerGenerated]
    static readonly IntPtr selWindowNumbersWithOptions_ = Selector.GetHandle ("windowNumbersWithOptions:");
    [CompilerGenerated]
    static readonly IntPtr selWindowNumberAtPointBelowWindowWithWindowNumber_ = Selector.GetHandle ("windowNumberAtPoint:belowWindowWithWindowNumber:");
    [CompilerGenerated]
    static readonly IntPtr selSelectNextKeyView_ = Selector.GetHandle ("selectNextKeyView:");
    [CompilerGenerated]
    static readonly IntPtr selSelectPreviousKeyView_ = Selector.GetHandle ("selectPreviousKeyView:");
    [CompilerGenerated]
    static readonly IntPtr selSelectKeyViewFollowingView_ = Selector.GetHandle ("selectKeyViewFollowingView:");
    [CompilerGenerated]
    static readonly IntPtr selSelectKeyViewPrecedingView_ = Selector.GetHandle ("selectKeyViewPrecedingView:");
    [CompilerGenerated]
    static readonly IntPtr selKeyViewSelectionDirection = Selector.GetHandle ("keyViewSelectionDirection");
    [CompilerGenerated]
    static readonly IntPtr selDisableKeyEquivalentForDefaultButtonCell = Selector.GetHandle ("disableKeyEquivalentForDefaultButtonCell");
    [CompilerGenerated]
    static readonly IntPtr selEnableKeyEquivalentForDefaultButtonCell = Selector.GetHandle ("enableKeyEquivalentForDefaultButtonCell");
    [CompilerGenerated]
    static readonly IntPtr selRecalculateKeyViewLoop = Selector.GetHandle ("recalculateKeyViewLoop");
    [CompilerGenerated]
    static readonly IntPtr selToggleToolbarShown_ = Selector.GetHandle ("toggleToolbarShown:");
    [CompilerGenerated]
    static readonly IntPtr selRunToolbarCustomizationPalette_ = Selector.GetHandle ("runToolbarCustomizationPalette:");
    [CompilerGenerated]
    static readonly IntPtr selRegisterForDraggedTypes_ = Selector.GetHandle ("registerForDraggedTypes:");
    [CompilerGenerated]
    static readonly IntPtr selUnregisterDraggedTypes = Selector.GetHandle ("unregisterDraggedTypes");
    [CompilerGenerated]
    static readonly IntPtr selDisableSnapshotRestoration = Selector.GetHandle ("disableSnapshotRestoration");
    [CompilerGenerated]
    static readonly IntPtr selEnableSnapshotRestoration = Selector.GetHandle ("enableSnapshotRestoration");
    [CompilerGenerated]
    static readonly IntPtr selUpdateConstraintsIfNeeded = Selector.GetHandle ("updateConstraintsIfNeeded");
    [CompilerGenerated]
    static readonly IntPtr selLayoutIfNeeded = Selector.GetHandle ("layoutIfNeeded");
    [CompilerGenerated]
    static readonly IntPtr selSetAnchorAttributeForOrientation_ = Selector.GetHandle ("setAnchorAttribute:forOrientation:");
    [CompilerGenerated]
    static readonly IntPtr selVisualizeConstraints_ = Selector.GetHandle ("visualizeConstraints:");
    [CompilerGenerated]
    static readonly IntPtr selConvertRectToScreen_ = Selector.GetHandle ("convertRectToScreen:");
    [CompilerGenerated]
    static readonly IntPtr selConvertRectFromScreen_ = Selector.GetHandle ("convertRectFromScreen:");
    [CompilerGenerated]
    static readonly IntPtr selConvertRectToBacking_ = Selector.GetHandle ("convertRectToBacking:");
    [CompilerGenerated]
    static readonly IntPtr selConvertRectFromBacking_ = Selector.GetHandle ("convertRectFromBacking:");
    [CompilerGenerated]
    static readonly IntPtr selBackingAlignedRectOptions_ = Selector.GetHandle ("backingAlignedRect:options:");
    [CompilerGenerated]
    static readonly IntPtr selToggleFullScreen_ = Selector.GetHandle ("toggleFullScreen:");
    [CompilerGenerated]
    static readonly IntPtr selAnimationForKey_ = Selector.GetHandle ("animationForKey:");
    [CompilerGenerated]
    static readonly IntPtr selDefaultAnimationForKey_ = Selector.GetHandle ("defaultAnimationForKey:");
    /*
    public static global::System.Drawing.RectangleF FrameRectFor (global::System.Drawing.RectangleF contectRect, NSWindowStyle styleMask)
    {
      global::System.Drawing.RectangleF ret;
      RhinoMac.ObjCRuntime.Messaging.RectangleF_objc_msgSend_stret_RectangleF_int (out ret, class_ptr, selFrameRectForContentRectStyleMask_, contectRect, (int)styleMask);
      return ret;
    }
    
    public static global::System.Drawing.RectangleF ContentRectFor (global::System.Drawing.RectangleF forFrameRect, NSWindowStyle styleMask)
    {
      global::System.Drawing.RectangleF ret;
      RhinoMac.ObjCRuntime.Messaging.RectangleF_objc_msgSend_stret_RectangleF_int (out ret, class_ptr, selContentRectForFrameRectStyleMask_, forFrameRect, (int)styleMask);
      return ret;
    }
    
    public static float MinFrameWidthWithTitle (string aTitle, NSWindowStyle aStyle)
    {
      if (aTitle == null)
        throw new ArgumentNullException ("aTitle");
      var nsaTitle = NSString.CreateNative (aTitle);
      
      float ret;
      ret = RhinoMac.ObjCRuntime.Messaging.float_objc_msgSend_IntPtr_int (class_ptr, selMinFrameWidthWithTitleStyleMask_, nsaTitle, (int)aStyle);
      NSString.ReleaseNative (nsaTitle);
      
      return ret;
    }
    */
    public virtual global::System.Drawing.RectangleF FrameRectFor (global::System.Drawing.RectangleF contentRect)
    {
      global::System.Drawing.RectangleF ret;
      if (IsDirectBinding) {
        RhinoMac.ObjCRuntime.Messaging.RectangleF_objc_msgSend_stret_RectangleF (out ret, this.Handle, selFrameRectForContentRect_, contentRect);
      } else {
        RhinoMac.ObjCRuntime.Messaging.RectangleF_objc_msgSendSuper_stret_RectangleF (out ret, this.SuperHandle, selFrameRectForContentRect_, contentRect);
      }
      return ret;
    }
    
    public virtual global::System.Drawing.RectangleF ContentRectFor (global::System.Drawing.RectangleF frameRect)
    {
      global::System.Drawing.RectangleF ret;
      if (IsDirectBinding) {
        RhinoMac.ObjCRuntime.Messaging.RectangleF_objc_msgSend_stret_RectangleF (out ret, this.Handle, selContentRectForFrameRect_, frameRect);
      } else {
        RhinoMac.ObjCRuntime.Messaging.RectangleF_objc_msgSendSuper_stret_RectangleF (out ret, this.SuperHandle, selContentRectForFrameRect_, frameRect);
      }
      return ret;
    }


/*
    public virtual void SetTitleWithRepresentedFilename (string filename)
    {
      if (filename == null)
        throw new ArgumentNullException ("filename");
      var nsfilename = NSString.CreateNative (filename);
      
      if (IsDirectBinding) {
        RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetTitleWithRepresentedFilename_, nsfilename);
      } else {
        RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetTitleWithRepresentedFilename_, nsfilename);
      }
      NSString.ReleaseNative (nsfilename);
      
    }
    */
    public virtual void SetExcludedFromWindowsMenu (bool flag)
    {
      if (IsDirectBinding) {
        RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetExcludedFromWindowsMenu_, flag);
      } else {
        RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetExcludedFromWindowsMenu_, flag);
      }
    }
    /*
    public virtual NSText FieldEditor (bool createFlag, NSObject forObject)
    {
      if (forObject == null)
        throw new ArgumentNullException ("forObject");
      if (IsDirectBinding) {
        return (NSText) Runtime.GetNSObject (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend_bool_IntPtr (this.Handle, selFieldEditorForObject_, createFlag, forObject.Handle));
      } else {
        return (NSText) Runtime.GetNSObject (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_bool_IntPtr (this.SuperHandle, selFieldEditorForObject_, createFlag, forObject.Handle));
      }
    }

    public virtual void EndEditingFor (NSObject anObject)
    {
      if (IsDirectBinding) {
        RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selEndEditingFor_, anObject == null ? IntPtr.Zero : anObject.Handle);
      } else {
        RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selEndEditingFor_, anObject == null ? IntPtr.Zero : anObject.Handle);
      }
    }
    
    public virtual global::System.Drawing.RectangleF ConstrainFrameRect (global::System.Drawing.RectangleF frameRect, NSScreen screen)
    {
      if (screen == null)
        throw new ArgumentNullException ("screen");
      global::System.Drawing.RectangleF ret;
      if (IsDirectBinding) {
        RhinoMac.ObjCRuntime.Messaging.RectangleF_objc_msgSend_stret_RectangleF_IntPtr (out ret, this.Handle, selConstrainFrameRectToScreen_, frameRect, screen.Handle);
      } else {
        RhinoMac.ObjCRuntime.Messaging.RectangleF_objc_msgSendSuper_stret_RectangleF_IntPtr (out ret, this.SuperHandle, selConstrainFrameRectToScreen_, frameRect, screen.Handle);
      }
      return ret;
    }
    */
    public virtual void SetFrame (global::System.Drawing.RectangleF frameRect, bool display)
    {
      if (IsDirectBinding) {
        RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_RectangleF_bool (this.Handle, selSetFrameDisplay_, frameRect, display);
      } else {
        RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_RectangleF_bool (this.SuperHandle, selSetFrameDisplay_, frameRect, display);
      }
    }
    
    public virtual void SetContentSize (global::System.Drawing.SizeF aSize)
    {
      if (IsDirectBinding) {
        RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_SizeF (this.Handle, selSetContentSize_, aSize);
      } else {
        RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_SizeF (this.SuperHandle, selSetContentSize_, aSize);
      }
    }
    
    public virtual void SetFrameOrigin (global::System.Drawing.PointF aPoint)
    {
      if (IsDirectBinding) {
        RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_PointF (this.Handle, selSetFrameOrigin_, aPoint);
      } else {
        RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_PointF (this.SuperHandle, selSetFrameOrigin_, aPoint);
      }
    }
    
    public virtual void SetFrameTopLeftPoint (global::System.Drawing.PointF aPoint)
    {
      if (IsDirectBinding) {
        RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_PointF (this.Handle, selSetFrameTopLeftPoint_, aPoint);
      } else {
        RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_PointF (this.SuperHandle, selSetFrameTopLeftPoint_, aPoint);
      }
    }

    public virtual string Title {
      get {
        if (IsDirectBinding) {
          return NSString.FromHandle (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTitle));
        } else {
          return NSString.FromHandle (RhinoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTitle));
        }
      }
      
      set {
        if (value == null)
          throw new ArgumentNullException ("value");
        var nsvalue = NSString.CreateNative (value);
        
        if (IsDirectBinding) {
          RhinoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetTitle_, nsvalue);
        } else {
          RhinoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetTitle_, nsvalue);
        }
        NSString.ReleaseNative (nsvalue);
        
      }
    }

  }
}
