using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VotingService.Models
{
    public class OptionData
    {
        [Required(ErrorMessage = "Option is required")]
        public string Option { get; set; }

        public int VoteCount { get; set; }
    }
}