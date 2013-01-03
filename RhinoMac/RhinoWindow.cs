using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;


namespace RhinoMac
{
  public class RhinoWindow : AppKit.NSWindow
  {
    IntPtr m_pWindow = IntPtr.Zero;
    IntPtr m_pController = IntPtr.Zero;

    public static RhinoWindow FromNib(string nib, INotifyPropertyChanged viewModel)
    {
      Interop.Init();
      string ass_loc = viewModel.GetType().Assembly.Location;
      string ass_dir = System.IO.Path.GetDirectoryName(ass_loc);
      string nib_path = System.IO.Path.Combine(ass_dir, nib);
      IntPtr pController = UnsafeNativeMethods.RUI_CreateWindow(nib_path);
      if( pController==IntPtr.Zero )
        return null;
      Interop.RegisterRhinoWindowController(pController, viewModel);
      IntPtr pWindow = UnsafeNativeMethods.RUI_GetWindow(pController);
      RhinoWindow rc = new RhinoWindow(viewModel, pController, pWindow);
      return rc;
    }

    public static IntPtr CreateController(string nib, INotifyPropertyChanged viewModel)
    {
      Interop.Init();
      string ass_loc = viewModel.GetType().Assembly.Location;
      string ass_dir = System.IO.Path.GetDirectoryName(ass_loc);
      string nib_path = System.IO.Path.Combine(ass_dir, nib);
      IntPtr pController = UnsafeNativeMethods.RUI_CreateWindow(nib_path);
      if( pController==IntPtr.Zero )
        return IntPtr.Zero;
      Interop.RegisterRhinoWindowController(pController, viewModel);
      return pController;
    }

    RhinoWindow(INotifyPropertyChanged viewmodel, IntPtr pController, IntPtr pWindow) : base(pWindow)
    {
      m_pController = pController;
      m_pWindow = pWindow;
      ViewModel = viewmodel;
      ViewModel.PropertyChanged += HandlePropertyChanged;
    }

    void HandlePropertyChanged (object sender, PropertyChangedEventArgs e)
    {
      if( m_pController!=IntPtr.Zero )
        UnsafeNativeMethods.RUI_ValueChanged(m_pController, e.PropertyName);
    }

    public INotifyPropertyChanged ViewModel { get; private set; }
    public IntPtr ControllerHandle { get { return m_pController; } }

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
