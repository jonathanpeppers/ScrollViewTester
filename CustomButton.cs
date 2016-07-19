using System;
using CoreGraphics;
using Foundation;
using UIKit;

namespace ScrollViewTester
{
    public partial class CustomButton : UIView
    {
        private UIButton _button;

        public CustomButton(IntPtr handle) : base(handle)
        {
            Initialize();
        }

        public CustomButton() : base(new CGRect(0, 0, 150, 150))
        {
            Initialize();
        }

        private void Initialize()
        {
            BackgroundColor = UIColor.Yellow;

            _button = UIButton.FromType(UIButtonType.System);
            _button.SetTitle("I'm a button!", UIControlState.Normal);
            AddSubview(_button);
        }

        public override void LayoutSubviews()
        {
            base.LayoutSubviews();

            _button.Frame = new CGRect(0, 0, Frame.Size.Width, Frame.Size.Height);
        }
    }
}
