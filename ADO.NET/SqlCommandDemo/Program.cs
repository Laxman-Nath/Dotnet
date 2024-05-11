using System.Data.SqlClient;
using System.Data;
class Program {

    //public static void Connection()
    //{
    //    string cs = "Data Source=DESKTOP-0R1UM5C\\SQLEXPRESS; Initial Catalog=ado_db; Integrated Security=true;";
    //    SqlConnection conn = new SqlConnection(cs);
    //    try
    //    {
    //        conn.Open();
    //        if (conn.State == ConnectionState.Open)
    //        {
    //            Console.WriteLine("Connection is created successfully");
    //        }
    //    }
    //    catch (SqlException e)
    //    {
    //        Console.WriteLine("Exception Occured:" + e.Message);
    //    }
    //    finally
    //    {
    //        conn.Close();
    //    }
    //}
    public static void Main(string[] args)
    {
       string cs= "Data Source=DESKTOP-0R1UM5C\\SQLEXPRESS; Initial Catalog=ado_db; Integrated Security=true;";
        using(SqlConnection conn = new SqlConnection(cs))
        {
            //String query = "select * from Employee";
            string query = "spGetEmployees";

            //SqlCommand cmd = new SqlCommand(query, conn);

            //SqlCommand cmd = conn.CreateCommand();
            //cmd.CommandText = query;
            //cmd.Connection = conn;

             SqlCommand cmd = new SqlCommand(query,conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("Id= " +reader["id"]+" Name:"+reader["name"]+" Gender:"+reader["gender"]+" Age:" +reader["age"]+" Salary:" +reader["salary"]+" City:" +reader["city"]);
            }
        }
    }
}

