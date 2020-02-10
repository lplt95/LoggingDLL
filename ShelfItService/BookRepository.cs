using System;
using System.Collections.Generic;
using System.Linq;
using DataTransfer;
using System.Threading.Tasks;

namespace ShelfItService
{
    public class BookRepository
    {
        public List<KsiazkaDto> ksiazki;
        public BookRepository()
        {
            ksiazki = new List<KsiazkaDto>();
            CreateList();
        }
        private void CreateList()
        {
            ksiazki.Add(new KsiazkaDto()
            {
                idPozycja = 1,
                notatka = "Książka do przeczytania",
                ocena = 5,
                Okladka = "Miękka",
                typ = "Książka",
                wydawca = "Kupa s.p. z.o.o.",
                idKsiazka = 1,
                IloscStron = 100,
                tytul = "Książka na pewien temat",
                rokWydania = 2020
            });
            ksiazki.Add(new KsiazkaDto() 
            {
                idPozycja = 2,
                notatka = "Ta książka jest dość średnia",
                ocena = 3,
                Okladka = "Twarda",
                typ = "Książka",
                wydawca = "Wydawnictwo Testowe S.A.",
                idKsiazka = 2, 
                IloscStron = 150,
                tytul = "Książka na inny temat",
                rokWydania = 2019
            });
            ksiazki.Add(new KsiazkaDto()
            {
                idPozycja = 3,
                notatka = "To jest okropna książka!",
                ocena = 1,
                Okladka = "Miękka",
                typ = "Książka",
                wydawca = "Wydajemy Szrot s.j.",
                idKsiazka = 3, 
                IloscStron = 200,
                tytul = "To nawet nie jest książka...",
                rokWydania = 2018
            });
        }
    }
}
