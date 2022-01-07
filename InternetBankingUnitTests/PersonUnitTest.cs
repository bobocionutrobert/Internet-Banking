using InternetBanking.Controller;
using InternetBanking.Model;
using System;
using Xunit;
using Xunit.Abstractions;

namespace InternetBankingUnitTests
{
    public class PersonUnitTest
    {

        private ControllerPerson control;

        private readonly ITestOutputHelper output;

        public PersonUnitTest(ITestOutputHelper output)
        {



            control = new ControllerPerson();
            this.output = output;
        }
        [Fact]
        public void TestLoad()
        {
            control.load();

            ControllerPerson c = new ControllerPerson();

            output.WriteLine(c.ToString());
        }
        [Fact]
        public void TestUpdateName()
        {
            control.load();

            control.updateName(1, "updatedname");

            Assert.Equal("updatedname", control.returnPersonById(1).Name);

        }
        [Fact]
        public void TestUpdateEmail()
        {
            control.load();

            control.updateEmail(1, "updatedemail");

            Assert.Equal("updatedemail", control.returnPersonById(1).Email);

        }

        [Fact]
        public void TestUpdateAddress()
        {
            control.load();

            control.updateAddress(1, "updatedaddress");

            Assert.Equal("updatedaddress", control.returnPersonById(1).Address);

        }


        [Fact]
        public void TestUpdateAdminPassword()
        {
            control.load();

            Person p = control.returnPersonById(2);

            if (p is Admin admin)
            {
                control.updateAdminPassword(2, "updatedpassword");

                Assert.Equal("updatedpassword", admin.Password);
            }


        }

    }
}
