using System;
using System.IO;
using System.Linq;
using SampleProjectGenerator.CodeGenerators;

namespace SampleProjectGenerator
{
    class Program
    {
        private const string projectFolder = @"C:\Users\zuzanad\code\thesis\thesis-sample-test-project\";

        static void Main(string[] args)
        {
            // get all implementations
            var generatorInterface = typeof(IClassCodeGenerator);
            var codeGenerators = generatorInterface.Assembly
                .GetTypes()
                .Where(type => generatorInterface.IsAssignableFrom(type) && !type.IsAbstract)
                .Select(Activator.CreateInstance)
                .Cast<IClassCodeGenerator>();

            foreach (var codeGenerator in codeGenerators)
            {
                var documentPath = Path.Combine(projectFolder, RelativeDocumentPaths.GetRelativePath(codeGenerator.ProjectType), codeGenerator.GetDocumentName() + ".cs");
                File.WriteAllText(documentPath, codeGenerator.Generate(1000));
            }
        }
    }
}
