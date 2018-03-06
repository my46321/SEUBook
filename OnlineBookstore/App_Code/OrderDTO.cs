using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
///OrderDto 的摘要说明
/// </summary>
public class OrderDTO
{
    private String ono, ouserId, oadress;
    private int obookId;

    public int ObookId
    {
        get { return obookId; }
        set { obookId = value; }
    }

    public String Oadress
    {
        get { return oadress; }
        set { oadress = value; }
    }

    public String OuserId
    {
        get { return ouserId; }
        set { ouserId = value; }
    }

    public String Ono
    {
        get { return ono; }
        set { ono = value; }
    }
	public OrderDTO(String ono, String ouserId, String oadress, int obookId)
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
        this.ono = ono;
        this.ouserId = ouserId;
        this.oadress = oadress;
        this.obookId = obookId;
	}
}