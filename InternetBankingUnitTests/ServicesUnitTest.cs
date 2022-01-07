using InternetBanking.Controller;
using InternetBanking.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace InternetBankingUnitTests
{
    public class ServicesUnitTest
    {

        private ControllerServices control;

        private readonly ITestOutputHelper output;

        public ServicesUnitTest(ITestOutputHelper output)
        {



            control = new ControllerServices();
            this.output = output;
        }
        [Fact]
        public void TestLoad()
        {
            control.load();

            ControllerServices c = new ControllerServices();

            output.WriteLine(c.ToString());
        }
        [Fact]
        public void TestUpdateName()
        {
            control.load();

            control.updateName(1, "updatedname");

            Assert.Equal("updatedname", control.service(1).Name);

        }
        [Fact]
        public void TestUpdateDesciption()
        {
            control.load();

            control.updateDescription(1, "updatedescription");

            Assert.Equal("updatedescription", control.service(1).Description);

        }

        [Fact]
        public void TestUpdateCreditTotal()
        {
            control.load();


            Services s = control.service(1);

            if (s is Credit credit)
            {
                control.updateCreditTotal(1, "1000");
                Assert.Equal("1000", credit.Total);
            }

        }


        [Fact]
        public void TestUpdateAmountTotal()
        {
            control.load();


            Services s = control.service(2);

            if (s is Debits debit)
            {
                control.updateDebitsTotal(2, "1000");
                Assert.Equal("1000", debit.Total);
            }

        }
    }
}
