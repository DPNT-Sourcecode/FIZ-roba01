using BeFaster.Runner.Exceptions;
using System;

namespace BeFaster.App.Solutions
{
    public static class FizzBuzzSolution
    {
        public static string FizzBuzz(int number)
        {
            //i don't understand !!
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


            string deluxe = "";
            if (Deluxe(number))
            {
                if (OddNumber(number))
                {
                    deluxe += "fake deluxe";
                }
                else
                {
                    deluxe += "deluxe";
                }
            }
            //if (OddNumber(number))
            //{
            //    if (Deluxe(number))
            //    {
            //        deluxe += "fake deluxe";
            //    }
            //}

            if (res == String.Empty)
                res = deluxe;
            else
            {
                if (deluxe != string.Empty)
                    res += " " + deluxe;
            }

            return res == String.Empty ? number.ToString() : res;
        }

        private static bool Deluxe(int number)
        {
            if (!((number % 3 == 0 && number.ToString().Contains("3")) || (number % 5 == 0 && number.ToString().Contains("5"))))
                return false;

            //string numberStr = number.ToString();
            //char firstSymbol = numberStr[0];
            //foreach (var num in number.ToString())
            //{
            //    if (num != firstSymbol)
            //    {
            //        return true;
            //    }
            //}
            return true;

        }

        private static bool OddNumber(int number)
        {


            string numberStr = number.ToString();
            char firstSymbol = numberStr[0];
            var res = false;

            if (number <= 10) res = true;


            foreach (var num in number.ToString())
            {
                if (num != firstSymbol)
                {
                    res = true;
                    break;
                }
            }

            if (number % 2 == 0)
                res = false;
            else
                res = true;

            return res;
        }
    }
}
