using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesAppTB1._1
{
    internal class User
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User(string Email, string Username, string Password)
        {
            this.Email = Email;
            this.Username = Username;
            this.Password = Password;
        }
    }
}
