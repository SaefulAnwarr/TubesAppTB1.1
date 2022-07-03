using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace RegLibrary
{
    public class Class1
    {


        public static void WriteJSON(string email, string uname, string pass)
        {
            //Contoh object yang akan ditulis dalam JSON
            User user = new User(email, uname, pass);
            //[Opsional] Merapikan format JSON
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            //Melakukan perubahan object menjadi string(Serialization)
            String jsonString = JsonSerializer.Serialize(user, options);

            //Membuat file JSON yg berisi string hasil serialization
            File.WriteAllText(Directory.GetParent(Directory.GetCurrentDirectory()) + ".json", jsonString);
        }
        public static string ReadJSON(string email, string uname, string pass)
        {
            //Baca file Json yang diinginkan
            String jsonString = File.ReadAllText(Directory.GetParent(Directory.GetCurrentDirectory()) + ".json");
            //Deserialize file json menjadi object
            User user = JsonSerializer.Deserialize<User>(jsonString);
            return user.Email + " " + user.Username + " " + user.Password;

        }
        public class User
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
}
