using PokemonReviews.Data;
using PokemonReviews.Interfaces;
using PokemonReviews.Models;

namespace PokemonReviews.Repository
{
    public class PokemonRepository: IPokemonRepository
    {
        private readonly DataContext _context;
        
        public PokemonRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<Pokemon> GetPokemons()
        {
            return _context.Pokemon.OrderBy(p => p.Id).ToList();
        }
        
    }
}