using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercise_6
{
    public partial class Page3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Person SingleUser = Person.LockingCheck();
            SingleUser.SetUserName((string)(Request.QueryString["name"]));
            SingleUser.SetUserEmail((string)(Request.QueryString["email"]));

            userNameLabel.Text = SingleUser.GetUserName();
            userEmailLabel.Text = SingleUser.GetUserEmail();
        }
    }
}