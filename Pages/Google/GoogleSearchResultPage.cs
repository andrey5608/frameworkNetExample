﻿using Extensions.Pages.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Pages.Google
{
  public sealed class GoogleSearchResultPage : PagePrototype, IPagePrototype
  {
    // put element description here
    [FindsBy(How = How.XPath, Using = "//div[@id='res']//div[@class='r']//h3")]
    public IWebElement searchResults;

    public GoogleSearchResultPage(IWebDriver webDriver) : base(webDriver, PageNames.GoogleSearchResultPage)
    {
      PageFactory.InitElements(_webDriver, this);

      SetElements(new (string, IWebElement)[]
      {
        ("search result", searchResults)
      });
      SetPageTransitions(new (string, string)[]
      {
        ("search result", PageNames.SpecFlowMainPage)
      });
    }
  }
}
