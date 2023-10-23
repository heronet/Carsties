using AutoMapper;
using Contracts;
using SearchService.Models;

namespace SearchService.Utils.RequestHelpers;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<AuctionCreated, Item>();
    }
}
