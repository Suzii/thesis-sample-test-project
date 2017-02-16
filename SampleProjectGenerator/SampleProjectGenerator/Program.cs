using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using SampleProjectGenerator.CodeGenerators;

namespace SampleProjectGenerator
{
    internal class Program
    {
        private static readonly int DesiredNumberOfDiagnosticsPerFile = 1000;

        private static readonly int NumberOfFilesPerAnalyzer = 1;
        
        private static void Main(string[] args)
        {
            var sampleProjectFolder = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\SampleProject"));
            var classCodeGenerators = GetAllClassCodeGenerators();

            foreach (var codeGenerator in classCodeGenerators)
            {
                var generatedClasses = codeGenerator.GenerateClasses(DesiredNumberOfDiagnosticsPerFile, NumberOfFilesPerAnalyzer);

                for (int i = 0; i < NumberOfFilesPerAnalyzer; i++)
                {
                    var documentPath = Path.Combine(sampleProjectFolder, RelativeDocumentPaths.Get(codeGenerator.ProjectType), codeGenerator.GetDocumentName(i) + ".cs");
                    File.WriteAllText(documentPath, generatedClasses[i]);
                }
            }

            Console.WriteLine($"Project files generated to {sampleProjectFolder}");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private static IEnumerable<IClassCodeGenerator> GetAllClassCodeGenerators()
        {
            var generatorInterface = typeof(IClassCodeGenerator);
            var codeGenerators = generatorInterface.Assembly
                .GetTypes()
                .Where(type => generatorInterface.IsAssignableFrom(type) && !type.IsAbstract)
                .Select(Activator.CreateInstance)
                .Cast<IClassCodeGenerator>();

            return codeGenerators;
        }
    }
}
