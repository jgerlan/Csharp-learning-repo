using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercSec06_132.Entities
{
    class ImportedProduct : Product
    {
        public double customsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee)
            : base(name, price)
        {
            this.customsFee = customsFee;
            //this.price = this.totalPrice();
        }

        public override string priceTag()
        {
            StringBuilder sbString = new StringBuilder();
            sbString.Append(name+" ");
            //sbString.Append("$ "+price.ToString("F2", CultureInfo.InvariantCulture) + " ");
            sbString.Append("$ " + this.totalPrice().ToString("F2", CultureInfo.InvariantCulture) + " ");
            sbString.Append("(Customs fee: $ " + customsFee.ToString("F2", CultureInfo.InvariantCulture)+")");
            return sbString.ToString();
        }

        public double totalPrice ()
        {
            return price + customsFee;
        }
    }
}
