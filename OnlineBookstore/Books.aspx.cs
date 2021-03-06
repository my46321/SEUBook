﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Books : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            getAllBooks();
        }
       
    }


    public void getAllBooks()
    {
        BookDAO booktDao = new BookDAO();

        DataTable dataTable = booktDao.getBooks();

        rptrProducts.DataSource = dataTable;

        rptrProducts.DataBind();
    }
    public void getAllBooks(String bName )
    {
        BookDAO booktDao = new BookDAO();

        DataTable dataTable = booktDao.getBooks(bName);

        rptrProducts.DataSource = dataTable;

        rptrProducts.DataBind();
    }


    protected void Button10_Click(object sender, EventArgs e)
    {
        String bName = UserID.Text;

        if (bName != null)
        {

            BookDAO booktDao = new BookDAO();

            DataTable dataTable = booktDao.searchBook(bName);

            rptrProducts.DataSource = dataTable;

            rptrProducts.DataBind();
        }
    }
    protected void rptrProducts_ItemCommand(object source, RepeaterCommandEventArgs e)
    {

    }
}