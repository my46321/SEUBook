<%@ Page Title="" Language="C#" MasterPageFile="~/User.master" AutoEventWireup="true" CodeFile="BookProcess.aspx.cs" Inherits="BookProcess" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="padding-top:80px">
        
       

        <asp:Repeater ID="rptrbook" runat="server" onitemcommand="rptrbook_ItemCommand">
            <ItemTemplate>
                
                <div class="col-md-3" style="margin-left:360px">
                    <div  class="thumbnail" style="max-width:"480">
                        <img src="Images/BookImages/<%#Eval("ISBN") %>/<%#Eval("ImgName") %><%#Eval("Extention") %>" alt="<%#Eval("ImgName") %>" alt="01" onerror="this.src='images/NoPicAvailable.png'">
                    </div>
                </div>

                <div >
                    <h1 class="proNameView"><%#Eval("bname") %></h1>
                    <p class="proPriceView">价格: <%#Eval("bprice") %></p>
                </div>


                <div >
                    <h3 class="proNameView">种类</h3>
                    <p class="proPriceView"><%#Eval("btype") %></p>  
            
                </div>

                <div >
                    <p class="proNameView" >作者</p>
                    <p class="proPriceView"><%#Eval("bauthor_name") %></p>  
            
                </div>


                <div >
                    <h3 class="proNameView">简介</h3>

                    <p><%#Eval("bstoryline") %></p>
                </div>

                
           </ItemTemplate>
        </asp:Repeater>

        <div  style="margin-right:12%">
            <asp:Button ID="Button1" CssClass="mainButton" runat="server" Text="加入购物车" 
                OnClick="Button1_Click"/>
            <%

            %>

        </div>

        <!-- Review Start -->
        
    </div>

    
</asp:Content>

