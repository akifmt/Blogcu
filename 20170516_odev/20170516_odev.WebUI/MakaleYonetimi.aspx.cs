using _20170516_odev.BLL.Controller.Blog;
using _20170516_odev.Entity;
using _20170516_odev.Extension;
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
        KategoriController _kateController = new KategoriController();
        MakaleController _mklController = new MakaleController();
        List<Makaleler> myListMakaleler;
        List<Kategoriler> myListKategoriler = new List<Kategoriler>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                myListMakaleler = _mklController.GetAll().ToList();
                myListKategoriler = _kateController.GetAll().ToList();
                Helper.BindDataControl(myListMakaleler, GridViewListele);
            }
            
        }

        protected void GridViewListele_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                DropDownList DropDownListKategori = e.Row.FindControl("DropDownListKategori") as DropDownList;
                string dropDownListSelectedValue = DataBinder.Eval(e.Row.DataItem, "KategoriID").ToString();
                Helper.BindDropDownList<Kategoriler>(myListKategoriler, DropDownListKategori, "KategoriID", "KategoriAdi", dropDownListSelectedValue);
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
                /*
                if (etkilenenSatir > 0)
                {
                    VerileriGetir();
                }
                */

            }

            else if (e.CommandName == "Guncelle")
            {

                LinkButton lb = e.CommandSource as LinkButton;
                GridViewRow rowum = (GridViewRow)lb.NamingContainer;
                DropDownList DropDownListKategori = rowum.FindControl("DropDownListKategori") as DropDownList;
                TextBox Baslık = rowum.FindControl("Baslık") as TextBox;
                TextBox Icerik = rowum.FindControl("Icerik") as TextBox;

                int dbTabloID = Convert.ToInt32(e.CommandArgument);

                SqlConnection connect = new SqlConnection("Server = MKF-PC\\SQLEXPRESS; Database = Blogcu; Integrated Security = true");
                SqlCommand command = new SqlCommand("sp_UpdateMakale", connect);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@MakaleID", dbTabloID);
                command.Parameters.AddWithValue("@Baslık", Baslık.Text);
                command.Parameters.AddWithValue("@Icerik", Icerik.Text);
                command.Parameters.AddWithValue("@KategoriID", DropDownListKategori.SelectedValue);
                if (connect.State == System.Data.ConnectionState.Closed)
                    connect.Open();

                int etkilenenSatir = command.ExecuteNonQuery();

                /*
                if (etkilenenSatir > 0)
                {
                    VerileriGetir();
                }
                */
            }
        }



    }
}