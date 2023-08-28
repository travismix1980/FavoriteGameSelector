<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="FavoriteGameSelector.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Favorite Game Selector</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 847px;
        }
        .auto-style3 {
            text-align: right;
            padding-right: 120px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Favorite Game</h1>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Select a Game from the List...&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="LblGame" runat="server" Width="200px"></asp:Label>
                    </td>
                    <td class="auto-style3" rowspan="2">
                        <asp:Image ID="ImgGame" runat="server" Height="206px" Width="334px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:DropDownList ID="DDGameList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DDGameList_SelectedIndexChanged" >
                            <asp:ListItem>Choose a Game</asp:ListItem>
                            <asp:ListItem>Baldur's Gate 3</asp:ListItem>
                            <asp:ListItem>Rise of the Tomb Raider</asp:ListItem>
                            <asp:ListItem>Resident Evil 2</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
