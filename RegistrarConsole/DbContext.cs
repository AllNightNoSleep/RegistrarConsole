using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RegistrarConsole
{
    public static class DbContext
    {
        private static SqlConnection connection;
        static DbContext()
        {
            connection = new SqlConnection("Data Source=localhost;Initial Catalog=TestDb;Integrated Security=true;");
        }

        private static bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        private static void CloseConnection()
        {
            try
            {
                connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static string GetTableNameFromT(Type type)
        {
            return Activator.CreateInstance(type).GetType().Name;
        }

        private static PropertyInfo[] GetPropertiesFromTableT(Type type)
        {
            return type.GetProperties();
        }

        public static int InsertData<T>(T values)
        {
            int result = 0;
            try
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    string query;
                    query = "INSERT INTO [dbo].[";
                    var type = GetTableNameFromT(typeof(T));
                    query += type + "] (";

                    //Dictionary<string, object> listOfValues = new Dictionary<string, object>();
                    var properties = GetPropertiesFromTableT(typeof(T));
                    foreach (var info in properties)
                    {
                        if(info.Name != "ID")
                        {
                            query += info.Name;
                        }
                        //listOfValues.Add(info.Name, info.GetValue(values, null));
                        //Console.WriteLine("{0}: {1}", info.Name, info.GetValue(values, null));
                    }
                    foreach (var info in properties)
                    {

                    }


                    Console.ReadKey();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                CloseConnection();
            }
            return result;
        }

        public static IEnumerable<T> SelectData<T>(string query)
        {
            ICollection<T> collection = new List<T>();
            try
            {
                using(SqlCommand cmd = connection.CreateCommand())
                {
                    
                }
            }
            catch (Exception)
            {
                throw;
            }
            return collection;
        }

        public static Func<string, IEnumerable<Student>> studentSelecterTwoOrMore = query => SelectData<Student>(query);
        //public static Func<string, Student> studentSelect = query => SelectData<Student>(query);

        public static int InsertData<TKey, TParams, T>(this Dictionary<TKey, TParams> entity, T table)
        {
            int result = 0;
            studentSelecterTwoOrMore("query");
            return result;
        }
        
    }
}
