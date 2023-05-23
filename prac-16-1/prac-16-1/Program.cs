using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac_16_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string oprt, n1, n2;
                Stack<string> expression = new Stack<string>();
                do
                {

                    Console.WriteLine("Введите операнд префиксного выражения");
                    oprt = Console.ReadLine();
                    Console.WriteLine("Введите первое число");
                    n1 = Console.ReadLine();
                    Console.WriteLine("Введите вторе число");
                    n2 = Console.ReadLine();
                    if (double.TryParse(n1,out double res1) && double.TryParse(n2, out double res2))
                    {
                        if (oprt.Length == 1)
                        {
                            if (oprt[0] == '+' || oprt[0] == '-' || oprt[0] == '*' || oprt[0] == '/')
                            {
                                Console.WriteLine($"Ваше выражение: {oprt} {n1} {n2}");
                                break;
                            }
                        }
                    }
                    Console.WriteLine("Выражение записано неправильно");

                }
                while (true);
                expression.Push(oprt);
                expression.Push(n1);
                expression.Push(n2);
                double res = Resolve(expression);
                if(res== -55555555)
                {
                    Console.WriteLine("На ноль делить нельзя");
                }
                else if (res == 11111111)
                {
                    Console.WriteLine("Извините что-то пошло не так");
                }
                else
                Console.WriteLine($"Result = {res}");
                Console.ReadKey();

                double Resolve(Stack<string> stack)
                {
                    double o1 = double.Parse(stack.Pop());
                    double o2 = double.Parse(stack.Pop());
                    string oprd = stack.Pop();
                    double result;
                    switch (oprd)
                    {
                        case "+": result = o2 + o1; break;
                        case "-": result = o2 - o1; break;
                        case "*": result = o2 * o1; break;
                        case "/":
                            if (o1 == 0) { result = -55555555; }
                            else
                            result = o2 / o1; break;
                        default:result = 11111111; break;
                    }
                    return result;
                }
            }
            catch
            {
                Console.WriteLine("Error");
                Console.ReadKey();
            }

        }
    } 
}
