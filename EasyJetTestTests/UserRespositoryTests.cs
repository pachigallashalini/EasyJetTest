using System;
using Interview;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EasyJetTestTests
{
    [TestClass]
    public class UserRespositoryTests
    {
        private UserRepository _userRepository;
        [TestInitialize]
        public void Initialise()
        {
            _userRepository = new UserRepository();
        }

        [TestMethod]
        public void TestSave()
        {
           
        }

        [TestMethod]
        public void TestGet()
        {
            
        }

        [TestMethod]
        public void TestDelete()
        {
            
        }
    }
}
