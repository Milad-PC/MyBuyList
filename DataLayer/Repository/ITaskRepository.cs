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
        Task GetTaskById(int id);

        bool TaskStatus(int id);

        bool DoTask(Task task,int userid);
        bool UndoTask(Task task);

        bool Insert(Task task);
        bool Update(Task task);
        bool Delete(int id);

        void Save();
    }
}
