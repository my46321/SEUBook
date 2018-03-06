using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PurchaseCar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            getAllBooks();
        }

    }


    public void getAllBooks()
    {
        BookDAO booktDao = new BookDAO();

        HttpCookie cookie = Request.Cookies["shop"];

        DataTable dataTable = null;
        for (int i = 0; i < cookie.Values.Count; i++)
        {
            string id = cookie.Values[i];
            if (id == "") {
                break;
            }
            if (i == 0)
            {
                dataTable = getAllBooks(id).Clone();
                dataTable.Merge(getAllBooks(id));
            }
            else
            {
                dataTable.Merge(getAllBooks(id));
            }
        }
        collectProducts.DataSource = dataTable;

        collectProducts.DataBind();
    }
    public DataTable getAllBooks(String bid)
    {
        BookDAO booktDao = new BookDAO();

        DataTable dataTable = null;
        if (bid != null  && bid !="")
        {
            int id = Convert.ToInt32(bid);
            dataTable = booktDao.getBooks(id);
        }
        
         

        return dataTable;
    }
}