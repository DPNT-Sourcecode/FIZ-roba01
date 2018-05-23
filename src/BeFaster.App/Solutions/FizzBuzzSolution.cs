using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions
{
    public static class FizzBuzzSolution
    {
        public static string FizzBuzz(int number)
        {
            if ((number % 5 == 0 || number.ToString().Contains("5")) &&
                (number % 3 == 0 || number.ToString().Contains("3"))) return "fizz buzz";
            if (number % 3 == 0 || number.ToString().Contains("3")) return "fizz";
            if (number % 5 == 0 || number.ToString().Contains("5")) return "buzz";
            return number.ToString();
        }
    }
}
