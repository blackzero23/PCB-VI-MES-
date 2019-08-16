using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBVI.Data.Data
{
    public class LotData : EntityData<Lot>
    {
        //public List<Barcode> Search(int lotId)
        //{
        //    using (PCBVIEntities context = DbContextFactory.Create())
        //    {
        //        var query = from x in context.LotBarCodes
        //                    where x.Lot.LotId == lotId
        //                    select new
        //                    {
        //                        Barcode = x.Barcode,
        //                        LotName = x.Lot.LotCode,
                                                               
        //                    };                               
                
        //        foreach (var x in query)
        //        { 
        //            x.Barcode.LotName = x.LotName;
                    
        //        }

               

        //    }
        //}
    }
}
