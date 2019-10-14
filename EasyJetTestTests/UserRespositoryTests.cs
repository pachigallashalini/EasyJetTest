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
            var newId = Guid.NewGuid();
            _userRepository.Save(new Model.User() { Id = newId });
            var item = _userRepository.Get(newId);
            Assert.IsNotNull(item);
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
