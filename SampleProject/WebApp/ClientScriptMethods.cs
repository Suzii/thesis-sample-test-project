namespace WebApp
{
    public class ClientScriptMethods : System.Web.UI.Control
    {
        public void SampleMethodA1()
        {
            var clientScript = new System.Web.UI.Page().ClientScript;
            clientScript.RegisterArrayDeclaration("arrayName", "arrayValue");
            clientScript.RegisterArrayDeclaration("arrayName", "arrayValue");
            clientScript.RegisterClientScriptBlock(typeof(object), "key", "script");
            clientScript.RegisterClientScriptInclude(typeof(object), "key", "url");
            clientScript.RegisterStartupScript(typeof(object), "key", "script");
        }

        public void SampleMethodB1()
        {
            new System.Web.UI.Page().ClientScript.RegisterArrayDeclaration("arrayName", "arrayValue");
            new System.Web.UI.Page().ClientScript.RegisterArrayDeclaration("arrayName", "arrayValue");
            new System.Web.UI.Page().ClientScript.RegisterClientScriptBlock(typeof(object), "key", "script");
            new System.Web.UI.Page().ClientScript.RegisterClientScriptInclude(typeof(object), "key", "url");
            new System.Web.UI.Page().ClientScript.RegisterStartupScript(typeof(object), "key", "script");
        }
    }
}
