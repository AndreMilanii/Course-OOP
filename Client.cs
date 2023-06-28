using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Course.Entities
{
    internal class Client
    {
        public string name { get; set; }
        public string mail { get; set; }
        public DateTime birthDate { get; set; }

        public Client()
        {

        }

        public Client(string name, string mail, DateTime birthDate)
        {
            this.name = name;
            this.mail = mail;
            this.birthDate = birthDate;
        }

        public override string ToString()
        {
            return name
            + " " + birthDate.ToString("dd/MM/yyyy")
            + " " + mail;

        }


    }

}
