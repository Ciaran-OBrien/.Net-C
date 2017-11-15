<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Exercise_6.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Excercise 6</title>
    <script language="C#" runat="server">

        void btn1_Click(Object Sender, EventArgs e)
        {
            Session["userName"] = Request.Form["userName"];
            Session["userEmail"] = Request.Form["userEmail"];
            Response.Redirect("Page1.aspx");
        }

        void btn2_Click(Object Sender, EventArgs e) {
            string strName = Request.Form["userName"];
            string strEmail = Request.Form["userEmail"];
            Response.Redirect("Page2.aspx?name="+strName+"&email="+strEmail);
        }

        void btn3_Click(Object Sender, EventArgs e) {
            string strName = Request.Form["userName"];
            string strEmail = Request.Form["userEmail"];
            Response.Redirect("Page2.aspx?name="+strName+"&email="+strEmail);
        }

   </script>

</head>
<body>
    <form id="form1" runat="server">
            <div class="title">
        <h1>Excercise 6</h1>
    </div>
    <div class="userInformation">
        <p>Fill in your information:</p>

        Your name: <asp:TextBox name="fname" ID="userName" placeholder="Jane Doe" runat="server"></asp:TextBox><br/>
        Your name: <asp:TextBox name="email" ID="userEmail" placeholder="example@gmail.com" pattern="[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,3}$" title="Invalid input" runat="server"></asp:TextBox>
    </div>

    <div class="btns">
        <asp:Button ID="btn1" runat="server" Text="Page 1" OnClick="btn1_Click" /><br/>
        <asp:Button ID="btn2" runat="server" Text="Page 2" OnClick="btn1_Click"/><br/>
        <asp:Button ID="btn3" runat="server" Text="Page 3" OnClick="Btn3_click"/><br/>
    </div>

 
            
    </form>
</body>
</html>
