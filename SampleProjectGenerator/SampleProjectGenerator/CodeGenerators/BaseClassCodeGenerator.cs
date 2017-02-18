﻿using System.Linq;
using System.Text;

namespace SampleProjectGenerator.CodeGenerators
{
    public abstract class BaseClassCodeGenerator : IClassCodeGenerator
    {
        public abstract  ProjectType ProjectType { get; }

        public abstract string GetDocumentName(int index);

        public string[] GenerateClasses(int desiredNumberOfDiagnostics, int numberOfFiles)
        {
            var numberOfDiagnosticsPerFile = desiredNumberOfDiagnostics/numberOfFiles;
            return Enumerable.Range(1, numberOfFiles).Select(index => GenerateSingleClass(numberOfDiagnosticsPerFile, index)).ToArray();
        }

        private string GenerateSingleClass(int desiredNumberOfDiagnosticsPerFile, int index)
        {
            var result = new StringBuilder();

            result.AppendLine(GetClassPrefix(index));
            var numberOfBodyRepetitions = desiredNumberOfDiagnosticsPerFile/NumberOfDiagnosticsInBody;

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