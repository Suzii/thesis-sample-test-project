namespace SampleProjectGenerator.CodeGenerators.BaseClassRules.Implementation
{
    public class WebPartBase : BaseForBaseClassesCodeGenerator
    {
        public override string GetDocumentName(int index) => $@"CMSWebParts\{nameof(WebPartBase)}{index}";

        protected override string GenerateSingleClass(int index)
        {
            return $@"
    public class WebPartBase{index}: System.Web.UI.WebControls.WebParts.WebPart
    {{
    }}";
        }
    }
}