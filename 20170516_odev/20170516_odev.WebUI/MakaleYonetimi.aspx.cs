using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _20170516_odev.WebUI
{
    public partial class MakaleYonetimi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                VerileriGetir();
            }
            
        }

        private void VerileriGetir()
        {
            SqlConnection connect = new SqlConnection("Server = MKF-PC\\SQLEXPRESS; Database = Blogcu; Integrated Security = true");

            SqlCommand command = new SqlCommand("select * from Makaleler", connect);
            if (connect.State == System.Data.ConnectionState.Closed)
                connect.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            GridViewListele.DataSource = dataReader;
            GridViewListele.DataBind();
            connect.Close();

           

        }

        protected void GridViewListele_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            SqlConnection connect = new SqlConnection("Server = MKF-PC\\SQLEXPRESS; Database = Blogcu; Integrated Security = true");

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                DropDownList DropDownListKategori = e.Row.FindControl("DropDownListKategori") as DropDownList;

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "[sp_GetAllKategoriler]";
                command.Connection = connect;

                if (connect.State == System.Data.ConnectionState.Closed)
                    connect.Open();

                SqlDataReader dataReader = command.ExecuteReader();
                DropDownListKategori.DataSource = dataReader;
                DropDownListKategori.DataValueField = "KategorilerID"; //kategoriler tablosundaki kategoriid
                DropDownListKategori.DataTextField = "KategoriName";
                DropDownListKategori.DataBind();

                DropDownListKategori.SelectedValue = DataBinder.Eval(e.Row.DataItem, "KategoriID").ToString(); // makaleden gelen kategoriID
                
                connect.Close();
                
            }
            
        }


        protected void GridViewListele_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Sil")
            {
                SqlConnection connect = new SqlConnection("Server = MKF-PC\\SQLEXPRESS; Database = Blogcu; Integrated Security = true");
                SqlCommand command = new SqlCommand("sp_DeleteMakale", connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MakaleID", Convert.ToInt32(e.CommandArgument));

                if (connect.State == System.Data.ConnectionState.Closed)
                    connect.Open();


                int etkilenenSatir = command.ExecuteNonQuery();
                if (etkilenenSatir > 0)
                {
                    VerileriGetir();
                }

            }

            else if (e.CommandName == "Guncelle")
            {

                LinkButton lb = e.CommandSource as LinkButton;
                GridViewRow rowum = (GridViewRow)lb.NamingContainer;
                DropDownList dropDownListBicim = rowum.FindControl("DropDownListBicim") as DropDownList;

                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridViewListele.Rows[index];

                Button btnDID = row.FindControl("IDButton") as Button;
                int dbTabloID = Convert.ToInt32(btnDID.CommandArgument);
                
                Image imageResim = row.FindControl("ImageResim") as Image;
                TextBox TextBoxIcerik1 = row.FindControl("TextBoxIcerik1") as TextBox;
                TextBox TextBoxIcerik2 = row.FindControl("TextBoxIcerik2") as TextBox;

                SqlConnection connect = new SqlConnection("Server = MKF-PC\\SQLEXPRESS; Database = NORTHWND; Integrated Security = true");
                SqlCommand command = new SqlCommand("sp_SliderGuncelle", connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ID", dbTabloID);
                command.Parameters.AddWithValue("@ResimUrl", imageResim.ImageUrl);
                command.Parameters.AddWithValue("@Icerik1", TextBoxIcerik1.Text);
                command.Parameters.AddWithValue("@Icerik2", TextBoxIcerik2.Text);
                command.Parameters.AddWithValue("@BicimID", Convert.ToInt32(dropDownListBicim.SelectedValue));
                
                if (connect.State == System.Data.ConnectionState.Closed)
                    connect.Open();

                int etkilenenSatir = command.ExecuteNonQuery();

                if (etkilenenSatir > 0)
                {
                    VerileriGetir();
                }
            }
        }

       

    }
}