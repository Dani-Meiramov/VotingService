using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VotingService.Models
{
    public class Voting
    {
        public int Id { get; set; }

        public string VotingName { get; set; }

        public string Question { get; set; }

        public List<OptionData> Options { get; set; }
    }
}