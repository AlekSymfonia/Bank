using EFCoreInMemoryDbDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class ApiContext : DbContext
    {
        protected override void OnConfiguring
       (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "BankDB");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<AccountHistory> History { get; set; }
    }

    public class User()
    {
        public int Id_user { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string accountNumber { get; set; }
        public int money { get; set; }
    }

    public class AccountHistory()
    {
        public int Id_history { get; set; }
        public bool transction { get; set; }  // true -> payment ; false -> paycheck
        public int howMuchMoney { get; set; }
        public int Id_u { get; set; }
    }
}