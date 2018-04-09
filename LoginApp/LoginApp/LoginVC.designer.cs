// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace LoginApp
{
    [Register ("LoginVC")]
    partial class LoginVC
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnSignin { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtEmail { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtPassword { get; set; }

        [Action ("btnLoginClicked:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnLoginClicked (UIKit.UIButton sender);

        [Action ("btnRegisterClicked:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnRegisterClicked (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnSignin != null) {
                btnSignin.Dispose ();
                btnSignin = null;
            }

            if (txtEmail != null) {
                txtEmail.Dispose ();
                txtEmail = null;
            }

            if (txtPassword != null) {
                txtPassword.Dispose ();
                txtPassword = null;
            }
        }
    }
}