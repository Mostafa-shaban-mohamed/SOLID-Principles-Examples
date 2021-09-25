using System;

namespace SOLID_Principles_Examples
{
    //this is examples of SOLID Principle for SOLID Article series on my website
    //SOLID Principle article series explain these principle in very simple and fun manners
    //here is the link for website: https://mostafa-shaban-mohamed.github.io/Index.html
    //here is the link for article: ....
    class Program
    {
        static void Main(string[] args)
        {
            ////SRP Principle (uncomment it to test)
            //Customers customer01 = new Customers();
            //customer01.name = "Mostafa";
            //customer01.address = "Cairo";
            ////normal order
            //Orders order01 = new Orders();  //SRP
            //order01.setItemName("Pizza");  //SRP
            //order01.quantity = 2;
            //order01.customer = customer01;
            //order01.prepareOrder();
            
            ////normal order billing
            //BillCalculation billCalculation
            //    = new BillCalculation(order01);
            //billCalculation.calculateBill();
            
            //Delivery deliveryApp = new Delivery(order01);  //SRP
            //deliveryApp.OrderDelivery();  //SRP

            ////OCP Principle (uncomment it to test)
            //// extra cheese order
            //Orders orderExtraCheese = new Orders();  //OCP - 1
            //orderExtraCheese.setItemName("Pizza with extra cheese");  //OCP - 1
            //orderExtraCheese.quantity = 3;
            //orderExtraCheese.customer = customer01;
            //orderExtraCheese.prepareOrder();
            ////Extra cheese order billing
            //BillCalculation billCalculationEC
            //    = new BillCalculation(orderExtraCheese);
            //billCalculationEC.calculateBill();
            ////Extra cheese delivery
            //DeliveryExtraCheese deliveryAppEC = new DeliveryExtraCheese(orderExtraCheese);  //OCP - 1
            //deliveryAppEC.OrderDelivery();  //OCP - 1
            //// -----------------------------------------------
            ////extra paparoni order
            //Orders orderExtraPaparoni = new Orders();  //OCP - 2
            //orderExtraPaparoni.setItemName("Pizza with extra paparoni");  //OCP - 2
            //orderExtraPaparoni.quantity = 2;
            //orderExtraPaparoni.customer = customer01;
            //orderExtraPaparoni.prepareOrder();
            ////Extra paparoni order billing
            //BillCalculation billCalculationEP
            //    = new BillCalculation(orderExtraPaparoni);
            //billCalculationEP.calculateBill();
            ////extra paparoni delivery
            //DeliveryExtraPaparoni deliveryAppEP = new DeliveryExtraPaparoni(orderExtraPaparoni);  //OCP - 2
            //deliveryAppEP.OrderDelivery();  //OCP - 2

            //LSP Principle (uncomment it ti test)
            //without LSP
            //Apple apple = new Orange();
            //Console.WriteLine(apple.GetColor());
            //with LSP
            Fruit fruit = new Orange();
            Console.WriteLine(fruit.GetColor());
            fruit = new Apple();
            Console.WriteLine(fruit.GetColor());

            //ISP Principle
            //look for IShape and I2DShape to see examples ....

            //DIP Principle
            //look for CustomerBusinessLogic and DIP_CustomerBusinessLogic to see example ......
        }
    }
}
