using BeFaster.Runner.Exceptions;
using System;

namespace BeFaster.App.Solutions
{
    public static class FizzBuzzSolution
    {
        public static string FizzBuzz(int number)
        {
            //i know that bad, but i have to do it fast
            string res = "";


            if (number % 3 == 0 || number.ToString().Contains("3"))
                res += "fizz";

            if (number % 5 == 0 || number.ToString().Contains("5"))
            {
                if (res == String.Empty)
                    res = "buzz";
                else
                    res += " buzz";

            }

            string deluxe = ;
            if (Deluxe(number))
            {
                if (OddNumber(number))
                {
                    res += "fake deluxe";
                }
                else
                {
                    res += "deluxe";
                }
            }

            return res == String.Empty ? number.ToString() : res;


            //if (FakeDeluxe(number))
            //    res += "fake deluxe";

            //if ((number % 5 == 0 || number.ToString().Contains("5")) &&
            //    (number % 3 == 0 || number.ToString().Contains("3")) 
            //    && Deluxe(number)) return "fizz buzz deluxe";

            //if ((Deluxe(number)) && (number % 5 == 0 || number.ToString().Contains("5")))
            //    return "buzz deluxe";

            //if ((Deluxe(number)) && (number % 3 == 0 || number.ToString().Contains("3")))
            //    return "fizz deluxe";

            //if (Deluxe(number))
            //    return "deluxe";

            //if ((number % 5 == 0 || number.ToString
            //    ().Contains("5")) &&
            //    (number % 3 == 0 || number.ToString().Contains("3")))
            //    return "fizz buzz";





        }

        private static bool Deluxe(int number)
        {
            if (number <= 10) return false;

            string numberStr = number.ToString();
            char firstSymbol = numberStr[0];
            foreach (var num in number.ToString())
            {
                if (num != firstSymbol)
                    return false;
            }
            return true;
        }

        private static bool OddNumber(int number)
        {
            if (number % 2 == 0)
                return false;
            else
                return true;
        }
    }
}
