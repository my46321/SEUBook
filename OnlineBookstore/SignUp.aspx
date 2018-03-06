<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SignUp.aspx.cs" Inherits="SignUp" %>

<!DOCTYPE html>



<html xmlns="http://www.w3.org/1999/xhtml">

<head id="Head1" runat="server">

    <meta charset="utf-8" />

    <meta http-equiv="X-UA-Compatible" content="IE=edge" />

    <meta name="viewport" content="width=device-width, initial-scale=1" />

    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->

    <title>Sign Up</title>



    <!-- Bootstrap -->

    <link href="css/bootstrap.min.css" rel="stylesheet" />

    <link href="css/Custom-Cs.css" rel="stylesheet" />

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->

    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->

    <!--[if lt IE 9]>

      <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>

      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>

    <![endif]-->

    <style type="text/css">
        .style1
        {
            width: 399px;
            height: 333px;
        }
    </style>

</head>

<body>

    <form id="form1" runat="server">

        <div>

            <div class="navbar navbar-default navbar-fixed-top" role="navigation">

                <div class="container">

                    <div class="navbar-header">

                        <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">

                            <span class="sr-only">Toggle navigation</span>

                            <span class="icon-bar"></span>

                            <span class="icon-bar"></span>

                            <span class="icon-bar"></span>

                        </button>

                        &nbsp;</div>

                    <div class="navbar-collapse collapse">

                        <ul class="nav navbar-nav navbar-right">

                            <li><a href="Default.aspx">首页</a></li>
                            <li><a href="Books.aspx">书籍</a></li>
                            <li><a href="AboutPage.aspx">帮助</a></li>

                              <li><a href="PurchaseCar.aspx">购物车</a></li>


                            <li><a href="SignUp.aspx">注册</a></li>

                            <li><a href="SignIn.aspx">登录</a></li>

                        </ul>

                    </div>

                </div>

            </div>

        </div>
         

        <div class="lol">
            <img alt="" class="style1" src="images/seu.jpg" />
        </div>

        <!-- Sign Up -->
        <div class="center-page">

            

            <label class="col-xs-11">用户名</label>
            <div class="col-xs-11">
            <asp:TextBox ID="tbUname" runat="server" Class="form-control" placeholder="Username"></asp:TextBox>
            </div>       
            
            <label class="col-xs-11 space-vert">密码</label>
            <div class="col-xs-11">
            <asp:TextBox ID="tbPass" runat="server" Class="form-control" placeholder="Password"></asp:TextBox>
            </div> 

            <label class="col-xs-11 space-vert">确认密码</label>
            <div class="col-xs-11">
            <asp:TextBox ID="tbCPass" runat="server" Class="form-control" placeholder="Confirm Password"></asp:TextBox>
            </div> 

            <label class="col-xs-11 space-vert">姓名</label>
            <div class="col-xs-11">
            <asp:TextBox ID="tbName" runat="server" Class="form-control" placeholder="Name"></asp:TextBox>
            </div> 

            <label class="col-xs-11 space-vert">邮箱</label>
            <div class="col-xs-11">
            <asp:TextBox ID="tbEmail" runat="server" Class="form-control" placeholder="Email"></asp:TextBox>
            </div>

            <div class="col-xs-11 space-vert">
                <asp:Button ID="btSignup" runat="server" class="btn btn-success" Text="注册" 
                    OnClick="btSignup_Click" />
                <asp:Label ID="show" runat="server" Text=""></asp:Label>
            </div>

        </div>


        

        <!-- Sign Up -->



        <!-- Footer Carousel-->
        <hr />

           
        <!-- Footer Carousel-->





    </form>

    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>

    <!-- Include all compiled plugins (below), or include individual files as needed -->

    <script src="js/bootstrap.min.js"></script>

</body>

</html>