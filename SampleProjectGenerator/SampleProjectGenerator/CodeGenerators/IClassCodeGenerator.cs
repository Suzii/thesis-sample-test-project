namespace SampleProjectGenerator.CodeGenerators
{
    public interface IClassCodeGenerator
    {
        ProjectType ProjectType { get; }

        string GetDocumentName(int index);

        string[] GenerateClasses(int desiredNumberOfDiagnostics, int numberOfFiles);
    }
}