using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBVI.Data.Data
{
    public class ItemData : EntityData<Item>
    {
        public List<Item> Search(int itemId, int firstDivisionId, int secondDivisionId)
        {
            using (PCBVIEntities context = DbContextFactory.Create())
            {
                var query = from item in context.Items
                            select item;

                if (itemId != 0)
                {
                    query = query.Where(x => x.ItemId == itemId);
                }

                if (firstDivisionId != 0)
                {
                    query = query.Where(x => x.FirstItemDivisionId == firstDivisionId);
                }

                if (secondDivisionId != 0)
                {
                    query = query.Where(x => x.SecondItemDivisionId == secondDivisionId);
                }

                return query.ToList();
            }
        }

        public Item CheckDuplicate(string itemCode)
        {
            using (var context = DbContextFactory.Create())
            {
                var query = from x in context.Items
                    where x.Code.Equals(itemCode)
                    select x;

                return query.FirstOrDefault();
            }
        }
    }
}
