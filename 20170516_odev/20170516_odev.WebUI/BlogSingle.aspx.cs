using _20170516_odev.BLL.Controller.Blog;
using _20170516_odev.Entity;
using _20170516_odev.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class BlogSingle : System.Web.UI.Page
    {
        YorumlarController _yorumController = new YorumlarController();
        int makaleID;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                makaleID = Convert.ToInt32(Request.QueryString["MakaleID"]);

                Makaleler gelenMakale = new Makaleler();
                MakaleController _makController = new MakaleController();
                gelenMakale = _makController.GetByID(null, makaleID);
                LabelBaslik.Text = gelenMakale.Baslik;
                LiteralIcerik.Text = gelenMakale.Icerik;
                LabelYazar.Text = gelenMakale.YazarUserName;



                List<Yorumlar> myListYorum = _yorumController.GetByID(makaleID, null).ToList();
                Helper.BindDataControl(myListYorum, RepeaterYorumlar);
            }

        }

        protected void ButtonYorumKaydet_Click(object sender, EventArgs e)
        {
            makaleID = Convert.ToInt32(Request.QueryString["MakaleID"]);

            Yorumlar yeniYor = new Yorumlar();
            yeniYor.AdiSoyadi = TextBoxAdSoyad.Text;
            yeniYor.Email = TextBoxEmail.Text;
            yeniYor.MakaleID = makaleID;
            yeniYor.Yorumicerik = TextBoxYorumIcerik.Text;
            _yorumController.Add(yeniYor);

            Response.Redirect(Request.RawUrl);

        }
    }
}