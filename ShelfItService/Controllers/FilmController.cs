using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataTransfer;

namespace ShelfItService.Controllers
{
    [Route("ShelfIt/Film")]
    public class FilmController : Controller
    {
        [HttpGet]
        public IActionResult GetAllFilms()
        {
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetFilm(int id)
        {
            FilmDto film = null;
            if(film == null)
            {
                return NotFound();
            }
            return Ok(film);
        }
        [HttpGet("{name}")]
        public IActionResult GetFilm(string name)
        {
            FilmDto film = null;
            if(film == null)
            {
                return NotFound();
            }
            return Ok(film);
        }
    }
}
