using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles_Examples
{
    class Delivery
    {
        private Orders order;
        public Delivery(Orders order) {
            this.order = order; 
        }
        public void OrderDelivery()
        {
            // Here, we would want to interface with another
            // system which actually assigns the task of
            // delivery to different persons
            // based on location, etc.
            Console.WriteLine("Delivering the order");
            Console.WriteLine(
                "Order with order id as "
                + this.order.getOrderId()
                + " being delivered to "
                + this.order.customer.name);
            Console.WriteLine(
                "Order is to be delivered to: "
                + this.order.customer.address
                + " but after discount is "
                + this.getDiscount(this.order.totalBillAmt));
        }

        //Open Closed Prinicple Example
        public virtual int getDiscount(int totalbill)
        {
            //without applying OCP
            //int billAfterDiscount = 0;
            //if (this.order.getItemName() == "Pizza")
            //{
            //    billAfterDiscount = totalbill - (int)(totalbill * 0.2);
            //}
            //else if (this.order.getItemName() == "Pizza with extra cheese")
            //{
            //    billAfterDiscount = totalbill - (int)(totalbill * 0.4);
            //}
            //return billAfterDiscount;

            //with applying OCP
            return totalbill - (int)(totalbill * 0.1);
        }
    }
}
