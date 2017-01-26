namespace SampleProjectGenerator.CodeGenerators.ConsoleApp.Implementation
{
    public class StringEqualsStaticMethod : BaseConsoleAppClassCodeGenerator
    {
        public override string GetDocumentName()
        {
            return nameof(StringEqualsStaticMethod);
        }

        protected override int NumberOfDiagnosticsInBody { get; } = 2;

        protected override string GetClassBodyToRepeat(int iterationNumber)
        {
            return $@"
        public string SampleMethod{iterationNumber}()
        {{
            // allowed usages
            // var res1 = string.Equals(""a"", ""b"", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals(""a"", ""b"");
            var result2 = string.Equals(""a"", ""b"").ToString();
            
            return (result1) ? result2 : string.Empty;
        }}";
        }
    }
}