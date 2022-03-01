using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieAPI.Model;
using System.IO;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace MovieAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly IList<Movie> _movies = new List<Movie>();

        private string path = AppDomain.CurrentDomain.BaseDirectory + "moviedata.json";

        public MoviesController()
        {
            _movies = JsonConvert.DeserializeObject<IList<Movie>>(System.IO.File.ReadAllText(path));

        }

        //[Route("GetMovies")]
        [HttpGet("AllMovies")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesDefaultResponseType]
        public IActionResult GetMovies()
        {
           return Ok(_movies);
        }

        //[Route("GetSpecificMovies")]
        [HttpGet("FilteredMovies")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesDefaultResponseType]
        public IActionResult GetSpecificMovies(string title = null, int? year = null)
        {
            if (!string.IsNullOrEmpty(title))
                return Ok(_movies.Where(m => m.Title == title));

            if (year!= null)
                return Ok(_movies.Where(m => m.Year == year));

            var movies = _movies.OrderByDescending(m => m.Year).Take(4);
            return Ok(movies);
        }
    }
}
