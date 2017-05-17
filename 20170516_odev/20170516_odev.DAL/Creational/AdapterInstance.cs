using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20170516_odev.DAL.Creational
{
    class AdapterInstance
    {
        private static AdapterInstance _instance;

        private AdapterInstance()
        {

        }

        public static AdapterInstance Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AdapterInstance();
                }
                return _instance;
            }
        }
        public SqlCommand Command { get; set; }
        private SqlDataAdapter _adapter;
        public SqlDataAdapter Adapter
        {
            get
            {
                if (_adapter == null)
                {
                    _adapter = new SqlDataAdapter(Command);
                }
                return _adapter;
            }
        }
    }
}
