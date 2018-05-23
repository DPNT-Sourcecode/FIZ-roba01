using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions
{
    public static class FizzBuzzSolution
    {
        public static string FizzBuzz(int number)
        {
            //i know that bad, but i have to do it fast
            if ((number % 5 == 0 || number.ToString().Contains("5")) &&
                (number % 3 == 0 || number.ToString().Contains("3")) 
                && Deluxe(number)) return "fizz buzz deluxe";
            if (number > 10 && Deluxe(number) && (number % 5 == 0 || number.ToString().Contains("5"))) return "deluxe";
            if (number > 10 && Deluxe(number) && (number % 3 == 0 || number.ToString().Contains("3")) return "deluxe";
            if (number > 10 && Deluxe(number)) return "deluxe";
            if ((number % 5 == 0 || number.ToString().Contains("5")) &&
                (number % 3 == 0 || number.ToString().Contains("3"))) return "fizz buzz";
            if (number % 3 == 0 || number.ToString().Contains("3")) return "fizz";
            if (number % 5 == 0 || number.ToString().Contains("5")) return "buzz";
            return number.ToString();
        }

        private static bool Deluxe(int number)
        {
            string numberStr = number.ToString();
            char firstSymbol = numberStr[0];
            foreach(var num in number.ToString())
            {
                if (num != firstSymbol)
                    return false;
            }
            return true;
        }
    }
}
