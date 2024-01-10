﻿using System;

using Xamarin.Forms;

namespace TestAppXamarinForms
{
  public class App : Application
  {
    public App ()
    {
      // The root page of your application
      MainPage = new NavigationPage(
        new TabbedMainPage()
      );
    }
  }
}

