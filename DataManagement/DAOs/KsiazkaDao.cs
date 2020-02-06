using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManagement.DAOs
{
    class KsiazkaDao
    {
        AutorDao autorSearch = new AutorDao();
        public List<KsiazkaDao> searchBook(bool? okladka, int? idWydawcy, string autor)
        {
            List<int> authors;
            if (!String.IsNullOrEmpty(autor))
            {
                authors = autorSearch.getAuthorsIdByName(autor);
            }

        }
    }
}
