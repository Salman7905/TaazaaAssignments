using Microsoft.EntityFrameworkCore;
using MovieManagement.Data;
using MovieManagement.Models;
using MovieManagement.Service;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.Extensions.Logging;
namespace MovieManagement.Controllers
{
    [ApiController]
    [Route("Taazaa/[controller]")]
    public class MovieController:ControllerBase
    {
        IMovieRepository imovie;
        public MovieController(IMovieRepository _imovie)
        {
            imovie = _imovie;
        }
        [HttpPost]
        [Route("Add")]
        public IActionResult addMovie(Movie movie)
        {
            int res = imovie.addMovie(movie);
            if(res!=0)
            {
                return Ok("Movie added successfully");
            }
            return Forbid();
        }
        [HttpPut]
        [Route("Update/{id}")]
        public IActionResult updateMovie(int id,Movie movie)
        {
            int res = imovie.updateMovie(id,movie);
            if(res!=0)
            {
                return Ok("Movie updated successfully");
            }
            return Forbid();
        }

        [HttpGet]
        [Route("Search")]
        public IActionResult searchMovie(int id)
        {
            var res = imovie.searchMovie(id);
            if(res!=null)
            {
                return Ok("Found! "+"\nName =>"+res.movieName+"\nPrice => "+res.moviePrice);
            }
            return NotFound("Movie does not exist ,please enter valid movie name");
        }
    }
}