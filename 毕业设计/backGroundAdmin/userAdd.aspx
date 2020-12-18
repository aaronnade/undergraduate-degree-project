<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="userAdd.aspx.cs" Inherits="毕业设计.backGroundAdmin.userAdd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    用户名：<asp:TextBox ID="txtUserNo" runat="server"></asp:TextBox>
    </br>
    用户姓名：<asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
    </br>
    密码：<asp:TextBox ID="txtUserPasswd" runat="server"></asp:TextBox>
    </br>
    <asp:DropDownList ID="ddlUserGroup" runat="server"></asp:DropDownList>
    </br>
    <asp:Button ID="btnAddUser" runat="server" Text="新增" OnClick="btnAddUser_Click" />
</asp:Content>
