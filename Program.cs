using System;

namespace Lesson2_05_08_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Выведите число A=");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Выведите число B=");
            int B = Convert.ToInt32(Console.ReadLine());
            if (A > B)
            {
                B = A;
            }
            else if (A < B)
            {
                    A = B;
            }
            else
            {
                A = B = 0;
            }
            Console.WriteLine($"A={A},B={B}");  
            
            Console.Write("Выведите первое число :");
            var operand1 =Convert.ToInt32(Console.ReadLine());
            Console.Write("Выведите второе число :");
            var operand2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Выведите знак");
            var sign = Console.ReadLine();
            var result = 0;
            switch (sign)
            {
                case "+" :
                    result = operand1 + operand2;
                    break;
                case "-" :
                    result = operand1 - operand2;
                    break;    
                case "*" :
                    result = operand1 * operand2;
                    break;
                
                case "/" :
                    if (operand2 == 0)
                    {
                        Console.WriteLine("Деление на ноль нельзя!");
                        return;
                    }
                    else
                    {
                        result = operand1 / operand2;
                    }

                    break;
            }
            Console.WriteLine($"Результат={result}");
            
            Console.WriteLine("Выведите число от 0 до 100:");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number >= 0 && number <= 14)
            {
                Console.WriteLine($"{number} попадает в числовой промежуток от [0 - 14]"); 
            }
            else if (number >= 15 && number <=35 )
            {
                Console.WriteLine($"{number} попадает в числовой промежуток от [15 - 35]"); 
            }
            else if (number >= 36 && number <=50 )
            {
                Console.WriteLine($"{number} попадает в числовой промежуток от [36 - 50]"); 
            }
            else if (number >= 51 && number <=100 )
            {
                Console.WriteLine($"{number} попадает в числовой промежуток от [51 - 100]"); 
            }
            else
            {
                Console.WriteLine($"{number} не попадает ни в один заданный числовой промежуток");   
            }
        }
        
    }
}