using System;

namespace DebugStarterExe
{
  class MainClass
  {
    public static void Main (string[] args)
    {
      Console.WriteLine (
@"The only reason this application exists is for being able to start the
MonoDevelop debugger for Rhino.  I haven't figured out a way to instrument
MonoDevelop to start debugging a DLL project yet.

Right click on this project in MonoDevelop, select Run With...
and choose one of the soft debuggers for Rhinoceros");
    }
  }
}
