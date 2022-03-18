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
        public void LoginTest()
        {
            Program program = new Program();
            string case2 = program.Login("", "");
            string case3 = program.Login("Admin", "Admin");

            string case1 = program.Login("User", "Password");

            Assert.AreEqual("Incorrect UserId or Password.", case1);

            Assert.AreEqual("Userid or password could not be Empty.", case2);
            Assert.AreEqual("Welcome Admin.", case3);



        }
        //[Test]
        //public void checkDetails()
        //{
        //    Program program = new Program();
        //    list = program.AllUsers();
        //    foreach (var _theVar in list)
        //    {
        //        Assert.IsNotNull(_theVar.Id);
        //        Assert.IsNotNull(_theVar.Name);
        //        Assert.IsNotNull(_theVar.salary);
        //        Assert.IsNotNull(_theVar.Geneder); 
        //    }
        //}
        [Test]
        public void checkDetails()
        {
            Program program = new Program();
            list = program.AllUsers();
            foreach (var _theVar in list)
            {
                Assert.IsNotNull(_theVar.Id);
                Assert.IsNotNull(_theVar.Name);
                Assert.IsNotNull(_theVar.salary);
                Assert.IsNotNull(_theVar.Geneder);
            }
        }


        [Test]
        public void getUser()
        {
            Program program = new Program();
            var p = program.GetEmployees(104);
            foreach (var _theVar in p)
            {
                Assert.AreEqual(_theVar.Name, "Dsize");
                Assert.AreEqual(_theVar.Id, 104);
                Assert.AreEqual(_theVar.Geneder, "male");
            }
        }
        
    }
}