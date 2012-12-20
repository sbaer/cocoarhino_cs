using System;

namespace CocoaRhino_CS
{
  public class TestCocoaRhinoCSCommand : Rhino.Commands.Command
  {
    public override string EnglishName { get { return "TestCocoaRhinoCS"; } }

    protected override Rhino.Commands.Result RunCommand (Rhino.RhinoDoc doc, Rhino.Commands.RunMode mode)
    {
      Rhino.RhinoApp.WriteLine("Hello!!");
      return Rhino.Commands.Result.Success;
    }
  }
}

