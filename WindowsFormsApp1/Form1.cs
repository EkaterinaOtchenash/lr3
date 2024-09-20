using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.UserClasses;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxEmail.Text = "task_code_development@list.ru";
            textBoxName.Text = "Антон Игоревич";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxEmail.Text) || string.IsNullOrWhiteSpace(textBoxName.Text) || string.IsNullOrWhiteSpace(textBoxSubject.Text) || string.IsNullOrWhiteSpace(textBoxBody.Text))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            
            string smtp = "smtp.mail.ru";
            StringPair fromInfo = new StringPair("eszhabrova@mail.ru", "Жаброва Екатерина");
            string password = "ehSqqE5A87n2W1ki76U8";
            StringPair toInfo = new StringPair(textBoxEmail.Text, textBoxName.Text); 
            string subject = textBoxSubject.Text; string body = $"{DateTime.Now} \n" +
            $"{Dns.GetHostName()} \n" +
            $"{Dns.GetHostAddresses(Dns.GetHostName()).First()} \n" +
            $"{textBoxBody.Text}";
            InfoEmailSending info =
            new InfoEmailSending(smtp, fromInfo, password, toInfo, subject, body); 
            SendingEmail sendingEmail = new SendingEmail(info); sendingEmail.Send();
            MessageBox.Show("Письмо отправлено!");
            foreach (TextBox textBox in Controls.OfType<TextBox>()) textBox.Text = "";
        }
    }
}
