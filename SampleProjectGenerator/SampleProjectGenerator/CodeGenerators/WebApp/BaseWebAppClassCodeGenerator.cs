namespace SampleProjectGenerator.CodeGenerators.WebApp
{
    public abstract class BaseWebAppClassCodeGenerator : BaseClassCodeGenerator
    {
        public abstract override string GetDocumentName();

        public override ProjectType ProjectType { get; } = ProjectType.WebApp;

        protected override string GetClassPrefix()
        {
            return $@"namespace WebApp
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