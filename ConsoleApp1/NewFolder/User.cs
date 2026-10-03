using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.NewFolder
{
    internal class User
    {

        public int Id { get; set; }
        public string Fullname { get; set; }
        public string email { get; set; }

        private string _password;
        public string password
        {
            get { return _password; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 8)
                {
                    Console.WriteLine("paroli unda iyos minimum 8 simbolo");
                }
                {
                    _password = value;
                    Console.WriteLine("paroli seicvala!");
                }
            }
        }

        public Bankaccount[] bankacount { get; set; } = Array.Empty<Bankaccount>();

        public User() { }

        public User(int id, string fullname, string email, string password, Bankaccount[] bankaccounts)
        {
            Id = id;
            Fullname = fullname;
            this.email = email;
            this.password = password;
            bankacount = bankaccounts;

        }

        public bool ChangeFullname(string fullname)
        {

            if (string.IsNullOrEmpty(fullname) || fullname.Length < 5)
            {
                Console.WriteLine("saxeli unda seicavdes minimum 5 asos");
                return false;
            }
            else
            {
                Fullname = fullname;
                Console.WriteLine("momxmareblis saxeli seicvala");
                return true;
            }

        }


        public bool Changepassword(string password)
        {
            if (string.IsNullOrEmpty(password) || password.Length < 8)
            {
                Console.WriteLine("paroli unda iyos minimum 8 simbolo");
                return false;
            }
            {
                _password = password;
                Console.WriteLine("paroli seicvala!");
                return true;
            }
        }

        public override string ToString()
        {
            return $"[{Id}] , {Fullname} , email : {email}";
        }

    }
}
