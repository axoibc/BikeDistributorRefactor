using System.ComponentModel.Design;

namespace BikeDistributor
{
    public abstract class Bike
    {
        public const int OneThousand = 1000;
        public const int TwoThousand = 2000;
        public const int FiveThousand = 5000;
        protected Discount Discount;

        protected Bike(string brand, string model, int price, Discount discount)
        {
            Brand = brand;
            Model = model;
            Price = price;
            Discount = discount;
        }

        public string Brand { get; private set; }
        public string Model { get; private set; }
        public int Price { get; set; }

        /// <summary>
        /// Calculate the discount based on price of the bike and quantity ordered
        /// </summary>
        /// <param name="quantity">quantity ordered</param>
        /// <returns>discount % or 100% for no discount</returns>
        public double GetDiscount(int quantity)
        {
            return quantity >= Discount.OrderQuantity ? Discount.Percentage : 1;
        }
    }
}
