﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20170516_odev.DAL.IRepositories
{
    interface IDelete<T> where T : class
    {
        int Delete(T parameter);
    }
}
