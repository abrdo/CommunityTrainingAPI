using CommunityTrainingAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace CommunityTrainingAPI.Models
{
    public class TrainingPlan
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        [Range(0,100)]
        public float RunningInKms { get; set; }
        public int PushUps { get; set; }
        public int PullUps { get; set; }
        public int LegLifts { get; set; }
        public ICollection<ResultsTable> ResultsTables { get; set; }
    }
}
