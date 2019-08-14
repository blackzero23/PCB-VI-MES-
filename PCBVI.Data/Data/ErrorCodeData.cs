using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBVI.Data.Data
{
    public class ErrorCodeData : EntityData<ErrorCode>
    {
        public List<ErrorCode> Search(string code, string kind, string type)
        {
            using (PCBVIEntities context = DbContextFactory.Create())
            {
                var query = from x in context.ErrorCodes
                            where x.Code.Equals(code) && x.ErrorKindName.Equals(kind) && x.ErrorTypeName.Equals(type)
                            select x;
                return query.ToList();

            }
        }
    }
}
