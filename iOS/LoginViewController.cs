﻿using System;

using UIKit;

namespace ClinicAttendance.iOS
{
    public partial class LoginViewController : UIViewController
    {
        public LoginViewController() : base("LoginViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void UIButton597_TouchUpInside(UIButton sender)
        {
            throw new NotImplementedException();
        }
    }
}

