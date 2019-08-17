using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBVI.Data.Data
{
    public class FirstInspectionData : EntityData<FirstInspection>
    {
        public List<FirstInspection> Search(string outCompanName, int itemId, DateTime fromDate, DateTime toDate)
        {
            using(PCBVIEntities context = DbContextFactory.Create())
            {
                var query = from x in context.FirstInspections
                            where x.OCompanyName.Equals(outCompanName)
                            && x.ItemId == itemId && (x.EnterDate <= fromDate || x.EnterDate >= toDate)
                            select new
                            {
                                FirstInspection = x,
                                  EmployeeName = x.Employee.Name
                            };

                foreach (var x in query)
                {
                    x.FirstInspection.EmployeeName = x.EmployeeName;
                }

                var list = query.ToList();


                return list.ConvertAll(x => x.FirstInspection);
            }
        }
    }
}
