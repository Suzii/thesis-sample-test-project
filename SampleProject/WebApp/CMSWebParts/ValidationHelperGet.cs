using CMS.Helpers;

namespace WebApp.CMSWebParts
{
    // file path is important
    public class ValidationHelperGet
    {
        public void SampleMethodA1()
        {
            var a1 = ValidationHelper.GetDouble("", 0);
            var b1 = ValidationHelper.GetDouble("", 0);

            var a2 = ValidationHelper.GetDouble("2", 2);
            var a3 = ValidationHelper.GetDouble("", 0, System.Globalization.CultureInfo.CurrentCulture);
        }

        public void SampleMethodB1()
        {
            var a1 = ValidationHelper.GetDateTime("", System.DateTime.MaxValue);
            var b1 = ValidationHelper.GetDateTime("", System.DateTime.MaxValue);
            var a2 = ValidationHelper.GetDateTime("", System.DateTime.MaxValue, "en-us");
            var a3 = ValidationHelper.GetDateTime("", System.DateTime.MaxValue, System.Globalization.CultureInfo.CurrentCulture);
        }

        public void SampleMethodC1()
        {
            var a1 = ValidationHelper.GetDate("", System.DateTime.MaxValue);
            var a2 = ValidationHelper.GetDate("", System.DateTime.MaxValue, System.Globalization.CultureInfo.CurrentCulture);
        }
    }
}
