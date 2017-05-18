
using _20170516_odev.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20170516_odev.DAL.IRepositories.Blog
{
    interface IYorum : IAdd<Yorumlar>, IDelete<Yorumlar>, IGetByID<Yorumlar, int>
    {
    }
}
