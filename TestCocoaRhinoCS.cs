using System;

namespace CocoaRhino_CS
{
  public class TestCocoaRhinoCSCommand : Rhino.Commands.Command
  {
    public override string EnglishName { get { return "TestCocoaRhinoCS"; } }

    protected override Rhino.Commands.Result RunCommand (Rhino.RhinoDoc doc, Rhino.Commands.RunMode mode)
    {
      /*
      // Seems like the following would be a good SDK for working with windows in nibs
      var win = RhinoMac.RhinoWindow.WindowFromNib("CocoaRhinoWindow.nib");
      win.DataContext = new DNViewModel();
      win.ShowModal();
      */

      var vm = new DNViewModel();
      vm.ShowModal();
      return Rhino.Commands.Result.Success;
    }
  }
}

