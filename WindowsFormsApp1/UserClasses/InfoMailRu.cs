using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.UserClasses
{
    internal class InfoMailRu :InfoEmail
    {
        public InfoMailRu(StringPair emailAdressTo, string subject, string body) : base(emailAdressTo, subject, body)
        {
            SmtpClientAdress = "smtp.mail.ru";
            EmailAdressFrom = new StringPair("eszhabrova@mail.ru", "Жаброва Екатерина");
            EmailPassword = "ehSqqE5A87n2W1ki76U8";
            Port = -1;
        }
    }
}
