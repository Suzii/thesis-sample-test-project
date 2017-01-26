﻿namespace SampleProjectGenerator.CodeGenerators.WebApp.Implementation
{
    public class HttpRequestCookies : BaseWebAppClassCodeGenerator
    {
        public override string GetDocumentName()
        {
            return nameof(HttpRequestCookies);
        }

        protected override int NumberOfDiagnosticsInBody { get; } = 6;

        protected override string GetClassBodyToRepeat(int iterationNumber)
        {
            return $@"
        public void SampleMethodA{iterationNumber}()
        {{
            var request = new System.Web.HttpRequest(""fileName"", ""url"", ""queryString"");
            var cookies1 = new System.Web.HttpRequest(""fileName"", ""url"", ""queryString"").Cookies;
            var cookies2 = request.Cookies;
            var numberOfCookies = request.Cookies.Count;
        }}

        public void SampleMethodB{iterationNumber}()
        {{
            var request = new System.Web.HttpRequestWrapper(new System.Web.HttpRequest(""fileName"", ""url"", ""queryString""));
            var cookies1 = new System.Web.HttpRequestWrapper(new System.Web.HttpRequest(""fileName"", ""url"", ""queryString"")).Cookies;
            var cookies2 = request.Cookies;
            var numberOfCookies = request.Cookies.Count;
        }}";
        }
    }
}