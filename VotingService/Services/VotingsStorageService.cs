using VotingService.Models;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;

namespace VotingService.Services
{
    public class VotingsStorageService : IVotingStorageService
    {
        private readonly List<Voting> _votings = new List<Voting>();
        private readonly IMapper _mapper;

        public VotingsStorageService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public int RegisterVoting(VotingViewModel model)
        {
            var mapped = _mapper.Map<Voting>(model);
            mapped.Id = _votings.Count;

            lock (_votings)
            {
                _votings.Add(mapped);
            }

            return mapped.Id;
        }

        public VotingViewModel GetVoting(int id)
        {
            return _mapper.Map<VotingViewModel>(_votings.FirstOrDefault(x => x.Id == id));
        }

        public List<VotingViewModel> GetVotingsList()
        {
            return _mapper.Map<List<Voting>, List<VotingViewModel>>(_votings);
        }

        public void AddOption(VotingOptionViewModel model)
        {
            var votingOptions = _votings[model.VotingId].Options;
            model.OptionData.Id = votingOptions.Count;
            votingOptions.Add(model.OptionData);
        }
    }
}