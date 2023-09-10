using PokemonReviews.Models;

namespace PokemonReviews.Interfaces
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons();
    }
}