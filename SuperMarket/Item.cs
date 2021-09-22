namespace SupermarketKata
{
    public class Item
    {
        public string Sku { get; }
        public int Price { get; }
        public bool Discount { get; }
        public int DiscountAmount { get; }
        public int DiscountPrice { get; }

        public Item(string sku, int price, string special_discount = null)
        {
            Sku = sku;
            Price = price;
            if (!string.IsNullOrEmpty(special_discount))
            {
                var details = special_discount.Split(' ');
                Discount = true;
                DiscountAmount = int.Parse(details[0]);
                DiscountPrice = int.Parse(details[2]);
            }
        }
    }
}
