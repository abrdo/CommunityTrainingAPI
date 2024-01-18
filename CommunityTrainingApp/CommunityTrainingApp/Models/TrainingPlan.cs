using CommunityTrainingAPI.Models;

namespace CommunityTrainingApp.Models
{
    public class TrainingPlan
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public float RunningInKms { get; set; }
        public int PushUps { get; set; }
        public int PullUps { get; set; }
        public int LegLifts { get; set; }
        public ICollection<ResultsTable> ResultsTables { get; set; }
    }
}
