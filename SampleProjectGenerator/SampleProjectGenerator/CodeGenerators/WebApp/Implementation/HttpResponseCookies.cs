﻿namespace SampleProjectGenerator.CodeGenerators.WebApp.Implementation
{
    public class HttpResponseCookies : BaseWebAppClassCodeGenerator
    {
        public override string GetDocumentName()
        {
            return nameof(HttpResponseCookies);
        }

        protected override int NumberOfDiagnosticsInBody { get; } = 6;

        protected override string GetClassBodyToRepeat(int iterationNumber)
        {
            return $@"
        public void SampleMethodA{iterationNumber}()
        {{
            var response = new System.Web.HttpResponse(null);
            var cookies1 = new System.Web.HttpResponse(null).Cookies;
            var cookies2 = response.Cookies;
            var numberOfCookies = response.Cookies.Count;
        }}

        public void SampleMethodB{iterationNumber}()
        {{
            var response = new System.Web.HttpResponseWrapper(new System.Web.HttpResponse(null));
            var cookies1 = new System.Web.HttpResponseWrapper(new System.Web.HttpResponse(null)).Cookies;
            var cookies2 = response.Cookies;
            var numberOfCookies = response.Cookies.Count;
        }}";
        }
    }
}