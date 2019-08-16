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
                            where x.Code.Equals(code) &&
                            x.ErrorKind.Name.Equals(kind) &&
                            x.ErrorType.Name.Equals(type)
                            select new
                            {
                                ErrorCode = x,
                                ErrorKindName = x.ErrorKind.Name,
                                ErrorTypeName = x.ErrorType.Name
                            };                

                foreach(var x in query)
                {
                    x.ErrorCode.ErrorKindName = x.ErrorKindName;
                    x.ErrorCode.ErrorTypeName = x.ErrorTypeName;
                }

                var list = query.ToList();

                return list.ConvertAll(x => x.ErrorCode);
            }
        }
    }
}
