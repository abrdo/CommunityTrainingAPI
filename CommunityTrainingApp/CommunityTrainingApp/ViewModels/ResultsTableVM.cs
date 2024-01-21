using System.ComponentModel.DataAnnotations;

namespace CommunityTrainingAPI.ViewModels
{
    public class ResultsTableVM
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        public int RuninngResult { get; set; }
        public int PushUpsResult { get; set; }
        public int PullUpsResult { get; set; }
        public int LegLiftsResult { get; set; }
    }
}
