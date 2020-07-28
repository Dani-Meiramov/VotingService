using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VotingService.Models
{
    public class VotingViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Voting Name is required")]
        [Display(Name = "Название голосования")]
        public string VotingName { get; set; }

        [Required(ErrorMessage = "Question is required")]
        [Display(Name = "Вопрос")]
        public string Question { get; set; }

        public List<OptionData> Options { get; set; }
    }
}