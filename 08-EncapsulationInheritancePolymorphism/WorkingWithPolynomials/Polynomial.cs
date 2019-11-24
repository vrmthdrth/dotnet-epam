namespace WorkingWithPolynomials
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A class for working with polynomials of one real variable.
    /// </summary>
    public class Polynomial
    {
        /// <summary>
        /// Gets coefficients of polynomial.
        /// </summary>
        public double[] Coeffs { get; }

        /// <summary>
        /// Gets power of polynomial.
        /// </summary>
        public int Power
        {
            get
            {
                return this.Coeffs.Length - 1;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Polynomial"/> class.
        /// </summary>
        /// <param name="coefs">Coefficients.</param>
        public Polynomial(params double[] coefs)
        {
            this.Coeffs = coefs;
        }

        /// <summary>
        /// An overload of the summation operator.
        /// </summary>
        /// <param name="p">First polynomial.</param>
        /// <param name="q">Second polynomial.</param>
        /// <returns>Sum of polynomials.</returns>
        public static Polynomial operator +(Polynomial p, Polynomial q)
        {
            if (p == null || q == null)
            {
                throw new ArgumentNullException();
            }

            if (p.Coeffs.Length == 0 || q.Coeffs.Length == 0)
            {
                throw new ArgumentException();
            }

            int maxLength = Math.Max(p.Coeffs.Length, q.Coeffs.Length);
            int minLength = Math.Min(p.Coeffs.Length, q.Coeffs.Length);

            double[] resultArray = new double[maxLength];
            for (int i = 0; i < maxLength; i++)
            {
                if (i > minLength - 1)
                {
                    if (p.Coeffs.Length > q.Coeffs.Length)
                    {
                        resultArray[i] = p.Coeffs[i];
                    }
                    else
                    {
                        resultArray[i] = q.Coeffs[i];
                    }
                }
                else
                {
                    resultArray[i] = p.Coeffs[i] + q.Coeffs[i];
                }
            }

            return new Polynomial(resultArray);
        }

        /// <summary>
        /// An overload of the substraction operator.
        /// </summary>
        /// <param name="p">First polynomial.</param>
        /// <param name="q">Second polynomial.</param>
        /// <returns>A result of substraction.</returns>
        public static Polynomial operator -(Polynomial p, Polynomial q)
        {
            if (p == null || q == null)
            {
                throw new ArgumentNullException();
            }

            if (p.Coeffs.Length == 0 || q.Coeffs.Length == 0)
            {
                throw new ArgumentException();
            }

            int maxLength = Math.Max(p.Coeffs.Length, q.Coeffs.Length);
            int minLength = Math.Min(p.Coeffs.Length, q.Coeffs.Length);

            double[] resultArray = new double[maxLength];
            for (int i = 0; i < maxLength; i++)
            {
                if (i > minLength - 1)
                {
                    if (p.Coeffs.Length < q.Coeffs.Length)
                    {
                        resultArray[i] = -q.Coeffs[i];
                    }
                    else if (p.Coeffs.Length > q.Coeffs.Length)
                    {
                        resultArray[i] = p.Coeffs[i];
                    }
                }
                else
                {
                    resultArray[i] = p.Coeffs[i] - q.Coeffs[i];
                }
            }

            return new Polynomial(resultArray);
        }

        /// <summary>
        /// An overload of the multiplication operator.
        /// </summary>
        /// <param name="p">First polynomial.</param>
        /// <param name="q">Second polynomial.</param>
        /// <returns>A result of multiplication.</returns>
        public static Polynomial operator *(Polynomial p, Polynomial q)
        {
            if (p == null || q == null)
            {
                throw new ArgumentNullException();
            }

            if (p.Coeffs.Length == 0 || q.Coeffs.Length == 0)
            {
                throw new ArgumentException();
            }

            double[] resultArray = new double[p.Coeffs.Length + q.Coeffs.Length - 1];
            for (int i = 0; i < p.Coeffs.Length; i++)
            {
                for (int j = 0; j < q.Coeffs.Length; j++)
                {
                    resultArray[i + j] += p.Coeffs[i] * q.Coeffs[j];
                }
            }

            return new Polynomial(resultArray);
        }

        /// <summary>
        /// An overload of the division operator.
        /// </summary>
        /// <param name="dividend">Divisend polynomial.</param>
        /// <param name="divisor">Divisor polynomial.</param>
        /// <returns>Quotient and remainder as parts of PolynomialDivisionResult type.</returns>
        public static PolynomialDivisionResult operator /(Polynomial dividend, Polynomial divisor)
        {
            if (dividend.Coeffs.Last() == 0)
            {
                throw new ArithmeticException();
            }

            if (divisor.Coeffs.Last() == 0)
            {
                throw new ArithmeticException();
            }

            decimal[] remainder = new decimal[dividend.Coeffs.Length];
            decimal[] quotient = new decimal[remainder.Length - divisor.Coeffs.Length + 1];
            for (int i = 0; i < remainder.Length; i++)
            {
                remainder[i] = (decimal)dividend.Coeffs[i];
            }

            for (int i = 0; i < quotient.Length; i++)
            {
                decimal coeff = remainder[remainder.Length - i - 1] / (decimal)divisor.Coeffs.Last();
                quotient[quotient.Length - i - 1] = coeff;
                for (int j = 0; j < divisor.Coeffs.Length; j++)
                {
                    decimal d = (decimal)divisor.Coeffs[divisor.Coeffs.Length - j - 1];
                    remainder[remainder.Length - i - j - 1] -= coeff * d;
                }
            }

            double[] quotientResult = new double[quotient.Length];
            for (int i = 0; i < quotientResult.Length; i++)
            {
                quotientResult[i] = (double)quotient[i];
            }

            double[] remainderResult = new double[remainder.Length];
            for (int i = 0; i < remainderResult.Length; i++)
            {
                remainderResult[i] = (double)remainder[i];
            }

            PolynomialDivisionResult divisionResult = new PolynomialDivisionResult();
            divisionResult.Quotient = new Polynomial(quotientResult);
            divisionResult.Remainder = new Polynomial(remainderResult);
            return divisionResult;
        }


        /// <summary>
        /// An overriding of Object.ToString() method.
        /// </summary>
        /// <returns>String representation of a polynomial.</returns>
        public override string ToString()
        {
            string result = string.Empty;
            for (int i = 0; i < this.Coeffs.Length; i++)
            {
                result += $"({this.Coeffs[i]})*(x^{i})";
                if (i != this.Coeffs.Length - 1)
                {
                    result += " + ";
                }
            }

            return result;
        }

        /// <summary>
        /// An overriding of Object.Equals() method to work with Polynomial type.
        /// </summary>
        /// <param name="obj">A polynomial for comparison.</param>
        /// <returns>Result of comparison as a boolean variable.</returns>
        public override bool Equals(object obj)
        {
            var polynomial = obj as Polynomial;
            if (polynomial == null || polynomial.Coeffs.Length == 0)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < Math.Max(this.Coeffs.Length, polynomial.Coeffs.Length) - Math.Abs(this.Coeffs.Length - polynomial.Coeffs.Length); i++)
                {
                    if ((decimal)this.Coeffs[i] != (decimal)polynomial.Coeffs[i])
                    {
                        return false;
                    }
                }

                if (this.Coeffs.Length > polynomial.Coeffs.Length)
                {
                    for (int i = Math.Max(this.Coeffs.Length, polynomial.Coeffs.Length) - Math.Abs(this.Coeffs.Length - polynomial.Coeffs.Length); i < this.Coeffs.Length; i++)
                    {
                        if (this.Coeffs[i] != 0)
                        {
                            return false;
                        }
                    }
                }
                else if (this.Coeffs.Length < polynomial.Coeffs.Length)
                {
                    for (int i = Math.Max(this.Coeffs.Length, polynomial.Coeffs.Length) - Math.Abs(this.Coeffs.Length - polynomial.Coeffs.Length); i < polynomial.Coeffs.Length; i++)
                    {
                        if (polynomial.Coeffs[i] != 0)
                        {
                            return false;
                        }
                    }
                }

            }

            return true;
        }

        /// <summary>
        /// An overriding of Object.GetHashCode() method to work with Polynomial type.
        /// </summary>
        /// <returns>Hash code of a current object.</returns>
        public override int GetHashCode()
        {
            var hashCode = 693794519;
            hashCode = (hashCode * -1521134295) + EqualityComparer<double[]>.Default.GetHashCode(this.Coeffs);
            hashCode = (hashCode * -1521134295) + this.Power.GetHashCode();
            return hashCode;
        }
    }
}
