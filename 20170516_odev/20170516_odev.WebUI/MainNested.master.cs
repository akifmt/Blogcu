using _20170516_odev.BLL.Controller.Blog;
using _20170516_odev.Entity;
using _20170516_odev.Extension;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class MainNested : System.Web.UI.MasterPage
    {
        KategoriController _kateController;
        public MainNested()
        {
            _kateController = new KategoriController();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            // Kategorileri Getirir
            List<Kategoriler> myList = _kateController.GetAll().ToList();
            Helper.BindDataControl(myList, Repeater1);
            


            if (!IsPostBack)
            {
                if (HttpContext.Current.User.Identity.IsAuthenticated)
                {
                    StatusText.Text = string.Format("Merhaba, {0}!!", HttpContext.Current.User.Identity.GetUserName());
                    LoginStatus.Visible = true;
                    LogoutButton.Visible = true;
                }
                else
                {
                    LoginForm.Visible = true;
                }
            }
        }
        protected void SignIn(object sender, EventArgs e)
        {
            var userStore = new UserStore<IdentityUser>();
            var userManager = new UserManager<IdentityUser>(userStore);
            var user = userManager.Find(UserName.Text, Password.Text);

            if (user != null)
            {
                var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
                var userIdentity = userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);

                authenticationManager.SignIn(new AuthenticationProperties() { IsPersistent = false }, userIdentity);
                Response.Redirect(Request.RawUrl);
            }
            else
            {
                StatusText.Text = "Yanlış Kullanıcı Adı veya Şifre.";
                LoginStatus.Visible = true;
            }
        }

        protected void SignOut(object sender, EventArgs e)
        {
            var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
            authenticationManager.SignOut();
            Response.Redirect("~/Blog.aspx");
        }


    }
}