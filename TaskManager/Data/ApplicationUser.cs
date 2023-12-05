using Microsoft.AspNetCore.Identity;
using TaskManager.Entities;

namespace TaskManager.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public ICollection<UserTask> UserTasks { get; set; }
    }

}
