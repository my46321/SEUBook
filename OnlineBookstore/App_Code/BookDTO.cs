using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
///BookDao 的摘要说明
/// </summary>
public class BookDTO
{
    private String bname, bauthorName, bstoryline, btype;
    private double bprice;
    private int bstock, ISBN;

    public int ISBN1
    {
        get { return ISBN; }
        set { ISBN = value; }
    }

	public BookDTO(int ISBN, String bname, String bauthorName, String bstoryline, String btype, double bprice, int bstock)
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
        this.bauthorName = bauthorName;
        this.bname = bname;
        this.bprice = bprice;
        this.bstock = bstock;
        this.bstoryline = bstoryline;
        this.btype = btype;
        this.ISBN = ISBN;
	}


    public String Bname
    {
        set { bname = value; }
        get { return bname; }
    }

    public String BauthorName
    {
        set { bauthorName = value; }
        get { return bauthorName; }
    }

    public String Bstoryline
    {
        get { return bstoryline; }
        set { bstoryline = value; }
    }

    public String Btype
    {
        set { btype = value; }
        get { return btype; }
    }

    public double Bprice
    {
        get { return bprice; }
        set { bprice = value; }
    }

    public int Bstock
    {
        get { return bstock; }
        set { bstock = value; }
    }
}