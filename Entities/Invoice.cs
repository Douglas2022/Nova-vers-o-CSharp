using System.Globalization;
namespace Xadrez1.Entities
{
    internal class Invoice
    {
        public double BasiPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basiPayment, double tax)
        {
            BasiPayment = basiPayment;
            Tax = tax;
        }
        public double TotalPayment
        {
            get { return BasiPayment + Tax }
        }
        public override string ToString()
        {
            return "Basic payment: "
                + BasiPayment.ToString("F2",CultureInfo.InvariantCulture)
                + "\nTax: "
                + Tax.ToString("F2",CultureInfo.InvariantCulture)
                + "\nTotal payment: "
                + TotalPayment.ToString(CultureInfo.InvariantCulture);
        }
    }
}
