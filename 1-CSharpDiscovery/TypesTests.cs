using System;
using NFluent;
using NUnit.Framework;

namespace CSharpDiscovery
{
    [TestFixture]
    public class TypesTests
    {
        private int integer; 
        private string integerAsAString;
        private float integerAsAFloat;
        private double integerAsADouble;
        private Decimal integerAsADecimal;
        private long integerAsLong;
        private Int32 integerAsInt32;
        private int? nullableInteger;
        [Test]
        public void NFluentAndNUnitAreWorking()
        {
            Check.That(true).IsTrue();
        }

        [Test]
        public void AnIntIsNotEqualToSameIntStringRepresentation()
        {
            this.integer = 17;
            this.integerAsAString = Convert.ToString(integer);

            Check.That(integerAsAString).Not.Equals(integer);
        }

        [Test]
        public void AnIntIsNotEqualToSameIntAsFloat()
        {
            this.integerAsAFloat = (float) integer;
            Check.That(integerAsAFloat).Not.Equals(integer);
        }

        [Test]
        public void AnIntIsNotEqualToSameIntAsDouble()
        {
            this.integerAsADouble = (double)integer;
            Check.That(integerAsADouble).Not.Equals(integer);
        }

        [Test]
        public void AnIntIsNotEqualToSameIntAsDecimal()
        {
            this.integerAsADecimal = (decimal) this.integer;
            Check.That(integerAsADecimal).Not.Equals(integer);
        }

        [Test]
        public void AnIntIsNotEqualToSameIntAsLong()
        {
            integerAsLong = (long) this.integer;
            Check.That(integerAsLong).Not.Equals(integer);
        }

        [Test]
        public void AnIntIsEqualToSameIntAsInt32()
        {
            integerAsInt32 = Convert.ToInt32(integer);
            Check.That(integerAsInt32).Equals(integer);
        }

        [Test]
        public void AFloatCanBeCastedToInteger()
        {
            float single = 1.0F;
            int singleCastedToInteger = (int) single;
            int expectedInteger = 1;

            Check.That(singleCastedToInteger).Equals(expectedInteger);
        }

        [Test]
        public void AnIntCanBeImplicitlyCastedToFloat()
        {
            int integer = 1;
            float singleImplicitlyCastToInteger = integer;
            float expectedSingle = 1.0F;

            Check.That(singleImplicitlyCastToInteger).Equals(expectedSingle);
        }

        [Test]
        public void AStringCanBeParsedToInteger()
        {
            string integerString = "30";
            int integerParsed = Int32.Parse(integerString);
            int expectedInteger = 30;

            Check.That(integerParsed).Equals(expectedInteger);
        }

        [Test]
        public void AFloatStringRepresentationCannotBeParsedToInteger()
        {
        // Create a method named ParseFloatStringAsInteger that takes no argument, return void and parse a float string representation "30.0"
            Check.ThatCode(this.ParseFloatStringAsInteger).Throws<FormatException>();
        }

        //[Test]
        //public void TryToParseAStringToInteger()
        //{
        //    string floatString = "30.0";
        //    int expectedInteger = 0;

        //    // Use int.TryParse, /!\ it uses an "out" argument

        //    Check.That(integerParsed).Equals(default(int));
        //    Check.That(tryParseFailed).IsFalse();
        //}

        [Test]
        public void UseVarForLessVerbosityButKeepStrongTyping()
        {
            var IntegerAsAString = this.integer.ToString();
            Check.That(integerAsAString).Not.Equals(integer);
        }

        [Test]
        public void NullableIntWithNullValueDoesNotHaveValue2()
        {
            // use "int?" to declare a nullable int initialized with null, then try also with Nullable<int>
            this.nullableInteger = null;
            Check.That(nullableInteger.HasValue).IsFalse();
        }

        //[Test]
        //public void GettingValueOfANullableIntwithNullValueThrowsAnInvalidOperationException()
        //{
        //    // Create a method named GetNullableIntValue that takes no argument, return void and access a nullable int value (nullableInteger.Value)
        //    Check.That(GetNullableIntValue).Throws<InvalidOperationException>();
        //}

        [Test]
        public void NullableIntWithNullValueDoesNotHaveValue()
        {
            // use "int?" to declare a nullable int initialized with 30
            int? nullableInteger = 30;
            Check.That(nullableInteger.Value).Equals(30);
        }

        /// <summary>
        /// takes no argument, return void and parse a float string representation "30.0"
        /// </summary>
        private void ParseFloatStringAsInteger()
        {
            var startFloat = "30.0";
            int floatToString = Convert.ToInt32(startFloat);
        }
    }
}
