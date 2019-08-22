using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBVI.Data.Data
{
    public class ItemData : EntityData<Item>
    {
        public List<Item> Search(int itemName, int firstDivisionId, int secondDivisionId)
        {
            using (PCBVIEntities context = DbContextFactory.Create())
            {
                var query = from item in context.Items
                            where item.ItemId == itemName
                            && item.FirstItemDivisionId == firstDivisionId
                            && item.SecondItemDivisionId == secondDivisionId
                            select item;

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
