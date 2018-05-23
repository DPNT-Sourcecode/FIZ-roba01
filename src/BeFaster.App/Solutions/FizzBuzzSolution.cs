using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions
{
    public static class FizzBuzzSolution
    {
        public static string FizzBuzz(int number)
        {
            //String containing either the number, "fizz", "buzz" or "fizz buzz"
            //i think that return any number for example 1 !
            if (number % 3 == 0 && number % 5 == 0) return "fizz buzz";
            if (number % 3 == 0) return "fizz";
            if (number % 5 == 0) return "buzz";
            return number.ToString();
        }
    }
}
