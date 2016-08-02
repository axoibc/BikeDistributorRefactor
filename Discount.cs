namespace BikeDistributor
{
    /// <summary>
    /// Discount at a certain quantity purchased, price and percentage.
    /// </summary>
    public class Discount
    {
        public Discount( int orderQuantity, double discountPercent)
        {
            OrderQuantity = orderQuantity;
            Percentage = discountPercent;
        }

        public int OrderQuantity { get; set; }

        public double Percentage { get; set; }
    }
}
