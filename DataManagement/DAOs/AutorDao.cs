using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataManagement.DTOs;

namespace DataManagement.DAOs
{
    class AutorDao
    {
        public List<AutorDto> getAutorsByBook(int bookId)
        {
            var authorsList = new List<AutorDto>();
            return authorsList;
        }
        public List<AutorDto> getAllAuthors()
        {
            var authorsList = new List<AutorDto>();
            return authorsList;
        }
        public List<int> getAuthorsIdByName(string autorName)
        {
            var authorsList = new List<int>();
            return authorsList;
        }
        public bool insertAutor(AutorDto autor)
        {
            return true;
        }
        public bool deleteAutor(int autorId)
        {
            return true;
        }
    }
}
