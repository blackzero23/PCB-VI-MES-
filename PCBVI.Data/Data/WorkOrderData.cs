using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PCBVI.Data.Data
{
    public class WorkOrderData : EntityData<WorkOrder>
    {
        public List<WorkOrder> Search(int itemId, int rotationId, DateTime fromDate, DateTime ToDate)
        {
            using (PCBVIEntities context = DbContextFactory.Create())
            {
                // TimeSpan ondDay = new System.TimeSpan(1, 0, 0, 0);
                var toDateAddOneDay = ToDate.Add(new System.TimeSpan(1, 0, 0, 0));
                var query = from x in context.WorkOrders
                            where x.OrderDate >= fromDate.Date.Date && x.OrderDate < toDateAddOneDay.Date
                            select x;

                if (itemId != 0)
                {
                    query = query.Where(x => x.ItemId == itemId);
                }

                if (rotationId != 0)
                {
                    query = query.Where(x => x.RotationGroupId == rotationId);
                }


                return query.ToList();
            }
        }


        //작업이 시작 되는순간 사라지는 오늘 작업리스트
        public List<WorkOrder> ToDayWorkOrderList()
        {
            using (var context = DbContextFactory.Create())
            {
                DateTime todayAdd = DateTime.Today.AddDays(1);
                var query = from x in context.WorkOrders
                            join y in context.WorkLogs on x.WorkOrderId equals y.WorkOrderId into _y
                            from y in _y.DefaultIfEmpty()
                            where (x.OrderDate >= DateTime.Today.Date && x.OrderDate < todayAdd.Date)
                                  && y.WorkOrderId == null
                            select x;

                return query.ToList();
            }
        }

        //오늘 작업리스트 전부
        public List<WorkOrder> TodayWorkerListALL()
        {
            using (var context = DbContextFactory.Create())
            {
                DateTime todayAdd = DateTime.Today.AddDays(1);
                var query = from x in context.WorkOrders
                            where (x.OrderDate >= DateTime.Today.Date && x.OrderDate < todayAdd.Date)
                            select x;

                return query.ToList();
            }
        }

        //작업지시 중복체크
        //설비 ,공정명,품목명,날짜,근무조.
        
        public WorkOrder DuplicateCheck(int facilitiesId, int processId, DateTime orderDate, int rotationId)
        {
            using (var context = DbContextFactory.Create())
            {
                DateTime dateTime = orderDate.AddDays(1);
                var query = from x in context.WorkOrders
                    where x.FacilitiesId == facilitiesId && x.ProcessId == processId 
                          && (x.OrderDate >= orderDate.Date && x.OrderDate < dateTime)
                          && x.RotationGroupId == rotationId
                    select x;

                return query.FirstOrDefault();
            }
        }

    }
}
