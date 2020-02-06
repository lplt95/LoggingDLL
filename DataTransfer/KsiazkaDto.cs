using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransfer
{
    public class KsiazkaDto : PozycjaDto
    {
        public int idKsiazka { get; set; }
        public int IloscStron { get; set; }
        public bool OkladkaTyp { private get; set; }
        public int idWydawca { get; set; }
        public string Okladka { get; }
        public KsiazkaDto()
        {
            Okladka = OkladkaTyp ? "Twarda" : "Miękka";
        }
    }
}
