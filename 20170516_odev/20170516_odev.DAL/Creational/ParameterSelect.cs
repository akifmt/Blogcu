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
    class ParameterSelect
    {
        public static IDataParameter CreateParameter(Databases selectDb, string paramName, object paramValue)
        {
            IDataParameter paramInstance = null;

            switch (selectDb)
            {
                case Databases.MSSQL:
                    paramInstance = SqlClientFactory.Instance.CreateParameter();
                    paramInstance.ParameterName = paramName;
                    paramInstance.Value = paramValue;
                    break;
                case Databases.MYSQL:
                    break;
                case Databases.ORACLE:
                    break;
                default:
                    break;
            }

            return paramInstance;
        }


    }
}
