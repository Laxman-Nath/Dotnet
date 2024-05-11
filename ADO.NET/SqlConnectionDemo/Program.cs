using System;
using System.Data;
using System.Data.SqlClient;
namespace MyApplication
{
    class Program {
        public static void Main(string[] args) {
            Program.Connection();
            Console.ReadLine();
        }
       public static void Connection()
        {
            string cs = "Data Source=DESKTOP-0R1UM5C\\SQLEXPRESS; Initial Catalog=ado_d; Integrated security=true;";
            // SqlConnection conn=new SqlConnection(cs);
            //try
            //{
            //    conn.Open();


            //    if (conn.State == ConnectionState.Open)
            //    {
            //        Console.WriteLine("Connection has been created successfully!");
            //    }
            //}
            //catch (SqlException ex)
            //{
            //    //Console.WriteLine("Entered into catch block");
            //    Console.WriteLine("Exception occured:"+ex.Message);
            //}
            //finally
            //{
            //    //Console.WriteLine("Entered into finally block");
            //    conn.Close();
            //}

            using(SqlConnection conn = new SqlConnection(cs)) {
                try
                {
                    conn.Open();
                    if (conn.State == ConnectionState.Open)
                    {
                        Console.WriteLine("Connection has been created successfully!");
                    }
                } catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            }
        }
    }

}

