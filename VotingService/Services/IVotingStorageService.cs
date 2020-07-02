using System.Collections.Generic;
using VotingService.Models;

namespace VotingService.Services
{
    public interface IVotingStorageService
    {
        int RegisterVoting(VotingViewModel model);
        List<VotingViewModel> GetVotingsList();
        VotingViewModel GetVoting(int id);
        void AddOption(VotingOptionViewModel model);
    }
}