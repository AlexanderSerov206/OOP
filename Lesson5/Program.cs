namespace Lesson5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RationalNumber first = new RationalNumber(2, 4);
            RationalNumber second = new RationalNumber(1, 4);

            RationalNumber third = first - second;

            bool result = first == second;
            bool result2 = second == third;

            first++;
            second--;

            bool result3 = first != second;
            bool result4 = second != third;

            RationalNumber half = new RationalNumber(1, 2);
            RationalNumber threeForth = new RationalNumber(3, 4);

            decimal resulting = half % threeForth;
            RationalNumber floate = 0.334f;

            int integer = new RationalNumber(3, 2);
        }
    }
}