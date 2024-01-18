namespace CommunityTrainingAPI.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<CommunityTrainingApp.Models.TrainingPlan> MyProperty { get; set; }

    }
}
