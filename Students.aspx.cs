using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspdatabind
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                StateData();
                GetallData();
            }
            
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-PN90N5M;Initial Catalog=AhmadEF;Integrated Security=True");

        public void StateData()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from StateName", con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            DropDownList1.DataSource = dt;
            DropDownList1.DataTextField = "Statename";
            DropDownList1.DataValueField = "Stateid";
            DropDownList1.DataBind();
            con.Close();
            ListItem Item = new ListItem("Select State", "Select State");
            Item.Selected = true;
            DropDownList1.Items.Insert(0, Item);
        }

        //public void CityData()
        //{
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("select cid,CName from CityName where StateId = '"+DropDownList1.SelectedValue+"'",con);
        //    SqlDataAdapter ad = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    ad.Fill(dt);
        //    DropDownList2.DataSource = dt;
        //    DropDownList2.DataTextField = "Cityname";
        //    DropDownList2.DataValueField = "Cityid";
        //    DropDownList2.DataBind();
        //    con.Close();
        //    ListItem Item = new ListItem("Select State", "Select State");
        //    Item.Selected = true;
        //    DropDownList3.Items.Insert(0, Item);
        //}

        public void CityData()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select cid, CName from CityName where StateId = '" + DropDownList1.SelectedValue + "'",con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            DropDownList2.DataSource = dt;
            DropDownList2.DataTextField = "Cityname";
            DropDownList2.DataValueField = "Cityid";
            DropDownList2.DataBind();
            con.Close();
            ListItem Item = new ListItem("Select City", "Select City");
            Item.Selected = true;
            DropDownList2.Items.Insert(0, Item);
        }
        protected void Button1_Click(object sender, EventArgs e)
        { 
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Users values('" + TextBox1.Text + "', '" + radiobutton1.Text +radiobutton2.Text+ "','" + int.Parse(TextBox2.Text) + "', '" + DropDownList2.Text + "', '" + DropDownList3.Text + "', '" + DropDownList4.Text + "')",con);
            cmd.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Data Inserted sucessfully')", true);
            ClearData();
            GetallData();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update Studentdata set StudentName = '" + TextBox2.Text + "', StudentAge = '" + int.Parse(TextBox3.Text) + "', Country = '" + DropDownList2.SelectedValue + "', State = '" + DropDownList3.SelectedValue + "', City = '" + DropDownList4.SelectedValue + "' where StudentId = '"+int.Parse(TextBox1.Text)+"'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Data Updated sucessfully')", true);
            ClearData();
            GetallData();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from Studentdata where StudentId = '" + int.Parse(TextBox1.Text) + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Data Deleted sucessfully')", true);
            ClearData();
            GetallData();
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            con.Open();
            int ID = int.Parse(TextBox1.Text);
            SqlCommand cmd = new SqlCommand("select * from StudentData where StudentId = '" + ID + "'", con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            con.Close();
        }

        public void GetallData()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Studentdata",con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            con.Close();
        }

        public void ClearData()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
           
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CityData();
        }

       
    }
}