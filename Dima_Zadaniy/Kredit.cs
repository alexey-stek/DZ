using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Калькулятор переплаты по кредиту - вводим сумму кредита, годовую ставку, 
//    срок, программа выводит сумму, которая будет выплачена банку в виде процентов.

namespace Dima_Zadaniy
{
    class Kredit
    {
        public double loanAmount;        // сумма кредита
        public double rate;                // ставка
        public double term;                // срок
        public double overpayment;     // сумма перплаты
        public double paymentMonth;     // платеж в месяц
        public double percentageofMonth; // процент в месяц

        public Kredit()
        {
            this.loanAmount = loanAmount;
            this.rate = rate;
            this.term = term;
            this.overpayment = overpayment;
            this.paymentMonth = paymentMonth;
            this.percentageofMonth = percentageofMonth;
        }
        public Kredit(double loanAmount, double rate, double term, double overpayment, double paymentMonth, double percentageofMonth)
        {
            this.loanAmount = loanAmount;
            this.rate = rate;
            this.term = term;
            this.overpayment = overpayment;
            this.paymentMonth = paymentMonth;
            this.percentageofMonth = percentageofMonth;
        }

        public double interestСredit(double rate)
        {
            percentageofMonth = (rate / 12) / 10;
            
            return percentageofMonth;
        }

        public double MonthlyPayment(double loanAmount)
        {
            paymentMonth = percentageofMonth * loanAmount;
            
            return paymentMonth;
        }

       public double OverpaymentOfTotal(double term, double loanAmount)
        {
             overpayment = (paymentMonth * term) - loanAmount;
            
            return overpayment;
        }

        public void Print()
        {
            Console.WriteLine("Процент по кредиту в месяц " + percentageofMonth);
            Console.WriteLine("Платеж в месяц по кредиту " + paymentMonth);
            Console.WriteLine("Переплата по кредиту " + overpayment);
        }






    }
}
