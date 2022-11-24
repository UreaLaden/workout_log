namespace WorkoutLog.Models
{
    public class Workout
    {
        public int Id { get; set; }
        public int SetAmount { get; set; }
        public float RestTime { get; set; } 
        public int UserId { get; set; }
        public int ExerciseId { get; set; }

    }
}
