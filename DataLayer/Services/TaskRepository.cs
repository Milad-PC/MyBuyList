using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class TaskRepository : ITaskRepository
    {
        MyContext db;
        public TaskRepository(MyContext mydb)
        {
            db = mydb;
        }
        public bool Delete(int id)
        {
            try
            {
                db.Entry(GetTaskById(id)).State = System.Data.Entity.EntityState.Deleted;
                return true;
            }
            catch { return false; }
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public bool DoTask(Task task, int userid)
        {
            try
            {
                task.IsDone = true;
                task.UserID = userid;
                db.Entry(task).State = System.Data.Entity.EntityState.Modified;
                return true;
            }
            catch { return false; }
        }

        public IEnumerable<Task> GetAllTasks()
        {
            return db.Tasks;
        }

        public Task GetTaskById(int id)
        {
            return db.Tasks.Find(id);
        }

        public bool Insert(Task task)
        {
            try
            {
                db.Tasks.Add(task);
                return true;
            }catch { return false; }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public bool TaskStatus(int id)
        {
            return db.Tasks.Find(id).IsDone;
        }

        public bool UndoTask(Task task)
        {
            try
            {
                task.IsDone = false;
                db.Entry(task).State = System.Data.Entity.EntityState.Modified;
                return true;
            }
            catch { return false; }
        }

        public bool Update(Task task)
        {
           try
            {
                db.Entry(task).State = System.Data.Entity.EntityState.Modified;
                return true;
            }
            catch { return false; }
        }
    }
}
