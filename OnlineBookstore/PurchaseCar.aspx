<%@ Page Language="C#"  MasterPageFile="~/User.master" AutoEventWireup="true" CodeFile="PurchaseCar.aspx.cs" Inherits="PurchaseCar" %>




<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="row" style="padding-top:100px; padding-left:250px; padding-right:250px;">
   <asp:Repeater ID="collectProducts" runat="server" >
            <ItemTemplate>
                <div class="col-sm-3 ">
                    <a style="text-decoration:none;" href="Operate.aspx?book_id=<%#Eval("ISBN") %>">
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