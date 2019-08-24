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
                            select new
                            {
                                Lot = x.Lot,
                                Barcode = x.Barcode,
                                LotName = x.Lot.LotCode,
                                ItemName = x.Barcode.Item.Name,
                                ErrorType = x.Barcode.ErrorCode.ErrorType.Name
                            };

                if (lotId != 0)
                {
                  query =  query.Where(x => x.Lot.LotId == lotId);
                }


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

        //불량인 애들만
        public List<Barcode> SearchFail(int lotId, DateTime fromDate, DateTime toDate)
        {
            using(var context = DbContextFactory.Create())
            {
                var query = from x in context.LotBarCodes
                            where x.Barcode.State.Equals("Fail")
                            select new
                            {
                                Barcode = x.Barcode,
                                LotBarCode = x
                            };

                if(lotId != 0)
                {
                    query = query.Where(x => x.LotBarCode.LotId == lotId);
                }


                foreach (var x in query)
                {
                    x.Barcode.LotId = x.LotBarCode.LotId;
                }

                var list = query.ToList();

                return list.ConvertAll(x => x.Barcode);
            }
        }

        //있는걸 들고옴
        public Barcode CheckBarcode(int code)
        {
            using (var context = DbContextFactory.Create())
            {
                var query = from x in context.Barcodes
                            where x.BarcodeCode.Equals(code)
                            select x;

                return query.FirstOrDefault();
            }
        }
    }
}
