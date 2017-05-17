using _20170516_odev.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20170516_odev.DAL.Creational
{
    class AdapterSelect
    {
        public static IDataAdapter CreateAdapter(Databases parameter, IDbCommand cmd)
        {
            IDataAdapter adapterInstance = null;

            switch (parameter)
            {
                case Databases.MSSQL:
                    AdapterInstance myAdapter = AdapterInstance.Instance;
                    myAdapter.Command = (SqlCommand)cmd;
                    adapterInstance = myAdapter.Adapter;
                    break;
                case Databases.MYSQL:
                    break;
                case Databases.ORACLE:
                    break;
                default:
                    break;
            }
            return adapterInstance;
        }
    }
}
