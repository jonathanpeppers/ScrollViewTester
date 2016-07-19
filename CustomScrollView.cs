using Foundation;
using System;
using UIKit;
using CoreGraphics;

namespace ScrollViewTester
{
    public partial class CustomScrollView : UIScrollView
    {
        private UIView _container;

        public CustomScrollView (IntPtr handle) : base (handle)
        {
            Initialize();
        }

        public CustomScrollView()
        {
            Initialize();
        }

        private void Initialize()
        {
            MaximumZoomScale = 1;
            MinimumZoomScale = 0.25f;
            MultipleTouchEnabled = true;
            DelaysContentTouches = true;

            _container = new UIView { BackgroundColor = UIColor.Red, AutoresizingMask = UIViewAutoresizing.None };
            _container.Frame = new CGRect(0, 0, 2000, 2000);
            base.AddSubview(_container);
            ViewForZoomingInScrollView = _ => _container;
        }

        public override void AddSubview(UIView view)
        {
            _container.AddSubview(view);
        }

        public override bool TouchesShouldCancelInContentView(UIView view)
        {
            return true;
        }

        public override void LayoutSubviews()
        {
            base.LayoutSubviews();


        }
    }
}