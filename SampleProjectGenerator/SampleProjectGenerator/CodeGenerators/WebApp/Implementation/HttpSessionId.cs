﻿namespace SampleProjectGenerator.CodeGenerators.WebApp.Implementation
{
    public class HttpSessionId : BaseWebAppClassCodeGenerator
    {
        public override string GetDocumentName()
        {
            return nameof(HttpSessionId);
        }

        protected override int NumberOfDiagnosticsInBody { get; } = 4;

        protected override string GetClassBodyToRepeat(int iterationNumber)
        {
            return $@"
        public void SampleMethodA{iterationNumber}()
        {{
            var session = System.Web.HttpContext.Current.Session;
            var sessionId = session.SessionID;
            var useless = System.Web.HttpContext.Current.Session.SessionID.Contains(""Oooops..."");
        }}

        public void SampleMethodB{iterationNumber}()
        {{
            var session = new System.Web.HttpSessionStateWrapper(System.Web.HttpContext.Current.Session);
            var sessionId = session.SessionID;
            var useless = new System.Web.HttpSessionStateWrapper(System.Web.HttpContext.Current.Session).SessionID.Contains(""Oooops..."");
        }}";
        }
    }
}