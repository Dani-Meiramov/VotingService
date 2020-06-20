using System;
using VotingService.Models;
using System.Collections.Generic;
using System.Linq;

namespace VotingService.Services
{
    public class VotingsStorageService : IVotingStorageService
    {
        private readonly List<Voting> votings = new List<Voting>();

        public int RegisterVoting(Voting model)
        {
            lock (votings)
            {
                votings.Add(model);
            }

            return 0;
        }

        public List<Voting> GetVotingsList()
        {
            return votings;
        }

        public Voting GetVoting(int id)
        {
            return votings.FirstOrDefault(x => x.Id == id);
        }
    }
}