namespace ConsoleApp
{
    public class StringStartsWithEndsWithMethod
    {

        public bool SampleMethod1()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod2()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod3()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod4()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod5()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod6()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod7()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod8()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod9()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod10()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod11()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod12()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod13()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod14()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod15()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod16()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod17()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod18()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod19()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod20()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod21()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod22()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod23()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod24()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod25()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod26()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod27()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod28()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod29()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod30()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod31()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod32()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod33()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod34()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod35()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod36()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod37()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod38()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod39()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod40()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod41()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod42()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod43()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod44()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod45()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod46()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod47()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod48()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod49()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod50()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod51()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod52()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod53()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod54()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod55()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod56()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod57()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod58()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod59()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod60()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod61()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod62()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod63()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod64()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod65()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod66()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod67()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod68()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod69()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod70()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod71()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod72()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod73()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod74()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod75()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod76()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod77()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod78()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod79()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod80()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod81()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod82()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod83()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod84()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod85()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod86()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod87()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod88()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod89()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod90()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod91()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod92()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod93()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod94()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod95()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod96()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod97()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod98()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod99()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod100()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod101()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod102()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod103()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod104()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod105()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod106()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod107()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod108()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod109()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod110()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod111()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod112()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod113()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod114()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod115()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod116()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod117()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod118()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod119()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod120()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod121()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod122()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod123()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod124()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod125()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod126()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod127()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod128()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod129()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod130()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod131()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod132()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod133()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod134()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod135()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod136()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod137()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod138()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod139()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod140()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod141()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod142()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod143()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod144()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod145()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod146()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod147()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod148()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod149()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod150()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod151()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod152()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod153()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod154()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod155()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod156()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod157()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod158()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod159()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod160()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod161()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod162()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod163()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod164()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod165()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod166()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod167()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod168()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod169()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod170()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod171()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod172()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod173()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod174()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod175()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod176()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod177()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod178()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod179()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod180()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod181()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod182()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod183()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod184()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod185()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod186()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod187()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod188()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod189()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod190()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod191()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod192()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod193()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod194()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod195()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod196()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod197()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod198()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod199()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod200()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod201()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod202()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod203()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod204()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod205()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod206()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod207()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod208()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod209()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod210()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod211()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod212()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod213()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod214()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod215()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod216()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod217()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod218()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod219()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod220()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod221()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod222()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod223()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod224()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod225()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod226()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod227()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod228()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod229()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod230()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod231()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod232()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod233()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod234()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod235()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod236()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod237()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod238()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod239()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod240()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod241()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod242()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod243()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod244()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod245()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod246()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod247()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod248()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod249()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

        public bool SampleMethod250()
        {
            // allowed usages
            // var res1 = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            // var res1 = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            // var res1 = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);
            
            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            
            return result1 || result2 && (result3 + result4) != "falsefalse";
        }

    }
}
