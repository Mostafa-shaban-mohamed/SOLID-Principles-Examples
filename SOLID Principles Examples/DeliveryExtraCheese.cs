namespace SOLID_Principles_Examples
{
    class DeliveryExtraCheese : Delivery
    {
        private Orders order;
        public DeliveryExtraCheese(Orders order) : base(order)
        {
            this.order = order;
        }
        //Open Closed Prinicple Example
        public override int getDiscount(int totalbill)
        {
            return base.getDiscount(totalbill) - (int)(totalbill * 0.2);
        }
    }
}