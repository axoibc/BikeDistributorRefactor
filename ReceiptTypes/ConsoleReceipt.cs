using System;
using System.Collections.Generic;
using System.Text;

namespace BikeDistributor.ReceiptTypes
{
    public class ConsoleReceipt : ReceiptType
    {
        public override string Receipt(IList<Line> lines, string companyName, double taxRate)
        {
            var totalAmount = 0d;
            var result = new StringBuilder($"Order Receipt for {companyName}{Environment.NewLine}");
            foreach (var line in lines)
            {
                var thisAmount = line.GetPrice();
                result.AppendLine(
                    $"\t{line.Quantity} x {line.Bike.Brand} {line.Bike.Model} = {thisAmount.ToString("C")}");
                totalAmount += thisAmount;
            }
            result.AppendLine($"Sub-Total: {totalAmount.ToString("C")}");
            var tax = totalAmount * taxRate;
            result.AppendLine($"Tax: {tax.ToString("C")}");
            result.Append($"Total: {(totalAmount + tax).ToString("C")}");
            return result.ToString();
        }
    }
}
