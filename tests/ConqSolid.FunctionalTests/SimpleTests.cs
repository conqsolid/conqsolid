using ConqSolid.Web.Common;
using Xunit;

namespace ConqSolid.FunctionalTests
{
    public class SimpleTests
    {
        [Fact]
        public void AdderMustAdd()
        {
            Adder theAdder = new Adder(1, 2);
            theAdder.Calculate();
            Assert.Equal(3, theAdder.Result);
        }

        [Fact]
        public void SubstracterMustSubstract()
        {
            Substracter theSubstracter = new Substracter(100,10);
            theSubstracter.Calculate();
            Assert.Equal(90, theSubstracter.Result);
        }
    }
}