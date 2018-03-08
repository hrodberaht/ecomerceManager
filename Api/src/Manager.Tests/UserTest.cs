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
            Assert.Throws(typeof(System.Exception),delegate() { new User("Stefaryryhfghf","email@com.pl","123");});
        }
    }
}
