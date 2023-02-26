using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DropDownForTask
{
    public partial class About : Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                AuthorDDL();
            }

        }
        void AuthorDDL()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from Authors";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            AuthorDropdownList.DataSource = data;
            AuthorDropdownList.DataTextField = "AuthorName";
            AuthorDropdownList.DataValueField = "AuthorId";
            AuthorDropdownList.DataBind();

            ListItem selectItem = new ListItem("Select Author", "Select Author");
            selectItem.Selected = true;
            AuthorDropdownList.Items.Insert(0, selectItem);
        }
        protected void AuthorDropdownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int authorID = Convert.ToInt32(AuthorDropdownList.SelectedValue);
                BookDDL(authorID);

            }
            catch (Exception ex)
            {
                Response.Write("<script> alert('Book not selected')</script>");
            }
        }
        void BookDDL(int AuthorId)
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("GetBookInfo", con);
            //string query = "select * from Books where AuthorId = @AuthorId";
            //SqlDataAdapter sda = new SqlDataAdapter(query, con);            
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@AuthorId", AuthorId);
            
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            BookDropdownList.DataSource = dt;

            BookDropdownList.DataTextField= "BookTitle";
            BookDropdownList.DataValueField= "BookID";
            BookDropdownList.DataBind();

            ListItem selectItem = new ListItem("Select Book", "Select Book");
            selectItem.Selected = true;
            BookDropdownList.Items.Insert(0, selectItem);
        }
    }
}