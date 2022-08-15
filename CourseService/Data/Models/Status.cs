using System.ComponentModel.DataAnnotations;

namespace CourseService.Data.Models
{
    public class Status
    {
        public int Id { get; set; }

        [Required, MaxLength(15)]
        public string Name { get; set; } = string.Empty;

        public List<Course> Courses { get; set; } = new List<Course>();
    }

    enum StatusEnum
    {
        NotApplied = 1,
        Applied,
        Accepted,
        Rejected
    }
}
