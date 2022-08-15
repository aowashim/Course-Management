using System.ComponentModel.DataAnnotations;

namespace CourseService.Data.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Title { get; set; } = string.Empty;

        [Required, MaxLength(250)]
        public string Description { get; set; } = string.Empty;

        [Required]
        public int Duration { get; set; }

        public int StatusId { get; set; }

        public Status Status { get; set; } = new Status();

        public List<User> Users { get; set; } = new List<User>();
    }
}
