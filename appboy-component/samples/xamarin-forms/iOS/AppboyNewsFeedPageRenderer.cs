using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using AppboyPlatformXamariniOSBinding;
using UIKit;
using CoreGraphics;

[assembly:ExportRenderer(typeof(TestAppXamarinForms.AppboyNewsFeedPage), typeof(TestAppXamarinForms.iOS.AppboyNewsFeedPageRenderer))]

namespace TestAppXamarinForms.iOS
{
  public class AppboyNewsFeedPageRenderer : PageRenderer
  {
    ABKFeedViewControllerNavigationContext abkFeedViewControllerNavigationContext;

    public AppboyNewsFeedPageRenderer() {
      abkFeedViewControllerNavigationContext = new ABKFeedViewControllerNavigationContext();
    }

    public override void ViewDidLoad ()
    {
      base.ViewDidLoad ();
      this.AddChildViewController (abkFeedViewControllerNavigationContext);
      View.Add (abkFeedViewControllerNavigationContext.View);
    }
  }
}
