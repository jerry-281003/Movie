using lab4Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lab4.Models
{
    public class MovieGenreViewMode
    {
        public List<Movie>? Movies { get; set; }
        public SelectList? Genres { get; set; }
        public string? MovieGenre { get; set; }
        public string? SearchString { get; set; }

    }
}
