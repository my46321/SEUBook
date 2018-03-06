<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SignIn.aspx.cs" Inherits="SignIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <title>BookLand</title>

    <!-- Bootstrap -->
    <link href="css/bootstrap.min.css" rel="stylesheet">
     <link href="css/Custom-Cs.css" rel="stylesheet">

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
     <style type="text/css">
         .style1
         {
             width: 361px;
             height: 337px;
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
        <br />
        <br />
         <div class="lol">
             <img alt="" class="style1" src="images/seu.jpg" />
        </div>
        <!-- Sign In -->
         <div  style="margin-left:50%; margin-top:80px;">
             <div class="form-horizontal">
                 <h2 style="font-family:'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif">
                     登录</h2>
                 <hr />
                 <div class="form-group">
                     <asp:Label ID="Label1" runat="server" CssClass="col-md-2 control-label" 
                         Text="用户名"></asp:Label>
                     <div class="col-md-3">
                         <asp:TextBox ID="UserName" Class="form-control" runat="server"  AutoPostBack="True"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidatorUsername" 
                             CssClass="text-danger" runat="server" ErrorMessage="用户名不能为空" 
                             ControlToValidate="UserName"></asp:RequiredFieldValidator>
                     </div>
                 </div>
                 <div class="form-group">
                     <asp:Label ID="Label2" runat="server" CssClass="col-md-2 control-label" 
                         Text="密码"></asp:Label>
                     <div class="col-md-3">
                         <asp:TextBox ID="Password" CssClass="form-control" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorPass" 
                             CssClass="text-danger" runat="server" ErrorMessage="密码不能为空" 
                             ControlToValidate="Password"></asp:RequiredFieldValidator>
                     </div>
                 </div>
                 <div class="form-group">
                     <div class="col-md-2"></div>
                     <div class="col-md-6">
                         <asp:CheckBox ID="CheckBox1" runat="server" />
                         <asp:Label ID="Label3" runat="server" CssClass=" control-label" Text="记住密码"></asp:Label>
                     </div>
                 </div>
                 <div class="form-group">
                     <div class="col-md-2"></div>
                     <div class="col-md-6">
                         <asp:Button ID="Button1" runat="server" Text="登录" CssClass="btn btn-default" 
                             OnClick="Button1_Click" />
                         <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/SignUp.aspx">去注册</asp:LinkButton>
                     </div>
                 </div>
                  
                 <div class="form-group">
                    <div class="col-md-2"></div>                    
                    <div class="col-md-6">
                        </div>
                </div>

             </div>
         </div>
        <!-- Sign In Ends-->
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
