using TaskManager.Entities;

namespace TaskManager.Services
{
    public interface ITaskService
    {
        Task<List<UserTask>> GetAllTasks();
        Task<UserTask> AddTask(UserTask userTask, string userId);
        Task<UserTask> GetTaskById(int id, string userId);
        Task<UserTask> EditTask(int id, UserTask userTask, string userId);
        Task<bool> DeleteTask(int id, string userId);
        Task<List<UserTask>> GetTasksForUser(string userId);
    }
}
