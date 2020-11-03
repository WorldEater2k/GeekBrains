using System;

namespace Task3
{
    class ArgumentException : Exception
    {
        public ArgumentException()
            : base("Знаменатель не может быть равен 0.")
        { }
    }
    class Fraction
    {
        private int numerator = 0;
        private int denominator = 1;
        public int Numerator
        {
            get
            {
                return numerator;
            }
            set
            {
                numerator = value;
            }
        }
        public int Denominator
        {
            get
            {
                return denominator;
            }
            set
            {
                if (value != 0)
                    denominator = value;
                else
                    throw new ArgumentException();
            }
        }
        public double Decimal
        {
            get
            {
                return (double)Numerator / Denominator;
            }
        }
        public Fraction() { }
        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }
        public Fraction Plus(Fraction f)
        {
            Fraction result = new Fraction();
            if (Denominator != f.Denominator)
            {
                result.Denominator = Denominator * f.Denominator;
                result.Numerator = Numerator * f.Denominator + f.Numerator * Denominator;
            }
            else
            {
                result.Denominator = Denominator;
                result.Numerator = Numerator + f.Numerator;
            }
            return result;
        }
        public Fraction Minus(Fraction f)
        {
            Fraction temp = new Fraction(-f.Numerator, f.Denominator);
            return Plus(temp);
        }
        public Fraction Multiply(Fraction f)
        {
            Fraction result = new Fraction();
            result.Denominator = Denominator * f.Denominator;
            result.Numerator = Numerator * f.Numerator;
            return result;
        }
        public Fraction Divide(Fraction f)
        {
            Fraction temp = new Fraction(f.Denominator, f.Numerator);
            return Multiply(temp);
        }
        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }
}
