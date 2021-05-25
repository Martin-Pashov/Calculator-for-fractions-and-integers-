using System;
using System.Linq;


namespace Fractions_and_integer_calculator
{
    class Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }


        public Fraction(int n, int d)
        {
            this.Numerator = n;
            this.Denominator = d;
        }


        public Fraction(string drop)
        {
            int[] nums = drop.Split(' ').Select(n => int.Parse(n)).ToArray();
            this.Numerator = nums[0];
            this.Numerator = nums[1];
        }


        public override string ToString()
        {
            if (this.Denominator == 1)
            {
                return this.Numerator.ToString();
            }
            return this.Numerator + "/" + this.Denominator;
        }


        private static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int oldB = b;
                b = a % b;
                a = oldB;
            }
            return a;
        }


        public static Fraction operator +(Fraction fr1, Fraction fr2)
        {
            Fraction result = new Fraction(1, 1);
            result.Denominator = fr1.Denominator * fr2.Denominator;
            result.Numerator = fr1.Numerator * fr2.Denominator + fr2.Numerator * fr1.Denominator;
            int gcd = GCD(result.Numerator, result.Denominator);
            result.Numerator /= gcd;
            result.Denominator /= gcd;
            return result;
        }


        public static Fraction operator -(Fraction fr1, Fraction fr2)
        {
            Fraction result = new Fraction(1, 1);
            result.Denominator = fr1.Denominator * fr2.Denominator;
            result.Numerator = fr1.Numerator * fr2.Denominator - fr2.Numerator * fr1.Denominator;
            int gcd = GCD(result.Numerator, result.Denominator);
            result.Numerator /= gcd;
            result.Denominator /= gcd;
            return result;
        }


        public static Fraction operator *(Fraction fr1, Fraction fr2)
        {
            Fraction result = new Fraction(1, 1);
            result.Denominator = fr1.Denominator * fr2.Denominator;
            result.Numerator = fr1.Numerator * fr2.Numerator;
            int gcd = GCD(result.Numerator, result.Denominator);
            result.Numerator /= gcd;
            result.Denominator /= gcd;
            return result;
        }


        public static Fraction operator /(Fraction fr1, Fraction fr2)
        {
            Fraction result = new Fraction(1, 1);
            result.Numerator = fr1.Numerator * fr2.Denominator;
            result.Denominator = fr1.Denominator * fr2.Numerator;
            int gcd = GCD(result.Numerator, result.Denominator);
            result.Numerator /= gcd;
            result.Denominator /= gcd;
            return result;
        }


        public static bool operator <(Fraction fr1, Fraction fr2)
        {
            double a = (double)fr1.Numerator * fr2.Denominator;
            double b = (double)fr2.Numerator * fr1.Denominator;
            if (Math.Abs(a - b) < 0.001)
            {
                return true;
            }
            return false;
        }


        public static bool operator >(Fraction fr1, Fraction fr2)
        {
            double a = (double)fr1.Numerator * fr2.Denominator;
            double b = (double)fr2.Numerator * fr1.Denominator;
            if (a > b)
            {
                return true;
            }
            return false;
        }


        public static bool operator <=(Fraction fr1, Fraction fr2)
        {
            double a = (double)fr1.Numerator * fr2.Denominator;
            double b = (double)fr2.Numerator * fr1.Denominator;
            if (a <= b)
            {
                return true;
            }
            return false;
        }


        public static bool operator >=(Fraction fr1, Fraction fr2)
        {
            double a = (double)fr1.Numerator * fr2.Denominator;
            double b = (double)fr2.Numerator * fr1.Denominator;
            if (a >= b)
            {
                return true;
            }
            return false;
        }


        public static bool operator ==(Fraction fr1, Fraction fr2)
        {
            double a = (double)fr1.Numerator / fr1.Denominator;
            double b = (double)fr2.Numerator / fr2.Denominator;
            if (Math.Abs(a - b) < 0.001)
            {
                return true;
            }
            return false;
        }


        public static bool operator !=(Fraction fr1, Fraction fr2)
        {
            return !(fr1 == fr2);
        }
    }
}