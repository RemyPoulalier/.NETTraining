using NFluent;
using NUnit.Framework;

namespace CSharpDiscovery
{
    using System;

    [TestFixture]
    public class ClassesTests
    {
        private Calculator calculator;

        
        [Test]
        public void CreateACalculatorClassWithADefaultConstructorAndInstanciate()
        {
            this.calculator = new Calculator();
            Check.That(calculator).IsNotNull();
        }

        [Test]
        public void AddAnotherConstructorWithAFriendlyNameAndInstanciate()
        {
            this.calculator = new Calculator("Calculator");
            // use a public member for Name for now, i.e public string Name;
            Check.That(calculator.mName).Equals("Calculator");
        }

        [Test]
        public void AddAMethodThatMakeASumOfAnArrayOfDouble()
        {
            var valuesToSum = new[] { 1.3, 1.7 };
            this.calculator = new Calculator();
            var sumOfTheArray = this.calculator.sumOfTheArray(valuesToSum);
            // add a method Sum to calculator class
            Check.That(sumOfTheArray).Equals(3.0);
        }

        [Test]
        public void AddAMethodOverloadThatMakeASumOfTwoDoubleFromStringRepresentation()
        {
            var sumOfTwoDoubleFromString = "1,0+2";
            this.calculator = new Calculator();
            double onePlusTwo = this.calculator.sumOfTheArray(sumOfTwoDoubleFromString);
            // add a method with the same name that uses the previous method
            // tips : use string.Split
            Check.That(onePlusTwo).Equals(3.0);
        }

        [Test]
        public void AddAGetterForNameInsteadOfPublicNameMember()
        {
            this.calculator = new Calculator();
            Check.That(this.calculator.mName).Equals("Calculator");
        }

        [Test]
        public void AddASetterForNameAndChangeNameWithIt()
        {
            this.calculator = new Calculator();
            this.calculator.mName = "Enhanced Calculator";
            Check.That(this.calculator.mName).Equals("Enhanced Calculator");
        }

        [Test]
        public void UseObjectInitializerWithDefaultConstructor()
        {
            Check.That(this.calculator.mName).Equals("Calculator");
        }

        [Test]
        public void DefineConstantForPi()
        {
            this.calculator = new Calculator();
            var sumOfADoubleAndPiConstant = "1,2 + pi";
            double sum = this.calculator.sumOfTheArray(sumOfADoubleAndPiConstant);
            // define pi constant (as double) and replace pi string with constant value
            Check.That(sum).Equals(4.34);
        }

        //[Test]
        //public void StaticReadonlyMembers()
        //{
        //    var sumOfADoubleAndPiConstant = "1,2 + pi";
        //    // replace pi constant with a static readonly member
        //    Check.That(sum).Equals(4.34);
        //}

        //[Test]
        //public void MakeSumMethodsStaticAsTheyDoNotNeedAnyInstanceSpecific()
        //{
        //    // make sum methods static and call one these to retrieve a sum of double array values
        //    Check.That(sum).Equals(3.0);
        //}

        //[Test]
        //public void AddStaticCalculatorClass()
        //{
        //    // define a static class StaticCalculator that uses Calculator static methods & define static getter for Name
        //    Check.That(staticCalculator.Name).Equals("Static calculator");
        //}
    }
}
