using AutoMapper;
using PokemonReviews.Dto;
using PokemonReviews.Models;

namespace PokemonReviews.Helper
{
    public class MappingProfiles: Profile
    {
        public MappingProfiles()
        {
            CreateMap<Pokemon, PokemonDto>();
            
        }
        
    }
}