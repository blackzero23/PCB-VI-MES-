using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBVI.Data.Data
{
   public class FacilitiesHistoryData :EntityData<FacilitiesHistory>
    {

        public List<FacilitiesHistory> Search(int facilitiesId, int workPlaceId, int fHistoryDivisionId,
                                DateTime fromDate, DateTime toDate)
        {
            using(PCBVIEntities context = DbContextFactory.Create())
            {
                var query = from x in context.FacilitiesHistories
                            where x.FacilitiesId == facilitiesId && x.WorkPlaceId == workPlaceId
                            && x.FHistoryDivisionId == fHistoryDivisionId
                            && (x.WorkDate <= fromDate || x.WorkDate >= toDate)
                            select x;


                return query.ToList();
            }
        }
    }
}
