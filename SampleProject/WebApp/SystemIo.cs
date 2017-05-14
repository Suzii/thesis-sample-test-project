namespace WebApp
{
    public class SystemIo
    {

        // allowed usages
        public void AllowedExceptionsMethod1()
        {
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod1()
        {
            return System.IO.Stream.Null;
        }

        // forbidden usages
        public System.IO.BinaryReader SampleMethod1(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public char StaticMemberMethod1()
        { 
            return System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod1(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod1()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod1(System.IO.Path.DirectorySeparatorChar);
        }

    }
}
