using System.ComponentModel.DataAnnotations;

namespace TermProject.Models
{
    public class Workouts
    {
        public int ID { get; set; }
        [Required]
        [StringLength(30, ErrorMessage ="Please enter a workout using 30 characters or less.")]
        public string? Name { get; set; }

        public int? Sets { get; set; }

        public int? Reps { get; set; }

        public int? Weight { get; set; }
    }
}
