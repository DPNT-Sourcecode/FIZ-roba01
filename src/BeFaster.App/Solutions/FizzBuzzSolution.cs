﻿using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions
{
    public static class FizzBuzzSolution
    {
        public static string FizzBuzz(int number)
        {
            //i know that bad, but i have to do it fast
            if (FakeDeluxe(number))
                return "fake deluxe";

            if ((number % 5 == 0 || number.ToString().Contains("5")) &&
                (number % 3 == 0 || number.ToString().Contains("3")) 
                && Deluxe(number)) return "fizz buzz deluxe";

            if ((Deluxe(number)) && (number % 5 == 0 || number.ToString().Contains("5")))
                return "buzz deluxe";

            if ((Deluxe(number)) && (number % 3 == 0 || number.ToString().Contains("3")))
                return "fizz deluxe";

            if (Deluxe(number))
                return "deluxe";

            if ((number % 5 == 0 || number.ToString
                ().Contains("5")) &&
                (number % 3 == 0 || number.ToString().Contains("3")))
                return "fizz buzz";

            if (number % 3 == 0 || number.ToString().Contains("3"))
                return "fizz";

            if (number % 5 == 0 || number.ToString().Contains("5"))
                return "buzz";

            return number.ToString();
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

        private static bool FakeDeluxe(int number)
        {
            if (Deluxe(number))
            {
                if (number % 2 != 0)
                    return true;
            }
            return false;
        }
    }
}
