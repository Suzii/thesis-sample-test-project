namespace SampleProjectGenerator.CodeGenerators.WebApp.Implementation
{
    public class HttpResponseRedirect : BaseWebAppClassCodeGenerator
    {
        public override string GetDocumentName(int index)
        {
            return $"{nameof(HttpResponseRedirect)}{index}";
        }

        protected override int NumberOfDiagnosticsInBody { get; } = 4;

        protected override string GetClassBodyToRepeat(int iterationNumber)
        {
            return $@"
        public void SampleMethodA{iterationNumber}()
        {{
            var response = new System.Web.HttpResponse(null);
            new System.Web.HttpResponse(null).Redirect(""https://some/super/funky/url"");
            response.Redirect(""https://some/url"");
        }}

        public void SampleMethodB{iterationNumber}()
        {{
            var response = new System.Web.HttpResponseWrapper(new System.Web.HttpResponse(null));
            new System.Web.HttpResponse(null).Redirect(""https://some/super/funky/url"");
            response.Redirect(""https://some/url"");
        }}";
        }
    }
}