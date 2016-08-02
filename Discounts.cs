using System.Collections.Generic;

namespace BikeDistributor
{
    /// <summary>
    /// Discounts class
    /// 
    /// This class allows one or more discounts based on quantity purchased.
    /// </summary>
    public class Discounts
    {
        private readonly IList<Discount> _discounts;
       
        /// <summary>
        /// Base constructor. Must add at least one discount.
        /// </summary>
        /// <param name="discounts"></param>
        public Discounts(IList<Discount> discounts)
        {
            this._discounts = discounts;
        }

        /// <summary>
        /// Add a discount
        /// </summary>
        /// <param name="quantity">minimum quantity to purchase (inclusive)</param>
        /// <param name="price">price of the bike</param>
        /// <param name="percentage">discount percentage</param>
        public void AddDiscount( int quantity, double percentage)
        {
            _discounts.Add(new Discount(quantity, percentage));
        }
       
    }
}
