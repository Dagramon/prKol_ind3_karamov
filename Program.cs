using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace prKol_ind3_karamov
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Complex number1 = new Complex();
                Complex number2 = new Complex();
                ArrayList results = new ArrayList();
                Console.Write("Введите a в первом комплексном числе: ");
                double a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите b в первом комплексном числе: ");
                double b = Convert.ToInt32(Console.ReadLine());
                number1.A = a;
                number1.B = b;
                Console.WriteLine($"Первое число: {number1.A} + {number1.B}i");
                Console.Write("Введите a во втором комплексном числе: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите b во втором комплексном числе: ");
                b = Convert.ToInt32(Console.ReadLine());
                number2.A = a;
                number2.B = b;
                Console.WriteLine($"Второе число: {number2.A} + {number2.B}i");
                Console.WriteLine("Результаты:");
                results.Add("Сумма: ");
                results.Add(Complex.sum(number1.A, number1.B, number2.A, number2.B));
                results.Add("Разность: ");
                results.Add(Complex.razn(number1.A, number1.B, number2.A, number2.B));
                results.Add("Произведение: ");
                results.Add(Complex.proizv(number1.A, number1.B, number2.A, number2.B));
                foreach (object item in results)
                {
                    Console.WriteLine(item);
                }
            }
            catch
            {
                Console.WriteLine("Неправильный формат ввода");
            }
            Console.ReadLine();
        }
    }
}
