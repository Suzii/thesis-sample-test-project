namespace SampleProjectGenerator.CodeGenerators.ConsoleApp.Implementation
{
    public class LuceneSearchDocument : BaseConsoleAppClassCodeGenerator
    {
        public override string GetDocumentName(int index)
        {
            return $"{nameof(LuceneSearchDocument)}{index}";
        }

        protected override int NumberOfDiagnosticsInBody { get; } = 3;

        protected override string GetClassPrefix(int index)
        {
            return $@"using CMS.Search.Lucene3; 

namespace SampleTestProject.CsSamples
{{
    public class {GetDocumentName(index)}
    {{
 ";
        }

        protected override string GetClassBodyToRepeat(int iterationNumber)
        {
            return $@"
        private LuceneSearchDocument Method{iterationNumber}(LuceneSearchDocument doc)
        {{
            LuceneSearchDocument badVariable = new LuceneSearchDocument();

            return new System.Random().Next(2) < 1 ? null : new LuceneSearchDocument();
        }}";
        }
    }
}