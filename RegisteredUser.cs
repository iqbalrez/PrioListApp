/*namespace PrioList
{
    public class RegisteredUser : User
    {
        private string userpassword;
        private int userPoints;

        public string UserPassword { get; set; }
        public int UserPoints { get; set; }

        public RegisteredUser(string userID, string userPassword) : base(userID)
        {
            this.UserID = userID;
            this.UserPassword = userPassword;
            UserPoints = 0;
        }

        public bool Login(string userID, string userPassword)
        {
            if (UserPassword == userPassword)
            {
                return true;
            }
            else return false;
        }
    }
}*/