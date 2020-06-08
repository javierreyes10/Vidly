using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;
using Vidly.Services;

namespace Vidly.ViewModels
{
    public class MovieViewModel
    {
        private readonly IMovieService _movieService;
        public List<Movie> Movies { get; set; }

        public MovieViewModel()
        {
            _movieService = new MovieService();
        }
        public void Initialize()
        {
            Movies = _movieService.Movies();
        }
    }
}