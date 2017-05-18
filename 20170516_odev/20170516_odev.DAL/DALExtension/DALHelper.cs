using _20170516_odev.DAL.Creational;
using _20170516_odev.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20170516_odev.DAL.DALExtension
{
    class DALHelper
    {
        internal static DataSet ExecDisconnected(string spName, Databases sDb)
        {
            DataSet ds = new DataSet();

            IDbConnection cnn = DBSelect.CreateConnection(sDb);
            IDbCommand cmd = CommandSelect.CreateCommand(sDb);
            cmd.CommandText = spName;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            IDataAdapter adapter = AdapterSelect.CreateAdapter(sDb, cmd);
            adapter.Fill(ds);

            return ds;
        }
        internal static IDataReader ExecReader(string spName, Databases sDb)
        {
            IDataReader DataReader;

            IDbConnection cnn = DBSelect.CreateConnection(sDb);
            IDbCommand cmd = CommandSelect.CreateCommand(sDb);

            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
                cmd.Parameters.Clear();
            }



            if (cmd != null)
            {
                cnn.Close();
                cmd.Parameters.Clear();
            }


            cmd.CommandText = spName;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }

            DataReader = cmd.ExecuteReader();

            //DataReader.Close();

            return DataReader;
        }

        internal static Object ExecNonQuery(string spName, Databases sDb, ICollection<KeyValuePair<string, object>> param)
        {
            object Gelen;
            IDbConnection cnn = DBSelect.CreateConnection(sDb);
            IDbCommand cmd = CommandSelect.CreateCommand(sDb);

            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
                cmd.Parameters.Clear();
            }

            cmd.CommandText = spName;

            foreach (KeyValuePair<string,object> item in param)
            {
                cmd.Parameters.Add(ParameterSelect.CreateParameter(sDb, item.Key, item.Value));
            }
            
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }

            Gelen = cmd.ExecuteNonQuery();

            return Gelen;
        }



        internal static Object ExecReturnObject(string spName, Databases sDb, ICollection<KeyValuePair<string, object>> param)
        {
            object Gelen;
            IDbConnection cnn = DBSelect.CreateConnection(sDb);
            IDbCommand cmd = CommandSelect.CreateCommand(sDb);

            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
                cmd.Parameters.Clear();
            }

            cmd.CommandText = spName;

            foreach (KeyValuePair<string, object> item in param)
            {
                cmd.Parameters.Add(ParameterSelect.CreateParameter(sDb, item.Key, item.Value));
            }

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }

            Gelen = cmd.ExecuteReader();

            return Gelen;
        }

        internal static Object ExecReader(string spName, Databases sDb, int? id, string param)
        {
            object Gelen;
            IDbConnection cnn = DBSelect.CreateConnection(sDb);
            IDbCommand cmd = CommandSelect.CreateCommand(sDb);

            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
                cmd.Parameters.Clear();
            }
            cmd.CommandText = spName;

            var parameter = cmd.CreateParameter();
            parameter.ParameterName = param;
            parameter.Value = id;
            cmd.Parameters.Add(parameter);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }

            
            Gelen = cmd.ExecuteReader();

            return Gelen;
        }


    }
}
