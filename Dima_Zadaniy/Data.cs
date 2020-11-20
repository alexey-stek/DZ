using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dima_Zadaniy
{
    
    
    class Data
    {
        DateTime today = DateTime.Today;
        DateTime date1 = new DateTime();
        DateTime date2 = new DateTime();
        DateTime date3 = new DateTime();

        public Data()
        {
           this. today = today;
           this. date1 = date1;
            this.date2 = date2;
            this. date3 = date3;


        }

        public Data(DateTime today, DateTime date1, DateTime date2, DateTime date3)
        {
            this.today = today;
            this.date1 = date1;
            this.date2 = date2;
            this.date3 = date3;


        }

        public void numberDays(DateTime date2, DateTime date1)
        {
            Console.WriteLine(date2.Subtract(date1));
            
            
        }
       
        
        public void expectedDate(DateTime date3, DateTime today)
        {
            //var today = DateTime.Today;
            
            var remainingDays = (date3 - today).TotalDays;
            Console.WriteLine("Оставшеся количество дней " + remainingDays);


        }

        //public void expectedDate1()
        //{
        //    var today = DateTime.Today;

        //    var remainingDays = (date3 - today).TotalDays;
        //    Console.WriteLine("Оставшеся количество дней " + remainingDays);


        //}

    }
}
