using Microsoft.AspNetCore.Mvc;
using cseresznye_gt0wig.MovieModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ZH3.Controllers
{
    [Route("api/movies")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        // GET: api/movies
        [HttpGet]
        public IActionResult Get()
        {
            MarvelContext ctx = new();
            return Ok(ctx.Movies.ToList());
        }

        // GET api/movies/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            MarvelContext ctx = new();
            var keresettFilm = (from m in ctx.Movies
                                where m.MovieId == id
                                select m).FirstOrDefault();

            if (keresettFilm == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(keresettFilm);
            }
        }

        // POST api/movies
        [HttpPost]
        public void Post([FromBody] Movie movie)
        {
            MarvelContext ctx = new();
            ctx.Movies.Add(movie);
            ctx.SaveChanges();
        }

        // PUT api/movies/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/movies/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var ctx = new MarvelContext();

            var filmToDel = (from m in ctx.Movies
                             where m.MovieId == id
                             select m).FirstOrDefault();

            if (filmToDel != null)
            {
                ctx.Remove(filmToDel);
                ctx.SaveChanges();
            }
        }
    }
}