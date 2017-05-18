using _20170516_odev.DAL.Repositories.Blog;
using _20170516_odev.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20170516_odev.BLL.Controller.Blog
{
    public class YorumlarController
    {
        YorumlarManagemant _yorumManagement;

        public YorumlarController()
        {
            _yorumManagement = new YorumlarManagemant();
        }

        public ICollection<Yorumlar> GetByID(int? parameter, Yorumlar parameter1)
        {
            return _yorumManagement.GetByID(parameter, parameter1);
        }

        public int Add(Yorumlar yeniYor)
        {
            return _yorumManagement.Add(yeniYor);
        }





    }
}
