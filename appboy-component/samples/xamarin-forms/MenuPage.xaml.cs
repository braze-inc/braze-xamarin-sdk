using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TestAppXamarinForms
{
  public partial class MenuPage : ContentPage
  {
    public MenuPage ()
    {
      InitializeComponent();
    }

    void OnLogCustomEvent(object sender, EventArgs args)
    {
      DependencyService.Get<IAppboyPlatformDelegate>().LogCustomEvent("FormsSampleEvent");
    }
  }
}

