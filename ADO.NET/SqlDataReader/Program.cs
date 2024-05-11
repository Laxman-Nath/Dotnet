using System;
using System.Data;
using System.Data.SqlClient;
namespace myApp
{
    class Program {
        public static void connection()
        {
            String cd = "Data source=DESKTOP-0R1UM5C\\SQLEXPRESS; Initial Catalog=ado_db; Integrated security=true";
           SqlConnection conn=new SqlConnection(cd);
            conn.Open();
            string query = "Select * from Student";
            using(SqlCommand cmd=new SqlCommand(query,conn)) { 
                SqlDataReader rd=cmd.ExecuteReader();
                Console.WriteLine(rd.FieldCount);
                while(rd.Read())
                {
                    Console.WriteLine("ID:" + rd[0]+" Name:" + rd[1]+" Address:" + rd[2]);
                }
                rd.Close();
            }
            conn.Close();
        }
        public static void Main(string[] args)
        {
            Program.connection();
        }
    }

}

