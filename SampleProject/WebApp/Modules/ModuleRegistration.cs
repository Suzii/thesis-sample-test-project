namespace WebApp.Modules
{
    public class ModuleRegistration : CMS.DataEngine.Module
    {
        public ModuleRegistration(CMS.Core.ModuleMetadata metadata, bool isInstallable = false) : base(metadata, isInstallable)
        {
        }

        public ModuleRegistration(string moduleName, bool isInstallable = false) : base(moduleName, isInstallable)
        {
        }
    }
}
