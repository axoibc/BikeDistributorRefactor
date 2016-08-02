using System.Collections.Generic;

namespace BikeDistributor.ReceiptTypes
{
    public abstract class ReceiptType
    {
        public abstract string Receipt(IList<Line> lines, string companyName, double taxRate);
    }
}
