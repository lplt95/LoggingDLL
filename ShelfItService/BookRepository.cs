using System;
using System.Collections.Generic;
using System.Linq;
using DataTransfer;
using System.Threading.Tasks;

namespace ShelfItService
{
    public class BookRepository
    {
        private BookRepository()
        {
            CreateList();
        }
        public List<KsiazkaDto> ksiazki = new List<KsiazkaDto>();
        private void CreateList()
        {
            ksiazki.Add(new KsiazkaDto { idKsiazka = 1, IloscStron = 100, OkladkaTyp = false});
            ksiazki.Add(new KsiazkaDto { idKsiazka = 2, IloscStron = 150, OkladkaTyp = true });
        }
    }
}
