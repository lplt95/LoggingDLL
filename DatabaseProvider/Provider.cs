using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBatisNet.DataMapper;

namespace DatabaseProvider
{
    public class Provider
    {
        public static ISqlMapper EntityMapper
        {
            get
            {
                try
                {
                    ISqlMapper mapper = Mapper.Instance();
                    return mapper;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
    }
}
