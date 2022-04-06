using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface ITaskRepository:IDisposable
    {
        IEnumerable<Task> GetAllTasks();
        IEnumerable<Task> GetTasksByUser(int userId);
        Task GetTaskById(int id);

        bool TaskStatus(int id);

        bool DoTask(int id,int userid);
        bool UndoTask(int id);

        bool Insert(Task task);
        bool Update(Task task);
        bool Delete(int id);

        void Save();
    }
}
