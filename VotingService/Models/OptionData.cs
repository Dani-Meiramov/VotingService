using System.ComponentModel.DataAnnotations;

namespace VotingService.Models
{
    public class OptionData
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Option is required")]
        public string Option { get; set; }

        public int VoteCount { get; set; }
    }
}