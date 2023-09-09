using System;

namespace PokemonReviews.Models
{
    public class Reviewer
    {
        public int Id { get; set; }
        public string? FirstName { get; set; } 
        public string? LastName { get; set; }
        public ICollection<Review>? Reviewers { get; set; }
    }
}