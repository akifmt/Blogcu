using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20170516_odev.DAL.IRepositories
{
    interface IAdd<T> where T : class
    {
        int Add(T parameter);
    }
}
