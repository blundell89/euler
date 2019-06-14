namespace euler._2
{
    public class EvenFibonacciCalculator
    {
        public int Calculate(int inclusiveTo)
        {
            int sum = 0;
            int current = 1;
            int previous = 0;

            while (current <= inclusiveTo)
            {
                if (current % 2 == 0)
                    sum += current;

                int temp = current;
                current += previous;
                previous = temp;
            }

            return sum;
        }
    }
}
