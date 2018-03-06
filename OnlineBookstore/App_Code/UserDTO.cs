using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
///UserDto 的摘要说明
/// </summary>
public class UserDTO
{
    private String uid, uemail, username, password, uname, utype;
    private double ucash;

    public double Ucash
    {
        get { return ucash; }
        set { ucash = value; }
    }

    public String Utype
    {
        get { return utype; }
        set { utype = value; }
    }

    public String Uname
    {
        get { return uname; }
        set { uname = value; }
    }

    public String Password
    {
        get { return password; }
        set { password = value; }
    }

    public String Username
    {
        get { return username; }
        set { username = value; }
    }

    public String Uemail
    {
        get { return uemail; }
        set { uemail = value; }
    }

    public String Uid
    {
        get { return uid; }
        set { uid = value; }
    }
    public UserDTO(String username, String password, String uname, String uemail)
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
        this.password = password;
        this.uemail = uemail;
        this.uname = uname;
        this.username = username;
	}
}