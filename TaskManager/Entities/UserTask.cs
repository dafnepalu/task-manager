using TaskManager.Data;

namespace TaskManager.Entities
{
    public class UserTask
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required bool IsCompleted { get; set; }
        public required Priority Priority { get; set; }

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }

    public enum Priority
    {
        High,
        Medium,
        Low
    }
}
