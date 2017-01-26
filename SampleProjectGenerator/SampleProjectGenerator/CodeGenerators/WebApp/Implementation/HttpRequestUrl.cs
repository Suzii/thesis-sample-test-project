namespace SampleProjectGenerator.CodeGenerators.WebApp.Implementation
{
    public class HttpRequestUrl : BaseWebAppClassCodeGenerator
    {
        public override string GetDocumentName()
        {
            return nameof(HttpRequestUrl);
        }

        protected override int NumberOfDiagnosticsInBody { get; } = 4;

        protected override string GetClassBodyToRepeat(int iterationNumber)
        {
            return $@"
        public void SampleMethodA{iterationNumber}()
        {{
            var request = new System.Web.HttpRequest(""fileName"", ""url"", ""queryString"");
            var url = request.Url;
            var useless = request.Url.Host.Contains(""Oooops..."");
        }}

        public void SampleMethodB{iterationNumber}()
        {{
            var request = new System.Web.HttpRequestWrapper(new System.Web.HttpRequest(""fileName"", ""url"", ""queryString""));
            var url = request.Url;
            var useless = request.Url.Host.Contains(""Oooops..."");
        }}";
        }
    }
}