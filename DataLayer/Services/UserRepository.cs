using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Services
{
    internal class UserRepository : IUserRepository
    {
        MyContext db;
        public UserRepository(MyContext mydb)
        {
            db = mydb;
        }
        public void Dispose()
        {
            db.Dispose();
        }

        public bool Existed(string UserName, string Password)
        {
            return db.Users.Where(u=>u.UserName == UserName && u.Password == Password).Any();
        }

        public User Get(int id)
        {
            return db.Users.Find(id);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return db.Users;
        }

        public bool Insert(User user)
        {
            try
            {
                db.Users.Add(user);
                return true;
            }catch { return false; }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public bool Update(User user)
        {
            try
            {
                db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                return true;
            }
            catch { return false; }
        }
    }
}
