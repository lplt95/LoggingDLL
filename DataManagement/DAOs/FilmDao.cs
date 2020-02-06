using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataManagement.DTOs;

namespace DataManagement.DAOs
{
    class FilmDao
    {
        public List<FilmDto> getAllFilms()
        {
            var filmList = new List<FilmDto>();
            return filmList;
        }
        public List<FilmDto> getFilmsByLength(int min, int max)
        {
            var filmList = new List<FilmDto>();
            return filmList;
        }
        public bool insertFilm(FilmDto film)
        {
            return true;
        }
        public bool deleteFilm(int filmId)
        {
            return true;
        }
    }
}
