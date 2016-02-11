namespace CSharpDiscovery
{
    using System;
    using NFluent;
    using NUnit.Framework;

    [TestFixture]
    public class ValueTypesTests
    {
        public enum monnaie { Euro=1, Yen=2,Dollar=3 };

        [Test]
        public void CreateAnEnumForCurrency()
        {
            Enum euro = monnaie.Euro;
            Check.That(euro.ToString()).Equals("Euro");
        }

        //[Test]
        //public void SpecifyIntegerValueAndCastIntegerValueToCurrencyEnum()
        //{
        //    Check.That(euro.ToString()).Equals("Euro");
        //}

        //[Test]
        //public void TryParseStringValueToRetrieveCurrencyEnum()
        //{
        //    // use Currency.TryParse
        //    Check.That(parseSuccess).IsTrue();
        //    Check.That(parsedCurrency.ToString()).Equals("Euro");
        //}

        //[Test]
        //public void DefineAStructForMoneyWithValueAndCurrency()
        //{
        //    // Define a struct called Money with one constructor having value (double) and currency (Currency enum) arguments, that initialize struct fields
        //    Check.That(tenEuros.Value).Equals(10.0);
        //    Check.That(tenEuros.Currency).Equals(Currency.Euro);
        //}

        //[Test]
        //public void InstanciateTheMoneyStructTwiceWithSameArgumentsThenTheyAreEqual()
        //{
        //    Check.That(tenEuros).Equals(anotherTenEuros);
        //}

        //[Test]
        //public void PassMoneyAsParameterOfAMethodThatModifiesItsMoneyArgumentValue()
        //{
        //    // Create the method that take a Money struct as parameter, it is passed by value, not by reference, then argument given to the method is not modified
        //    MakeTenEurosBecomeFifteen(tenEuros);
        //    Check.That(tenEuros.Value).Equals(10.0);
        //}

        //[Test]
        //public void PassMoneyAsParameterOfAMethodThatModifiesItsMoneyArgumentValuePassedByRef()
        //{
        //    // Create the method that take a Money struct as parameter, it is explicitly passed by reference with ref keyword, then argument given to the method is modified
        //    MakeTenEurosBecomeFifteenByRef(ref tenEuros);
        //    Check.That(tenEuros.Value).Equals(15.0);
        //}
    }
}
