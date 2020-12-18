<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="userManage.aspx.cs" Inherits="毕业设计.backGroundAdmin.userManage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="gvUser" runat="server" AutoGenerateColumns="False" OnRowCommand="gvUser_RowCommand">
        <Columns>
            <asp:BoundField DataField="user_no" HeaderText="用户名" />
            <asp:BoundField DataField="user_name" HeaderText="用户姓名" />
            <asp:BoundField DataField="user_passwd" HeaderText="密码" />
            <asp:BoundField DataField="user_group_name" HeaderText="用户组" />
            <asp:HyperLinkField Text="更新" />
            <asp:ButtonField CommandName="btn_delete" Text="删除" />
        </Columns>
    </asp:GridView>
    <asp:Button ID="btnAddUser" runat="server" Text="新增用户" OnClick="btnAddUser_Click" />
</asp:Content>
