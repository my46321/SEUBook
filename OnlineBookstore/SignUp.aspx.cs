using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SignUp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btSignup_Click(object sender, EventArgs e)
    {


        if (tbUname.Text != "" & tbPass.Text != "" && tbName.Text != "" && tbEmail.Text != "" && tbCPass.Text != "")
        {
            if (tbPass.Text == tbCPass.Text)
            {

                UserDao userDao = new UserDao();

                userDao.createUser(new UserDTO(tbUname.Text, tbPass.Text, tbName.Text, tbEmail.Text));

                Response.Redirect("~/Signin.aspx");

            }
            else
            {
                show.ForeColor = Color.Red;
                show.Text = "密码或ID错误";
            }

        }
        else
        {
            show.ForeColor = Color.Red;
            show.Text = "请把所有信息填写完整";
        }


    }
}