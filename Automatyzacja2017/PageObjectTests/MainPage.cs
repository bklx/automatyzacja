using System;
using System.Linq;

namespace PageObjcectTests
{
    internal class MainPage
    {
        private static string url = "https://autotestdotnet.wordpress.com/";

        internal static void GoTo()
        {
            Browser.NavigateTo(url);

        }

        internal static void OpenFirstNote()
        {
            var elements = Browser.FindByXpath("//article/header");
            elements.First().Click();
        }
    }
}