namespace CustomerRepresentation.Tests
{
    using NUnit.Framework;

    public class CustomerNUnitTests
    {
        Customer testCustomer = new Customer("Jeffrey Richter", 1000000, "+1 (425) 555-0100");

        [TestCase(CustomerRepresentation.NRC, ExpectedResult = "Customer record: Jeffrey Richter, 1,000,000.00, +1 (425) 555-0100")]
        [TestCase(CustomerRepresentation.NrC, ExpectedResult = "Customer record: Jeffrey Richter, 1000000, +1 (425) 555-0100")]
        [TestCase(CustomerRepresentation.NC, ExpectedResult = "Customer record: Jeffrey Richter, +1 (425) 555-0100")]
        [TestCase(CustomerRepresentation.NR, ExpectedResult = "Customer record: Jeffrey Richter, 1,000,000.00")]
        [TestCase(CustomerRepresentation.Nr, ExpectedResult = "Customer record: Jeffrey Richter, 1000000")]
        [TestCase(CustomerRepresentation.N, ExpectedResult = "Customer record: Jeffrey Richter")]
        [TestCase(CustomerRepresentation.RC, ExpectedResult = "Customer record: 1,000,000.00, +1 (425) 555-0100")]
        [TestCase(CustomerRepresentation.rC, ExpectedResult = "Customer record: 1000000, +1 (425) 555-0100")]
        [TestCase(CustomerRepresentation.C, ExpectedResult = "Customer record: +1 (425) 555-0100")]
        [TestCase(CustomerRepresentation.R, ExpectedResult = "Customer record: 1,000,000.00")]
        [TestCase(CustomerRepresentation.r, ExpectedResult = "Customer record: 1000000")]
        public string CustomerToString_Customer_StringRepresentation(CustomerRepresentation representation)
        {
            return testCustomer.ToString(representation);
        }
    }
}