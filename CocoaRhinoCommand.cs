using System;

namespace CocoaRhino_CS
{
  public class CocoaRhinoCommand : Rhino.Commands.Command
  {
    public override string EnglishName { get { return "TestCocoaRhinoCSharp"; } }

    protected override Rhino.Commands.Result RunCommand (Rhino.RhinoDoc doc, Rhino.Commands.RunMode mode)
    {
      MonoMac.ObjCRuntime.Runtime.RegisterAssembly (this.GetType ().Assembly);
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
      TestResponer res = new TestResponer ();
      btn.Activated += (object sender, EventArgs e) => {
        MonoMac.AppKit.NSFontManager.SharedFontManager.Target = res;
        MonoMac.AppKit.NSFontManager.SharedFontManager.OrderFrontFontPanel (btn);
      };
      res.NextResponder = win.NextResponder;
      win.NextResponder = res;

      win.ShowModal();

      return Rhino.Commands.Result.Success;
    }
  }

  public class TestResponer : MonoMac.AppKit.NSResponder
  {
    [MonoMac.Foundation.Export("changeFont:")]
    public void ChangeFont(MonoMac.Foundation.NSObject sender)
    {
      Rhino.RhinoApp.WriteLine ("YES");
    }
  }

  public class CustomButton : MonoMac.AppKit.NSButton
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

