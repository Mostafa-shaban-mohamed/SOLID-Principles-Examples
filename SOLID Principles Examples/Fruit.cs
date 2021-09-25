using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles_Examples
{
    abstract class Fruit
    {
        public abstract string GetColor();
    }
    class Apple : Fruit
    {
        public override string GetColor()
        {
            return "Red";
        }
    }
    class Orange : Fruit
    {
        public override string GetColor()
        {
            return "Orange";
        }
    }

    // without LSP
    //public class Apple
    //{
    //    public virtual string GetColor()
    //    {
    //        return "Red";
    //    }
    //}
    //public class Orange : Apple
    //{
    //    public override string GetColor()
    //    {
    //        return "Orange";
    //    }
    //}
}
