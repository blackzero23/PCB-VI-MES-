using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBVI.Data.Data
{
    public class ItemData : EntityData<Item>
    {
        public List<Item> Search(string itemCode, string itemName, int firstDivisionId, int secondDivisionId)
        {
            using (PCBVIEntities context = DbContextFactory.Create())
            {
                var query = from item in context.Items
                            where item.Code.Equals(itemCode) && item.Name.Equals(itemName)
                            && item.FirstItemDivisionId == firstDivisionId
                            && item.SecondItemDivisionId == secondDivisionId
                            select item;

                return query.ToList();
            }
        }
    }
}
