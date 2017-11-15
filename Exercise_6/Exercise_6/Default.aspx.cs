using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercise_6
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void Btn3_click(object sender, EventArgs e)
        {
            string strName = Request.Form["userName"];
            string strEmail = Request.Form["userEmail"];
            Response.Redirect("Page3.aspx?name=" + strName + "&email=" + strEmail);
        }

        public String UserName
        {
            get
            {
                return userName.Text;
            }
        }
    }
}