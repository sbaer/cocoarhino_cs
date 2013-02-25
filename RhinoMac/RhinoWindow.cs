using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;


namespace RhinoMac
{
  public class RhinoWindow : AppKit.NSWindow
  {
    IntPtr m_pDNWindowController = IntPtr.Zero; // DNWindowController*

    public static RhinoWindow FromNib(string nib, INotifyPropertyChanged viewModel)
    {
      var pi = Rhino.PlugIns.PlugIn.Find(viewModel.GetType().Assembly);
      IntPtr pDNWindowController = UnsafeNativeMethods.RUI_CreateWindow(nib, pi.Id);
      if( pDNWindowController==IntPtr.Zero )
        return null;
      Interop.RegisterRhinoWindowController(pDNWindowController, viewModel);
      IntPtr pWindow = UnsafeNativeMethods.RUI_GetWindow(pDNWindowController);
      RhinoWindow rc = new RhinoWindow(viewModel, pDNWindowController, pWindow);
      return rc;
    }

    RhinoWindow(INotifyPropertyChanged viewmodel, IntPtr pController, IntPtr pWindow)
      : base(pWindow)
    {
      m_pDNWindowController = pController;
      ViewModel = viewmodel;
      ViewModel.PropertyChanged += HandlePropertyChanged;
    }

    void HandlePropertyChanged (object sender, PropertyChangedEventArgs e)
    {
      if( m_pDNWindowController!=IntPtr.Zero )
        UnsafeNativeMethods.RUI_ValueChanged(m_pDNWindowController, e.PropertyName);
    }

    public INotifyPropertyChanged ViewModel { get; private set; }
    IntPtr ControllerHandle { get { return m_pDNWindowController; } }

    public void ShowModal()
    {
      UnsafeNativeMethods.RUI_ShowModalWindow(ControllerHandle);
    }

    public void Show()
    {
      UnsafeNativeMethods.RUI_ShowWindow(ControllerHandle);
    }
  }
}
