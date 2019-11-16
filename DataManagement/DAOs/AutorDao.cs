using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseProvider;
using DataTransfer;

namespace DataManagement.DAOs
{
    class AutorDao
    {
        ProviderTest provider;
        public AutorDao()
        {
            provider = new ProviderTest();
        }
        public List<AutorDto> GetAllAuthors()
        {
            return provider.GetAllData();
        }
        public List<AutorDto> GetAuthorByPosition(PozycjaDto position)
        {
            int positionId = position.idPozycja;
            return new List<AutorDto>();
        }
        public bool InsertNewAuthors(List<AutorDto> authorsList)
        {
            foreach (var author in authorsList)
            {
                //sth
            }
            return true;
        }
        //public 
    }
}
