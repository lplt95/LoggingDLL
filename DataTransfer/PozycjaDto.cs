using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransfer
{
    public class PozycjaDto
    {
        public int idPozycja { get; set; }
        public string tytul { get; set; }
        public int rokWydania { get; set; }
        public int udostepnioneDla { get; set; }
        public int idTyp { get; set; }
        public int idNotatka { get; set; }
        public int idOcena { get; set; }
    }
}
