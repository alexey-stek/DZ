using Dima_Zadaniy;
using System;

namespace DimaZadaniy
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Console.WriteLine("Введите цифру для выбора программы:  1 - Дата, 2- Кредит, 3- число, 4 - площадь");
            int a = Convert.ToInt32(Console.ReadLine());

            switch(a)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    Console.WriteLine("Введите начальную дату ");
                    DateTime date1 = Convert.ToDateTime(Console.ReadLine());

                    Console.WriteLine("Введите конечную дату");
                    DateTime date2 = Convert.ToDateTime(Console.ReadLine());

                    Data data = new Data();
                    data.numberDays(date2, date1);


                    Console.WriteLine("Введите предполагаемую дату");
                    DateTime today = DateTime.Today;
                    DateTime date3 = Convert.ToDateTime(Console.ReadLine());
                    data.expectedDate(date3, today);                    
                    break;

                case 2:
                    Console.WriteLine("Case 2");

                    Console.WriteLine("Введите сумму кредита");

                    double SummaKredita = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите годовую ставку");

                    double stavka = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите срок");

                    double srok = Convert.ToDouble(Console.ReadLine());

                    Kredit kredit = new Kredit();

                    kredit.interestСredit(stavka);

                    kredit.MonthlyPayment(SummaKredita);

                    kredit.OverpaymentOfTotal(srok, SummaKredita);

                    kredit.Print();                    
                    break;

                case 3:
                
                    guessNumber guess = new guessNumber();
                    guess.Guess();
                        Console.WriteLine("Case 3");
                    break;

                case 4:
                    Console.WriteLine("Case 4");
                    Console.Write("Введите длину  стены ");
                    double d = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("Введите ширину стены ");
                    double s = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("Введите высоту стены ");
                    double v = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();

                    Ploshad ploshad = new Ploshad();
                    ploshad.SSteny(d, s, v);

                    Console.Write("Введите высоту двери ");
                    double vdoor = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("Введите ширину  двери ");
                    double sdoor = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("Введите высоту окна ");
                    double vwindow = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("Введите ширину окна ");
                    double swindow = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();

                    ploshad.SdoorWindow(vdoor, sdoor, vwindow, swindow);

                    ploshad.SUseful();
                    ploshad.Print();                   
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }

           



        }
    }   } 

