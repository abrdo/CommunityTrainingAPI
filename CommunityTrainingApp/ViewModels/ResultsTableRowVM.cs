using System.ComponentModel.DataAnnotations;

namespace CommunityTrainingAPI.ViewModels
{
    public class ResultsTableRowVM
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        // public string TrainingPlanName { get; set; }
    }
}
