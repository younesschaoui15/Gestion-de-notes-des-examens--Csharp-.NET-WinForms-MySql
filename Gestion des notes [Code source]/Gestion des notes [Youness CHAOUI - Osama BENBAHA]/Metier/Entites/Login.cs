using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gestion_des_notes__Youness_CHAOUI___Osama_BENBAHA_.Metier.Entites
{
    public class Login
    {
        public string login { get; set; }
        public string password { get; set; }

        public Login(string login, string password)
        {
            this.login = login;
            this.password = password;
        }

        public Login()
        {
        }
    }


     
}
