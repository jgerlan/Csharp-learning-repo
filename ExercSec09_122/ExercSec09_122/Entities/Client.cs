using System;
using System.Collections.Generic;
using System.Text;

namespace ExercSec09_122.Entities
{
    class Client
    {
        public string name { get; set; }
        public string  email { get; set; }
        public DateTime dateBirth { get; set; }

        public Client()
        {
        }

        public Client(string name, string email, DateTime dateBirth)
        {
            this.name = name;
            this.email = email;
            this.dateBirth = dateBirth;
        }

        public override string ToString()
        {
            return name+" ("+dateBirth.ToString("dd/MM/yyyy")+") - "+email;
        }

    }
}
