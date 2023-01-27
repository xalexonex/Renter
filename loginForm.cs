using System;
using System.Windows.Forms;
using System.IO;

namespace Renter
{
    public partial class LoginForm : Form
    {
        string clientData = @"clients.csv";
        string clientPretty = @"clientsPretty.txt";
        string flatData = @"flats.csv";
        string flatPretty = @"flatsPretty.txt";

        public LoginForm()
        {
            InitializeComponent();
        }

        // Кнопка "войти как клиент"
        private void btnLoginClient_Click(object sender, EventArgs e)
        {
            // Подключаем класс формы клиента и выводим на экран
            UserForm fUser = new UserForm();
            fUser.Show();
        }

        // Кнопка "войти как менеджер"
        private void btnLoginManager_Click(object sender, EventArgs e)
        {
            // Подключаем класс формы менеджера и выводим на экран
            ManagerForm fManager = new ManagerForm();
            fManager.Show();
        }

        // Кнопка Github
        private void btnGitHub_Click(object sender, EventArgs e)
        {
            // Открываем ссылку
            System.Diagnostics.Process.Start("https://github.com/xalexonex/Renter");
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (!File.Exists(clientData))
            {
                File.Create(clientData).Close();
            }
            if (!File.Exists(clientPretty))
            {
                File.Create(clientPretty).Close();
            }
            if (!File.Exists(flatData))
            {
                File.Create(flatData).Close();
            }
            if (!File.Exists(flatPretty))
            {
                File.Create(flatPretty).Close();
            }
        }
    }
}
