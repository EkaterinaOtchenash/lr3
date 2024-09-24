using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.UserClasses
{
    internal class InfoGMail : InfoEmail
    {
        public InfoGMail(StringPair emailAdressTo, string subject, string body) : base (emailAdressTo, subject, body)
        {
            SmtpClientAdress = "smtp.gmail.com";
            EmailAdressFrom = new StringPair("innocentizov@gmail.com", "Жаброва Е.С.");
            EmailPassword = "qriuozhrwkstbkxz";
            Port = 587;
        }
    }
}
