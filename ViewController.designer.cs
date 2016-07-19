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

namespace ScrollViewTester
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView _container { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        ScrollViewTester.CustomScrollView _scrollView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (_container != null) {
                _container.Dispose ();
                _container = null;
            }

            if (_scrollView != null) {
                _scrollView.Dispose ();
                _scrollView = null;
            }
        }
    }
}