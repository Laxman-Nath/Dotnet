using EFCoreBasics.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreBasics.Database
{
    public class AppDbContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        
  
        public string ConnectionString { get; set; }
        public AppDbContext() {
            ConnectionString = "Data Source=DESKTOP-0R1UM5C\\SQLEXPRESS; Initial Catalog=EmployeeMngt_EFCorePractice; Integrated Security=True; trustServerCertificate=true";
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
      

        
    }
}
