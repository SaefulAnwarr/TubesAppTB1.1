using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
namespace UserAPI
{
    public class UserData
    {
        public string NamaUser { get; set; }
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public UserData(string NamaUser, int Id, string Username, string Password)
        {
            this.NamaUser = NamaUser;
            this.Id = Id;
            this.Username = Username;
            this.Password = Password;
        }
    }
}
