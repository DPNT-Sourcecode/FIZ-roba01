using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions
{
    public static class FizzBuzzSolution
    {
        public static string FizzBuzz(int number)
        {
            //String containing either the number, "fizz", "buzz" or "fizz buzz"
            //i think that return any number for example 1 !
            if (number % 3 == 0 || number.ToString().Contains("3")) return "fizz";
            if (number % 5 == 0 || number.ToString().Contains("5")) return "buzz";
            if (number % 5 == 0 || number.ToString().Contains("5") &&
                number % 3 == 0 || number.ToString().Contains("3")) return "fizz buzz";
            return number.ToString();
        }
    }
}
