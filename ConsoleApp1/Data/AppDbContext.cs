using ConsoleApp1.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Data
{
    public class AppDbContext:DbContext
    {
        
        private readonly IConfiguration _config;

        public AppDbContext(IConfiguration config)
        {
            _config = config;
        }
        public DbSet<Employee> Employee { get; set; }
        /*public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }*/
       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            // var connectionString = "server=localhost;user=root;password=root;database=test_ef";
            var connectionString = _config.GetValue<string>("ConnectionStrings");
            var serverVersion = new MySqlServerVersion(new Version(5,7,24));
            optionsBuilder.UseMySql(connectionString, serverVersion);                    
        }
    }

}
