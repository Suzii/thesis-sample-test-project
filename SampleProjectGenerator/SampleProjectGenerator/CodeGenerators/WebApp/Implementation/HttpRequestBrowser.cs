namespace SampleProjectGenerator.CodeGenerators.WebApp.Implementation
{
    public class HttpRequestBrowser : BaseWebAppClassCodeGenerator
    {
        public override string GetDocumentName()
        {
            return nameof(HttpRequestBrowser);
        }

        protected override int NumberOfDiagnosticsInBody { get; } = 6;

        protected override string GetClassBodyToRepeat(int iterationNumber)
        {
            return $@"
        public void SampleMethodA{iterationNumber}()
        {{
            var request = new System.Web.HttpRequest(""fileName"", ""url"", ""queryString"");
            var browserInfo = request.Browser;
            var useless = request.Browser.Browser == browserInfo.Browser;
            var completelyUseless = browserInfo.Browser.Contains(""Ooops..."");
        }}

        public void SampleMethodB{iterationNumber}()
        {{
            var request = new System.Web.HttpRequestWrapper(new System.Web.HttpRequest(""fileName"", ""url"", ""queryString""));
            var browserInfo = request.Browser;
            var useless = request.Browser.Browser == browserInfo.Browser;
            var completelyUseless = browserInfo.Browser.Contains(""Ooops..."");
        }}";
        }
    }
}