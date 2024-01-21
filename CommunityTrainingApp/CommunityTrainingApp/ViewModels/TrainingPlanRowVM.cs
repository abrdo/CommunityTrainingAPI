using CommunityTrainingAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace CommunityTrainingAPI.ViewModels
{
    public class TrainingPlanRowVM
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        public Category Category { get; set; }
    }
}
