using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        Session["USERNAME"] = null;
        Session["UID"] = null;

        if (Request.Cookies["shop"] == null)
        {
            HttpCookie cookie = new HttpCookie("shop");
            cookie.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(cookie);
        }
    
       // HttpContext.Current.Response.Cookies.Add(cookie); 
    }

   
}