using _20170516_odev.BLL.Controller.Blog;
using _20170516_odev.Entity;
using _20170516_odev.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _20170516_odev.WebUI
{
    public partial class MakaleEkle : System.Web.UI.Page
    {
        KategoriController _kateController;
        MakaleController _makaleController;
        public MakaleEkle()
        {
            _kateController = new KategoriController();
            _makaleController = new MakaleController();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                // Kategorileri Getirir
                List<Kategoriler> myListKategoriler = _kateController.GetAll().ToList();
                Helper.BindDropDownList(myListKategoriler, DropDownListKategori, "KategoriID", "KategoriAdi");
                            
            }

        }

        protected void ButtonMakaleKaydet_Click(object sender, EventArgs e)
        {
            Makaleler yeniMak = new Makaleler();
            yeniMak.Baslik = TextBoxBaslik.Text;
            yeniMak.Icerik = editor1.Value;
            yeniMak.KategoriID = Convert.ToInt32(DropDownListKategori.SelectedItem.Value);
            yeniMak.MakaleFotoPath = "asdasd";
            yeniMak.YazarUserName = "aa";
            _makaleController.Add(yeniMak);
        }
    }
}