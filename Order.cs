using System.Collections.Generic;
using BikeDistributor.ReceiptTypes;

namespace BikeDistributor
{
    /// <summary>
    /// Order object to handle all order items.
    /// </summary>
    public class Order
    {
        private readonly IList<Line> _lines = new List<Line>();
        private ReceiptType _receipt;

        /// <summary>
        /// Set company name and taxreate
        /// </summary>
        /// <param name="company">Company name</param>
        /// <param name="taxRate">Taxrate</param>
        public Order(string company, double taxRate)
        {
            Company = company;
            TaxRate = taxRate;
        }

        /// <summary>
        /// Set order company, taxrate and receipt type all at once.
        /// </summary>
        /// <param name="company">Company name</param>
        /// <param name="taxRate">Taxrate for this order</param>
        /// <param name="receiptType">Type of receipt</param>
        public Order(string company, double taxRate, ReceiptType receiptType) : this(company, taxRate)
        {
            _receipt = receiptType;
        }
       

        /// <summary>
        /// TaxRate for this order
        /// </summary>
        public double TaxRate { get; private set; }

        /// <summary>
        /// Company name
        /// </summary>
        public string Company { get; private set; }

        /// <summary>
        /// Add an order line to the order
        /// </summary>
        /// <param name="line">Line of bikes to add</param>
        public void AddLine(Line line)
        {
            _lines.Add(line);
        }

        /// <summary>
        /// Set the receipt type
        /// </summary>
        /// <param name="receiptType">Receipt type to set</param>
        public void SetReceiptType(ReceiptType receiptType)
        {
            _receipt = receiptType;
        }

        /// <summary>
        /// Receipt overloaded output method
        /// </summary>
        /// <returns>string based on receipt method</returns>
        public string Receipt()
        {
            return _receipt?.Receipt(_lines, Company, TaxRate);
        }
    }
}
