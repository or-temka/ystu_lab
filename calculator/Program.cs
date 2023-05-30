using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double fNum, sNum, result = 0;
            int typeOperation;
            Console.WriteLine("Здравствуйте, мой господин.");
            Console.Write("Введите первое число >> ");
            fNum = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число >> ");
            sNum = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Выберите тип операции для a и b:");
            Console.WriteLine("1. Сложение\n2. Вычетание\n3. Умножение\n4. Деление");
            typeOperation = Convert.ToInt32(Console.ReadLine());
            switch (typeOperation)
            {
                case 1: result = fNum + sNum; break;
                case 2: result = fNum - sNum; break;
                case 3: result = fNum * sNum; break;
                case 4:
                    if (sNum == 0)
                    {
                        Console.WriteLine("Деление на 0 невозможно!");
                        return;
                    }
                    result = fNum / sNum;
                    break;
            }
            Console.Write("Ответ: " + result);
        }
    }
}
