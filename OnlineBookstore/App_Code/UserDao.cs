using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;



public class UserDao
{
    public UserDao()
    {
        //
        //TODO: 在此处添加构造函数逻辑
        //
    }

    public void createUser(UserDTO userDto)
    {

        DbConnect db = new DbConnect();
        db.sqlConnection.Open();
        string queryRows = "select count(*) from userinfo";
        MySqlCommand command = new MySqlCommand(queryRows, db.sqlConnection);
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        adapter.SelectCommand = command;
        DataTable dataTable = new DataTable();
        adapter.Fill(dataTable);
        //Console.WriteLine(dataTable.Rows[0][0]);
        int rows = int.Parse(dataTable.Rows[0][0].ToString());
    
        string uid = "0";
        if (rows != 0)
        {
            string queryAllId = "select uid from userinfo";
            command = new MySqlCommand(queryAllId, db.sqlConnection);
            adapter.SelectCommand = command;
            DataTable idsTable = new DataTable();
            adapter.Fill(idsTable);
            int maxId = int.Parse(idsTable.Rows[0][0].ToString());
            int temp;
            for (int i = 1; i < idsTable.Rows.Count; i++)
            {
                temp = int.Parse(idsTable.Rows[i][0].ToString());
                if (temp > maxId)
                    maxId = temp;
            }
            //Console.WriteLine(idsTable.Rows[0][0]);
            uid = (maxId + 1).ToString();
        }

        String insert = "INSERT INTO bookstore.userinfo (uid, username, password, uemail, uname) VALUES ('" + uid +"','" 
                                                                + userDto.Username + "','"
                                                                + userDto.Password + "','"
                                                                + userDto.Uemail + "','"
                                                                + userDto.Uname + "')";
        //Console.WriteLine(insert);
        command = new MySqlCommand(insert, db.sqlConnection);
        command.ExecuteNonQuery();
        db.sqlConnection.Close();
    }

    public void deleteUser(string text)
    {
        DbConnect db = new DbConnect();
        db.sqlConnection.Open();
        String query = "DELETE FROM userinfo WHERE uid = '" + text + "'";
        Console.WriteLine(query);
        MySqlCommand sqlCommand = new MySqlCommand(query, db.sqlConnection);
        sqlCommand.ExecuteNonQuery();
        db.sqlConnection.Close();
    }

    public DataTable getUser(String name, String pass)
    {
        DbConnect db = new DbConnect();
        db.sqlConnection.Open();
        String query = "select * from userinfo where `username` = '" + name + "' and  `password` = '" + pass + "'";
        System.Diagnostics.Debug.WriteLine(query);
        MySqlCommand sqlCommand = new MySqlCommand(query, db.sqlConnection);
        MySqlDataAdapter sqlAdapter = new MySqlDataAdapter();
        sqlAdapter.SelectCommand = sqlCommand;
        DataTable dataTable = new DataTable();
        sqlAdapter.Fill(dataTable);
        db.sqlConnection.Close();
        return dataTable;
    }

    public DataTable getUserAll()
    {
        DbConnect db = new DbConnect();
        db.sqlConnection.Open();
        String query = "select * from userinfo";
        System.Diagnostics.Debug.WriteLine(query);
        MySqlCommand sqlCommand = new MySqlCommand(query, db.sqlConnection);
        MySqlDataAdapter sqlAdapter = new MySqlDataAdapter();
        sqlAdapter.SelectCommand = sqlCommand;
        DataTable dataTable = new DataTable();
        sqlAdapter.Fill(dataTable);
        db.sqlConnection.Close();
        return dataTable;
    }

    public DataTable getUser(String id)
    {
        DbConnect db = new DbConnect();
        db.sqlConnection.Open();
        String query = "select * from userinfo where `uid` = '" + id + "'";
        System.Diagnostics.Debug.WriteLine(query);
        MySqlCommand sqlCommand = new MySqlCommand(query, db.sqlConnection);
        MySqlDataAdapter sqlAdapter = new MySqlDataAdapter();
        sqlAdapter.SelectCommand = sqlCommand;
        DataTable dataTable = new DataTable();
        sqlAdapter.Fill(dataTable);
        db.sqlConnection.Close();
        return dataTable;
    }

    public DataTable getUserByUserName(String name)
    {
        DbConnect db = new DbConnect();
        db.sqlConnection.Open();
        String query = "select * from userinfo where `username` = '" + name + "'";
        System.Diagnostics.Debug.WriteLine(query);
        MySqlCommand sqlCommand = new MySqlCommand(query, db.sqlConnection);
        MySqlDataAdapter sqlAdapter = new MySqlDataAdapter();
        sqlAdapter.SelectCommand = sqlCommand;
        DataTable dataTable = new DataTable();
        sqlAdapter.Fill(dataTable);
        db.sqlConnection.Close();
        return dataTable;
    }

    public DataTable searchUser(String name)
    {
        DbConnect db = new DbConnect();
        db.sqlConnection.Open();
        String query = "select * from userinfo where `username` like '%" + name + "%'";
        System.Diagnostics.Debug.WriteLine(query);
        MySqlCommand sqlCommand = new MySqlCommand(query, db.sqlConnection);
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        adapter.SelectCommand = sqlCommand;
        DataTable dt = new DataTable();
        adapter.Fill(dt);
        db.sqlConnection.Close();
        return dt;
    }
}

