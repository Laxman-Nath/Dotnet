// Create a table named BAG(ID,Brand,Price,Date).Perform the following operations using Entity Framwork core.
// a.Update the price of those book to 2000 who are published in 2022.
// b.Delete the book which are published in 1981.
// c.Retrieve the Brand of Book having price greater tahn 500

using _2080EFCore.Models;
using _2080EFCore.Database;
using System.Diagnostics;
using (var context = new AppDbContext())
{
    //var bg = new BAG();
    //bg.Brand = "gutchi";
    //bg.Price = 800;
    //DateOnly d1= new DateOnly(2022,1,1);
    //bg.Date = d1;
    //var bg2 = new BAG();
    //bg2.Brand = "Reebok";
    //bg2.Price = 1000;
    //DateOnly d2= new DateOnly(1981,2,2);
    //bg2.Date = d2;
    //var bg3 = new BAG();
    //bg3.Brand = "Nike";
    //bg3.Price = 400;
    //DateOnly d3=new DateOnly(2020,3,3);
    //bg3.Date = d3;
    //context.bAGs.Add(bg);
    //context.bAGs.Add(bg2);
    //context.bAGs.Add(bg3);
    //context.SaveChanges();

    //   a.Update the price of those book to 2000 who are published in 2022
    //var bg=context.bAGs.Where(e=>e.Date.Year==2022).ToList();
    //foreach(BAG b in bg)
    //{
    //    b.Price = 2000;
    //}
    //context.SaveChanges();

    //b.Delete the book which are published in 1981.
    //var b=context.bAGs.Where(e=>e.Date.Year==1981).ToList();
    //foreach(BAG bg in b)    
    //{
    //    context.bAGs.Remove(bg);
    //}
    //context.SaveChanges();

    //c.Retrieve the Brand of Book having price greater tahn 500
     var b=context.bAGs.Where(e=>e.Price>500).ToList();
    foreach(BAG bg in b)
    {
        Console.WriteLine("Id:"+bg.ID);
        Console.WriteLine("Brand:"+bg.Brand);
        Console.WriteLine("Price:" + bg.Price);
        Console.WriteLine("Date:"+bg.Date);
    }
}

//namespace my {
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine();
//        }
//    }
//}

