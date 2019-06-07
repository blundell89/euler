namespace euler
{
    public class MultiplesOf3And5Calculator
    {
        public int CalculateSumOfMultiplesBelow(int number)
        {
            int result = 0;

            for (int i = 1; i < number; i++)
            {
                if (IsMultipleOf(i, 3) ||
                    IsMultipleOf(i, 5))
                    result += i;
            }

            return result;
        }

        private static bool IsMultipleOf(int current, int multiple)
        {
            return current % multiple == 0;
        }
    }
}
