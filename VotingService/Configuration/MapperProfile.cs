using AutoMapper;
using VotingService.Models;

namespace VotingService.Configuration
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Voting, VotingViewModel>();
            CreateMap<VotingViewModel, Voting>();
        }
    }
}