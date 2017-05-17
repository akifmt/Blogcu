using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20170516_odev.DAL.IRepositories
{
    interface IGetByID<T, R>
        where T : class
        where R : struct
    {
        T GetByID(R? parameter, T parameter1);
    }
}
