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

namespace notificationsCross.iOS
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UIButton Button { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField firstNameTextField { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton notificationButton1 { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton notificationButton2 { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField sureNameTextField { get; set; }

		[Action ("notificationButton1_touchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void notificationButton1_touchUpInside (UIButton sender);

		[Action ("notificationButton2_touchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void notificationButton2_touchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (firstNameTextField != null) {
				firstNameTextField.Dispose ();
				firstNameTextField = null;
			}
			if (notificationButton1 != null) {
				notificationButton1.Dispose ();
				notificationButton1 = null;
			}
			if (notificationButton2 != null) {
				notificationButton2.Dispose ();
				notificationButton2 = null;
			}
			if (sureNameTextField != null) {
				sureNameTextField.Dispose ();
				sureNameTextField = null;
			}
		}
	}
}
