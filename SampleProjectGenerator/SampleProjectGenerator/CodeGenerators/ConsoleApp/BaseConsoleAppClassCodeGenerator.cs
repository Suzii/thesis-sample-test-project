namespace SampleProjectGenerator.CodeGenerators.ConsoleApp
{
    public abstract class BaseConsoleAppClassCodeGenerator : BaseClassCodeGenerator
    {
        public abstract override string GetDocumentName(int index);

        public override ProjectType ProjectType { get; } = ProjectType.ConsoleApp;

        protected override string GetClassPrefix(int index)
        {
            return $@"namespace ConsoleApp
{{
    public class {GetDocumentName(index)}
    {{";
        }

        protected override string GetClassSuffix()
        {
            return @"
    }
}";
        }
    }
}