using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ElDee
{
    internal class Db
    {
        private const string _connectionStr = @"Data Source=DESKTOP-LGPJDMJ\SQLEXPRESS;
                                             Initial Catalog=DD3E;
                                             Integrated Security=True;
                                             Connect Timeout=15;
                                             Encrypt=False;
                                             TrustServerCertificate=False;
                                             ApplicationIntent=ReadWrite;
                                             MultiSubnetFailover=False";
        public static string ConnectionStr => _connectionStr;


        public static List<string[]> SqlSelect(string sqlStr)
        {
            var items = new List<string[]>();


            using (var connection = new SqlConnection(_connectionStr))
            {
                var command = connection.CreateCommand();

                command.CommandText = sqlStr;
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var tempArr = new string[reader.FieldCount];
                    for (var i = 0; i < reader.FieldCount; i++)
                        tempArr[i] = reader[i].ToString();
                    items.Add(tempArr);
                }
                reader.Close();
            }
            return items;
        }

        public static bool SqlInsert(string sqlStr)
        {
            bool flag;

            using (var connection = new SqlConnection(_connectionStr))
            {
                var command = new SqlCommand(sqlStr, connection);
                connection.Open();
                try
                {
                    flag = command.ExecuteNonQuery() == 1;

                }
                catch (Exception e)
                {
                    flag = false;
                    MessageBox.Show($"Интересная ОШИБКА БД!\n{e.Message}");

                }
                connection.Close();
            }
            return flag;

        }

        public static bool SqlUpdate(string sqlStr)
        {
            bool flag;

            using (var connection = new SqlConnection(_connectionStr))
            {
                var command = new SqlCommand(sqlStr, connection);
                connection.Open();
                try
                {
                    flag = command.ExecuteNonQuery() == 1;

                }
                catch (Exception e)
                {
                    flag = false;
                    MessageBox.Show($"Интересная ОШИБКА БД!\n{e.Message}");

                }
                connection.Close();
            }
            return flag;

        }

        public static bool SqlDelete(string sqlStr)
        {
            bool flag;

            using (var connection = new SqlConnection(_connectionStr))
            {
                var command = new SqlCommand(sqlStr, connection);

                connection.Open();
                try
                {
                    flag = command.ExecuteNonQuery() == 1;

                }
                catch (Exception e)
                {
                    flag = false;
                    MessageBox.Show($"Интересная ОШИБКА БД!\n{e.Message}");
                }
                connection.Close();
            }
            return flag;

        }

    }
}
