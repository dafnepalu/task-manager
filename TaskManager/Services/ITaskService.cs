using TaskManager.Entities;

namespace TaskManager.Services
{
    public interface ITaskService
    {
        Task<List<UserTask>> GetAllTasks();
        Task<UserTask> AddTask(UserTask userTask);
        Task<UserTask> GetTaskById(int id);
        Task<UserTask> EditTask(int id, UserTask userTask);
        Task<bool> DeleteTask(int id);
    }
}
