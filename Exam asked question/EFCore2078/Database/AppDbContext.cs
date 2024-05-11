using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCore2078.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
namespace EFCore2078.Database
{
    public class AppDbContext :DbContext
    {
      public  DbSet<Employee> emp {  get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source =DESKTOP-0R1UM5C\\SQLEXPRESS; Initial Catalog=exam2; Integrated Security=True; trustServerCertificate=True");
        }
    }
}
