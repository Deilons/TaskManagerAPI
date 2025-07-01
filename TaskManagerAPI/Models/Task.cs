using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TaskManagerAPI.Models
{
    public class Task
    { 
        public int Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Title cannot be longer than 100 characters.")]
        public string Title { get; set; }

        [StringLength(500, ErrorMessage = "Description cannot be longer than 500 characters.")]
        public string Description { get; set; }

        [Required]
        [RegularExpression("High|Medium|Low", ErrorMessage = "Priority must be High|Medium|Low")]
        public string Priority { get; set; } // high, medium, low
        public DateTime Created { get; set; } = DateTime.UtcNow;
        public bool IsCompleted { get; set; }
         
    }
}
