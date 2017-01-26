using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using SampleProjectGenerator.CodeGenerators;

namespace SampleProjectGenerator
{
    internal class Program
    {
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

        private static void Main(string[] args)
        {
            var sampleProjectFolder = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\SampleProject"));
            var classCodeGenerators = GetAllClassCodeGenerators();

            foreach (var codeGenerator in classCodeGenerators)
            {
                var documentPath = Path.Combine(sampleProjectFolder, RelativeDocumentPaths.Get(codeGenerator.ProjectType), codeGenerator.GetDocumentName() + ".cs");
                File.WriteAllText(documentPath, codeGenerator.Generate(1000));
            }

            Console.WriteLine($"Project files generated to {sampleProjectFolder}");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
