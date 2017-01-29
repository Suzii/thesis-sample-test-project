namespace SampleProjectGenerator.CodeGenerators.ConsoleApp.Implementation
{
    public class ValidationHelperGet : BaseConsoleAppClassCodeGenerator
    {
        public override string GetDocumentName()
        {
            return nameof(ValidationHelperGet);
        }

        protected override int NumberOfDiagnosticsInBody { get; } = 8;
        
        protected override string GetClassPrefix()
        {
            return $@"using System;
using System.Globalization;
using CMS.Helpers;

namespace ConsoleApp.Controllers
{{
    public class {GetDocumentName()}
    {{";
        }

        protected override string GetClassBodyToRepeat(int iterationNumber)
        {
            return $@"
        public void SampleMethodA{iterationNumber}()
        {{
            var a1 = ValidationHelper.GetDouble("""", 0);
            var a1 = ValidationHelper.GetDouble(""2"", 2);
            var a2 = ValidationHelper.GetDouble("""", 0, CultureInfo.CurrentCulture);
        }}

        public void SampleMethodB{iterationNumber}()
        {{
            var a1 = ValidationHelper.GetDateTime("""", DateTime.MaxValue);
            var a2 = ValidationHelper.GetDateTime("""", DateTime.MaxValue, ""en-us"");
            var a3 = ValidationHelper.GetDateTime("""", DateTime.MaxValue, CultureInfo.CurrentCulture);
        }}

        public void SampleMethodC{iterationNumber}()
        {{
            var a1 = ValidationHelper.GetDate("""", DateTime.MaxValue);
            var a3 = ValidationHelper.GetDate("""", DateTime.MaxValue, CultureInfo.CurrentCulture);
        }}";
        }
    }
}