namespace SampleProjectGenerator.CodeGenerators.WebApp.Implementation
{
    public class HttpSessionElementAccessGet : BaseWebAppClassCodeGenerator
    {
        public override string GetDocumentName()
        {
            return nameof(HttpSessionElementAccessGet);
        }

        protected override int NumberOfDiagnosticsInBody { get; } = 6;

        protected override string GetClassBodyToRepeat(int iterationNumber)
        {
            return $@"
        public void SampleMethodA{iterationNumber}()
        {{
            var session = System.Web.HttpContext.Current.Session;
            var aValue = session[""aKey""];
            var aValueString1 = session[""aKey""].ToString();
            var aValueString2 = System.Web.HttpContext.Current.Session[""aKey""].ToString();
        }}

        public void SampleMethodB{iterationNumber}()
        {{
            var session = new System.Web.HttpSessionStateWrapper(System.Web.HttpContext.Current.Session);
            var aValue = session[""aKey""];
            var aValueString1 = session[""aKey""].ToString();
            var aValueString2 = new System.Web.HttpSessionStateWrapper(System.Web.HttpContext.Current.Session)[""aKey""].ToString();
        }}";
        }
    }
}