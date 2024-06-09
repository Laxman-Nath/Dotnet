using System;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
namespace db
{
    
    public class Program {
        public static void insert()
        {
            Console.WriteLine("Enter Id:");
            string Id = Console.ReadLine();
            Console.WriteLine("Enter name:");
            string name=Console.ReadLine();
            Console.WriteLine("Enter gender:");
            string gender = Console.ReadLine();
            Console.WriteLine("Enter age:");
            string age = Console.ReadLine();
            Console.WriteLine("Enter salary:");
            string salary = Console.ReadLine();
            Console.WriteLine("Enter city:");
            string city = Console.ReadLine();
            SqlConnection conn = null;
           string cs= "Data Source=DESKTOP-0R1UM5C\\SQLEXPRESS; Initial Catalog=ado_db; Integrated Security=true";
            using (conn = new SqlConnection(cs))
            {
                String query = "Insert into Employee values(@Id,@name,@gender,@age,@salary,@city)";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("Id", Id);
                cmd.Parameters.AddWithValue("name", name);
                cmd.Parameters.AddWithValue("gender", gender);
                cmd.Parameters.AddWithValue("age", age);
                cmd.Parameters.AddWithValue("salary", salary);
                cmd.Parameters.AddWithValue("city", city);

                int affectedRows = cmd.ExecuteNonQuery();
                if (affectedRows > 0)
                {
                    Console.WriteLine("Successfully inserted");
                }
                else
                {
                    Console.WriteLine("Error inserting");
                }
            }
           

        }
        public static void update()
        {
            Console.WriteLine("Enter Id you want to update:");
            string Id = Console.ReadLine();
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter gender:");
            string gender = Console.ReadLine();
            Console.WriteLine("Enter age:");
            string age = Console.ReadLine();
            Console.WriteLine("Enter salary:");
            string salary = Console.ReadLine();
            Console.WriteLine("Enter city:");
            string city = Console.ReadLine();
            
            string cs = "Data Source=DESKTOP-0R1UM5C\\SQLEXPRESS; Initial Catalog=ado_db; Integrated Security=true";
            using (SqlConnection conn = new SqlConnection(cs))
            {
                string query = "update Employee set name=@name,gender=@gender,age=@age,salary=@salary,city=@city where id=@id";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue ("id", Id);
                cmd.Parameters.AddWithValue("name", name);
                cmd.Parameters.AddWithValue("gender", gender);
                cmd.Parameters.AddWithValue("age", age);
                cmd.Parameters.AddWithValue("salary", salary);
                cmd.Parameters.AddWithValue("city", city);

                int affectedRows = cmd.ExecuteNonQuery();
                if (affectedRows > 0)
                {
                    Console.WriteLine("Successfully Updated");
                }
                else
                {
                    Console.WriteLine("Error updating");
                }
            }
        }

        public static void delete()
        {
            Console.WriteLine("Enter the id you want to delete:");
            string Id=   Console.ReadLine();
            string cs = "Data Source=DESKTOP-0R1UM5C\\SQLEXPRESS; Initial Catalog=ado_db; Integrated Security=true";
            using (SqlConnection conn=new SqlConnection(cs))
            {
                string query = "delete from Employee where id=@Id";
                conn.Open();
                SqlCommand cmd= new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", Id);
                int affectedRows = cmd.ExecuteNonQuery();
                if (affectedRows > 0)
                {
                    Console.WriteLine("Deleted successfully");
                }
                else
                {
                    Console.WriteLine("Error deleting");
                }
            }
        }

        public static void show()
        {
            string cs = "Data Source=DESKTOP-0R1UM5C\\SQLEXPRESS; Initial Catalog=ado_db; Integrated Security=true";
            using(SqlConnection conn=new SqlConnection(cs))
            {
                Console.WriteLine("Enter id of a student:");
                string id = Console.ReadLine();
                //String query="Select * from Employee where Id='"+id+"'";
                String query = "Select * from Employee where Id=@id";
                conn.Open();
                SqlCommand cmd=new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("id", id);
                SqlDataReader reader= cmd.ExecuteReader();
                while(reader.Read())
                {
                    Console.WriteLine( " Name:" + reader["name"] + " Gender:" + reader["gender"] + " Age:" + reader["age"] + " Salary:" + reader["salary"] + " City:" + reader["city"]);

                }
            }
        }
        public static void Main(string[] args)
        {
            //Program.insert();
            //Program.update();
            //Program.delete();
            Program.show();

        }
    }

}
