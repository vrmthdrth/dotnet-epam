using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NullableExtensionMethods.Tests
{
    [TestClass]
    public class NulableExtensionMSTests
    {
        [TestMethod]
        public void IsNull_uint_False()
        {
            uint? uintNumber = 0;
            bool expected = false;
            bool real = uintNumber.IsNull();
            Assert.AreEqual(expected, real);
        }

        [TestMethod]
        public void IsNull_uint_True()
        {
            uint? uintNumber = null;
            bool expected = true;
            bool real = uintNumber.IsNull();
            Assert.AreEqual(expected, real);
        }

        [TestMethod]
        public void IsNull_int_False()
        {
            int? intNumber = 0;
            bool expected = false;
            bool real = intNumber.IsNull();
            Assert.AreEqual(expected, real);
        }

        [TestMethod]
        public void IsNull_int_True()
        {
            int? intNumber = null;
            bool expected = true;
            bool real = intNumber.IsNull();
            Assert.AreEqual(expected, real);
        }

        [TestMethod]
        public void IsNull_float_False()
        {
            float? floatNumber = 0;
            bool expected = false;
            bool real = floatNumber.IsNull();
            Assert.AreEqual(expected, real);
        }

        [TestMethod]
        public void IsNull_float_True()
        {
            float? floatNumber = null;
            bool expected = true;
            bool real = floatNumber.IsNull();
            Assert.AreEqual(expected, real);
        }

        [TestMethod]
        public void IsNull_double_False()
        {
            double? doubleNumber = 0;
            bool expected = false;
            bool real = doubleNumber.IsNull();
            Assert.AreEqual(expected, real);
        }

        [TestMethod]
        public void IsNull_double_True()
        {
            double? doubleNumber = null;
            bool expected = true;
            bool real = doubleNumber.IsNull();
            Assert.AreEqual(expected, real);
        }

        [TestMethod]
        public void IsNull_decimal_False()
        {
            decimal? decimalNumber = 0;
            bool expected = false;
            bool real = decimalNumber.IsNull();
            Assert.AreEqual(expected, real);
        }

        [TestMethod]
        public void IsNull_decimal_True()
        {
            decimal? decimalNumber = null;
            bool expected = true;
            bool real = decimalNumber.IsNull();
            Assert.AreEqual(expected, real);
        }

        [TestMethod]
        public void IsNull_bool_False()
        {
            bool? statement = true;
            bool expected = false;
            bool real = statement.IsNull();
            Assert.AreEqual(expected, real);
        }

        [TestMethod]
        public void IsNull_bool_True()
        {
            bool? statement = null;
            bool expected = true;
            bool real = statement.IsNull();
            Assert.AreEqual(expected, real);
        }

        [TestMethod]
        public void IsNull_byte_False()
        {
            byte? byteNumber = 0;
            bool expected = false;
            bool real = byteNumber.IsNull();
            Assert.AreEqual(expected, real);
        }

        [TestMethod]
        public void IsNull_byte_True()
        {
            byte? byteNumber = null;
            bool expected = true;
            bool real = byteNumber.IsNull();
            Assert.AreEqual(expected, real);
        }

        [TestMethod]
        public void IsNull_sbyte_False()
        {
            sbyte? sbyteNumber = 0;
            bool expected = false;
            bool real = sbyteNumber.IsNull();
            Assert.AreEqual(expected, real);
        }

        [TestMethod]
        public void IsNull_sbyte_True()
        {
            sbyte? sbyteNumber = null;
            bool expected = true;
            bool real = sbyteNumber.IsNull();
            Assert.AreEqual(expected, real);
        }

        [TestMethod]
        public void IsNull_ushort_False()
        {
            ushort? ushortNumber = 0;
            bool expected = false;
            bool real = ushortNumber.IsNull();
            Assert.AreEqual(expected, real);
        }

        [TestMethod]
        public void IsNull_ushort_True()
        {
            ushort? ushortNumber = null;
            bool expected = true;
            bool real = ushortNumber.IsNull();
            Assert.AreEqual(expected, real);
        }

        [TestMethod]
        public void IsNull_short_False()
        {
            short? shortNumber = 0;
            bool expected = false;
            bool real = shortNumber.IsNull();
            Assert.AreEqual(expected, real);
        }

        [TestMethod]
        public void IsNull_short_True()
        {
            short? shortNumber = null;
            bool expected = true;
            bool real = shortNumber.IsNull();
            Assert.AreEqual(expected, real);
        }

        [TestMethod]
        public void IsNull_ulong_False()
        {
            ulong? ulongNumber = 0;
            bool expected = false;
            bool real = ulongNumber.IsNull();
            Assert.AreEqual(expected, real);
        }

        [TestMethod]
        public void IsNull_ulong_True()
        {
            ulong? ulongNumber = null;
            bool expected = true;
            bool real = ulongNumber.IsNull();
            Assert.AreEqual(expected, real);
        }

        [TestMethod]
        public void IsNull_long_False()
        {
            long? longNumber = 0;
            bool expected = false;
            bool real = longNumber.IsNull();
            Assert.AreEqual(expected, real);
        }

        [TestMethod]
        public void IsNull_long_True()
        {
            long? longNumber = null;
            bool expected = true;
            bool real = longNumber.IsNull();
            Assert.AreEqual(expected, real);
        }

        [TestMethod]
        public void IsNull_object_False()
        {
            object obj = 0;
            bool expected = false;
            bool real = obj.IsNull();
            Assert.AreEqual(expected, real);
        }

        [TestMethod]
        public void IsNull_object_True()
        {
            object obj = null;
            bool expected = true;
            bool real = obj.IsNull();
            Assert.AreEqual(expected, real);
        }

        [TestMethod]
        public void IsNull_char_False()
        {
            char? word = '0';
            bool expected = false;
            bool real = word.IsNull();
            Assert.AreEqual(expected, real);
        }

        [TestMethod]
        public void IsNull_char_True()
        {
            char? word = null;
            bool expected = true;
            bool real = word.IsNull();
            Assert.AreEqual(expected, real);
        }

        [TestMethod]
        public void IsNull_string_False()
        {
            string name = "Kathy";
            bool expected = false;
            bool real = name.IsNull();
            Assert.AreEqual(expected, real);
        }

        [TestMethod]
        public void IsNull_string_True()
        {
            string name = null;
            bool expected = true;
            bool real = name.IsNull();
            Assert.AreEqual(expected, real);
        }
    }
}
