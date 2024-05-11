// Write an ADO.NET application to read the data from existing table MOVIE(id,name,genre) where genre is "comedy";
using System.Data.SqlClient;
namespace myApp
{
    class Program {
      static  string cs = "Data source=DESKTOP-0R1UM5C\\SQLEXPRESS;Initial Catalog=Exam;Integrated Security=True";
       
        public static void insert()
        {
            // Inserting
            SqlConnection conn = new SqlConnection(cs);
            Console.WriteLine("Enter id:");
            string id = Console.ReadLine();
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter genre:");
            string genre = Console.ReadLine();
            string query = "Insert into MOVIE values(@id,@name,@genre)";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("name", name);
            cmd.Parameters.AddWithValue("genre", genre);
            int affectedRows= cmd.ExecuteNonQuery();
            if(affectedRows > 0)
            {
                Console.WriteLine("Inserted successfully");
            }
            else
            {
                Console.WriteLine("Error inserting record");
            }
        }
        public static void read()
        {
            SqlConnection conn = new SqlConnection(cs);
            Console.WriteLine("Enter genre:");
            string genre = Console.ReadLine();
            string query = "select * from MOVIE where genre=@genre";
            conn.Open();
            SqlCommand cmd=new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("genre",genre);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("Id:" + reader[0]);
                Console.WriteLine("Name:" + reader[1]);
                Console.WriteLine("Genre:" + reader[2]);
            }
        }
        public static void Main(string[] args) {
            //Program.insert();
            Program.read();
            
        }
    }

}
