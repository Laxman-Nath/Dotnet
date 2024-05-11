using EFCore2078.Database;
using EFCore2078.Models;
namespace myApp
{
    class Program { 
        static void insert()
        {
            using(var context=new AppDbContext())
            {
                var employee=new Employee();
                employee.Id = 3;
                employee.Name = "John";  
                employee.Salary = 12000;
                context.emp.Add(employee);
                context.SaveChanges();
            }
        }
        public static void Main(string[] args)
        {
            Program.insert();
        }
    }

}
