using System;

namespace Task1
{
    struct Complex
    {
        private double re;
        private double im;
        public Complex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }
        public Complex Plus(Complex x)
        {
            Complex y;
            y.re = re + x.re;
            y.im = im + x.im;
            return y;
        }
        public Complex Minus(Complex x)
        {
            Complex y;
            y.re = re - x.re;
            y.im = im - x.im;
            return y;
        }
        public Complex Multiply(Complex x)
        {
            Complex y;
            y.re = re * x.re - im * x.im;
            y.im = re * x.im + im * x.re;
            return y;
        }
        public Complex Divide(Complex x)
        {
            Complex y;
            y.re = (re * x.re + im * x.im) / (x.re * x.re + x.im * x.im);
            y.im = (im * x.re - re * x.im) / (x.re * x.re + x.im * x.im);
            return y;
        }
        public override string ToString()
        {
            return re + "+" + im + "i";
        }
    }

}
