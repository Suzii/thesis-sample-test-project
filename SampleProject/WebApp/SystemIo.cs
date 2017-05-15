namespace WebApp
{
    public class SystemIo
    {
        // allowed usages
        public void AllowedUsageOfIoExceptions()
        {
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedUsageOfStream()
        {
            return System.IO.Stream.Null;
        }

        // forbidden usages - no code fix provided
        public System.IO.BinaryReader ForbiddenUsage1(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public char ForbiddenUsage2()
        { 
            return System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod(char c) 
        {
            // Do nothing
        }

        public void ComplexForbiddenUsage1()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod(System.IO.Path.DirectorySeparatorChar);
        }
    }
}
