using System;

namespace IfElse_DaysOfWeeks
{
    class Program
    {
        static void Main(string[] args)
        {
           var DS = DateTime.Now.DayOfWeek; 

            if (DS == DayOfWeek.Sunday)
            {
              Console.WriteLine($"Today is: {DayOfWeek.Sunday}");  
            }
            else if (DS == DayOfWeek.Monday)
            {
                Console.WriteLine($"Today is: {DayOfWeek.Monday}");
            }
            else if (DS == DayOfWeek.Tuesday)
            {
                Console.WriteLine($"Today is: {DayOfWeek.Tuesday}");
            }
            else if (DS == DayOfWeek.Wednesday)
            {
                Console.WriteLine($"Today is: {DayOfWeek.Wednesday}");
            }
            else if (DS == DayOfWeek.Thursday)
            {
                Console.WriteLine($"Today is: {DayOfWeek.Thursday}");
            }
            else if (DS == DayOfWeek.Friday)
            {
                Console.WriteLine($"Today is: {DayOfWeek.Friday}");
            }
            else if (DS == DayOfWeek.Saturday)
            {  
              Console.WriteLine($"Today is: {DayOfWeek.Saturday}");
           }
        }
    }
}