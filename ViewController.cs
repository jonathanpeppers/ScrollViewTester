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

            var button = new CustomButton();
            var frame = button.Frame;
            frame.X = 50;
            frame.Y = 50;
            button.Frame = frame;
            _scrollView.AddSubview(button);

            button = new CustomButton();
            frame = button.Frame;
            frame.X = 0;
            frame.Y = 250;
            button.Frame = frame;
            _scrollView.AddSubview(button);

            button = new CustomButton();
            frame = button.Frame;
            frame.X = 50;
            frame.Y = 450;
            button.Frame = frame;
            _scrollView.AddSubview(button);
        }
    }
}

