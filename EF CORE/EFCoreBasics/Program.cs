using EFCoreBasics.Models;
//using EFCoreBasics.Database;
using Microsoft.EntityFrameworkCore;
namespace myApp
{
    class AppDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }


        public string ConnectionString { get; set; }
        public AppDbContext()
        {
            ConnectionString = "Data Source=DESKTOP-0R1UM5C\\SQLEXPRESS; Initial Catalog=EmployeeMngt_EFCorePractice; Integrated Security=True; trustServerCertificate=true";
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

    }

    class Program
    {

        public static void insert(AppDbContext context)
        {
            //var context = new AppDbContext();

            var emp = new Employee();
            //emp.EmployeeId = 5;


            emp.EmpFirstName = "rohit";
            emp.EmpLastName = "budha";
            emp.Salary = 10000;
            context.Employees.Add(emp);
            context.SaveChanges();
        }

        public static void show(AppDbContext context)
        {
            //var context = new AppDbContext();
            // Retreiving
            //var emp = context.Employees.Where(e => e.EmployeeId == 2);
             var emp = context.Employees.ToList();
            foreach (Employee e in emp)
            {
                Console.WriteLine("Id:" + e.EmployeeId);
                Console.WriteLine("First Name:" + e.EmpFirstName);
                Console.WriteLine("Last Name:" + e.EmpLastName);
                Console.WriteLine("Salary:" + e.Salary);
            }
        }

        public static void SpecificShow(AppDbContext context)
        {
            //var context = new AppDbContext();

            var emp = context.Employees.Single(e => e.EmployeeId == 1);
            Console.WriteLine("First Name:" + emp.EmpFirstName);
            Console.WriteLine("Last Name:" + emp.EmpLastName);
            Console.WriteLine("Salary:" + emp.Salary);
        }

        public static void update(AppDbContext context)
        {
            //Updating
            var emp = context.Employees.Single(e => e.EmployeeId == 2);
            emp.EmpFirstName = "Manoj";
            emp.EmpLastName = "B.K";
            emp.Salary = 5000;
            context.SaveChanges();
            Console.WriteLine("First Name:" + emp.EmpFirstName);
            Console.WriteLine("Last Name:" + emp.EmpLastName);
            Console.WriteLine("Salary:" + emp.Salary);
        }

        public void delete(AppDbContext context)
        {
            // Deleting
            var emp = context.Employees.Single(e => e.EmployeeId == 2);
            context.Employees.Remove(emp);
            context.SaveChanges();
        }
        public static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {

                //insert(context);
                //show(context);
                update(context);






            }
        }
    }
}
