using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20170516_odev.DAL.Creational
{
    class DBInstance
    {
        private static DBInstance _instance;

        private DBInstance()
        {

        }

        public static DBInstance Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DBInstance();
                }
                return _instance;
            }
        }

        private string BaglantiCumlecigi
        {
            get
            {
                return "Server=.;Database=NORTHWND2;Integrated Security=true;MultipleActiveResultSets=true;";
            }
        }

        private SqlConnection _connection;

        public SqlConnection Connection
        {
            get
            {
                if (_connection == null)
                {
                    _connection = new SqlConnection(BaglantiCumlecigi);
                }
                return _connection;
            }
        }
    }
}
