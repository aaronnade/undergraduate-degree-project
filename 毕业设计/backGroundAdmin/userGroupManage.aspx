<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="userGroupManage.aspx.cs" Inherits="毕业设计.backGroundAdmin.userGroupManage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:GridView ID="gvGroup" runat="server" AutoGenerateColumns="False" OnRowCommand="gvGroup_RowCommand">
            <Columns>
                <asp:BoundField DataField="user_group_name" HeaderText="群组名称" />
                <asp:BoundField DataField="user_group_desc" HeaderText="群组描述" />
                <asp:HyperLinkField Text="修改" />
                <asp:ButtonField Text="删除" CommandName="btn_delete" />
                <asp:HyperLinkField Text="群组功能" />
            </Columns>
        </asp:GridView>

        <asp:Button ID="btnAddUserGroup" runat="server" OnClick="btnAddUserGroup_Click" Text="新增用户组" />

    </div>
</asp:Content>
