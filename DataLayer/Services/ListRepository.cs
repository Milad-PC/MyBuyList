using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ListRepository : IListRepository
    {
        MyContext db;
        public ListRepository(MyContext mydb)
        {
            db = mydb;
        }
        public bool Delete(int id)
        {
            return Delete(GetListByID(id));
        }

        public bool Delete(List list)
        {
            try
            {
                db.Entry(list).State = System.Data.Entity.EntityState.Deleted;
                return true;
            }
            catch { return false; }
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public IEnumerable<List> GetAllLists()
        {
            return db.Lists ;
        }

        public List GetListByID(int id)
        {
            return db.Lists.Find(id);
        }

        public IEnumerable<List> GetListsByUserID(int id)
        {
            IEnumerable<List> lists = db.Lists.Where(u=>u.MakerID==id);

            lists = lists.Concat(db.Partners.Where(u => u.UserID == id).Select(u => u.List));

            return lists;
        }

        public bool Insert(List list)
        {
            try
            {
                db.Lists.Add(list);
                return true;
            }catch { return false; }
        }

        public bool IsUserListMaker(int listId, int userId)
        {
             return db.Lists.Where(u=>u.ListID==listId && u.MakerID==userId).Any();
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public bool Update(List list)
        {
            try
            {
                db.Entry(list).State = System.Data.Entity.EntityState.Modified;
                return true;
            }
            catch { return false; }
        }
    }
}
