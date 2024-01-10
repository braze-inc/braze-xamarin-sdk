using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TestAppXamarinForms
{
  public partial class MenuPage : ContentPage
  {
    public MenuPage()
    {
      InitializeComponent();
    }

    void OnLogCustomEvent(object sender, EventArgs args)
    {
      DependencyService.Get<IAppboyPlatformDelegate>().LogCustomEvent("FormsSampleEvent");
    }

    void OnShowSlideupIam(object sender, EventArgs args)
    {
      DependencyService.Get<IAppboyPlatformDelegate>().ShowSlideupIam();
    }

    void OnShowModalIam (object sender, EventArgs args)
    {
      DependencyService.Get<IAppboyPlatformDelegate>().ShowModalIam();
    }

    void OnShowFullIam (object sender, EventArgs args)
    {
      DependencyService.Get<IAppboyPlatformDelegate>().ShowFullIam();
    }
  }
}

