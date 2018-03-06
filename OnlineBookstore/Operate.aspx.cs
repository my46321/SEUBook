using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Operate : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Session["USERNAME"] == null && Session["UID"] == null) {
            Response.Redirect("~/Signin.aspx");
        }

        BookDAO booktDao = new BookDAO();
        OrderDAO oDao = new OrderDAO();
        string bookid = Request.QueryString["book_id"];

        int bid = Convert.ToInt32(bookid);
        string address = TextBox1.Text.Trim();
        string uid = Session["UID"].ToString();
        string no = DateTime.Now.Date.ToString();
        if (address == "")
        {
            Label11.Text = "请输入您的收货地址";
        }
        else
        {
            OrderDTO order = new OrderDTO(no,uid , address, bid);
            oDao.insertOrder(order);
            Label11.Text = "成功创建订单";
            Button1.Enabled = false;
            Button1.Text = "已下单";
        }

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        BookDAO booktDao = new BookDAO();

        String bookid = Request.QueryString["book_id"];

        HttpCookie cookie = Request.Cookies["shop"];
        for (int i = 0; i < cookie.Values.Count; i++)
        {
            string id = cookie.Values[i];
            if (id == bookid)
            {
                cookie.Values.Remove(bookid);
            }
        }
        cookie.Values.Remove("2");
        Response.Cookies.Add(cookie);
        Response.Redirect("~/PurchaseCar.aspx");
    }
}