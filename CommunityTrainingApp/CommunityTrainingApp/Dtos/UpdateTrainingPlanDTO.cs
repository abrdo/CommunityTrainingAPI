using System.ComponentModel.DataAnnotations;

namespace CommunityTrainingAPI.Dtos
{
    public class UpdateTrainingPlanDTO
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        [Range(0, 100)]
        public float RunningInKms { get; set; }
        public int PushUps { get; set; }
        public int PullUps { get; set; }
        public int LegLifts { get; set; }
    }
}
}
