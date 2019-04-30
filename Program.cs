using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1
{
    public class Cuboid
    {
        private readonly int length;
        private readonly int width;
        private readonly int hight;
        public Cuboid(int _length, int _width, int _hight)
        {
            this.hight = _hight;
            this.width = _width;
            this.length = _length;
        }
        public double Cubage
        {
            get { return this.hight * this.length * this.width; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("请输入长方形的长");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入长方形的宽");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入长方形的高");
            c = int.Parse(Console.ReadLine());
            Cuboid p = new Cuboid(a,b,c);
            Console.WriteLine("正方形体积为："+p.Cubage );
            Console.Read();
        }
    }
}
