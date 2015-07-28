using MyStore.Domain;
using MyStore.Domain.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore.Infrastructure.DataMSSQL
{
    public class StoreRepository : IRepository<Store>
    {
        MyStoreDatabase db = new MyStoreDatabase();
        public List<Domain.Store> GetAll()
        {
            return db.Stores.ToList();
        }

        public void Create(Domain.Store store)
        {
            store.DateCreated = DateTime.UtcNow;

            db.Stores.Add(store);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var dbStore = db.Stores.Find(id);
            db.Stores.Remove(dbStore);
            db.SaveChanges();
        }
    }
}
