using CommunityTrainingApp.Models;

namespace CommunityTrainingAPI.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<TrainingPlan> TrainingPlans { get; set; }

    }
}
