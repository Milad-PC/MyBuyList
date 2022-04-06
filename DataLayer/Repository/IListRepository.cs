using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IListRepository:IDisposable
    {
        IEnumerable<List> GetAllLists();
        IEnumerable<List> GetListsByUserID(int id);
        List GetListByID(int id);
        List GetListByName(string name);

        bool IsUserListMaker(int listId, int userId);

        bool Insert(List list);
        bool Update(List list);
        bool Delete(int id);
        bool Delete(List list);

        void Save();
    }
}
