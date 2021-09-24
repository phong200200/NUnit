using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestableApp;
namespace TestProject2
{
    [TestFixture]
    public class Tests
    {
        List<Employee> list;

        [Test]
        public void checkDetails()
        {
            Program program = new Program();
            list = program.AllUsers();
            foreach (var x in list)
            {
                Assert.IsNotNull(x.Id); 
                Assert.IsNotNull(x.Name); 
                Assert.IsNotNull(x.salary); 
                Assert.IsNotNull(x.Geneder); 
            }
        }

        [Test]
        public void LoginTest()
        {
            Program program = new Program();
            string case1 = program.Login("User", "Password");
            string case2 = program.Login("", "");
            string case3 = program.Login("Admin", "Admin");
            Assert.AreEqual("Userid or password could not be Empty.", case2);
            Assert.AreEqual("Incorrect UserId or Password.", case1);
            Assert.AreEqual("Welcome Admin.", case3);
        }
        [Test]
        public void getUserDetails()
        {
            Program program = new Program();
            var p = program.GetEmployees(104);
            foreach(var x in p)
            {
                Assert.AreEqual(x.Id, 104);
                Assert.AreEqual(x.Name, "Dsize");
                Assert.AreEqual(x.Geneder, "male");
            }
        }
    }
}