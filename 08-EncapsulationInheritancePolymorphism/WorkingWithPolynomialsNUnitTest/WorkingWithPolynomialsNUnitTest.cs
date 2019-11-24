namespace WorkingWithPolynomials.NUnitTest
{
    using NUnit.Framework;

    public class WorkingWithPolynomialsNUnitTest
    {
        [TestCase(new double[] { -4, 2, 0, 1, 7 }, new double[] { 0, -8, 19, 4 }, new double[] { -4, -6, 19, 5, 7 })]
        [TestCase(new double[] { 0, 1, 2, 3, 4, 5 }, new double[] { 1, 1, 1 }, new double[] { 1, 2, 3, 3, 4, 5 })]
        [TestCase(new double[] { 0.2, 0.2 }, new double[] { -6, -0.1, 0.4 }, new double[] { -5.8, 0.1, 0.4 })]
        [TestCase(new double[] { 90, 17, -8.430, 0, 0, 940, 1.837 }, new double[] { 0.8, 7, -6.815, 435.1, 0.0004, -1, 5, -7.9017 }, new double[] { 90.8, 24, -15.245, 435.1, 0.0004, 939, 6.837, -7.9017 })]
        public void Summation_FirstPolynomialCoeffs_SecondPolynomialCoeffs_ExpectedPolynomialCoeffs_Result(double[] firstPolynomialCoeffs, double[] secondPolynomialCoeffs, double[] expectedPolynomialCoeffs)
        {
            Polynomial outputPolynomial = (new Polynomial(firstPolynomialCoeffs)) + (new Polynomial(secondPolynomialCoeffs));
            Polynomial expectedPolynomial = new Polynomial(expectedPolynomialCoeffs);
            Assert.IsTrue(outputPolynomial.Equals(expectedPolynomial));
        }

        [TestCase(new double[] { -4, 2, 0, 1, 7 }, new double[] { 0, -8, 19, 4 }, new double[] { -4, 10, -19, -3, 7 })]
        [TestCase(new double[] { 0, 1, 2, 3, 4, 5 }, new double[] { 1, 1, 1 }, new double[] { -1, 0, 1, 3, 4, 5 })]
        [TestCase(new double[] { 0.2, 0.2 }, new double[] { -6, -0.1, 0.4 }, new double[] { 6.2, 0.3, -0.4 })]
        [TestCase(new double[] { 90, 17, -8.430, 0, 0, 940, 1.837 }, new double[] { 0.8, 7, -6.815, 435.1, 0.0004, -1, 5, -7.9017 }, new double[] { 89.2, 10, -1.615, -435.1, -0.0004, 941, -3.163, 7.9017 })]
        public void Substitution_FirstPolynomialCoeffs_SecondPolynomialCoeffs_ExpectedPolynomialCoeffs_Result(double[] firstPolynomialCoeffs, double[] secondPolynomialCoeffs, double[] expectedPolynomialCoeffs)
        {
            Polynomial outputPolynomial = (new Polynomial(firstPolynomialCoeffs)) - (new Polynomial(secondPolynomialCoeffs));
            Polynomial expectedPolynomial = new Polynomial(expectedPolynomialCoeffs);
            Assert.IsTrue(outputPolynomial.Equals(expectedPolynomial));
        }

        [TestCase(new double[] { -4, 2, 0, 1, 7 }, new double[] { 0, -8, 19, 4 }, new double[] { 0, 32, -92, 22, 0, -37, 137, 28 })]
        [TestCase(new double[] { 0, 1, 2, 3, 4, 5 }, new double[] { 1, 1, 1 }, new double[] { 0, 1, 3, 6, 9, 12, 9, 5 })]
        [TestCase(new double[] { 0.2, 0.2 }, new double[] { -6, -0.1, 0.4 }, new double[] { -1.2, -1.22, 0.06, 0.08 })]
        [TestCase(new double[] { 90, 17, -8.430, 0, 0, 940, 1.837 }, new double[] { 0.8, 7, -6.815, 435.1, 0.0004, -1, 5, -7.9017 }, new double[] { 72, 643.6, -501.094, 38984.135, 7454.18645, -3005.8862, 7014.466228, -7010.964, 408805.001945, 866.266031, -939.9992652, 4698.163, -7418.413, -14.5154229 })]
        public void Multiplication_FirstPolynomialCoeffs_SecondPolynomialCoeffs_ExpectedPolynomialCoeffs_Result(double[] firstPolynomialCoeffs, double[] secondPolynomialCoeffs, double[] expectedPolynomialCoeffs)
        {
            Polynomial outputPolynomial = (new Polynomial(firstPolynomialCoeffs)) * (new Polynomial(secondPolynomialCoeffs));
            Polynomial expectedPolynomial = new Polynomial(expectedPolynomialCoeffs);
            Assert.IsTrue(outputPolynomial.Equals(expectedPolynomial));
        }

        [TestCase(new double[] { 4, 2, 0, 5, 3 }, new double[] { 1, 2, 1 }, new double[] { -1, -1, 3 }, new double[] { 5, 5 })]
        [TestCase(new double[] { 0, 1, 2, 3, 4, 5 }, new double[] { 1, 1, 1 }, new double[] { 4, -1, -1, 5 }, new double[] { -4, -2 })]
        [TestCase(new double[] { 0.2, 0.2 }, new double[] { -6, -0.1, 0.4 }, new double[] { 0 }, new double[] { 0.2, 0.2 })]
        [TestCase(new double[] { 0.003, 0.004, 0.005 }, new double[] { 0.001, 0.002 }, new double[] { 0.75 , 2.5 }, new double[] { 0.00225 })]
        public void Division_FirstPolynomialCoeffs_SecondPolynomialCoeffs_ExpectedPolynomialCoeffs_Result(double[] firstPolynomialCoeffs, double[] secondPolynomialCoeffs, double[] expectedQuotientCoeffs, double[] expectedRemainderCoeffs)
        {
            PolynomialDivisionResult outputDivisionResult = (new Polynomial(firstPolynomialCoeffs)) / (new Polynomial(secondPolynomialCoeffs));
            Polynomial expectedQuotient = new Polynomial(expectedQuotientCoeffs);
            Polynomial expectedRemainder = new Polynomial(expectedRemainderCoeffs);
            Assert.IsTrue(outputDivisionResult.Quotient.Equals(expectedQuotient));
            Assert.IsTrue(outputDivisionResult.Remainder.Equals(expectedRemainder));
        }

        [TestCase(new double[] { 1, 0, 2, 0 }, new double[] { 1, 0, 2 }, ExpectedResult = true)]
        [TestCase(new double[] { 0.003, 0.004, 0.005 }, new double[] { 0.003, 0.004, 0.005, 0, 0, 0 }, ExpectedResult = true)]
        [TestCase(new double[] { 0.42, 95, 0, 0, -76, 0, 0 }, new double[] { 0.42, 95, 0, 0, -76 }, ExpectedResult = true)]
        public bool Equals_FirstPolynomialCoeffs_SecondPolynomialCoeffs_True(double[] firstPolynomialCoeffs, double[] secondPolynomialCoeffs)
        {
            return (new Polynomial(firstPolynomialCoeffs).Equals(new Polynomial(secondPolynomialCoeffs)));
        }

        [TestCase(new double[] { 1, 0, 2, 1 }, new double[] { 1, 0, 2 }, ExpectedResult = false)]
        [TestCase(new double[] { }, new double[] { 0.003, 0.004, 0.005 }, ExpectedResult = false)]
        [TestCase(new double[] { 0.003, 0.004, 0.005 }, new double[] { }, ExpectedResult = false)]
        public bool Equals_FirstPolynomialCoeffs_SecondPolynomialCoeffs_False(double[] firstPolynomialCoeffs, double[] secondPolynomialCoeffs)
        {
            return (new Polynomial(firstPolynomialCoeffs).Equals(new Polynomial(secondPolynomialCoeffs)));
        }

    }
}