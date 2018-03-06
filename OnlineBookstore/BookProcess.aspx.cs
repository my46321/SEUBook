using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BookProcess : System.Web.UI.Page
{
    public int BID;
    protected void Page_Load(object sender, EventArgs e)
    {

     

        int uid = Convert.ToInt32(Session["UID"]);

        if (Request.QueryString["book_id"] != null)
        {
            BID = Convert.ToInt32(Request.QueryString["book_id"]);

            if (!IsPostBack)
            {
                 getBook(BID);
            }
        }
        else
        {
            Response.Redirect("~/Books.aspx");
        }

        String bookid = Request.QueryString["book_id"];
        if (Request.Cookies["shop"] != null)
        {
            HttpCookie cookie = Request.Cookies["shop"];
            for (int i = 0; i < cookie.Values.Count; i++)
            {
                string id = cookie.Values[i];
                if (id == bookid) {
                    Button1.Text = "已加入购物车";
                    Button1.Enabled = false;
                }
            }
        }
    }



    public void getBook(int bID)
    {
        BookDAO booktDao = new BookDAO();

        DataTable dataTable = booktDao.getBooks(bID);

        rptrbook.DataSource = dataTable;

        rptrbook.DataBind();


      
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        BookDAO booktDao = new BookDAO();

        String bookid = Request.QueryString["book_id"];


        HttpCookie cookie = Request.Cookies["shop"];
        int j=0;
        for (int i = 0; i < cookie.Values.Count; i++)
        {
            string id = cookie.Values[i];
            if (id == bookid)
            {
                Button1.Text = "已经加入啦";
                Button1.Enabled = false;
                j++;
            }
        }
        if (j == 0)
        {
            cookie.Values.Add(bookid, bookid);
            cookie.Expires = DateTime.Now.AddDays(15);
            Response.Cookies.Add(cookie);
        }
      //  String temp = Request.Cookies["Collect"].Value;

       // temp += (bookid + "|");

       // Response.Cookies["Collect"].Value = temp;
 /*       DataTable dataTable = booktDao.getBookPdf(Convert.ToInt32(bookid));

        String bookname = dataTable.Rows[0][1].ToString() + dataTable.Rows[0][2].ToString();

        System.Diagnostics.Debug.WriteLine(bookname);

        String price = booktDao.getPrice(bookid);
        
        if( price != "not found")
        {
            if( price == "0")
            {
                Response.Redirect("Books/" + bookid + "/" + bookname);
            }
            else
            {
                Response.Redirect("~/transaction.aspx?book_id=" + bookid );
            }
        }
*/
        //Response.Redirect("Books/"+bookid+"/"+bookname);
    }





    protected void rptrbook_ItemCommand(object source, RepeaterCommandEventArgs e)
    {

    }
}