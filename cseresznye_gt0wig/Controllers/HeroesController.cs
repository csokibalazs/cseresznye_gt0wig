using cseresznye_gt0wig.MovieModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ZH3.Controllers
{
    [Route("api/heroes")]
    [ApiController]
    public class HeroesController : ControllerBase
    {
        // GET: api/<heroesController>
        [HttpGet]
        public IActionResult Get()
        {
            MarvelContext context = new();
            return Ok(context.Characters.ToList());
        }

        // GET api/<heroesController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            MarvelContext context = new();
            var sel_char = (from x in context.Characters
                            where x.CharacterId == id
                            select x).FirstOrDefault();

            if (sel_char == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(sel_char);
            }
        }

        // POST api/<heroesController>
        [HttpPost]
        public void Post([FromBody] Character hero)
        {
            MarvelContext ctx = new();
            ctx.Characters.Add(hero);
            ctx.SaveChanges();
        }

        // PUT api/<heroesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<heroesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var ctx = new MarvelContext();

            var charToDel = (from m in ctx.Characters
                             where m.CharacterId == id
                             select m).FirstOrDefault();

            if (charToDel != null)
            {
                ctx.Remove(charToDel);
                ctx.SaveChanges();
            }
        }
    }
}