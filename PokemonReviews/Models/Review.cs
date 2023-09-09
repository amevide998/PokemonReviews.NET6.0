using System.Net.Mime;
using System;

namespace PokemonReviews.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Text { get; set; }
        public Reviewer? Reviewer { get; set; }
        public Pokemon? Pokemon { get; set; }
    }
}