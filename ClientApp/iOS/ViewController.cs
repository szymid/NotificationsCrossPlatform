using System;
		
using UIKit;

namespace notificationsCross.iOS
{
	public partial class ViewController : UIViewController
	{
		

		public ViewController (IntPtr handle) : base (handle)
		{		
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



		partial void notificationButton1_touchUpInside (UIButton sender)
		{
			//throw new NotImplementedException ();
			Console.WriteLine("notificationButton1 Pressed");
			new UIAlertView("Notification 1", "notificationButton1 Pressed", null, "OK", null).Show();
		}

		partial void notificationButton2_touchUpInside (UIButton sender)
		{
			//throw new NotImplementedException ();
			new UIAlertView("Notification 2", "notificationButton2 Pressed", null, "OK", null).Show();
		}
	}
}
