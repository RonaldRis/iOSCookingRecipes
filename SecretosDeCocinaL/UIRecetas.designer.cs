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

namespace SecretosDeCocinaL
{
    [Register ("UIRecetas")]
    partial class UIRecetas
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView TableRecetas { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (TableRecetas != null) {
                TableRecetas.Dispose ();
                TableRecetas = null;
            }
        }
    }
}