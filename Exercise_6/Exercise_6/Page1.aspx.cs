using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercise_6
{
    public partial class Page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string userName = (string)(Session["userName"]);
            string userEmail = (string)(Session["userEmail"]);
            //userNameLabel.Text = PreviousPage.UserName;
            userNameLabel.Text = userName;
            userEmailLabel.Text = userEmail;
        }
    }
}