namespace Refactoring
{
    public class IntroduceExplainingVariable
    {
        public bool Method(string platform, string browser, int resize)
        {
            return platform.IndexOf("MAC") > -1 && browser.IndexOf("IE") > -1 && resize > 0;
        }
    }
}