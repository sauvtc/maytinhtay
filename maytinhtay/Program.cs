using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maytinhtay
{
    internal class Program
    {
        delegate double calculater(double x, double y);
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Menu();
            while (true)
            {
                double sohang1 = Input();
                Console.Write("Nhập phép toán: ");
                ConsoleKeyInfo str=Console.ReadKey();
                Console.WriteLine();
                switch (str.Key)
                {
                    case ConsoleKey.Add:
                        {
                            double sohang2 = Input();
                            calculater calculaterdelegate = new calculater(Add);
                            double result = calculaterdelegate(sohang1, sohang2);
                            Show(sohang1,sohang2,str,result);
                            break;
                        }
                    case ConsoleKey.Subtract:
                        {
                            double sohang2 = Input();
                            calculater calculaterdelegate = new calculater(Sub);
                            double result = calculaterdelegate(sohang1, sohang2);
                            Show(sohang1, sohang2, str, result);
                            break;
                        }
                    case ConsoleKey.Divide:
                        {
                            double sohang2 = Input();
                            calculater calculaterdelegate = new calculater(Div);
                            double result = calculaterdelegate(sohang1, sohang2);
                            Show(sohang1, sohang2, str, result);
                            break;
                        }
                    case ConsoleKey.Multiply:
                        {
                            double sohang2 = Input();
                            calculater calculaterdelegate = new calculater(Mul);
                            double result = calculaterdelegate(sohang1, sohang2);
                            Show(sohang1, sohang2, str, result);
                            break;
                        }    
                    default:
                        {
                            Console.WriteLine("bạn nhập không đúng  phép toán");
                            break;
                        }
                }
                ConsoleKeyInfo stop = Console.ReadKey();
                if (stop.Key == ConsoleKey.Escape) break;
                Console.Clear();
                Menu();
            }
            
            Console.ReadLine();
        }
        public static void Menu()
        {
            Console.WriteLine("Máy tính tay");
            Console.WriteLine("Bạn nhập số và phép toán trên bàn phím số");
            Console.WriteLine("Bạn nhấn phím bất kỳ để tiếp tục");
            Console.WriteLine("Bạn nhấn phím Escape để thoát khỏi  chương trình");
        }
        public static double Add(double x, double y)
        {
            return x + y;
        }
        public static double Sub(double x, double y)
        {
            return x - y;
        }
        public static double Mul(double x, double y)
        {
            return x * y;
        }
        public static double Div(double x, double y)
        {
            return x * y;
        }
        public static double Input()
        {
             Console.Write("Nhập số hạng: ");
             double x = double.Parse(Console.ReadLine());
             return x;
        }
        public static void Show(double x, double y, ConsoleKeyInfo keys, double z)
        {
            Console.WriteLine();
            if(keys.Key ==  ConsoleKey.Add) Console.WriteLine("{0} + {1} = {2}",x,y,z);
            if (keys.Key == ConsoleKey.Subtract) Console.WriteLine("{0} - {1} = {2}", x, y, z);
            if (keys.Key == ConsoleKey.Divide) Console.WriteLine("{0} / {1} = {2}", x, y, z);
            if (keys.Key == ConsoleKey.Multiply) Console.WriteLine("{0} * {1} = {2}", x, y, z);
        }
    }
}
