﻿namespace SampleProjectGenerator.CodeGenerators.WebApp.Implementation
{
    public class ClientScriptMethods : BaseWebAppClassCodeGenerator
    {
        public override string GetDocumentName(int index)
        {
            return $"{nameof(ClientScriptMethods)}{index}";
        }

        protected override int NumberOfDiagnosticsInBody { get; } = 8;

        protected override string GetClassPrefix(int index)
        {
            return $@"namespace WebApp.Controllers
{{
    public class {GetDocumentName(index)} : System.Web.UI.Control
    {{";
        }

        protected override string GetClassBodyToRepeat(int iterationNumber)
        {
            return $@"
        public void SampleMethodA{iterationNumber}()
        {{
            var clientScript = new System.Web.UI.Page().ClientScript;
            clientScript.RegisterArrayDeclaration(""arrayName"", ""arrayValue"");
            clientScript.RegisterClientScriptBlock(typeof(object), ""key"", ""script"");
            clientScript.RegisterClientScriptInclude(typeof(object), ""key"", ""url"");
            clientScript.RegisterStartupScript(typeof(object), ""key"", ""script"");
        }}

        public void SampleMethodB{iterationNumber}()
        {{
            new System.Web.UI.Page().ClientScript.RegisterArrayDeclaration(""arrayName"", ""arrayValue"");
            new System.Web.UI.Page().ClientScript.RegisterClientScriptBlock(typeof(object), ""key"", ""script"");
            new System.Web.UI.Page().ClientScript.RegisterClientScriptInclude(typeof(object), ""key"", ""url"");
            new System.Web.UI.Page().ClientScript.RegisterStartupScript(typeof(object), ""key"", ""script"");
        }}";
        }
    }
}