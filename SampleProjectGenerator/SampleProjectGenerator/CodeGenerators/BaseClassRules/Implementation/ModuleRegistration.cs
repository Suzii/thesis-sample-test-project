namespace SampleProjectGenerator.CodeGenerators.BaseClassRules.Implementation
{
    public class ModuleRegistration : BaseForBaseClassesCodeGenerator
    {
        public override string GetDocumentName(int index) => $@"Modules\{nameof(ModuleRegistration)}{index}";

        protected override string GenerateSingleClass(int index)
        {
            return $@"
    public class ModuleRegistration{index} : CMS.DataEngine.Module
    {{
        public MyModule(CMS.Core.ModuleMetadata metadata, bool isInstallable = false) : base(metadata, isInstallable)
        {{
        }}

        public MyModule(string moduleName, bool isInstallable = false) : base(moduleName, isInstallable)
        {{
        }}
    }}";
        }
    }
}