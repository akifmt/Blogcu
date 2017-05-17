using _20170516_odev.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20170516_odev.DAL.Creational
{
    class CommandSelect
    {
        public static IDbCommand CreateCommand(Databases parameter)
        {
            IDbCommand commandInstance = null;

            switch (parameter)
            {
                case Databases.MSSQL:
                    CommandInstance myCommand = CommandInstance.Instance;
                    commandInstance = myCommand.Command;
                    break;
                case Databases.MYSQL:
                    break;
                case Databases.ORACLE:
                    break;
                default:
                    break;
            }

            return commandInstance;
        }
}
