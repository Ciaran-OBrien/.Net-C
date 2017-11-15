using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercise_6
{
    public partial class Page_2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strName = (string)(Request.QueryString["name"]);
            string strEmail = (string)(Request.QueryString["email"]);
            userNameLabel.Text = strName;
            userEmailLabel.Text = strEmail;
        }
    }
}