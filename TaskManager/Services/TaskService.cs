using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using TaskManager.Data;
using TaskManager.Entities;

namespace TaskManager.Services
{
    public class TaskService(ApplicationDbContext context, UserManager<ApplicationUser> userManager) : ITaskService
    {
        public async Task<UserTask> AddTask(UserTask userTask, string userId)
        {
            userTask.UserId = userId;
            context.UserTasks.Add(userTask);
            await context.SaveChangesAsync();
            return userTask;
        }

        public async Task<List<UserTask>> GetTasksForUser(string userId)
        {
            return await context.UserTasks
                .Where(userTask => userTask.UserId == userId)
                .ToListAsync();
        }

        public async Task<bool> DeleteTask(int id, string userId)
        {
            var userTask = await context.UserTasks.FindAsync(id);
            if (userTask != null && userTask.UserId == userId)
            {
                context.Remove(userTask);
                await context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<UserTask> EditTask(int id, UserTask userTask, string userId)
        {
            var dbUserTask = await context.UserTasks.FindAsync(id);
            if (dbUserTask != null && dbUserTask.UserId == userId)
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

        public async Task<UserTask> GetTaskById(int id, string userId)
        {
            var userTask = await context.UserTasks.FindAsync(id);
            if (userTask != null && userTask.UserId == userId)
            {
                return userTask;
            }
            throw new Exception("Task not found or unauthorized to access");
        }
    }
}
