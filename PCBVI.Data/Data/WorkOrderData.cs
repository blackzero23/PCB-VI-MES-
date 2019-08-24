﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PCBVI.Data.Data
{
    public class WorkOrderData :EntityData<WorkOrder>
    {
        public List<WorkOrder> Search(int itemId, int rotationId, DateTime fromDate, DateTime ToDate)
        {
            using (PCBVIEntities context = DbContextFactory.Create())
            {
               // TimeSpan ondDay = new System.TimeSpan(1, 0, 0, 0);
                var toDateAddOneDay =ToDate.Add(new System.TimeSpan(1, 0, 0, 0));
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

        public List<WorkOrder> ToDayWorkOrderList()
        {
            using(var context = DbContextFactory.Create())
            {
                var query = from x in context.WorkOrders
                   // join y in context.WorkLogs on x.WorkOrderId equals y.WorkOrderId 
                            where (x.OrderDate<= DateTime.Today || x.OrderDate >=DateTime.Today) 
                            select x;

                return query.ToList();
            }
        }

        public List<WorkOrder> TodayWorkerList()
        {
            using (var context = DbContextFactory.Create())
            {
                var query = from x in context.WorkOrders
                     join y in context.WorkLogs on x.WorkOrderId equals y.WorkOrderId 
                    where (x.OrderDate <= DateTime.Today || x.OrderDate >= DateTime.Today) && y.EndTime == null
                    select x;

                return query.ToList();
            }
        }

    }
}
