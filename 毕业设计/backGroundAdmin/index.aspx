<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="毕业设计.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        
        .auto-style2 {
            width: 1003px;
            height: 432px;
        }
        
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <asp:TreeView ID="TreeView1" runat="Server">
                            <DataBindings>
                                <asp:TreeNodeBinding NavigateUrl="~/Web.sitemap" />
                            </DataBindings>
                            <Nodes>
                                <asp:TreeNode Text="系统管理" Value="系统管理">
                                    <asp:TreeNode NavigateUrl="~/backGroundAdmin/userGroupManage.aspx" Text="群组管理" Value="群组管理" Target="frame"></asp:TreeNode>
                                    <asp:TreeNode NavigateUrl="~/backGroundAdmin/userManage.aspx" Text="用户管理" Value="用户管理" Target="frame"></asp:TreeNode>
                                </asp:TreeNode>
                            </Nodes>
                        </asp:TreeView>
                    </td>
                    <td>
                        <iframe src="main.aspx" name="frame" scrolling="yes" id="IFRAME1" class="auto-style2"></iframe>
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
<script>
</script>
</html>