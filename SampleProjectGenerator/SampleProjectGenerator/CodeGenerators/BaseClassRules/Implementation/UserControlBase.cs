namespace SampleProjectGenerator.CodeGenerators.BaseClassRules.Implementation
{
    public class UserControlBase : BaseForBaseClassesCodeGenerator
    {
        public override string GetDocumentName(int index) => $@"Pages\{nameof(UserControlBase)}{index}.ascx";

        protected override string GenerateSingleClass(int index)
        {
            return $@"
    public partial class UserControlBase{index}: System.Web.UI.UserControl
    {{
    }}";
        }
    }
}