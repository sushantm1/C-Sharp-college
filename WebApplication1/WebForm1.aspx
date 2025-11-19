<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Button" />
            <br />
            <h2>This is a home page</h2>
        </div>
            <asp:Menu ID="Menu1" runat="server" OnMenuItemClick="Menu1_MenuItemClick" Orientation="Horizontal">
                <Items>
                    <asp:MenuItem Text="HoemPage" Value="HoemPage">
                        <asp:MenuItem Text="DashBoard" Value="DashBoard">
                            <asp:MenuItem Text="Palindrom" Value="Palindrom"></asp:MenuItem>
                            <asp:MenuItem Text="Prime NUmber" Value="Prime NUmber"></asp:MenuItem>
                        </asp:MenuItem>
                    </asp:MenuItem>
                </Items>
        </asp:Menu>
    </form>
</body>
</html>
