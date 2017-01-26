namespace SampleProjectGenerator.CodeGenerators.WebApp.Implementation
{
    public class PageIsPostBack : BaseWebAppClassCodeGenerator
    {
        public override string GetDocumentName()
        {
            return nameof(PageIsPostBack);
        }

        protected override int NumberOfDiagnosticsInBody { get; } = 2;

        protected override string GetClassBodyToRepeat(int iterationNumber)
        {
            return $@"
        public void SampleMethodA{iterationNumber}()
        {{
            var isPostBack = new System.Web.UI.Page().IsPostBack;
        }}

        public void SampleMethodB{iterationNumber}()
        {{
            var page = new System.Web.UI.Page();
            var answer = page.IsPostBack.ToString();
        }}";
        }
    }
}