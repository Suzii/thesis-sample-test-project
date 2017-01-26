using System;

namespace SampleProjectGenerator
{
    public class RelativeDocumentPaths
    {
        public const string CONSOLE_APP = @"SampleTestProject\CsSamples";

        // documents in this path required dependency on System.Web
        public const string WEB_APP = @"WebApplication1\Controllers";

        public static string GetRelativePath(ProjectType projectType)
        {
            switch (projectType)
            {
                case ProjectType.ConsoleApp:
                    return CONSOLE_APP;
                case ProjectType.WebApp:
                    return WEB_APP;
                default:
                    throw new ArgumentOutOfRangeException(nameof(projectType));
            }
        }
    }
}