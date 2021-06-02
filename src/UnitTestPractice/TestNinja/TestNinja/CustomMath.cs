using System;

namespace TestNinja
{
    public class CustomMath
    {
        public int MaxNumber(int first, int second)
        {
            return first > second ? first : second;
        }

        public double Devide(string first, string second)
        {
            if (string.IsNullOrWhiteSpace(second))
                throw new ArgumentNullException();

            return int.Parse(first) / int.Parse(second);
        }
    }
}