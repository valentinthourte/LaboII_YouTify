using Entities.Model;

namespace EjercicioIntegrador2_YouTify.Model
{
    public class User
    {
        private string name;

        public string Name { get => name; set => name = value; }

        public User(string name)
        {
            this.name = name;
        }
        public User(Credentials c)
        {
            this.name = c.Username;
        }
        
        public static implicit operator User(string name)
        {
            return new User(name);
        }
    }
}