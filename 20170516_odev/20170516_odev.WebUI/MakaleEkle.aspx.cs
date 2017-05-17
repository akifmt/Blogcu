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
        public MakaleEkle()
        {
            _kateController = new KategoriController();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            // Kategorileri Getirir
            List<Kategoriler> myListKategoriler = _kateController.GetAll().ToList();
            
            Helper.BindDropDownList(myListKategoriler, DropDownListKategori, "KategoriID", "KategoriAdi");
            DropDownListKategori.Items[0].Text = "asdasd";
        }
    }
}