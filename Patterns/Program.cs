using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    //Написать функцию, которая запрашивает число у пользователя (с помощью метода Console.ReadLine() )
    //и пытается сконвертировать его в тип int (с помощью int.TryParse())
    //Если конвертация не удалась у пользователя запрашивается число повторно до тех пор, пока не будет введено верно.
    //После ввода, который удалось преобразовать в число, число возвращается.

    //P.S Задача решается с помощью циклов

    //P.S Также в TryParse используется модфикатор параметра out

    internal class Programm
    {
        static void Main(string[] args)
        {
            int numberToConvert;
            Convert(out numberToConvert);
        }

        static void Convert(out int number)
        {
            bool isEntering = true;
            number = 0;

            while (isEntering)
            {
                Console.WriteLine("Введите любое число.");
                bool isConverted = int.TryParse(Console.ReadLine(), out number);

                if (isConverted == true)
                {
                    Console.WriteLine("Переконвертация прошла успешно.");
                    isEntering = false;
                }
                else
                {
                    Console.WriteLine("Вы ввели некорректное число. Попробуйте снова.");
                }
            }
        }
    }
}
