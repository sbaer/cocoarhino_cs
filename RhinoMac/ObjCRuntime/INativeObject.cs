using System;

namespace RhinoMac.ObjCRuntime {
	public interface INativeObject {
		IntPtr Handle { get; }
	}
}
