using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercise_7_Cars
{
    public partial class Audis : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                CarModel carModel = new CarModel();

                var Audis = from CarsTable in carModel.CarsTables
                            where CarsTable.brand.Contains("Audi")
                            select CarsTable;

                GridAudis.DataSource = Audis.ToList();
                GridAudis.DataBind();
                
                RecordLabel.Text = "Records found";
 
            }
            catch
            {
                RecordLabel.Text = "Records not found";
            }
        }
        protected void BtnFirst_Click(object sender, EventArgs e)
        {
            Response.Redirect("AllCars.aspx");
        }

        protected void BtnNext_Click(object sender, EventArgs e)
        {
            var path = Path.GetFileName(Request.PhysicalPath);

            switch (path)
            {
                case "AllCars.aspx":
                    {
                        Response.Redirect("Audis.aspx");
                        break;
                    }
                case "Audis.aspx":
                    {
                        Response.Redirect("BlackCars.aspx");
                        break;
                    }
                case "BlackCars.aspx":
                    {
                        Response.Redirect("AllCars.aspx");
                        break;
                    }
            }
        }

        protected void BtnPrevious_Click(object sender, EventArgs e)
        {
            var path = Path.GetFileName(Request.PhysicalPath);

            switch (path)
            {
                case "AllCars.aspx":
                    {
                        Response.Redirect("BlackCars.aspx");
                        break;
                    }
                case "Audis.aspx":
                    {
                        Response.Redirect("AllCars.aspx");
                        break;
                    }
                case "BlackCars.aspx":
                    {
                        Response.Redirect("Audis.aspx");
                        break;
                    }
            }
        }

        protected void BtnLast_Click(object sender, EventArgs e)
        {
            Response.Redirect("BlackCars.aspx");
        }
    }
}