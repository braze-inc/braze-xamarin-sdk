using System;
using Xamarin.Forms;

namespace TestAppXamarinForms
{
  class TabbedMainPage : TabbedPage
  {
    public TabbedMainPage ()
    {
      this.Title = "Appboy Xamarin Forms Example";
      this.Children.Add (new MenuPage());
      this.Children.Add (new AppboyNewsFeedPage());
    }
  }
}