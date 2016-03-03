namespace CSharpDiscovery
{
    using System;
    using System.Globalization;
    using NFluent;
    using NUnit.Framework;

    [TestFixture]
    public class ValueTypesTests
    {
        public enum Monnaie { Euro=1, Yen=2,Dollar=3 };

        struct Money
        {
            public Monnaie mDeviseMonnaie;
            public Double Value;

            public Money(Monnaie pDeviseMonnaie, double pValeur)
            {
                this.mDeviseMonnaie = pDeviseMonnaie;
                this.Value = pValeur;
            }
        }

        [Test]
        public void CreateAnEnumForCurrency()
        {
            Enum euro = Monnaie.Euro;
            Check.That(euro.ToString()).Equals("Euro");
        }

        [Test]
        public void SpecifyIntegerValueAndCastIntegerValueToCurrencyEnum()
        {
            Monnaie euro = (Monnaie)1;
            Check.That(euro.ToString()).Equals("Euro");
        }

        [Test]
        public void TryParseStringValueToRetrieveCurrencyEnum()
        {
            Monnaie wMonnaie;
            //use Currency.TryParse
            Check.That(Enum.TryParse("Euro",out wMonnaie)).IsTrue();
            Check.That(wMonnaie.ToString()).Equals("Euro");
        }

        [Test]
        public void DefineAStructForMoneyWithValueAndCurrency()
        {
            // Define a struct called Money with one constructor having value (double) and currency (Currency enum) arguments, that initialize struct fields
            Money tenEuros = new Money(Monnaie.Euro, 10.0);
            Check.That(tenEuros.Value).Equals(10.0);
            Check.That(tenEuros.mDeviseMonnaie).Equals(Monnaie.Euro);
        }

        [Test]
        public void InstanciateTheMoneyStructTwiceWithSameArgumentsThenTheyAreEqual()
        {
            Money tenEuros = new Money(Monnaie.Dollar, 10.0);
            Money anotherTenEuros = new Money(Monnaie.Dollar,10.0);
            Check.That(tenEuros).Equals(anotherTenEuros);
        }

        [Test]
        public void PassMoneyAsParameterOfAMethodThatModifiesItsMoneyArgumentValue()
        {
            Money tenEuros = new Money(Monnaie.Dollar, 10.0);
            // Create the method that take a Money struct as parameter, it is passed by value, not by reference, then argument given to the method is not modified
            MakeTenEurosBecomeFifteen(tenEuros);
            Check.That(tenEuros.Value).Equals(10.0);
        }

        private void MakeTenEurosBecomeFifteen(Money tenEuros)
        {
            tenEuros.Value = 15.0;
        }

        [Test]
        public void PassMoneyAsParameterOfAMethodThatModifiesItsMoneyArgumentValuePassedByRef()
        {
            Money tenEuros = new Money(Monnaie.Yen, 10.0);
            // Create the method that take a Money struct as parameter, it is explicitly passed by reference with ref keyword, then argument given to the method is modified
            MakeTenEurosBecomeFifteenByRef(ref tenEuros);
            Check.That(tenEuros.Value).Equals(15.0);
        }

        private void MakeTenEurosBecomeFifteenByRef(ref Money tenEuros)
        {
            tenEuros.Value = 15.0;
        }
    }
}
