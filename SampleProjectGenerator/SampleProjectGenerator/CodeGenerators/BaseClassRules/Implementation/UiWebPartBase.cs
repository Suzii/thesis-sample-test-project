namespace SampleProjectGenerator.CodeGenerators.BaseClassRules.Implementation
{
    public class UiWebPartBase : BaseForBaseClassesCodeGenerator
    {
        public override string GetDocumentName(int index) => $@"CMSModules\AdminControls\Controls\UIControls\{nameof(UiWebPartBase)}{index}";

        protected override string GenerateSingleClass(int index)
        {
            return $@"
    public class UiWebPartBase{index}: System.Web.UI.WebControls.WebParts.WebPart
    {{
    }}";
        }
    }
}