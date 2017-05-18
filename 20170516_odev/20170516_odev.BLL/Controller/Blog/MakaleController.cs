using _20170516_odev.DAL.Repositories.Blog;
using _20170516_odev.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20170516_odev.BLL.Controller.Blog
{
    public class MakaleController
    {

        MakaleManagement _makaleManagement;
        public MakaleController()
        {
            _makaleManagement = new MakaleManagement();
        }

        public ICollection<Makaleler> GetAll()
        {
            return _makaleManagement.GetAll();
        }

        public int Add(Makaleler yeniMak)
        {
            return _makaleManagement.Add(yeniMak);
        }


    }
}
