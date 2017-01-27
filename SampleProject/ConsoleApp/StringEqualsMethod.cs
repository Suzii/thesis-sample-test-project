namespace ConsoleApp
{
    public class StringEqualsMethod
    {

        public string SampleMethodInstanceVariant1()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant1()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant2()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant2()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant3()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant3()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant4()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant4()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant5()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant5()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant6()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant6()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant7()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant7()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant8()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant8()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant9()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant9()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant10()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant10()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant11()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant11()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant12()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant12()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant13()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant13()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant14()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant14()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant15()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant15()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant16()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant16()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant17()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant17()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant18()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant18()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant19()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant19()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant20()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant20()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant21()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant21()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant22()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant22()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant23()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant23()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant24()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant24()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant25()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant25()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant26()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant26()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant27()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant27()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant28()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant28()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant29()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant29()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant30()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant30()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant31()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant31()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant32()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant32()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant33()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant33()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant34()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant34()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant35()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant35()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant36()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant36()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant37()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant37()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant38()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant38()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant39()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant39()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant40()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant40()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant41()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant41()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant42()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant42()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant43()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant43()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant44()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant44()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant45()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant45()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant46()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant46()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant47()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant47()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant48()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant48()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant49()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant49()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant50()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant50()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant51()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant51()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant52()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant52()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant53()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant53()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant54()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant54()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant55()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant55()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant56()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant56()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant57()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant57()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant58()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant58()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant59()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant59()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant60()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant60()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant61()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant61()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant62()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant62()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant63()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant63()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant64()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant64()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant65()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant65()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant66()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant66()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant67()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant67()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant68()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant68()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant69()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant69()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant70()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant70()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant71()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant71()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant72()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant72()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant73()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant73()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant74()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant74()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant75()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant75()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant76()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant76()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant77()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant77()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant78()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant78()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant79()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant79()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant80()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant80()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant81()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant81()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant82()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant82()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant83()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant83()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant84()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant84()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant85()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant85()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant86()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant86()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant87()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant87()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant88()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant88()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant89()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant89()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant90()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant90()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant91()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant91()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant92()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant92()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant93()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant93()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant94()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant94()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant95()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant95()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant96()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant96()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant97()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant97()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant98()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant98()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant99()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant99()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant100()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant100()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant101()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant101()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant102()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant102()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant103()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant103()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant104()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant104()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant105()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant105()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant106()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant106()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant107()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant107()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant108()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant108()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant109()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant109()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant110()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant110()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant111()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant111()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant112()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant112()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant113()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant113()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant114()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant114()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant115()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant115()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant116()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant116()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant117()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant117()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant118()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant118()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant119()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant119()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant120()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant120()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant121()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant121()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant122()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant122()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant123()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant123()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant124()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant124()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant125()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant125()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant126()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant126()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant127()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant127()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant128()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant128()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant129()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant129()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant130()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant130()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant131()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant131()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant132()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant132()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant133()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant133()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant134()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant134()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant135()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant135()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant136()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant136()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant137()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant137()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant138()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant138()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant139()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant139()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant140()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant140()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant141()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant141()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant142()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant142()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant143()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant143()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant144()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant144()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant145()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant145()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant146()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant146()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant147()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant147()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant148()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant148()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant149()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant149()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant150()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant150()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant151()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant151()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant152()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant152()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant153()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant153()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant154()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant154()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant155()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant155()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant156()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant156()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant157()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant157()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant158()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant158()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant159()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant159()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant160()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant160()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant161()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant161()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant162()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant162()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant163()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant163()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant164()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant164()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant165()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant165()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant166()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant166()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant167()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant167()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant168()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant168()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant169()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant169()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant170()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant170()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant171()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant171()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant172()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant172()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant173()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant173()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant174()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant174()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant175()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant175()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant176()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant176()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant177()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant177()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant178()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant178()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant179()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant179()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant180()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant180()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant181()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant181()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant182()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant182()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant183()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant183()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant184()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant184()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant185()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant185()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant186()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant186()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant187()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant187()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant188()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant188()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant189()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant189()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant190()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant190()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant191()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant191()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant192()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant192()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant193()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant193()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant194()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant194()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant195()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant195()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant196()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant196()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant197()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant197()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant198()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant198()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant199()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant199()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant200()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant200()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant201()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant201()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant202()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant202()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant203()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant203()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant204()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant204()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant205()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant205()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant206()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant206()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant207()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant207()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant208()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant208()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant209()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant209()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant210()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant210()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant211()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant211()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant212()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant212()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant213()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant213()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant214()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant214()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant215()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant215()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant216()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant216()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant217()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant217()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant218()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant218()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant219()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant219()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant220()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant220()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant221()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant221()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant222()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant222()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant223()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant223()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant224()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant224()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant225()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant225()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant226()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant226()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant227()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant227()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant228()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant228()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant229()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant229()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant230()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant230()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant231()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant231()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant232()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant232()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant233()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant233()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant234()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant234()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant235()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant235()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant236()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant236()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant237()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant237()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant238()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant238()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant239()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant239()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant240()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant240()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant241()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant241()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant242()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant242()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant243()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant243()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant244()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant244()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant245()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant245()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant246()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant246()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant247()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant247()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant248()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant248()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant249()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant249()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodInstanceVariant250()
        {
            // allowed usages
            // var res1 = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);
            // var res2 = "Original string".Equals("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

        public string SampleMethodStaticVariant250()
        {
            // allowed usages
            // var res1 = string.Equals("a", "b", StringComparison.InvariantCultureIgnoreCase);
            
            // usages raising diagnostic 
            var result1 = string.Equals("a", "b");
            var result2 = string.Equals("a", "b").ToString();
            
            return (result1) ? result2 : string.Empty;
        }

    }
}
