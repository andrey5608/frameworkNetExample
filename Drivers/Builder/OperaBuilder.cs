﻿using OpenQA.Selenium;
using OpenQA.Selenium.Opera;

namespace Drivers.Builder
{
  public class OperaBuilder : IDriverBuilder
  {
    private readonly OperaOptions _options;
    private static OperaDriver _driver;
    private string _driverPath;

    public OperaBuilder()
    {
      string driverName = "OperaDriver";
      _options = new OperaOptions();
      _driverPath = null;

      SetArguments(WebDriverConfigManager.GetDriverArgument(driverName));
      SetBinaryLocation(WebDriverConfigManager.GetDriverConfiguration(driverName, WebDriverConfigParameters.BinaryLocation));
      SetBrowserVersion(WebDriverConfigManager.GetDriverConfiguration(driverName, WebDriverConfigParameters.BrowserVersion));
      SetPlatformName(WebDriverConfigManager.GetDriverConfiguration(driverName, WebDriverConfigParameters.PlatformName));
    }
    public IWebDriver GetWebDriver()
    {
      _driver ??= new OperaDriver(_driverPath, _options);
      return _driver;
    }

    public void SetAcceptInsecureCertificates(bool isAccept)
    {
      _options.AcceptInsecureCertificates = isAccept;
    }

    public void SetBrowserVersion(string browserVersion)
    {
      _options.BrowserVersion = browserVersion;
    }

    public void SetPlatformName(string platformName)
    {
      _options.PlatformName = platformName;
    }

    public void SetArguments(string[] arguments)
    {
      _options.AddArguments(arguments);
    }

    public void SetBinaryLocation(string location)
    {
      _driverPath = location;
    }

    public void SetPageLoadStrategy(PageLoadStrategy strategy)
    {
      _options.PageLoadStrategy = strategy;
    }

    public void SetProxy(Proxy proxy)
    {
      _options.Proxy = proxy;
    }

    public void SetUnhandledPromptBehavior(UnhandledPromptBehavior behavior)
    {
      _options.UnhandledPromptBehavior = behavior;
    }
  }
}
