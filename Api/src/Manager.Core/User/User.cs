namespace Manager.Core.User
{
    public class User
    {
        public string UserName { get; private set; }
        public string UserEmail { get;private set; }
        public string Password { get; private set; }

        public User(string userName, string userEmail, string password)
        {
            UserName = checkisUserNameNotToLong(userName);
            UserEmail = userEmail;
            Password = password;
        }

        string checkisUserNameNotToLong(string userName)
        {
            if(userName.Length > 10)
                throw new System.Exception("Name is to long");
            
            return userName;

        }
    }
}