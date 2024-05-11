using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using EFCorePractice2.Models;
namespace EFCorePractice2.Database
{
    public class AppDbContext:DbContext
    {
       public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string ConnectionString = "Data source=DESKTOP-0R1UM5C\\SQLEXPRESS ; Initial Catalog=StudentDb;Integrated Security=True; trustServerCertificate=true;";
           optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
