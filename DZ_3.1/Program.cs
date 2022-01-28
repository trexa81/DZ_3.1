using System;

namespace DZ_3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RationalNumber rn = new(5, 10);
            Console.WriteLine("{0}/{1}", rn.Numerator, rn.Denominator);

            RationalNumber r1 = new RationalNumber(3, 5);
            RationalNumber r2 = new RationalNumber(4, 7);

            RationalNumber add = r1 + r2;   // add = 41/35
            RationalNumber sub = r1 - r2;   // sub = 1/35
            RationalNumber mul = r1 * r2;   // mul = 12/35
            RationalNumber div = r1 / r2;   // div = 21/20
            Console.WriteLine("{0}/{1}", add.Numerator, add.Denominator);
            Console.WriteLine("{0}/{1}", sub.Numerator, sub.Denominator);
            Console.WriteLine("{0}/{1}", mul.Numerator, mul.Denominator);
            Console.WriteLine("{0}/{1}", div.Numerator, div.Denominator);

        }

        struct RationalNumber
        {
            /// <summary>
            /// числитель
            /// </summary>
            private int _numerator;
            /// <summary>
            /// знаменатель
            /// </summary>
            private int _denominator;

            public int Numerator
            {
                get { return _numerator; }
            }

            public int Denominator
            {
                get { return _denominator; }
            }

            //конструктор
            public RationalNumber(int numerator, int denominator)
            {
                if (denominator == 0)
                    throw new ArgumentException("Знаменатель не может быть равным 0.");

                if (denominator < 0)
                {
                    numerator *= -1;
                    denominator *= -1;
                }

                _numerator = numerator;
                _denominator = denominator;

                ReduceToLowestTerms();
            }

            private void ReduceToLowestTerms()
            {
                int greatestCommonDivisor = RationalNumber.GetGCD(_numerator, _denominator);
                _numerator /= greatestCommonDivisor;
                _denominator /= greatestCommonDivisor;
            }

            /// <summary>
            /// наибольший общий делитель
            /// </summary>
            /// <param name="term1"></param>
            /// <param name="term2"></param>
            /// <returns></returns>
            private static int GetGCD(int term1, int term2)  //Сокращение дроби до ее наименьших значений
            {
                if (term2 == 0)
                    return term1;
                else
                    return GetGCD(term2, term1 % term2);
            }

            public static RationalNumber operator +(RationalNumber r1, RationalNumber r2)
            {
                return new RationalNumber((r1.Numerator * r2.Denominator)
                    + (r2.Numerator * r1.Denominator), r1.Denominator * r2.Denominator);

            }

            public static RationalNumber operator -(RationalNumber r1, RationalNumber r2)
            {
                return new RationalNumber((r1.Numerator * r2.Denominator)
                    - (r2.Numerator * r1.Denominator), r1.Denominator * r2.Denominator);
            }

            public static RationalNumber operator *(RationalNumber r1, RationalNumber r2)
            {
                return new RationalNumber(r1.Numerator * r2.Numerator, r1.Denominator * r2.Denominator);
            }

            public static RationalNumber operator /(RationalNumber r1, RationalNumber r2)
            {
                return new RationalNumber(r1.Numerator * r2.Denominator, r1.Denominator * r2.Numerator);
            }


        }
    }
}
