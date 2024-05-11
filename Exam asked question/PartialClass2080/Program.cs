namespace MyApplication
{
  public partial  class Employee {
        public int Id { get; set; }
        public string Name { get; set; }
        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }  
        public void show()
        {
            Console.WriteLine("Name is :" + Name);
            Console.WriteLine("Id is:" + Id);
        }
        
    }

   public class Program {
        public static void Main(string[] args) {
            Employee e = new Employee(1, "Laxman");
            e.show();
        }  
    }

}

