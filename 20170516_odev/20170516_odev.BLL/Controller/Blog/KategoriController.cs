
using _20170516_odev.DAL.Repositories.Blog;
using _20170516_odev.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20170516_odev.BLL.Controller.Blog
{
    public class KategoriController 
    {

        KategoriManagement _kategoriManagement;
        public KategoriController()
        {
            _kategoriManagement = new KategoriManagement();
        }

        public ICollection<Kategoriler> GetAll()
        {
            return _kategoriManagement.GetAll();
        }
        

    }
}
