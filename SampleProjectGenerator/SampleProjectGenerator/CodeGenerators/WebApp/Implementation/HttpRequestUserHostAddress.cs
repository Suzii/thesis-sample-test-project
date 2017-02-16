﻿namespace SampleProjectGenerator.CodeGenerators.WebApp.Implementation
{
    public class HttpRequestUserHostAddress : BaseWebAppClassCodeGenerator
    {
        public override string GetDocumentName(int index)
        {
            return $"{nameof(HttpRequestUserHostAddress)}{index}";
        }

        protected override int NumberOfDiagnosticsInBody { get; } = 4;

        protected override string GetClassBodyToRepeat(int iterationNumber)
        {
            return $@"
        public void SampleMethodA{iterationNumber}()
        {{
            var request = new System.Web.HttpRequest(""fileName"", ""url"", ""queryString"");
            var address = request.UserHostAddress;
            var useless = request.UserHostAddress.Contains(""Oooops..."");
        }}

        public void SampleMethodB{iterationNumber}()
        {{
            var request = new System.Web.HttpRequestWrapper(new System.Web.HttpRequest(""fileName"", ""url"", ""queryString""));
            var address = request.UserHostAddress;
            var useless = request.UserHostAddress.Contains(""Oooops..."");
        }}";
        }
    }
}