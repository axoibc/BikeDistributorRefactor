using System;

namespace BikeDistributor.Bikes
{
    public class DefyBike : Bike
    {
        public DefyBike(Discount discount) : base("Giant", "Defy 1", Bike.OneThousand, discount)
        {
        }

        
    }
}
