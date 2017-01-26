namespace SampleProjectGenerator.CodeGenerators.ConsoleApp.Implementation
{
    public class StringCompareToMethod : BaseConsoleAppClassCodeGenerator
    {
        public override string GetDocumentName()
        {
            return nameof(StringCompareToMethod);
        }

        protected override int NumberOfDiagnosticsInBody { get; } = 2;

        protected override string GetClassBodyToRepeat(int iterationNumber)
        {
            return $@"
        public string SampleMethod{iterationNumber}()
        {{
            // allowed usages
            // var res1 = ""Original string"".CompareTo(""a"", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = ""Original string"".CompareTo(""a"", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = ""a"".CompareTo(""a"");

            var original = ""Original string"";
            var result2 = original.Substring(0).CompareTo(""a"").ToString();
            
            return (result1 < 0) ? result2 : string.Empty;
        }}";
        }
    }
}