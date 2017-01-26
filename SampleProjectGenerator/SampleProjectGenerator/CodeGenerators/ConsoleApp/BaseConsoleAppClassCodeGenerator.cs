namespace SampleProjectGenerator.CodeGenerators.ConsoleApp
{
    public abstract class BaseConsoleAppClassCodeGenerator : BaseClassCodeGenerator
    {
        public abstract override string GetDocumentName();

        public override ProjectType ProjectType { get; } = ProjectType.ConsoleApp;

        protected override string GetClassPrefix()
        {
            return $@"namespace ConsoleApp
{{
    public class {GetDocumentName()}
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