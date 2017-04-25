using System;

namespace TestAppXamarinForms
{
  public interface IAppboyPlatformDelegate
  {
    void LogCustomEvent(String eventName);
    void ShowSlideupIam();
    void ShowModalIam();
    void ShowFullIam();
  }
}
