using WorkoutLog.Classes;

namespace WorkoutLog.Models
{
    public class Exercise
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public ExerciseType Type { get; set; }
        public List<int>? RepSequence { get; set; }
        public int WorkoutId { get; set; }

    }
}
