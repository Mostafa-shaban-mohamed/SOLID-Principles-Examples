using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles_Examples
{
    //without ISP Principle
    public interface IShapes
    {
        void Area(string dimensions);
        void Volume(string dimensions);
    }

    public class Square: IShapes
    {
        public void Area(string dimen)
        {
            Console.WriteLine("Calculate Area");
        }

        public void Volume(string dimen)
        {
            throw new NotImplementedException();
        }
    }

    public class Cube : IShapes
    {
        public void Area(string dimen)
        {
            Console.WriteLine("Calculate Area");
        }

        public void Volume(string dimen)
        {
            Console.WriteLine("Calculate Volume");
        }
    }
}
