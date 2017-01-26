namespace SampleProjectGenerator.CodeGenerators.ConsoleApp.Implementation
{
    public class StringEqualsMethod : BaseConsoleAppClassCodeGenerator
    {
        public override string GetDocumentName()
        {
            return nameof(StringEqualsMethod);
        }

        protected override int NumberOfDiagnosticsInBody { get; } = 2;

        protected override string GetClassBodyToRepeat(int iterationNumber)
        {
            return $@"
        public string SampleMethod{iterationNumber}()
        {{
            // allowed usages
            // var res1 = ""Original string"".Equals(""a"", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = ""Original string"".Equals(""a"", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = ""a"".Equals(""a"");

            var original = ""Original string"";
            var result2 = original.Substring(0).Equals(""a"").ToString();
            
            return (result1) ? result2 : string.Empty;
        }}";
        }
    }
}