using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VotingService.Models
{
    public class VotingViewModel
    {
        [Required(ErrorMessage = "Voting Name is required")]
        public string VotingName { get; set; }

        [Required(ErrorMessage = "Question is required")]
        public string Question { get; set; }

        public List<OptionData> Options { get; set; } = new List<OptionData>();

        public VotingViewModel()
        {
            Options.Add(new OptionData());
            Options.Add(new OptionData());
        }
    }
}