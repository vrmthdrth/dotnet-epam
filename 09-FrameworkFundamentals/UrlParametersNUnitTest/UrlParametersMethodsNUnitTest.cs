namespace UrlParametersTask.Tests
{
    using NUnit.Framework;

    public class UrlParametersMethodsNUnitTest
    {
        [TestCase("www.example.com", "key=value", ExpectedResult = "www.example.com?key=value")]
        [TestCase("www.example.com?key=value", "key2=value2", ExpectedResult = "www.example.com?key=value&key2=value2")]
        [TestCase("www.example.com?key=oldValue", "key=newValue", ExpectedResult = "www.example.com?key=newValue")]
        public string AddOrChangeUrlParameter_Url_Key_AddsOrChangesParameter(string testUrl, string testParam)
        {
            return UrlParametersMethods.AddOrChangeUrlParameter(testUrl, testParam);
        }
    }
}