using System;
using Manager.Core.User;
using Xunit;

namespace Manager.Tests
{
    public class UserTest
    {
        [Fact]
        public void IsNameToLong()
        {
            string name = "Stefaryryhfghf";
            string email = "email@com.pl";
            string password = "123";

            Assert.Throws(typeof(System.Exception),delegate() { new User(name,email,password);});
        }

        [Fact]
        public void UserNameIsOK()
        {
            string name = "Stefan";
            string email = "email@com.pl";
            string password = "123";

            User user = new User(name, email , password);

            Assert.Equal(name, user.UserName);
            
        }
    }
}
