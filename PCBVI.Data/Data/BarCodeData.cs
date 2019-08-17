using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBVI.Data.Data
{
    public class BarCodeData : EntityData<Barcode>
    {
        public List<Barcode> Search(int lotId)
        {
            using (PCBVIEntities context = DbContextFactory.Create())
            {

                var query = from x in context.LotBarCodes
                            where x.Lot.LotId == lotId
                            select new
                            {
                                Barcode = x.Barcode,
                                LotName = x.Lot.LotCode,
                                ItemName = x.Barcode.Item.Name,
                                ErrorType = x.Barcode.ErrorCode.ErrorType.Name
                            };


                foreach (var x in query)
                {
                    x.Barcode.LotName = x.LotName;
                    x.Barcode.ItemName = x.ItemName;
                    x.Barcode.ErrorTypeName = x.ErrorType;
                }

                var list = query.ToList();

                return list.ConvertAll(x => x.Barcode);

            }
        }
    }
}
