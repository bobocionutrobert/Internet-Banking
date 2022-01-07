using InternetBanking.Controller;
using Xunit;
using Xunit.Abstractions;

namespace InternetBankingUnitTests
{
    public class BankUnitTest
    {

        private ControllerBank control;

        private readonly ITestOutputHelper output;

        public BankUnitTest(ITestOutputHelper output)
        {



            control = new ControllerBank();
            this.output = output;
        }
        [Fact]
        public void TestLoad()
        {
            control.load();

            ControllerBank c = new ControllerBank();

            output.WriteLine(c.ToString());
        }
        [Fact]
        public void TestUpdateDescription()
        {
            control.load();

            control.updateDescription(1,"update");

            Assert.Equal("update", control.bankById(1).Description);

        }
        [Fact]
        public void TestUpdateCode()
        {
            control.load();

            control.updateCode(1, "updatecode");

            Assert.Equal("updatecode", control.bankById(1).Code);

        }


    }
}