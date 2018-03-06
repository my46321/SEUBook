<%@ Page Title="" Language="C#" MasterPageFile="~/User.master" AutoEventWireup="true" CodeFile="Books.aspx.cs" Inherits="Books" %>



<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label style="padding-top:70px; margin-left:330px;" ID="Label10" runat="server" CssClass="col-md-2 control-label" Text=""></asp:Label>
        <div  class="col-md-3"  style="padding-top:70px; margin-left:400px;" >
             <asp:TextBox ID="UserID" Class="form-control" runat="server"  AutoPostBack="True" placeholder="Search by Book Name"></asp:TextBox>
            
             <asp:RequiredFieldValidator ID="RequiredFieldValidatorUserID" 
                 CssClass="text-danger" runat="server" ErrorMessage="不能为空！" 
                 ControlToValidate="UserID"></asp:RequiredFieldValidator>
        </div>
       <div class="form-group" style="padding-top:70px; margin-left:330px;">
              <div style="margin-left:360px; width: 313px;" class="col-md-2"></div>
                  <div  class="col-md-6">
               </div>
                  <asp:Button style="margin-left:634px;" ID="Button10" runat="server" Text="搜索" 
                          CssClass="btn btn-success" OnClick="Button10_Click" Height="40px" 
                  Width="126px"   />          
        </div>
       
    <hr/>
  <div class="row" style="padding-top:100px; padding-left:250px; padding-right:250px;">
   <asp:Repeater ID="rptrProducts" runat="server" 
          onitemcommand="rptrProducts_ItemCommand">
            <ItemTemplate>
                <div class="col-sm-3 ">
                    <a style="text-decoration:none;" href="BookProcess.aspx?book_id=<%#Eval("ISBN") %>">
                    <div class="thumbnail">
                        <img src="Images/BookImages/<%#Eval("ISBN") %>/<%#Eval("ImgName") %><%#Eval("Extention") %>" alt="<%#Eval("ImgName") %>" width="250" height="250"/>
                        <div class="caption">
                            <div class="probrand"><%#Eval("btype") %></div>
                            <div class="proName"><%#Eval("bname") %></div>
                            <div class="proPrice">Price : <%#Eval("bprice") %></div>
                        </div>
                    </div>
                    </a>
                </div>
            </ItemTemplate>
        </asp:Repeater>
  </div>

</asp:Content>

