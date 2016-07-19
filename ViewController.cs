using System;

using UIKit;

namespace ScrollViewTester
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            _scrollView.MaximumZoomScale = 1;
            _scrollView.MinimumZoomScale = 0.25f;
            _scrollView.MultipleTouchEnabled = true;
            _scrollView.ViewForZoomingInScrollView = _ => _container;
        }
    }
}

