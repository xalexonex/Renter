using System;
using System.Windows.Forms;

namespace Renter
{
    public partial class LoginForm : Form
    {
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
    }
}
