using NUnit.Framework;
using Service.Interfaces;
using Service.Services;

namespace ServiceTest.Service
{
    class LoginTest
    {

        ILogin loginService = new LoginImpl();

        [Test]
        public void TestUserLogin()
        {
            if (loginService.UserLogin("1","1"))
            {

                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}
