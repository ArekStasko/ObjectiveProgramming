using NUnit.Framework;
using FluentAssertions;
using ObjectiveProgramming;

namespace ObjectiveProgramming.Tests
{
    public class UlamekTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void UlamekToString_ShouldReturn_CorrectStringFormat()
        {
            var ulamek = new Ulamek(2, 3);
            string convertedUlamek = ulamek.ToString();
            convertedUlamek.Should().Be("2/3");
        }
    }
}