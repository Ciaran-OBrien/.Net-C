<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AllCars.aspx.cs" Inherits="Exercise_7_Cars.AllCars" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="RecordLabel" runat="server" Text="Label"></asp:Label>
        <asp:GridView ID="GridAll" runat="server" AllowPaging="True" PageSize="6">
            <PagerSettings Visible="False" />
        </asp:GridView>
        <asp:Button ID="BtnFirst" runat="server" OnClick="BtnFirst_Click" Text="First" />
        <asp:Button ID="BtnLast" runat="server" OnClick="BtnLast_Click" Text="Last" />
        <asp:Button ID="BtnPrevious" runat="server" OnClick="BtnPrevious_Click" Text="Previous" />
        <asp:Button ID="BtnNext" runat="server" OnClick="BtnNext_Click" Text="Next" />
    </form>
</body>
</html>
