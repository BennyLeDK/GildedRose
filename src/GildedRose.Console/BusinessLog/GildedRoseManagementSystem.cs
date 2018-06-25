using System.Collections.Generic;
using System.Linq;
using GildedRose.Console.Interfaces;

namespace GildedRose.Console.BusinessLog
{
    public class GildedRoseManagementSystem : IGildedRoseManagementSystem
    {
        private readonly IEnumerable<IGildedRoseItem> _itemTypes;

        public GildedRoseManagementSystem(IEnumerable<IGildedRoseItem> itemTypes)
        {
            _itemTypes = itemTypes;
        }
        public IList<Item> UpdateQuality(IList<Item> items)
        {

            foreach (var item in items)
            {
                var foundItem = false;
                foreach (var itemType in _itemTypes)
                {
                    if (item.Name.Contains(itemType.GetName()))
                    {
                        itemType.UpdateItem(item);
                        foundItem = true;
                        break;
                    }
                }

                if (!foundItem)
                {
                    var notmalItemType = _itemTypes.Single(x => x.GetType().IsInstanceOfType(new NormalItem()));
                    notmalItemType.UpdateItem(item);
                }
            }
            return items;
        }
    }
}
