using lab4Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lab4.Controllers
{
    internal class MovieGenreViewModel
    {
        public SelectList Genres { get; set; }
        public List<Movie> Movies { get; set; }
    }
}