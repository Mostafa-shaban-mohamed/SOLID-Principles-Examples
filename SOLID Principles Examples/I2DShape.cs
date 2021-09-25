using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles_Examples
{
    //with ISP Principle
    public interface I2DShape
    {
        void Area(string dimensions);
    }
    public interface I3DShape
    {
        void Volume(string dimensions);
    }

    public class Square2D : I2DShape
    {
        public void Area(string dimen)
        {
            Console.WriteLine("Calculate Area");
        }
    }

    public class Cube3D : I3DShape
    {
        public void Volume(string dimen)
        {
            Console.WriteLine("Calculate Volume");
        }
    }
}
