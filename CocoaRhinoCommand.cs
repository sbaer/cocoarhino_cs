using System;

namespace CocoaRhino_CS
{
  public class CocoaRhinoCommand : Rhino.Commands.Command
  {
    public override string EnglishName { get { return "TestCocoaRhinoCSharp"; } }

    protected override Rhino.Commands.Result RunCommand (Rhino.RhinoDoc doc, Rhino.Commands.RunMode mode)
    {
      var vm = new DNViewModel();
      var win = RhinoMac.RhinoWindow.FromNib("CocoaRhinoWindow", vm);
      win.Title = "On the fly";

      var rect = new System.Drawing.RectangleF(10, 100, 200, 50);
      //var btn = new MonoMac.AppKit.NSButton (rect);
			var btn = new CustomButton(rect);
      win.ContentView.AddSubview(btn);
      btn.Title = "On the fly";
      btn.SetButtonType(MonoMac.AppKit.NSButtonType.MomentaryLightButton);
      btn.BezelStyle = MonoMac.AppKit.NSBezelStyle.Rounded;
      btn.Activated += (object sender, EventArgs e) => Rhino.RhinoApp.WriteLine("I got click!!!");
      win.ShowModal();

      return Rhino.Commands.Result.Success;
    }
  }

  class CustomButton : MonoMac.AppKit.NSButton
	{
		public CustomButton(System.Drawing.RectangleF r):base(r){
		}

		public override void DrawRect (MonoMac.Foundation.NSRect dirtyRect)
		{
			base.DrawRect (dirtyRect);
			var context = MonoMac.AppKit.NSGraphicsContext.CurrentContext.GraphicsPort;
			context.SetFillColor (new MonoMac.CoreGraphics.CGColor (1, 0, 0));
			context.FillRect (new System.Drawing.RectangleF (5, 5, 10, 10));
			//base.DrawRect (dirtyRect);
		}
	}
}

