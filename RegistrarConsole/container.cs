using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RegistrarConsole
{
    static class container
    {
        private static WebClient client = new WebClient();
        public static Func<string, string> download = url => client.DownloadString(url);
        public static Func<string, Func<string>> curryer = download.Curry();

        public static Func<TParam1, Func<TResult>> Curry<TParam1, TResult>(this Func<TParam1, TResult> func)
        {
            return parameter => () => func(parameter);
        }

        public static void Funker()
        {
            var data = curryer("").Execute();
            var announcement = new SortedDictionary<string, HashSet<Student>>();
        }

        public static T Execute<T>(this Func<T> action)
        {
            var result = default(T);
            try
            {
                result = action();
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }

        public static DataSet Select<T>(this T value, string query)
        {
            var dataSet = new DataSet();
            //try
            //{
            //    if (OpenConnection())
            //    {
            //        using (SqlCommand command = connection.CreateCommand())
            //        {
            //            command.CommandText = query;
            //            using (SqlDataAdapter adapter = new SqlDataAdapter())
            //            {
            //                adapter.SelectCommand = command;
            //                adapter.Fill(dataSet);
            //            }
            //        }
            //    }
            //}
            //catch
            //{
            //    throw;
            //}
            //finally
            //{
            //    connection.Close();
            //}
            return dataSet;
        }
    }
}
