// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Pushr.iOS
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel PushUpCount { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton PushUpTap { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton RestartButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton StartButton { get; set; }

		[Action ("PushUpTap_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void PushUpTap_TouchUpInside (UIButton sender);

		[Action ("RestartButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void RestartButton_TouchUpInside (UIButton sender);

		[Action ("StartButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void StartButton_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (PushUpCount != null) {
				PushUpCount.Dispose ();
				PushUpCount = null;
			}
			if (PushUpTap != null) {
				PushUpTap.Dispose ();
				PushUpTap = null;
			}
			if (RestartButton != null) {
				RestartButton.Dispose ();
				RestartButton = null;
			}
			if (StartButton != null) {
				StartButton.Dispose ();
				StartButton = null;
			}
		}
	}
}
