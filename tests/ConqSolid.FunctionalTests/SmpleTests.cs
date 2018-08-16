using ConqSolid.Web.Common;
using Xunit;

namespace ConqSolid.FunctionalTests
{
    public class SimpleTests
    {
        [Fact]
        public void AdderMustAdd()
        {
            Adder adder = new Adder(1, 2);
            int adderResult = adder.Calculate();
            Assert.Equal(3, adderResult);
        }
    }
}