using System;
using System.Data;
using System.Data.SqlClient;
namespace MyApp
{
    class Program {
        public static void connection()
        {
            String cd = "Data source=DESKTOP-0R1UM5C\\SQLEXPRESS; Initial Catalog=ado_db; Integrated security=true";
            SqlConnection conn=new SqlConnection(cd);
            //conn.Open();
            SqlDataAdapter sad = new SqlDataAdapter("Select * from Student", conn);
            DataSet ds = new DataSet();
            sad.Fill(ds);
            Console.WriteLine("The details of student are:");
            foreach(DataRow row in ds.Tables[0].Rows)
            {
                Console.WriteLine("Id:" + row[0]+" Name:" + row[1]+" Address:" + row[2]);
            }
        }
        public static void Main(string[] args)
        {
            Program.connection();
        }
    }

}

