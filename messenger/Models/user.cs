
namespace messenger.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Pass { get; set; }
        public User(string name, string pass)
        {
            Name = name;
            Pass = pass;
        }
        public User(){}
    }
}
