using System.Collections.Generic;
using VotingService.Models;

namespace VotingService.Services
{
    public interface IVotingStorageService
    {
        int RegisterVoting(Voting model);
        List<Voting> GetVotingsList();
        Voting GetVoting(int id);
    }
}