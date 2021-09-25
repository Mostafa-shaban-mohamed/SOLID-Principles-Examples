using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles_Examples
{
    class DeliveryExtraPaparoni : Delivery
    {
        private Orders order;
        public DeliveryExtraPaparoni(Orders order) : base(order)
        {
            this.order = order;
        }
        //Open Closed Prinicple Example
        public override int getDiscount(int totalbill)
        {
            return base.getDiscount(totalbill) - (int)(totalbill * 0.4);
        }
    }
}
