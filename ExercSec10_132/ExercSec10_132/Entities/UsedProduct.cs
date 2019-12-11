using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercSec06_132.Entities
{
    class UsedProduct : Product
    {
        public DateTime manufactureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate)
            : base(name, price)
        {
            this.manufactureDate = manufactureDate;
        }

        public override string priceTag()
        {
            StringBuilder sbString = new StringBuilder();
            sbString.Append(name + " ");
            sbString.Append("(used) ");
            sbString.Append("$ " + price.ToString("F2", CultureInfo.InvariantCulture) + " ");
            sbString.Append(" (Manufacture date: "+manufactureDate.ToString("dd/MM/yyyy")+")");
            return sbString.ToString();
        }
    }
}
