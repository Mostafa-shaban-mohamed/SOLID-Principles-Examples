using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles_Examples
{
    class Orders
    {
        public Customers customer { set; get; }
        private String orderId { set;  get; }
        private String itemName { set;  get; }
        public int quantity { set; get; }
        public int totalBillAmt { set; get; }

        public String getOrderId() { return orderId; }
        public void setOrderId(String orderId)
        {
            Random random = new Random();

            this.orderId = orderId + "-" + random.Next(500);
        }
        public String getItemName() { return itemName; }
        public void setItemName(String itemName)
        {
            this.itemName = itemName;
            setOrderId(itemName);
        }
        public void prepareOrder()
        {
            Console.WriteLine("Preparing order for customer -"
                               + this.customer.name
                               + " who has ordered "
                               + this.getItemName());
        }
    }
}
