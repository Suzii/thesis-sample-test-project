﻿namespace SampleProjectGenerator.CodeGenerators.WebApp.Implementation
{
    public class HttpSessionElementAccessSet : BaseWebAppClassCodeGenerator
    {
        public override string GetDocumentName()
        {
            return nameof(HttpSessionElementAccessSet);
        }

        protected override int NumberOfDiagnosticsInBody { get; } = 4;

        protected override string GetClassBodyToRepeat(int iterationNumber)
        {
            return $@"
        public void SampleMethodA{iterationNumber}()
        {{
            var session = System.Web.HttpContext.Current.Session;
            session[""aKey""] = ""aValue"";
            System.Web.HttpContext.Current.Session[""aKey""] = ""aValue"";
        }}

        public void SampleMethodB{iterationNumber}()
        {{
            var session = new System.Web.HttpSessionStateWrapper(System.Web.HttpContext.Current.Session);
            session[""aKey""] = ""aValue"";
            new System.Web.HttpSessionStateWrapper(System.Web.HttpContext.Current.Session)[""aKey""] = ""aValue"";
        }}";
        }
    }
}