using System;

using UIKit;

namespace Pushr.iOS
{
	public partial class ViewController : UIViewController
	{

		public Counter pushUpCounter {
			get;
			set;
		}

		public ViewController (IntPtr handle) : base (handle)
		{
			pushUpCounter = new Counter();
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

		partial void StartButton_TouchUpInside(UIButton sender) {
			UpdateCountLabel();
			StartButton.Hidden = true;
			PushUpCount.Hidden = false;
			PushUpTap.Hidden = false;
			RestartButton.Hidden = false;
		}

		partial void RestartButton_TouchUpInside(UIButton sender) {
			PushUpCount.Hidden = true;
			StartButton.Hidden = false;
			RestartButton.Hidden = true;
			PushUpTap.Hidden = true;
			pushUpCounter.ResetCount();
		}


		partial void PushUpTap_TouchUpInside (UIButton sender)
		{
			pushUpCounter.IncrementCount();
			UpdateCountLabel();
		}

		public void UpdateCountLabel() {
			PushUpCount.Text = pushUpCounter.GetCountAsString();
		}
	}
}

