namespace SampleProjectGenerator.CodeGenerators
{
    public interface IClassCodeGenerator
    {
        ProjectType ProjectType { get; }

        string GetDocumentName();

        string Generate(int desiredNumberOfDiagnostics);
    }
}