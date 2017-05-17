using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20170516_odev.DAL.Creational
{
    class CommandInstance
    {
        private static CommandInstance _instance;

        private CommandInstance()
        {

        }

        public static CommandInstance Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CommandInstance();
                }
                return _instance;
            }
        }

        private SqlCommand _command;

        public SqlCommand Command
        {
            get
            {
                if (_command == null)
                {
                    _command = new SqlCommand();
                }
                return _command;
            }
        }
    }
}
