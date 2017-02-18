namespace SampleProjectGenerator.CodeGenerators.BaseClassRules.Implementation
{
    public class PageBase : BaseForBaseClassesCodeGenerator
    {
        public override string GetDocumentName(int index) => $@"Pages\{nameof(PageBase)}{index}.aspx";

        protected override string GenerateSingleClass(int index)
        {
            return $@"
    public partial class PageBase{index}: System.Web.UI.Page
    {{
    }}";
        }
    }
}