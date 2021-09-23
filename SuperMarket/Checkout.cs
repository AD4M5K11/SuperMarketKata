using System.Collections.Generic;

namespace SupermarketKata
{
    public class Checkout : ICheckout
    {
        public Dictionary<string, Item> Items;

        private Dictionary<string, int> _itemsScanned = new Dictionary<string, int>();

        public Checkout(Dictionary<string, Item> items)
        {
            Items = items;
        }

        public void Scan(string item)
        {
            if (_itemsScanned.ContainsKey(item))
                _itemsScanned[item]++;
            else
                _itemsScanned.Add(item, 1);
        }
        public int GetTotalPrice()
        {
            var total = 0;

            foreach (var pair in _itemsScanned)
            {
                var item = Items[pair.Key];
                if (item.Discount)
                {
                    var itemsAtNormalPrice = pair.Value;
                    total += item.Price * itemsAtNormalPrice;

                    var itemsAtDiscountedPrice = pair.Value;
                    total += item.DiscountPrice * itemsAtDiscountedPrice;
                }
                else
                {
                    total += item.Price * pair.Value;
                }
            }
            return total;
        }
    }
}
