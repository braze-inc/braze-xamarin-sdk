using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.Views;
using Android.Widget;

[assembly:ExportRenderer(typeof(TestAppXamarinForms.AppboyNewsFeedPage), typeof(TestAppXamarinForms.Droid.AppboyNewsFeedPageRenderer))]
namespace TestAppXamarinForms.Droid
{
  public class AppboyNewsFeedPageRenderer : PageRenderer
  {
    Android.Views.View view;

    protected override void OnElementChanged (ElementChangedEventArgs<Page> e)
    {
      base.OnElementChanged (e);
      // this is a ViewGroup - so should be able to load an AXML file and FindView<>
      var activity = this.Context as Activity;

      var o = activity.LayoutInflater.Inflate(Resource.Layout.appboy_feed_layout, this, false);
      view = o;
      AddView(view);
    }

    protected override void OnLayout (bool changed, int l, int t, int r, int b)
    {
      base.OnLayout (changed, l, t, r, b);
      var msw = MeasureSpec.MakeMeasureSpec (r - l, MeasureSpecMode.Exactly);
      var msh = MeasureSpec.MakeMeasureSpec (b - t, MeasureSpecMode.Exactly);
      view.Measure(msw, msh);
      view.Layout (0, 0, r - l, b - t);
    }
  }
}
  