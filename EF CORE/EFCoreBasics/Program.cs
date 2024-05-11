using EFCoreBasics.Models;
using EFCoreBasics.Database;
using(var context=new AppDbContext())
{
    //var emp=new Employee();
    //emp.EmployeeId = 1;
    // Inserting

    //emp.EmpFirstName = "Laxman";
    //emp.EmpLastName = "Nath";
    //emp.Salary = 10000;
    //context.Employees.Add(emp);
    //context.SaveChanges();

    // Retreiving
    //var emp = context.Employees.ToList();
    //foreach(Employee e in emp)
    //{
    //    Console.WriteLine("Id:" + e.EmployeeId);
    //    Console.WriteLine("First Name:" + e.EmpFirstName);
    //    Console.WriteLine("Lasr Name:" + e.EmpLastName);
    //    Console.WriteLine("Salary:" + e.Salary);
    //}

    //var emp = context.Employees.Single(e => e.EmployeeId == 1);
    //Console.WriteLine("First Name:" + emp.EmpFirstName);
    //Console.WriteLine("Lasr Name:" + emp.EmpLastName);
    //Console.WriteLine("Salary:" + emp.Salary);

    //Updating
    //var emp = context.Employees.Single(e => e.EmployeeId == 2);
    //emp.EmpFirstName = "Bikash";
    //emp.EmpLastName = "Chand";
    //emp.Salary = 5000;
    //context.SaveChanges();
    //Console.WriteLine("First Name:" + emp.EmpFirstName);
    //Console.WriteLine("Lasr Name:" + emp.EmpLastName);
    //Console.WriteLine("Salary:" + emp.Salary);

    // Deleting
    var emp=context.Employees.Single(e => e.EmployeeId==2);
    context.Employees.Remove(emp);
    context.SaveChanges();
}
