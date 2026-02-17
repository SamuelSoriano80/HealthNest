using System.ComponentModel.DataAnnotations;

namespace HealthNest.Models;

public class CheckIn
{
    public int Id { get; set; }

    public string UserId { get; set; }

    public DateOnly Date { get; set; }

    [Range(0, 24)]
    public decimal SleepHours { get; set; }

    [Range(0, 20)]
    public int WaterIntake { get; set; }

    [Range(0, 300)]
    public int ExerciseMinutes { get; set; }

    [Range(1, 5)]
    public int Mood { get; set; }

    [MaxLength(500)]
    public string? Notes { get; set; }
}
