using System;

namespace CocoaRhino_CS
{
  public class CocoaRhinoCommand : Rhino.Commands.Command
  {
    public override string EnglishName { get { return "TestCocoaRhinoCS"; } }

    protected override Rhino.Commands.Result RunCommand (Rhino.RhinoDoc doc, Rhino.Commands.RunMode mode)
    {
      var vm = new DNViewModel();
      var win = RhinoMac.RhinoWindow.FromNib("CocoaRhinoWindow", vm);
      win.ShowModal();

      return Rhino.Commands.Result.Success;
    }
  }
}

