using MyStore.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore.Infrastructure.DataMSSQL
{
    public class MyStoreDatabase : DbContext
    {
        public MyStoreDatabase()
            : base("name=MyStoreMSSQLConnection")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Store> Stores { get; set; }
    }
}
