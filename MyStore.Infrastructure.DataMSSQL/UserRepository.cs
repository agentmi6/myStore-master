using MyStore.Domain.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore.Infrastructure.DataMSSQL
{
    public class UserRepository : IUserRepository
    {
        MyStoreDatabase db = new MyStoreDatabase();
        public List<Domain.User> GetAll()
        {
            return db.Users.ToList();
        }

        public void Create(Domain.User user)
        {
            user.DateCreated = DateTime.UtcNow;

            db.Users.Add(user);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var dbUser = db.Users.Find(id);
            db.Users.Remove(dbUser);
            db.SaveChanges();
        }
    }
}
