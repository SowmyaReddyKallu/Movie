using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieApp.Infrastructure;
using MovieApp.Models;

namespace MovieApp.Controllers
{
    [EnableCors("MyPolicy")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MovieWebApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public MovieWebApiController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/MovieWebApi
        //[HttpGet]
        public async Task<ActionResult<IEnumerable<MovieModel>>> GetMovieModel()
        {
            return await _context.MovieModel.ToListAsync();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MovieModel>>> SearchMovieModel([FromQuery]MovieViewModel movieModel)
        {
            int pageSize = 10;
            List<MovieModel> lst = await _context.MovieModel.ToListAsync();
            lst = lst.Where(a =>
             (movieModel.ReleaseYear != 0 && a.ReleaseYear == movieModel.ReleaseYear) ||
             (movieModel.Title!=null &&  a.Title.ToLower().StartsWith(movieModel.Title.ToLower())) ||
             (movieModel.OriginEthinicity != null && a.OriginEthinicity.ToLower().StartsWith(movieModel.OriginEthinicity.ToLower())) ||
             (movieModel.Genre != null && a.Genre.ToLower().StartsWith(movieModel.Genre.ToLower())) ||
             (movieModel.Cast != null && a.Cast.ToLower().StartsWith(movieModel.Cast.ToLower())) ||
             (movieModel.Director != null && a.Director.ToLower().StartsWith(movieModel.Director.ToLower())) ||
             (movieModel.Plot != null && a.Plot.ToLower().StartsWith(movieModel.Plot.ToLower()))
            ).ToList().Skip((movieModel.PageIndex - 1) * pageSize).Take(pageSize).ToList();
            return lst;// await _context.MovieModel.ToListAsync();
        }

        // GET: api/MovieWebApi/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MovieModel>> GetMovieModel(int id)
        {
            var movieModel = await _context.MovieModel.FindAsync(id);

            if (movieModel == null)
            {
                return NotFound();
            }

            return movieModel;
        }

        // PUT: api/MovieWebApi/5
        [HttpPut]
        public async Task<IActionResult> PutMovieModel( MovieModel movieModel)
        {
            if (movieModel.Id ==null)
            {
                return BadRequest();
            }

            _context.Entry(movieModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovieModelExists(movieModel.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/MovieWebApi
        [HttpPost]
        public async Task<ActionResult<MovieModel>> PostMovieModel(MovieModel movieModel)
        {
            _context.MovieModel.Add(movieModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMovieModel", new { id = movieModel.Id }, movieModel);
        }

        // DELETE: api/MovieWebApi/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<MovieModel>> DeleteMovieModel(int id)
        {
            var movieModel = await _context.MovieModel.FindAsync(id);
            if (movieModel == null)
            {
                return NotFound();
            }

            _context.MovieModel.Remove(movieModel);
            await _context.SaveChangesAsync();

            return movieModel;
        }

        private bool MovieModelExists(int id)
        {
            return _context.MovieModel.Any(e => e.Id == id);
        }
    }
}
