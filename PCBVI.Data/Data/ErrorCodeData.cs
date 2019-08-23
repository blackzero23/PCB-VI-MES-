using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBVI.Data.Data
{
    public class ErrorCodeData : EntityData<ErrorCode>
    {
        public List<ErrorCode> Search(int codeId, int typeId, int kindId)
        {
            using (PCBVIEntities context = DbContextFactory.Create())
            {
                var query = from x in context.ErrorCodes
                            //where x.Code.Equals(code) &&
                            //x.ErrorKind.Name.Equals(kind) &&
                            //x.ErrorType.Name.Equals(type)
                            select new
                            {
                                ErrorCode = x,
                                ErrorKindName = x.ErrorKind.Name,
                                ErrorTypeName = x.ErrorType.Name
                            };

                if (codeId != 0)
                {
                    query = query.Where(x => x.ErrorCode.ErrorCodeId == codeId);
                }

                if (typeId != 0)
                {
                    query = query.Where(x => x.ErrorCode.ErrorTypeId == typeId);
                }

                if (kindId != 0)
                {
                    query = query.Where(x => x.ErrorCode.ErrorKindId == kindId);
                }

                foreach(var x in query)
                {
                    x.ErrorCode.ErrorKindName = x.ErrorKindName;
                    x.ErrorCode.ErrorTypeName = x.ErrorTypeName;
                }

                var list = query.ToList();

                return list.ConvertAll(x => x.ErrorCode);
            }
        }

        public ErrorCode CheckErroCode(string errorCodeName)
        {
            using (var context = DbContextFactory.Create())
            {
                var query = from x in context.ErrorCodes
                    where x.Code.Equals(errorCodeName)
                    select x;

                var list = query.ToList();

                return list.FirstOrDefault();
            }
        }
    }
}
