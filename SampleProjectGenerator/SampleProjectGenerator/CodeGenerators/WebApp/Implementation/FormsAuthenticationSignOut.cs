namespace SampleProjectGenerator.CodeGenerators.WebApp.Implementation
{
    public class FormsAuthenticationSignOut : BaseWebAppClassCodeGenerator
    {
        public override string GetDocumentName(int index)
        {
            return $"{nameof(FormsAuthenticationSignOut)}{index}";
        }

        protected override int NumberOfDiagnosticsInBody { get; } = 4;
        
        protected override string GetClassBodyToRepeat(int iterationNumber)
        {
            return $@"
       public void SampleMethod{iterationNumber}()
       {{
            System.Web.Security.FormsAuthentication.SignOut();
            System.Web.Security.FormsAuthentication.SignOut();
            System.Web.Security.FormsAuthentication.SignOut();
            System.Web.Security.FormsAuthentication.SignOut();
       }}";
        }
    }
}