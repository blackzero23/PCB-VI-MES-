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
                var _toDateAdd = toDate.AddDays(1);

                var query = from x in context.FirstInspections
                            where x.EnterDate >= fromDate.Date && x.EnterDate < _toDateAdd.Date
                            select new
                            {
                                FirstInspection = x,
                                  EmployeeName = x.Employee.Name
                            };

                if(string.IsNullOrWhiteSpace(outCompanName) == false)
                {
                    query = query.Where(x => x.FirstInspection.OCompanyName.Contains(outCompanName));
                }

                if(itemId != 0)
                {
                    query = query.Where(x => x.FirstInspection.ItemId == itemId);
                }

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
