using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Database
    {
        static void Main(string[] args)
        {
            using (var conn = new SQLiteConnection("Data Source=Bank.db"))
            {
                conn.Open();
            }
        }
    }
}