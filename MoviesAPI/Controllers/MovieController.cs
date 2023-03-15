using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Models;

namespace MoviesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {

        private static List<Movie> movies = new List<Movie>();
        public static int id = 1;

        [HttpPost]
        public void AddMovie([FromBody] Movie movie)
        {
            movie.Id = id++;
            movies.Add(movie);
        }

        [HttpGet]
        public IEnumerable<Movie> GetMovies()
        {
            return movies;
        }

        [HttpGet("{id}")]
        public Movie GetMovieById(int id) => movies.FirstOrDefault(movie => movie.Id == id);
    }
}
