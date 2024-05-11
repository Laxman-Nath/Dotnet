using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using _2080EFCore.Models;
namespace _2080EFCore.Database

{
    public class AppDbContext:DbContext
    {
        public DbSet<BAG> bAGs {  get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string cs = "Data Source=DESKTOP-0R1UM5C\\SQLEXPRESS; Initial Catalog=Exam; Integrated Security=True;trustServerCertificate=true";
            optionsBuilder.UseSqlServer(cs);
        }
    }
}
