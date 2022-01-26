using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfMonth
{
    class FavoriteMonth
    {
        //my varibles 
        private int month;
        private int days = 0;
        private int years;
       

        //method to start app
        public void Start()
        {
            // assing calm with the Calcmonth value
            int calm = MonthFav();

           if (calm == 0) //if it is equal to 0, we just Console
            {
                Console.ReadKey();
            } else //otherwise we play
            {
                CalcMonth(MonthFav());
                WichYear();
                DisplayInformation();
            }
        }

        // method for favorite month 
        private int MonthFav()
        {
            //converting to int and returningd
            Console.WriteLine("Write your favorite month 1 to 12 to terminate or 0 to terminate: ");
            string monthInput = Console.ReadLine();
            month = int.Parse(monthInput);
           
            return month; 
         
        }

        //method to calc month and we using parameter
        private int CalcMonth(int monthValue)
        {
         
                //switch case for the months
                switch (monthValue)
                {

                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        days = 31; //asinging the days 
                        break;

                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        days = 30;
                        break;
                    case 2:
                    //using conditinal and modules for counitng the leap year
                        if (((years % 4 == 0) &&
                                !(years % 100 == 0))
                                || (years % 400 == 0))
                            days = 29;
                        else
                            days = 28;
                        break;
                    default:
                        Console.WriteLine("Invalid month.");
                        break;

                }
            
            //returing it 
            return days;
        }

        //method for year
        private int WichYear()
        {
            //convering, parsing and returing
            Console.WriteLine("Which year (1900 to 3000)");
            string yearInput = Console.ReadLine();
            
            years = int.Parse(yearInput);
            return years;
        }

        //dispalying the info
        private void DisplayInformation()
        {
            Console.WriteLine($"Number of days for {month} in {years}: {days}");
        }
    }


}
 