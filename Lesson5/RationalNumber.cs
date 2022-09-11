using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    public class RationalNumber
    {
        public int Numerator { get; private set; }
        public int Denominator { get; private set; }

        /// <summary>
        /// Рациональная дробь.
        /// </summary>
        /// <param name="numerator">Числитель</param>
        /// <param name="denominator">Знаменатель</param>
        /// <exception cref="DivideByZeroException">При передаче 0 в параметр "Знаменатель".</exception>
        public RationalNumber(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new DivideByZeroException("В качестве знаменателя был указан 0.");

            Numerator = numerator;
            Denominator = denominator;
        }
        public static RationalNumber operator +(RationalNumber first, RationalNumber second)
        {
            int resultNumerator = (first.Numerator * second.Denominator) + (second.Numerator * first.Denominator);
            int resultDenominator = first.Denominator * second.Denominator;
            return new RationalNumber(resultNumerator, resultDenominator);
        }
        public static RationalNumber operator -(RationalNumber first, RationalNumber second)
        {
            int resultNumerator = (first.Numerator * second.Denominator) - (second.Numerator * first.Denominator);
            int resultDenominator = first.Denominator * second.Denominator;
            return new RationalNumber(resultNumerator, resultDenominator);
        }
        public static RationalNumber operator *(RationalNumber first, RationalNumber second)
        {
            return new RationalNumber(first.Numerator * second.Numerator, first.Denominator * second.Denominator);
        }
        public static RationalNumber operator /(RationalNumber first, RationalNumber second)
        {
            return new RationalNumber(first.Numerator * second.Denominator, first.Denominator * second.Numerator);
        }
        public static decimal operator %(RationalNumber first, RationalNumber second)
        {
            decimal firstFraction = (decimal)first.Numerator / (decimal)first.Denominator;
            decimal secondFraction = (decimal)second.Numerator / (decimal)second.Denominator;
            decimal result = firstFraction % secondFraction;
            return result;
        }
        public static RationalNumber operator ++(RationalNumber rationalNumber)
        {
            return new RationalNumber(rationalNumber.Numerator + rationalNumber.Denominator, rationalNumber.Denominator);
        }
        public static RationalNumber operator --(RationalNumber rationalNumber)
        {
            return new RationalNumber(rationalNumber.Numerator - rationalNumber.Denominator, rationalNumber.Denominator);
        }
        public static bool operator ==(RationalNumber first, RationalNumber second)
        {
            return first.Equals(second);
        }
        public static bool operator !=(RationalNumber first, RationalNumber second)
        {
            return !first.Equals(second);
        }
        public static bool operator >(RationalNumber first, RationalNumber second)
        {
            if (ConvertToFraction(first) > ConvertToFraction(second))
                return true;

            return false;
        }
        public static bool operator <(RationalNumber first, RationalNumber second)
        {
            if (ConvertToFraction(first) < ConvertToFraction(second))
                return true;

            return false;
        }
        public static bool operator >=(RationalNumber first, RationalNumber second)
        {
            if (ConvertToFraction(first) >= ConvertToFraction(second))
                return true;

            return false;
        }
        public static bool operator <=(RationalNumber first, RationalNumber second)
        {
            if (ConvertToFraction(first) <= ConvertToFraction(second))
                return true;

            return false;
        }
        public static implicit operator float(RationalNumber rationalNumber)
        {
            return (float)rationalNumber.Numerator / (float)rationalNumber.Denominator;
        }
        public static implicit operator int(RationalNumber rationalNumber)
        {
            return rationalNumber.Numerator / rationalNumber.Denominator;
        }
        public static implicit operator RationalNumber(int integer)
        {
            return new RationalNumber(integer, 1);
        }
        public static implicit operator RationalNumber(float fraction)
        {
            int numbersCount = !fraction.ToString().Contains(',') ? 0 : fraction.ToString().Length - fraction.ToString().IndexOf(',') - 1;
            int multiplier = Convert.ToInt32(Math.Pow(10, numbersCount));
            int numerator = (int)(fraction * multiplier);

            return new RationalNumber(numerator, multiplier);
        }
        public override bool Equals(object? obj)
        {
            if (obj is not RationalNumber || obj == null)
                return false;

            RationalNumber first = this;
            RationalNumber second = (RationalNumber)obj;

            if (ConvertToFraction(first) == ConvertToFraction(second))
                return true;

            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
        private static decimal ConvertToFraction(RationalNumber rationalNumber)
        {
            return (decimal)rationalNumber.Numerator / (decimal)rationalNumber.Denominator;
        }
    }
}
