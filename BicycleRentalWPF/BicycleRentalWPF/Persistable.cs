﻿using System;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleRentalWPF
{
    public class Persistable
    {
        System.Data.OleDb.OleDbConnection conn;
        protected static string connectionString { get; set; }
        public Persistable()
        {
            conn = new System.Data.OleDb.OleDbConnection();
        }

        public void configureConnection()
        {
            conn.ConnectionString = connectionString;
        }

        public List<Object> getValues(string queryString)
        {
            List<Object> results = new List<Object>();
            configureConnection();
            using (conn)
            {
                System.Data.OleDb.OleDbCommand command = new System.Data.OleDb.OleDbCommand(queryString, conn);
                try
                {
                    conn.Open();
                    System.Data.OleDb.OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Object[] nextRow = new Object[reader.FieldCount];
                        reader.GetValues(nextRow);
                        results.Add(nextRow);
                    }
                    return results;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    return null;
                }
            }
        }

        public int modifyDatabase(string queryString)
        {
            configureConnection();
            using (conn)
            {
                System.Data.OleDb.OleDbCommand command = new System.Data.OleDb.OleDbCommand(queryString);
                command.Connection = conn;
                try
                {
                    conn.Open();
                    command.ExecuteNonQuery();
                    return 0;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return 1;
                }
            }
        }
    }
}
