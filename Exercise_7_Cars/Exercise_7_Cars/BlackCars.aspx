<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BlackCars.aspx.cs" Inherits="Exercise_7_Cars.BlackCars" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="BlackCars" runat="server">
        <div>
        </div>
        <asp:Label ID="RecordLabel" runat="server" Text="Label"></asp:Label>
        <asp:GridView ID="GridBlack" runat="server">
        </asp:GridView>
        <asp:Button ID="BtnFirst" runat="server" OnClick="BtnFirst_Click" Text="First" />
        <asp:Button ID="BtnLast" runat="server" OnClick="BtnLast_Click" Text="Last" />
        <asp:Button ID="BtnPrevious" runat="server" OnClick="BtnPrevious_Click" Text="Previous" />
        <asp:Button ID="BtnNext" runat="server" OnClick="BtnNext_Click" Text="Next" />
    </form>
</body>
</html>
