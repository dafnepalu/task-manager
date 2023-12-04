using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using TaskManager.Data;
using TaskManager.Entities;

namespace TaskManager.Services
{
    public class TaskService(ApplicationDbContext context) : ITaskService
    {
        public async Task<UserTask> AddTask(UserTask userTask)
        {
            context.UserTasks.Add(userTask);
            await context.SaveChangesAsync();
            return userTask;
        }

        public async Task<bool> DeleteTask(int id)
        {
            var userTask = await context.UserTasks.FindAsync(id);
            if (userTask != null)
            {
                context.Remove(userTask);
                await context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<UserTask> EditTask(int id, UserTask userTask)
        {
            var dbUserTask = await context.UserTasks.FindAsync(id);
            if (dbUserTask != null)
            {
                dbUserTask.Name = userTask.Name;
                await context.SaveChangesAsync();
                return dbUserTask;
            }
            throw new Exception("Task not found");
        }

        public async Task<List<UserTask>> GetAllTasks()
        {
            return await context.UserTasks.ToListAsync();
        }

        public async Task<UserTask> GetTaskById(int id)
        {
            var userTask = await context.UserTasks.FindAsync(id);
            return userTask ?? throw new Exception("Task not found");
        }
    }
}
