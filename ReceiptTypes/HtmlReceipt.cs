using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BikeDistributor.ReceiptTypes
{
    /// <summary>
    /// HTML receipt for web orders
    /// 
    /// </summary>
    public class HtmlReceipt : ReceiptType
    {
        public override string Receipt(IList<Line> lines, string companyName, double taxRate)
        {

            var totalAmount = 0d;
            var result = new StringBuilder($"<html><body><h1>Order Receipt for {companyName}</h1>");
            if (lines.Any())
            {
                result.Append("<ul>");
                foreach (var line in lines)
                {
                    var thisAmount = line.GetPrice();                    
                    result.Append(
                        $"<li>{line.Quantity} x {line.Bike.Brand} {line.Bike.Model} = {thisAmount.ToString("C")}</li>");
                    totalAmount += thisAmount;
                }
                result.Append("</ul>");
            }
            result.Append($"<h3>Sub-Total: {totalAmount.ToString("C")}</h3>");
            var tax = totalAmount * taxRate;
            result.Append($"<h3>Tax: {tax.ToString("C")}</h3>");
            result.Append($"<h2>Total: {(totalAmount + tax).ToString("C")}</h2>");
            result.Append("</body></html>");
            return result.ToString();
        }
    }
}
