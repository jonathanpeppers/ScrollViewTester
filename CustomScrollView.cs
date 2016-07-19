using Foundation;
using System;
using UIKit;

namespace ScrollViewTester
{
    public partial class CustomScrollView : UIScrollView
    {
        public CustomScrollView (IntPtr handle) : base (handle)
        {
        }

        public override bool TouchesShouldCancelInContentView(UIView view)
        {
            return true;
        }
    }
}