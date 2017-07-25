namespace Exercise10
{
    class Model
    {
        public int GetSum(int min, int max)
        {
            int sum = 0;
            for(int i = min; i <= max; i++)
            {
                sum += i * i;
            }
            return sum;
        }

        public float GetAverage(int min, int max)
        {
            int count = max - min + 1;
            return this.GetSum(min, max) / count;
        }
    }
}
