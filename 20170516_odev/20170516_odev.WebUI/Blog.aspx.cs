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
    public partial class Blog : System.Web.UI.Page
    {

            MakaleController _mklController = new MakaleController();
            protected void Page_Load(object sender, EventArgs e)
            {
                List<Makaleler> myList = _mklController.GetAll().ToList();
                Helper.BindDataControl(myList, Repeater1);


            }









        }
}