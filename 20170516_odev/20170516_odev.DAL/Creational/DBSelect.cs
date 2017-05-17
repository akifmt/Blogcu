using _20170516_odev.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20170516_odev.DAL.Creational
{
    class DBSelect
    {
        public static IDbConnection CreateConnection(Databases selectDb)
        {
            IDbConnection dbInstance = null;

            switch (selectDb)
            {
                case Databases.MSSQL:
                    DBInstance myConnection = DBInstance.Instance;
                    dbInstance = myConnection.Connection;
                    dbInstance.Close();
                    break;
                case Databases.MYSQL:
                    break;
                case Databases.ORACLE:
                    break;
                default:
                    break;
            }

            return dbInstance;
        }
    }
}
