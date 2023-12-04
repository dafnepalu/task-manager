namespace TaskManager.Entities
{
    public class UserTask
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required bool IsCompleted { get; set; }
        public required Priority Priority { get; set; }
    }

    public enum Priority
    {
        High,
        Medium,
        Low
    }
}
