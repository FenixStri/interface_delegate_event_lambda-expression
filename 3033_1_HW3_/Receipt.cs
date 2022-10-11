using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3033_1_HW3_
{
    public class Receipt
    {
        [Key] 

        public string ReceiptID { get; set; }
        public double Total { get; set; }
        public int CogQuantity { get; set; }
        public int GearQuantity { get; set; }

        public override string ToString()
        {
            string str = string.Format($"ReceiptID:{this.ReceiptID}, NCogs:{this.CogQuantity}, NGears:{this.GearQuantity}, Total:{this.Total:C2}");
            return str;

        }

        public double CalculateTotal()
        {
            double subtotal = 79.99 * this.CogQuantity + 250.0 * this.GearQuantity;
            this.Total = subtotal * (1 + 0.089);
            return this.Total;

        }
    }
}
