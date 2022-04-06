using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IUserRepository : IDisposable
    {
        IEnumerable<User> GetAllUsers();
        User Get(int id);
        bool Insert(User user);
        bool Update(User user);
        bool Existed(string UserName, string Password);
        void Save();
    }
}
