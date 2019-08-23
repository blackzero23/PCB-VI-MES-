using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBVI.Data.Data
{
    public class DefectiveProductData :EntityData<DefectiveProduct>
    {
        public List<DefectiveProduct> Search(int lotId , DateTime fromDate, DateTime toDate)
        {
            using(var context = DbContextFactory.Create())
            {
                //바코드에서 불량

                var query = from x in context.DefectiveProducts
                            where x.WorkDate <= fromDate || x.WorkDate >= toDate
                            select x;

                if (lotId != 0)
                {
                    query = query.Where(x => x.LotId == lotId);
                }

                return query.ToList();
            }
        }
    }
}
