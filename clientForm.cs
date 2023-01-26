using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Renter
{
    public partial class ClientForm : Form
    {
        // Файлы данных
        string clientDataRaw = @"clients.csv"; // "Сырые" данные
        string clientDataPretty = @"clientsPretty.txt"; // Данные для GUI

        // Создаём список клиентов
        internal static List<Client> clientList = new List<Client>();

        public ClientForm()
        {
            InitializeComponent();
        }

        // Нажатие на кнопку "добавить"
        private void AddClient_Click(object sender, EventArgs e)
        {
            // Открываем запись в файлы данных, в режиме присоединения строки
            StreamWriter swClDataRaw = new StreamWriter(clientDataRaw, true);
            StreamWriter swClDataPretty = new StreamWriter(clientDataPretty, true);

            // Создаём нового клиента с помощью данных из формы
            Client client = new Client(boxClientName.Text, dateClientBirthday.Value.ToShortDateString(), boxClientPhone.Text);

            // И добавляем его в список
            clientList.Add(client);

            // Записываем в файлы
            swClDataRaw.WriteLine(client.saveData);
            swClDataPretty.WriteLine(client.ToString());

            // Добавляем в список в форме
            listClients.Items.Add(client.ToString());

            // Освобождаем файлы
            swClDataRaw.Close();
            swClDataPretty.Close();
        }

        private void clientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            // Загружаем данные из файла и выводим в список в форме
            using (StreamReader srClDataPretty = new StreamReader(clientDataPretty))
            {
                string fileContent = srClDataPretty.ReadToEnd();
                string[] lines = fileContent.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                foreach (string line in lines)
                {
                    if (line != "")
                    {
                        listClients.Items.Add(line);
                    }
                }
                srClDataPretty.Close();
            }
        }
    }
}
