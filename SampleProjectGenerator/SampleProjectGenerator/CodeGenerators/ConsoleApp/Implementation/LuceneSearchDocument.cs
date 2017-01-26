namespace SampleProjectGenerator.CodeGenerators.ConsoleApp.Implementation
{
    public class LuceneSearchDocument : BaseConsoleAppClassCodeGenerator
    {
        public override string GetDocumentName()
        {
            return nameof(LuceneSearchDocument);
        }

        protected override int NumberOfDiagnosticsInBody { get; } = 3;

        protected override string GetClassPrefix()
        {
            return $@"using CMS.Search.Lucene3; 

namespace SampleTestProject.CsSamples
{{
    public class {GetDocumentName()}
    {{
 ";
        }

        protected override string GetClassBodyToRepeat(int iterationNumber)
        {
            return $@"
        private LuceneSearchDocument Method{iterationNumber}(LuceneSearchDocument doc)
        {{
            LuceneSearchDocument badVariable = null;

            return new LuceneSearchDocument();
        }}";
        }
    }
}