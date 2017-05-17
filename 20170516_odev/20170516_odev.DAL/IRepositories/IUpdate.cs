using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20170516_odev.DAL.IRepositories
{
    interface IUpdate<T> where T : class
    {
        int Update(T parameter);
    }
}
