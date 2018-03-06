using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

public class OrderDAO
{
    public string calculateOrderNumber()
    {
        DbConnect db = new DbConnect();
        db.sqlConnection.Open();
        string queryRows = "select count(*) from orders";
        MySqlCommand command = new MySqlCommand(queryRows, db.sqlConnection);
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        adapter.SelectCommand = command;
        DataTable dataTable = new DataTable();
        adapter.Fill(dataTable);
        //Console.WriteLine(dataTable.Rows[0][0]);
        int rows = int.Parse(dataTable.Rows[0][0].ToString());

        string orderNumber = "0";
        if (rows != 0)
        {
            string queryAllId = "select oNO from orderinfo";
            command = new MySqlCommand(queryAllId, db.sqlConnection);
            adapter.SelectCommand = command;
            DataTable idsTable = new DataTable();
            adapter.Fill(idsTable);
            int maxNumber = int.Parse(idsTable.Rows[0][0].ToString());
            int temp;
            for (int i = 1; i < idsTable.Rows.Count; i++)
            {
                temp = int.Parse(idsTable.Rows[i][0].ToString());
                if (temp > maxNumber)
                    maxNumber = temp;
            }
            //Console.WriteLine(idsTable.Rows[0][0]);
            orderNumber = (maxNumber + 1).ToString();
        }
        return orderNumber;
    }

  

    public DataTable getAllInfoByOno(string ono)
    {
        DataTable dt = new DataTable();
        DbConnect db = new DbConnect();
        db.sqlConnection.Open();
        String query = "select * from orderinfo where oNO = '" + ono + "'";
        System.Diagnostics.Debug.WriteLine(query);
        MySqlCommand sqlCommand = new MySqlCommand(query, db.sqlConnection);
        MySqlDataAdapter sqlAdapter = new MySqlDataAdapter();
        sqlAdapter.SelectCommand = sqlCommand;        
        sqlAdapter.Fill(dt);
        db.sqlConnection.Close();
        return dt;
    }

    public void insertOrder(OrderDTO order)
    {
        DbConnect db = new DbConnect();
        db.sqlConnection.Open();
        String query = "INSERT INTO orders ( oNO, ouser_id, obook_id, oadress)  VALUES ('"
            + order.Ono + "','"
            + order.OuserId + "',"
            + order.ObookId + ",'" + order.Oadress + "')";
        System.Diagnostics.Debug.WriteLine(query);
        MySqlCommand sqlCommand = new MySqlCommand(query, db.sqlConnection);
        sqlCommand.ExecuteNonQuery();
        db.sqlConnection.Close();
    }
}

