using _20170516_odev.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20170516_odev.DAL.IRepositories.Blog
{
    interface IMakale : IAdd<Makaleler>, IDelete<Makaleler>,IGetAll<Makaleler>,IUpdate<Makaleler>
    {

    }
}
