<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="addNewUserGroup.aspx.cs" Inherits="毕业设计.backGroundAdmin.addNewUserGroup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h>新增用户组</h>      
    </br>
    群组名称：<asp:TextBox ID="txtGroupName" runat="server"></asp:TextBox>
    </br>
    群组说明：<asp:TextBox ID="txtGroupDesc" runat="server"></asp:TextBox>
    </br>
    <asp:Button ID="btnAdd" runat="server" Text="新增" OnClick="btnAdd_Click" />
</asp:Content>
