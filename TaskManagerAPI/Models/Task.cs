namespace TaskManagerAPI.Models
{
    public class Task
    { 
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; } // high, medium, low
        public DateTime Created { get; set; } = DateTime.UtcNow;
        public bool IsCompleted { get; set; }
         
    }
}
