using CommunityTrainingApp.Models;

namespace CommunityTrainingAPI.Models
{
    public class ResultsTable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TrainingPlanId { get; set; }
        public TrainingPlan TrainingPlan { get; set; }
        public int RuninngResult { get; set; }
        public int PushUpsResult { get; set; }
        public int PullUpsResult { get; set; }
        public int LegLiftsResult { get; set; }
    }
}
