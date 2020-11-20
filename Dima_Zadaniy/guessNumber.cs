using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;


//Игра “Угадай число” - программа случайно генерирует число в некотором диапазоне,
//    пользователь вводит предполагаемое значение, если они совпали - победа.
//Доработать игру - после неудачной попытки давать еще одну,
//и указывать в большую или в меньшую сторону была ошибка

namespace Dima_Zadaniy
{


    class guessNumber
    {

       
        public void Guess()
        {
           
            while (true)
            {
                Random r = new Random();
                int a = r.Next(5);
                Console.WriteLine("Компьютер загадал число. Попробуйте отгодать его.");
                Console.WriteLine("Введите  число:");
                int k = Convert.ToInt32(Console.ReadLine());


                if (a == k)
                {
                    Console.WriteLine("Вы угодали число " + k + " Победа!");
                    break;
                }

                if (a > k)
                {
                    Console.WriteLine("Ваше число меньше загаданого, попробуйте еще раз");

                    k = Convert.ToInt32(Console.ReadLine());
                    continue;
                }
                if (a < k)
                {
                    Console.WriteLine("Ваше число ,больше  загаданого, попробуйте еще раз");
                    k = Convert.ToInt32(Console.ReadLine());
                    continue;
                }
                

            }
        }

    }
}
