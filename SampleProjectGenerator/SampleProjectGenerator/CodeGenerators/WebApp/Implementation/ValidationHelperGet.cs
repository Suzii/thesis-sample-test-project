﻿namespace SampleProjectGenerator.CodeGenerators.WebApp.Implementation
{
    public class ValidationHelperGet : BaseWebAppClassCodeGenerator
    {
        public override string GetDocumentName(int index)
        {
            return $"{nameof(ValidationHelperGet)}{index}";
        }

        protected override int NumberOfDiagnosticsInBody { get; } = 2;

        protected override string GetClassBodyToRepeat(int iterationNumber)
        {
            return $@"
        public void SampleMethodA{iterationNumber}()
        {{
            var a0 = CMS.Helpers.ValidationHelper.GetDouble(""0"", 0);
            var a1 = CMS.Helpers.ValidationHelper.GetDouble(""0"", 0, ""en-us"");
            var a2 = CMS.Helpers.ValidationHelper.GetDouble(""0"", 0, CultureInfo.CurrentUICulture);
        }}

        public void SampleMethodB{iterationNumber}()
        {{
            var a0 = CMS.Helpers.ValidationHelper.GetDecimal(""0"", 0);
            var a2 = CMS.Helpers.ValidationHelper.GetDecimal(""0"", 0, CultureInfo.CurrentUICulture);
        }}

        public void SampleMethodC{iterationNumber}()
        {{
            var a0 = CMS.Helpers.ValidationHelper.GetDateTime(""0"", DateTime.MaxValue);
            var a1 = CMS.Helpers.ValidationHelper.GetDateTime(""0"", DateTime.MaxValue, ""en-us"");
            var a2 = CMS.Helpers.ValidationHelper.GetDateTime(""0"", DateTime.MaxValue, CultureInfo.CurrentUICulture);
        }}";
        }
    }
}