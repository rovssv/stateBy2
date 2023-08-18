using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ForwarderManagementBusinessLayer.Presenters.Users;
using ForwarderManagementEntityLayer.Users;

namespace FMUnitTest
{
    [TestClass]
    public class Authentication
    {
        [TestMethod]
        public void Login()
        {
            UsersPst pst = new UsersPst();
            string userCode = "oli";
            bool result = pst.UserExists(userCode);
            Assert.IsTrue(result == true, "User code exists.");
            
            string password = "asdf@1234";
            result = pst.UserIsAuthenticated(userCode, password);
            Assert.IsTrue(result == true, "User is authenticated.");
            
            UsersDto loggedInUser = pst.LoggedInUser(userCode, password);
            Assert.IsTrue(loggedInUser != null, "User info found.");
        }

        [TestMethod]
        public void ChangeName()
        {
            UsersPst pst = new UsersPst();
            string userCode = "oli";
            string password = "asdf@1234";
            UsersDto loggedInUser = pst.LoggedInUser(userCode, password);
            Assert.IsTrue(loggedInUser != null, "User info found.");

            loggedInUser = pst.ChangeUserDisplayName(loggedInUser, "Mr. Khan Ali");
            Assert.IsTrue(loggedInUser != null, "User display name changed.");
        }

        [TestMethod]
        public void ChangePassword()
        {
            UsersPst pst = new UsersPst();
            string userCode = "oli";
            string password = "asdf@12345";
            UsersDto loggedInUser = pst.LoggedInUser(userCode, password);
            Assert.IsTrue(loggedInUser != null, "User info found.");

            loggedInUser = pst.ChangeUserPassword(loggedInUser, "asdf@1234");
            Assert.IsTrue(loggedInUser != null, "User display name changed.");
        }
    }
}
