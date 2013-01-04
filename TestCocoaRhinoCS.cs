using System;

namespace CocoaRhino_CS
{
  public class TestCocoaRhinoCSCommand : Rhino.Commands.Command
  {
    public override string EnglishName { get { return "TestCocoaRhinoCS"; } }

    protected override Rhino.Commands.Result RunCommand (Rhino.RhinoDoc doc, Rhino.Commands.RunMode mode)
    {
      //IntPtr pController = RhinoMac.RhinoWindow.CreateController("CocoaRhinoWindow.nib", new DNViewModel());
      //var ctrl = new RhinoMac.AppKit.NSWindowController(pController);
      //ctrl.ShowWindow(ctrl);
      var vm = new DNViewModel();
      var win = RhinoMac.RhinoWindow.FromNib("CocoaRhinoWindow", vm);
      win.ShowModal();

      return Rhino.Commands.Result.Success;
    }
  }
}

