using System;
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
    }
}
