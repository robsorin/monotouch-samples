// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace Quotes
{
	[Register ("PagePreview")]
	partial class PagePreview
	{
		[Outlet]
		MonoTouch.UIKit.UIImageView pageImageView { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel textLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (pageImageView != null) {
				pageImageView.Dispose ();
				pageImageView = null;
			}

			if (textLabel != null) {
				textLabel.Dispose ();
				textLabel = null;
			}
		}
	}
}
