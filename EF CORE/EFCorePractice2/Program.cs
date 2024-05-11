using EFCorePractice2.Database;
using EFCorePractice2.Models;
try
{
    using (var context = new AppDbContext())
    {
        // Inserting in database
        //var st = new Student();
        ////st.Id = 2;
        //st.Name = "Bikash";
        //st.Address = "mnr";
        //context.Students.Add(st);
        //context.SaveChanges();

        // Retrieving
        //var std=context.Students.ToList();
        //foreach(var s in std)
        //{
        //    Console.WriteLine("Id:" + s.Id);
        //    Console.WriteLine("Name:"+s.Name);
        //    Console.WriteLine("Address:"+s.Address);

        //}

        //var std = context.Students.Where(e=>e.Address=="mnr");
        //foreach (Student s in std)
        //{
        //    Console.WriteLine("Id:" + s.Id);
        //    Console.WriteLine("Name:" + s.Name);
        //    Console.WriteLine("Address:" + s.Address);
        //}

        // updating 
        //var std=context.Students.Single(e=>e.Id==1);
        //std.Address = "Belauri";
        //context.SaveChanges();

        // Deleting
        var std = context.Students.Single(e => e.Id == 1);
        context.Students.Remove(std);
        context.SaveChanges();

        
    }
}
catch(Exception e)
{
    Console.WriteLine(e.StackTrace);
}

