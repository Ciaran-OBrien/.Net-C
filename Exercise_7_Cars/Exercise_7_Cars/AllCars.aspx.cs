using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace Exercise_7_Cars
{
    public partial class AllCars : System.Web.UI.Page
    {
        public class IndexViewModel
        {
            public IEnumerable<string> Items { get; set; }
            public Pager Pager { get; set; }
        }
        public class Pager
        {
            public Pager(int totalItems, int? page, int pageSize = 10)
            {
                // calculate total, start and end pages
                var totalPages = (int)Math.Ceiling((decimal)totalItems / (decimal)pageSize);
                var currentPage = page != null ? (int)page : 1;
                var startPage = currentPage - 5;
                var endPage = currentPage + 4;
                if (startPage <= 0)
                {
                    endPage -= (startPage - 1);
                    startPage = 1;
                }
                if (endPage > totalPages)
                {
                    endPage = totalPages;
                    if (endPage > 10)
                    {
                        startPage = endPage - 9;
                    }
                }

                TotalItems = totalItems;
                CurrentPage = currentPage;
                PageSize = pageSize;
                TotalPages = totalPages;
                StartPage = startPage;
                EndPage = endPage;
            }

            public int TotalItems { get; private set; }
            public int CurrentPage { get; private set; }
            public int PageSize { get; private set; }
            public int TotalPages { get; private set; }
            public int StartPage { get; private set; }
            public int EndPage { get; private set; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string connString = ConfigurationManager.ConnectionStrings["CarModel"].ConnectionString;
                SqlConnection conn = new SqlConnection(connString);
                SqlCommand cmd = new SqlCommand("SELECT * FROM CarsTable", conn);
                cmd.CommandType = System.Data.CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds, "id");

                GridAll.DataSource = ds.Tables["id"];

                GridAll.DataBind();
                RecordLabel.Text = "Records are found";
            }
            catch {
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