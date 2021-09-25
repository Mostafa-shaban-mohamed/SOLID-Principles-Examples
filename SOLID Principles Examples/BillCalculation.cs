using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles_Examples
{
    class BillCalculation
    {
        private Orders order;
        public BillCalculation(Orders order)
        {
            this.order = order;
        }

        public void calculateBill()
        {
            /* In the real world, we would want a kind of lookup
              functionality implemented here where we look for
              the price of each item included in the order, add
              them up and add taxes, delivery charges, etc on
              top to reach the total price. We will simulate
              this behaviour here, by generating a random number
              for total price.
            */
            Random rand = new Random();
            int totalAmt
                = rand.Next(200) * this.order.quantity;

            this.order.totalBillAmt = totalAmt;
            Console.WriteLine("Order with order id  "
                               + this.order.getOrderId()
                               + " has a total bill amount of "
                               + this.order.totalBillAmt);
        }
    }
}
