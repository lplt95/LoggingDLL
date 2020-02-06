using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBatisNet.DataMapper;
using DataTransfer;

namespace DatabaseProvider
{
    public class ProviderTest
    {
        private ISqlMapper mapper;
        public ProviderTest()
        {
            mapper = Provider.EntityMapper;
        }
        public List<AutorDto> GetAllData()
        {
            List<AutorDto> data = mapper.QueryForObject<List<AutorDto>>("Statement", null);
            return data;
        }
    }
}
