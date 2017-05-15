namespace WebApp
{
    public class CmsApiReplacements
    {
        public void HttpSessionSessionId()
        {
            var session = System.Web.HttpContext.Current.Session;
            var sessionId = session.SessionID;
            var temp = System.Web.HttpContext.Current.Session.SessionID.Contains("Oooops...");
        }

        public void HttpSessionElementAccessGet()
        {
            var session = System.Web.HttpContext.Current.Session;
            var aValue = session["aKey"];
            var aValueString1 = session["aKey"].ToString();
            var aValueString2 = System.Web.HttpContext.Current.Session["aKey"].ToString();
        }

        public void HttpSessionElementAccessSet()
        {
            var session = System.Web.HttpContext.Current.Session;
            session["aKey"] = "aValue";
            System.Web.HttpContext.Current.Session["aKey"] = "aValue";
            System.Web.HttpContext.Current.Session["BKey"] = "BValue";
        }

        public void HttpRequestCookies()
        {
            var request = new System.Web.HttpRequest("fileName", "url", "queryString");
            var cookies1 = new System.Web.HttpRequest("fileName", "url", "queryString").Cookies;
            var cookies2 = request.Cookies;
            var numberOfCookies = request.Cookies.Count;
        }

        public void HttpResponseCookies()
        {
            var response = new System.Web.HttpResponse(null);
            var cookies1 = new System.Web.HttpResponse(null).Cookies;
            var cookies2 = response.Cookies;
            var numberOfCookies = response.Cookies.Count;
        }

        public void HttpRequestUserHostAddress()
        {
            var request = new System.Web.HttpRequest("fileName", "url", "queryString");
            var address = request.UserHostAddress;
            var contains = request.UserHostAddress?.Contains("Oooops...");
        }

        public void HttpRequestUrl()
        {
            var request = new System.Web.HttpRequest("fileName", "url", "queryString");
            var url = request.Url;
            var contains = request.Url.Host.Contains("Oooops...");
        }

        public void HttpRequestBrowser()
        {
            var request = new System.Web.HttpRequest("fileName", "url", "queryString");
            var browserInfo = request.Browser;
            var useless = CMS.Helpers.BrowserHelper.GetBrowser() == browserInfo.Browser;
            var completelyUseless = browserInfo.Browser.Contains("Ooops...");
        }

        public void HttpResponseRedirect()
        {
            var response = new System.Web.HttpResponse(null);
            new System.Web.HttpResponse(null).Redirect("https://google.com");
            response.Redirect("https://is.muni.cz");
        }

        public void HttpRequestQueryString()
        {
            // no code fix provided
            var request = new System.Web.HttpRequest("fileName", "url", "queryString");
            var value = request.QueryString["key"].Contains("Ooops...");
        }

        public void PageIsCallback()
        {
            var isCallback = new System.Web.UI.Page().IsCallback;
        }

        public void PageIsPostBack()
        {
            var isPostBack = new System.Web.UI.Page().IsPostBack;
        }

        public void FormsAuthenticationSignOut()
        {
            System.Web.Security.FormsAuthentication.SignOut();
        }

        public void ClientScriptMethods()
        {
            // see ClientScriptsMethods.cs
        }

        public void SystemIO()
        {
            // see SystemIO.cs
        }
    }
}