namespace PrioList
{
    public class User
    {
        private string userID;

        public string UserID { get; set; }
        public string password { get; set; }
        public User(string userID, string password)
        {
            this.UserID = userID;
            this.password = password;
        }

        public bool Verify(string userID, string password)
        {
            if (this.UserID == userID && this.password == password)
                return true;
            else
                return false;
        }
    }
}