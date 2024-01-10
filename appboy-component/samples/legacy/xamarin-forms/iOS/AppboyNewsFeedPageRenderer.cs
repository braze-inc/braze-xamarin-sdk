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
    public AppboyNewsFeedPageRenderer() {
    }

    public override void ViewDidLoad ()
    {
      base.ViewDidLoad();
      ABKNewsFeedTableViewController feed = ABKNewsFeedTableViewController.GetNavigationFeedViewController();
      this.AddChildViewController(feed);
      View.Add(feed.View);
    }
  }
}
