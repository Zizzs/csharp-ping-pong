using System;
using System.Collections.Generic;
using System.Linq;


namespace PingPongMain
{
    public class PingPongClass
    {
        public static string CheckNumber(int number)
        {
               if (number%3==0 && number%5==0) 
               {
                   return "ping-pong";
               } 
               else if (number%3==0)
               {
                   return "ping";
               } 
               else if (number%5==0)
               {
                   return "pong";
               }
               else
               {
                   return number.ToString();
               }
            //User Enters Number

            //Given a list of all numbers beginning at 1 and counting up to the inputted number

            //Replace some numbers with wordßs.
            // - All numbers divisible by BOTH 3 and 5 are replaced by "ping-pong".
            // - All numbers in the list that are divisible by 3 are replaced by "ping".
            // - All numbers divisible by 5 are replaced by "pong".
            
        }

        public static void Main()
        {
            Console.WriteLine("Please enter a number.");
            int userNumber = int.Parse(Console.ReadLine());
            for(int i=1;i<=userNumber;i++)
            {
                string userOutput = CheckNumber(i);
                Console.WriteLine(userOutput);
            }
        }
    }
}