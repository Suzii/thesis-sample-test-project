using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleProjectGenerator.CodeGenerators
{
    public abstract class BaseClassCodeGenerator : IClassCodeGenerator
    {
        public abstract  ProjectType ProjectType { get; }

        public abstract string GetDocumentName(int index);

        public string[] GenerateClasses(int desiredNumberOfDiagnosticsPerFile, int numberOfFiles)
        {
            var result = new List<string>();

            for (var i = 0; i < numberOfFiles; i++)
            {
                result.Add(GenerateSingleClass(desiredNumberOfDiagnosticsPerFile, i));
            }

            return result.ToArray();
        }

        private string GenerateSingleClass(int desiredNumberOfDiagnosticsPerFile, int i)
        {
            var result = new StringBuilder();

            result.AppendLine(GetClassPrefix(i));
            var numberOfBodyRepetitions = desiredNumberOfDiagnosticsPerFile / NumberOfDiagnosticsInBody;

            Enumerable.Range(1, numberOfBodyRepetitions)
                .Select(GetClassBodyToRepeat)
                .Aggregate(result, (cur, next) => cur.AppendLine(next));

            result.AppendLine(GetClassSuffix());

           return result.ToString();
        }

        protected abstract int NumberOfDiagnosticsInBody { get; }

        protected abstract string GetClassPrefix(int index);

        protected abstract string GetClassSuffix();

        protected abstract string GetClassBodyToRepeat(int iterationNumber);
    }
}