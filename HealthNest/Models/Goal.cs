using System.ComponentModel.DataAnnotations;
using HealthNest.Models.Enums;

namespace HealthNest.Models
{
    public class Goal
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        [Required]
        public GoalCategory Category { get; set; }

        [Range(1, 1000)]
        public int TargetValue { get; set; }

        [Required]
        public GoalPeriod Period { get; set; }

        public bool IsActive { get; set; } = true;
    }
}
