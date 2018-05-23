using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions
{
    public static class FizzBuzzSolution
    {
        public static string FizzBuzz(int number)
        {
            if (number % 3 == 0 && number % 5 == 0) return "fizz buzz";
            if (number % 3 == 0) return "fizz";
            if (number % 5 == 0) return "buzz";
            else return "1";
        }
    }
}
