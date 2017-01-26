using System.Linq;
using System.Text;

namespace SampleProjectGenerator.CodeGenerators
{
    public abstract class BaseClassCodeGenerator : IClassCodeGenerator
    {
        public abstract  ProjectType ProjectType { get; }

        public abstract string GetDocumentName();

        public string Generate(int desiredNumberOfDiagnostics)
        {
            var result = new StringBuilder();

            result.AppendLine(GetClassPrefix());
            var numberOfBodyRepetitions = desiredNumberOfDiagnostics / NumberOfDiagnosticsInBody;

            Enumerable.Range(1, numberOfBodyRepetitions)
                .Select(GetClassBodyToRepeat)
                .Aggregate(result, (cur, next) => cur.AppendLine(next));
            
            result.AppendLine(GetClassSuffix());

            return result.ToString();
        }

        protected abstract int NumberOfDiagnosticsInBody { get; }

        protected abstract string GetClassPrefix();

        protected abstract string GetClassSuffix();

        protected abstract string GetClassBodyToRepeat(int iterationNumber);
    }
}