using Foundation;
using System;
using UIKit;

namespace LoginApp
{
    public partial class LoginVC : UIViewController
    {

        partial void btnRegisterClicked(UIButton sender)
        {
            
        }

        partial void btnLoginClicked(UIButton sender)
        {
            if (txtEmail.Text == null) {
                
            } else if (txtPassword.Text == null) {
                
            } else {
                
            }
        }

        public LoginVC (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
            base.ViewDidLoad();
        }
	}
}