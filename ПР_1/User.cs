using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР_1
{
    public class User

    {
        public User(string name, string login, string password)
        {
            name = "Максим";
            login = "Generalisimys";
            password = "123123";
        }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        User people = new User("","","");

        void enter()
        {
        }
        public User()
        {

        }
    }
}
