using System;
using Interview;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Interview.Model;

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
            _userRepository.Save(new User() { Id = newId });
            var item = _userRepository.Get(newId);
            Assert.IsNotNull(item);
        }

        [TestMethod]
        public void TestGet()
        {
            var newId = Guid.NewGuid();
            AddUsers(newId);
            var item = _userRepository.Get(newId);
            Assert.IsNotNull(item);
        }

        [TestMethod]
        public void TestDelete()
        {
            var newId = Guid.NewGuid();
            AddUsers(newId);
            _userRepository.Delete(newId);
            var item = _userRepository.Get(newId);
            Assert.IsNull(item);
        }

        private void AddUsers(Guid newId)
        {
            _userRepository.Save(new User() { Id = newId });
            _userRepository.Save(new User() { Id = Guid.NewGuid() });
            _userRepository.Save(new User() { Id = Guid.NewGuid() });
            _userRepository.Save(new User() { Id = Guid.NewGuid() });
        }
    }
}
