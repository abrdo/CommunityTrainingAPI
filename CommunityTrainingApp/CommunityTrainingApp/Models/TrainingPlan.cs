using CommunityTrainingAPI.Models;

namespace CommunityTrainingApp.Models
{
    public class TrainingPlan
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public ICollection<ResultsTable> ResultsTable { get; set; }
        public float RunningInKms { get; set; }
        public int pushUps { get; set; }
        public int pullUps { get; set; }
        public int legLifts { get; set; }
    }
}
