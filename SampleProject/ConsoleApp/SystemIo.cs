namespace ConsoleApp
{
    public class SystemIo
    {

        public void AllowedExceptionsMethod1()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod1()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod1(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod1()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
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

        public void AllowedExceptionsMethod2()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod2()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod2(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod2()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod2(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod2()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod2(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod3()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod3()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod3(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod3()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod3(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod3()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod3(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod4()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod4()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod4(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod4()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod4(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod4()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod4(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod5()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod5()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod5(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod5()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod5(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod5()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod5(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod6()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod6()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod6(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod6()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod6(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod6()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod6(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod7()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod7()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod7(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod7()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod7(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod7()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod7(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod8()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod8()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod8(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod8()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod8(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod8()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod8(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod9()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod9()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod9(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod9()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod9(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod9()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod9(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod10()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod10()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod10(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod10()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod10(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod10()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod10(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod11()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod11()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod11(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod11()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod11(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod11()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod11(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod12()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod12()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod12(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod12()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod12(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod12()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod12(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod13()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod13()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod13(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod13()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod13(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod13()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod13(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod14()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod14()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod14(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod14()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod14(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod14()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod14(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod15()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod15()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod15(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod15()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod15(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod15()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod15(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod16()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod16()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod16(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod16()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod16(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod16()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod16(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod17()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod17()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod17(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod17()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod17(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod17()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod17(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod18()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod18()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod18(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod18()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod18(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod18()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod18(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod19()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod19()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod19(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod19()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod19(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod19()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod19(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod20()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod20()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod20(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod20()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod20(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod20()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod20(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod21()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod21()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod21(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod21()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod21(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod21()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod21(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod22()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod22()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod22(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod22()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod22(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod22()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod22(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod23()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod23()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod23(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod23()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod23(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod23()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod23(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod24()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod24()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod24(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod24()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod24(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod24()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod24(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod25()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod25()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod25(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod25()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod25(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod25()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod25(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod26()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod26()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod26(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod26()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod26(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod26()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod26(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod27()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod27()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod27(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod27()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod27(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod27()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod27(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod28()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod28()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod28(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod28()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod28(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod28()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod28(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod29()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod29()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod29(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod29()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod29(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod29()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod29(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod30()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod30()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod30(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod30()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod30(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod30()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod30(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod31()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod31()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod31(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod31()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod31(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod31()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod31(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod32()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod32()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod32(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod32()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod32(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod32()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod32(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod33()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod33()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod33(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod33()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod33(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod33()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod33(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod34()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod34()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod34(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod34()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod34(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod34()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod34(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod35()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod35()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod35(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod35()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod35(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod35()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod35(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod36()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod36()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod36(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod36()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod36(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod36()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod36(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod37()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod37()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod37(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod37()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod37(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod37()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod37(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod38()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod38()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod38(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod38()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod38(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod38()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod38(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod39()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod39()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod39(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod39()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod39(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod39()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod39(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod40()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod40()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod40(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod40()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod40(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod40()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod40(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod41()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod41()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod41(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod41()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod41(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod41()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod41(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod42()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod42()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod42(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod42()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod42(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod42()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod42(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod43()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod43()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod43(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod43()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod43(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod43()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod43(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod44()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod44()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod44(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod44()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod44(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod44()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod44(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod45()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod45()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod45(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod45()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod45(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod45()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod45(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod46()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod46()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod46(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod46()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod46(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod46()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod46(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod47()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod47()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod47(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod47()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod47(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod47()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod47(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod48()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod48()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod48(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod48()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod48(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod48()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod48(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod49()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod49()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod49(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod49()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod49(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod49()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod49(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod50()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod50()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod50(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod50()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod50(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod50()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod50(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod51()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod51()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod51(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod51()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod51(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod51()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod51(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod52()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod52()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod52(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod52()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod52(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod52()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod52(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod53()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod53()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod53(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod53()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod53(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod53()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod53(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod54()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod54()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod54(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod54()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod54(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod54()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod54(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod55()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod55()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod55(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod55()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod55(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod55()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod55(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod56()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod56()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod56(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod56()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod56(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod56()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod56(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod57()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod57()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod57(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod57()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod57(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod57()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod57(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod58()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod58()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod58(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod58()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod58(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod58()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod58(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod59()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod59()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod59(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod59()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod59(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod59()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod59(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod60()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod60()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod60(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod60()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod60(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod60()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod60(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod61()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod61()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod61(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod61()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod61(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod61()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod61(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod62()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod62()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod62(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod62()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod62(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod62()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod62(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod63()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod63()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod63(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod63()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod63(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod63()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod63(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod64()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod64()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod64(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod64()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod64(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod64()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod64(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod65()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod65()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod65(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod65()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod65(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod65()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod65(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod66()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod66()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod66(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod66()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod66(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod66()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod66(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod67()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod67()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod67(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod67()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod67(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod67()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod67(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod68()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod68()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod68(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod68()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod68(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod68()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod68(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod69()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod69()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod69(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod69()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod69(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod69()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod69(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod70()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod70()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod70(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod70()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod70(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod70()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod70(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod71()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod71()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod71(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod71()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod71(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod71()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod71(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod72()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod72()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod72(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod72()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod72(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod72()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod72(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod73()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod73()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod73(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod73()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod73(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod73()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod73(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod74()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod74()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod74(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod74()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod74(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod74()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod74(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod75()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod75()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod75(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod75()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod75(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod75()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod75(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod76()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod76()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod76(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod76()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod76(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod76()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod76(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod77()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod77()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod77(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod77()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod77(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod77()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod77(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod78()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod78()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod78(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod78()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod78(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod78()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod78(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod79()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod79()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod79(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod79()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod79(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod79()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod79(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod80()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod80()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod80(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod80()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod80(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod80()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod80(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod81()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod81()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod81(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod81()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod81(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod81()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod81(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod82()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod82()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod82(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod82()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod82(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod82()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod82(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod83()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod83()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod83(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod83()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod83(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod83()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod83(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod84()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod84()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod84(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod84()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod84(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod84()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod84(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod85()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod85()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod85(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod85()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod85(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod85()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod85(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod86()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod86()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod86(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod86()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod86(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod86()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod86(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod87()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod87()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod87(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod87()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod87(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod87()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod87(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod88()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod88()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod88(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod88()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod88(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod88()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod88(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod89()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod89()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod89(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod89()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod89(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod89()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod89(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod90()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod90()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod90(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod90()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod90(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod90()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod90(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod91()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod91()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod91(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod91()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod91(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod91()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod91(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod92()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod92()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod92(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod92()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod92(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod92()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod92(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod93()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod93()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod93(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod93()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod93(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod93()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod93(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod94()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod94()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod94(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod94()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod94(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod94()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod94(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod95()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod95()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod95(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod95()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod95(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod95()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod95(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod96()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod96()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod96(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod96()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod96(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod96()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod96(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod97()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod97()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod97(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod97()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod97(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod97()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod97(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod98()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod98()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod98(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod98()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod98(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod98()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod98(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod99()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod99()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod99(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod99()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod99(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod99()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod99(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod100()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod100()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod100(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod100()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod100(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod100()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod100(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod101()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod101()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod101(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod101()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod101(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod101()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod101(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod102()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod102()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod102(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod102()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod102(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod102()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod102(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod103()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod103()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod103(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod103()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod103(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod103()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod103(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod104()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod104()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod104(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod104()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod104(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod104()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod104(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod105()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod105()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod105(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod105()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod105(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod105()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod105(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod106()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod106()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod106(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod106()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod106(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod106()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod106(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod107()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod107()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod107(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod107()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod107(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod107()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod107(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod108()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod108()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod108(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod108()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod108(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod108()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod108(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod109()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod109()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod109(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod109()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod109(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod109()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod109(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod110()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod110()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod110(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod110()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod110(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod110()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod110(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod111()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod111()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod111(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod111()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod111(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod111()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod111(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod112()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod112()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod112(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod112()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod112(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod112()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod112(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod113()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod113()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod113(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod113()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod113(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod113()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod113(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod114()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod114()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod114(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod114()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod114(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod114()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod114(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod115()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod115()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod115(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod115()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod115(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod115()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod115(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod116()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod116()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod116(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod116()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod116(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod116()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod116(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod117()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod117()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod117(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod117()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod117(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod117()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod117(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod118()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod118()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod118(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod118()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod118(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod118()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod118(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod119()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod119()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod119(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod119()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod119(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod119()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod119(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod120()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod120()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod120(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod120()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod120(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod120()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod120(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod121()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod121()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod121(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod121()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod121(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod121()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod121(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod122()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod122()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod122(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod122()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod122(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod122()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod122(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod123()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod123()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod123(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod123()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod123(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod123()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod123(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod124()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod124()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod124(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod124()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod124(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod124()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod124(System.IO.Path.DirectorySeparatorChar);
        }

        public void AllowedExceptionsMethod125()
        {
            // Possible false positives 
            throw new System.IO.IOException("Ooops...");
            throw new System.IO.DirectoryNotFoundException("Ooops...");
        }

        public System.IO.Stream AllowedStreamMethod125()
        {
            // Possible false positive
            return System.IO.Stream.Null;
        }

        public System.IO.BinaryReader SampleMethod125(System.IO.BinaryReader param)
        { 
            var result = new System.IO.BinaryReader(System.IO.Stream.Null);
            System.IO.BinaryReader badVariable = param;
            return result;
        }

        public void StaticMemberMethod125()
        { 
            var badVariable1 = System.IO.Path.DirectorySeparatorChar;
        }

        public static void HelperMethod125(char c) 
        {
            // Do nothing
        }

        public void ComplexNestedMemberAccessMethod125()
        {
            var directory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("./some/path"));
            HelperMethod125(System.IO.Path.DirectorySeparatorChar);
        }

    }
}
