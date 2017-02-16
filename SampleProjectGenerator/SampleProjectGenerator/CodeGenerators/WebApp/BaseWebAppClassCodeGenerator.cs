namespace SampleProjectGenerator.CodeGenerators.WebApp
{
    public abstract class BaseWebAppClassCodeGenerator : BaseClassCodeGenerator
    {
        public abstract override string GetDocumentName(int index);

        public override ProjectType ProjectType { get; } = ProjectType.WebApp;

        protected override string GetClassPrefix(int index)
        {
            return $@"namespace WebApp
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