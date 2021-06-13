namespace PrioList
{
    public class User
    {
        public int Id { get; set; }
        public string userID { get; set; }
        public string password { get; set; }
        public User(string userID, string password)
        {
            this.userID = userID;
            this.password = password;
        }
    }
}