using System;
using System.Globalization;

namespace WebApp
{
    public class StringAndCulture
    {
        public void StringManipulationMethods()
        {
            // allowed usages
            var resultA = "Original string".ToLowerInvariant();
            var resultB = "Original string".ToLower(CultureInfo.CurrentCulture);
            var resultC = "Original string".ToUpperInvariant();
            var resultD = "Original string".ToUpper(CultureInfo.CurrentCulture);

            // usages raising diagnostic 
            var result1 = "Original string".ToUpper();
            var result2 = "Original string".ToLower();

            var original = "Original string";
            var result3 = original.Substring(0).ToUpper().ToString();
            var result4 = original.Substring(0).ToLower().ToString();
            var result5 = original?.Substring(0)?.ToLower().ToString();
        }

        public void StringEqualsMethod()
        {
            // allowed usages
            var resultA = "Original string".Equals("a", StringComparison.InvariantCultureIgnoreCase);

            // usages raising diagnostic 
            var result1 = "a".Equals("a");

            var original = "Original string";
            var result2 = original.Substring(0).Equals("a").ToString();
            var result3 = original?.Substring(0)?.Equals("a").ToString();
        }
        
        public void StringCompareToMethod()
        {
            // usages raising diagnostic 
            var result1 = "a".CompareTo("a");

            var original = "Original string";
            var result2 = original.CompareTo("a").ToString();
        }

        public void StringStartsAndEndsWithMethods()
        {
            // allowed usages
            var resultA = "Original string".StartsWith("a", StringComparison.InvariantCultureIgnoreCase);
            var resultB = "Original string".StartsWith("a", false, CultureInfo.CurrentCulture);
            var resultC = "Original string".EndsWith("a", StringComparison.InvariantCultureIgnoreCase);
            var resultD = "Original string".EndsWith("a", false, CultureInfo.CurrentCulture);

            // usages raising diagnostic 
            var result1 = "Original string".StartsWith("a");
            var result2 = "Original string".EndsWith("a");

            var original = "Original string";
            var result3 = original.Substring(0).StartsWith("a").ToString();
            var result4 = original.Substring(0).EndsWith("a").ToString();
            var result5 = original?.Substring(0)?.EndsWith("a").ToString();
        }

        public void SampleMethod1()
        {
            // allowed usages
            var resultA = "Original string".IndexOf("a", StringComparison.InvariantCultureIgnoreCase);
            var resultB = "Original string".IndexOf('a');
            var resultC = "Original string".IndexOf('a', 0);
            var resultD = "Original string".IndexOf('a', 0, 1);
            var resultE = "Original string".LastIndexOf("a", StringComparison.InvariantCultureIgnoreCase);
            var resultF = "Original string".LastIndexOf('a');
            var resultG = "Original string".LastIndexOf('a', 0);
            var resultH = "Original string".LastIndexOf('a', 0, 1);

            // usages raising diagnostic 
            var result1 = "Original string".IndexOf("a");
            var result2 = "Original string".LastIndexOf("a");

            var original = "Original string";
            var result3 = original.Substring(0).IndexOf("a").ToString();
            var result4 = original.Substring(0).LastIndexOf("a").ToString();
            var result5 = original?.Substring(0)?.LastIndexOf("a").ToString();
        }

        public void StringCompareStaticMethod()
        {
            // allowed usages
            var resultA = string.Compare("a", "b", false, CultureInfo.CurrentCulture);
            var resultB = string.Compare("a", "b", CultureInfo.CurrentCulture, CompareOptions.IgnoreCase);
            var resultC = string.Compare("a", "b", StringComparison.InvariantCultureIgnoreCase);
            var resultD = string.Compare("a", 0, "b", 1, 1, false, CultureInfo.CurrentCulture);
            var resultE = string.Compare("a", 0, "b", 1, 1, StringComparison.InvariantCultureIgnoreCase);

            // usages raising diagnostic 
            var result1 = string.Compare("a", "aa");
            var result2 = string.Compare("a", "aa", true);
            var result3 = string.Compare("a", "aa", false);
            var result4 = string.Compare("a", 0, "aa", 0, 1, true);
            var result5 = string.Compare("a", 0, "aa", 0, 1, false);
        }
    }
}