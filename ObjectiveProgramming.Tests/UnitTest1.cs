using NUnit.Framework;
using FluentAssertions;
using ObjectiveProgramming;

namespace ObjectiveProgramming.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void UlamekToString_ShouldReturn_CorrectString()
        {
            var ulamek = new Ulamek(2, 3);
            string convertedValue = ulamek.ToString();
            convertedValue.Should().Be("2/3");
        }

        [Test]
        public void UlamekEqual_ShouldReturn_True()
        {
            var ulamek1 = new Ulamek(2, 3);
            var ulamek2 = new Ulamek(2, 3);

            bool result = ulamek1 == ulamek2;
            result.Should().BeTrue();
        }

        [Test]
        public void UlamekEqual_ShouldReturn_False()
        {
            var ulamek1 = new Ulamek(2, 3);
            var ulamek2 = new Ulamek(3, 2);

            bool result = ulamek1 == ulamek2;

            result.Should().BeFalse();
        }

        [Test]
        public void UlamekCompareTo_ShouldReturn_MinusOne()
        {
            var ulamek1 = new Ulamek(2, 3);
            var ulamek2 = new Ulamek(3, 5);

            int result = ulamek1.CompareTo(ulamek2);

            result.Should().Be(-1);
        }

        [Test]
        public void UlamekComparTo_ShouldReturn_PlusOne()
        {
            var ulamek1 = new Ulamek(2, 3);
            var ulamek2 = new Ulamek(4, 5);

            int result = ulamek2.CompareTo(ulamek1);
            result.Should().Be(+1);
        }

        [Test]
        public void UlamekCompareTo_ShouldReturn_Zero()
        {
            var ulamek1 = new Ulamek(2, 3);
            var ulamek2 = new Ulamek(2, 3);

            int result = ulamek1.CompareTo(ulamek2);
            result.Should().Be(0);
        }

        [Test]
        public void UlamekPlusOperator_ShouldReturn_CorrectResult()
        {
            var ulamek1 = new Ulamek(2, 3);
            var ulamek2 = new Ulamek(1, 3);
            var sum = ulamek1 + ulamek2;

            sum.licznik.Should().Be(3);
            sum.mianownik.Should().Be(3);
        }

        [Test]
        public void UlamekMinusOperator_ShouldReturn_CorrectResult()
        {
            var ulamek1 = new Ulamek(3, 5);
            var ulamek2 = new Ulamek(4, 5);

            var diff = ulamek2 - ulamek1;

            diff.licznik.Should().Be(1);
            diff.mianownik.Should().Be(5);
        }

        [Test]
        public void UlamekMultiplyOperator_ShouldReturn_CorrectResult()
        {
            var ulamek1 = new Ulamek(1, 2);
            var ulamek2 = new Ulamek(2, 4);

            var result = ulamek1 * ulamek2;
            result.licznik.Should().Be(2);
            result.mianownik.Should().Be(8);
        }

        [Test]
        public void UlamekDivisionOperator_ShouldReturn_CorrectResult()
        {
            var ulamek1 = new Ulamek(3, 4);
            var ulamek2 = new Ulamek(3, 4);
            var result = ulamek1 / ulamek2;

            result.licznik.Should().Be(12);
            result.mianownik.Should().Be(12);
        }

        [Test]
        public void GetRoundedUpp_ShouldReturn_RoundedValue()
        {
            var ulamek = new Ulamek(5,4);
            var result = ulamek.GetRoundedUpp();
            result.Should().Be(1);
        }

        [Test]
        public void GetRoundedDown_ShouldReturn_RoundedValue()
        {
            var ulamek = new Ulamek(1,4);
            var result = ulamek.GetRoundedDown();
            result.Should().Be(0);
        }
    }
}