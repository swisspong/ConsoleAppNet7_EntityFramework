// See https://aka.ms/new-console-template for more information

using ConsoleApp1.Data;
using ConsoleApp1.Model;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;


namespace ConsoleApp1
{
    public class GreetingService : IGreetingService
    {
        private readonly ILogger<GreetingService> _log;
        private readonly IConfiguration _config;
        private readonly AppDbContext _dbContext;
        public GreetingService(ILogger<GreetingService> log, IConfiguration config, AppDbContext dbContext)
        {
            _log = log;
            _config = config;
            _dbContext = dbContext;
        }
        public void Run()
        {
            for (int i = 0; i < _config.GetValue<int>("LoopTimes"); i++)
            {
                _log.LogInformation("Run number {runNumber}", i);
            }

            /*  using (var dbContext = new AppDbContext())
              {
                  var newEmployee = new Employee()
                  {
                      Name = "John",
                      Title = "Doe"
                  };

                  dbContext.Employee.Add(newEmployee);
                  dbContext.SaveChanges();
              }*/

            var newEmplyee = new Employee()
            {
                Name = "test"
            };
            _dbContext.Employee.Add(newEmplyee);
            _dbContext.SaveChanges();
            _dbContext.Dispose();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}



