<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sliderTest.aspx.cs" Inherits="毕业设计.sliderTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script src="~/showlist.js" type="text/javascript"></script>
    <script src="jquery-1.8.0.js" type="text/javascript"></script>
    <script src="main.css" type="text/css" rel="stylesheet"></script>
    <style>
        .auto-style1 {
            width: 711px;
            height: 323px;
        }

        * {
            margin: 0;
            padding: 0;
        }

        ol, ul, li {
            list-style: none;
        }

        .sideNav {
            width: 200px;
            position: fixed;
            top: 0;
            bottom: 0;
            background-color: #292929;
            color: white;
        }

        .oneStair:hover {
            background-color: #111;
            text-shadow: 0px 0px 2px #EEEEEE;
        }

        .titleStair {
            font-size: 16px;
            line-height: 45px;
            padding: 0 12px;
            box-sizing: border-box;
        }

            .titleStair * {
                display: inline-block;
            }

            .titleStair > h4 {
                text-indent: 1em;
            }

        .pullDown {
            float: right;
        }

        .pullDown1 {
            transform: rotate(-90deg);
        }

        .stairUL {
            display: none;
            font-size: 13px;
            padding-left: 40px;
            padding-right: 12px;
            box-sizing: border-box;
        }

            .stairUL > li {
                display: flex;
                align-items: center;
                padding: 2px 0;
            }

                .stairUL > li > i {
                    margin-right: 2px;
                }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div id="sider">
                <div class="operate">
                    <h3>功能清单
                    </h3>
                    <ul id="J_navlist">
                        <li>
                            <h4 onclick="fun1()">基本信息</h4>
                            <div class="list-item none">
                                <p><a>信息维护</a></p>
                            </div>
                        </li>
                        <li>
                            <h4 onclick="fun1()">公司动态</h4>
                            <div class="list-item none">
                                <p><a>动态发布</a></p>
                                <p><a>动态维护</a></p>
                                <p><a>动态类别</a></p>
                            </div>
                        </li>
                        <li>
                            <h4 onclick="fun1()">产品中心</h4>
                            <div class="list-item none">
                                <p><a>产品维护</a></p>
                                <p><a>产品发布</a></p>
                                <p><a>产品类别</a></p>
                            </div>
                        </li>
                        <li>
                            <h4 onclick="fun1()">招聘中心</h4>
                            <div class="list-item none">
                                <p><a>招聘信息</a></p>
                                <p><a>招聘模板</a></p>
                            </div>
                        </li>
                        <li>
                            <h4 onclick="fun1()">留言管理</h4>
                            <div class="list-item none">
                                <p><a>留言信息</a></p>
                            </div>
                        </li>
                        <li>
                            <h4 onclick="fun1()">系统管理</h4>
                            <div class="list-item none">
                                <p><a>群组维护</a></p>
                                <p><a>用户管理</a></p>
                            </div>
                        </li>
                    </ul>
                    <!--<script type="text/javascript">navList();</script>-->
                </div>
            </div>
        </div>
    </form>
</body>
</html>