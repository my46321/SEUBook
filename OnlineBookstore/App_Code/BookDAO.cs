using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

public class BookDAO
{
    public void addBook(BookDTO book)
    {
        DbConnect db = new DbConnect();
        db.sqlConnection.Open();
        String query = "INSERT INTO books ( ISBN, bname, bauthor_name, `bprice`, bstock, `bstoryline`, `btype`)  VALUES (" 
            + book.ISBN1 + ",'"
            + book.Bname + "','" 
            + book.BauthorName + "','" 
            + book.Bprice + "','" 
            + book.Bstock + "','" 
            + book.Bstoryline + "','" 
            + book.Btype + "')";
        System.Diagnostics.Debug.WriteLine(query);
        MySqlCommand sqlCommand = new MySqlCommand(query, db.sqlConnection);
        sqlCommand.ExecuteNonQuery();
        db.sqlConnection.Close();
    }

    public void deleteBook(int isbn)
    {
        DbConnect db = new DbConnect();
        db.sqlConnection.Open();
        String query = "delete from books where ISBN = " + isbn;
        System.Diagnostics.Debug.WriteLine(query);
        MySqlCommand sqlCommand = new MySqlCommand(query, db.sqlConnection);
        sqlCommand.ExecuteNonQuery();
        db.sqlConnection.Close();
    }

    public DataTable searchBook(String bname)
    {
        DataTable dt = new DataTable();
        DbConnect db = new DbConnect();
        db.sqlConnection.Open();
        String query = "select books.* ,bookimages.iname as ImgName, bookimages.iextension as Extention from books, bookimages where (bname like '%" + bname
            + "%' or bauthor_name like '%" + bname
            + "%' or bstoryline like '%" + bname
            + "%' or btype like '%" + bname + "%')" + " And  books.ISBN = bookimages.ibook_id";
        System.Diagnostics.Debug.WriteLine(query);
        MySqlCommand sqlCommand = new MySqlCommand(query, db.sqlConnection);
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        adapter.SelectCommand = sqlCommand;
        adapter.Fill(dt);
        db.sqlConnection.Close();
        return dt;
    }

    public void updateStock(int isbn, int stockChange)
    {
        DbConnect db = new DbConnect();
        db.sqlConnection.Open();

        DataTable dt = new DataTable();
        String query = "select bstock from books where ISBN = " + isbn;
        System.Diagnostics.Debug.WriteLine(query);
        MySqlCommand sqlCommand = new MySqlCommand(query, db.sqlConnection);
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        adapter.SelectCommand = sqlCommand;
        adapter.Fill(dt);
        int newStock = int.Parse(dt.Rows[0][0].ToString()) + stockChange;

        String update = "update books set bstock = " + newStock + " where ISBN = " + isbn;
        System.Diagnostics.Debug.WriteLine(update);
        sqlCommand = new MySqlCommand(update, db.sqlConnection);
        sqlCommand.ExecuteNonQuery();
    }

    public DataTable getBooks(int isbn)
    {
        DataTable dt = new DataTable();
        DbConnect db = new DbConnect();
        db.sqlConnection.Open();
        String query = "select books.*, bookimages.iname as ImgName, bookimages.iextension as Extention from books, bookimages where books.ISBN = bookimages.ibook_id and books.ISBN = " + isbn;
        System.Diagnostics.Debug.WriteLine(query);
        MySqlCommand sqlCommand = new MySqlCommand(query, db.sqlConnection);
        MySqlDataAdapter sqlAdapter = new MySqlDataAdapter();
        sqlAdapter.SelectCommand = sqlCommand;
        sqlAdapter.Fill(dt);
        db.sqlConnection.Close();
        return dt;
    }

    public DataTable getBooks(string isbn)
    {
        DataTable dt = new DataTable();
        DbConnect db = new DbConnect();
        db.sqlConnection.Open();
        String query = "select books.*, bookimages.iname as ImgName, bookimages.iextension as Extention from books, bookimages where books.ISBN = bookimages.ibook_id and books.bname = '" + isbn+"'";
        System.Diagnostics.Debug.WriteLine(query);
        MySqlCommand sqlCommand = new MySqlCommand(query, db.sqlConnection);
        MySqlDataAdapter sqlAdapter = new MySqlDataAdapter();
        sqlAdapter.SelectCommand = sqlCommand;
        sqlAdapter.Fill(dt);
        db.sqlConnection.Close();
        return dt;
    }

    public DataTable getBooks()
    {
        DataTable dt = new DataTable();
        DbConnect db = new DbConnect();
        db.sqlConnection.Open();
        String query = "select books.*, bookimages.iname as ImgName, bookimages.iextension as Extention from books, bookimages where books.ISBN = bookimages.ibook_id";
        System.Diagnostics.Debug.WriteLine(query);
        MySqlCommand sqlCommand = new MySqlCommand(query, db.sqlConnection);
        MySqlDataAdapter sqlAdapter = new MySqlDataAdapter();
        sqlAdapter.SelectCommand = sqlCommand;
        sqlAdapter.Fill(dt);
        db.sqlConnection.Close();
        return dt;
    }
}

