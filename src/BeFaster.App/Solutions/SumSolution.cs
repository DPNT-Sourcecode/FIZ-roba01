using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions
{
    public static class SumSolution
    {
        public static int Sum(int x, int y)
        {
            if (x < 0 && x > 100) throw new System.ArgumentException("x should be beetween 0 - 100");
            if (y < 0 && y > 100) throw new System.ArgumentException("y should be beetween 0 - 100");
            return x + y;
        }
    }
}
