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
using System.Windows.Forms.VisualStyles;

namespace Renter
{
    public partial class UserForm : Form
    {
        List<string> flatList = new List<string>(); // Список квартир
        List<string> clientList = new List<string>(); // Список клиентов

        public static Requests reqQueue = new Requests(); // Очередь заявок

        public static Client curClient; // Текущий клиент
        public static Flat curFlat; // Текущая квартира
        public static Contract curContract; // Текущий договор
        public static int rentLength; // Длительность аренды

        // Файлы данных
        string clientDataPretty = @"clientsPretty.txt";
        string flatDataPretty = @"flatsPretty.txt";
        string clientDataRaw = @"clients.csv";
        string flatDataRaw = @"flats.csv";

        string clientName; // Имя клиента
        string clientBirthday; // Дата рождения клиента
        string clientPhone; // Номер телефона

        string flatAddress; // Адрес квартиры
        string flatArea; // Площадь
        string flatRooms; // Комнаты
        string flatRentDaily; // Стоимость в сутки

        public UserForm()
        {
            InitializeComponent();
            readClients(); // Загружаем список клиентов
            readFlats(); // Загружаем список квартир

        }

        // Загрузка списка квартир
        private void readFlats()
        {
            // Читаем данные из файла и вставляем их в список
            try
            {
                using (StreamReader srFlats = new StreamReader(flatDataPretty))
                {
                    string flatContent = srFlats.ReadToEnd();
                    string[] lines = flatContent.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                    flatList.AddRange(lines);
                    srFlats.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Произошла ошибка при чтении данных\r\n\r\nТехническая информация: { e.ToString() }", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                        
        }

        // Загрузка списка клиентов
        private void readClients()
        {
            // Читаем данные из файла и вставляем их в список
            try
            {
                using (StreamReader srClients = new StreamReader(clientDataPretty))
                {
                    string clientContent = srClients.ReadToEnd();
                    string[] lines = clientContent.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                    clientList.AddRange(lines);
                    srClients.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Произошла ошибка при чтении данных\r\n\r\nТехническая информация: {e.ToString()}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // При открытии формы наполняем ListBox-ы данными из списков
        private void userForm_Load(object sender, EventArgs e)
        {
            foreach(string flatInfo in flatList)
            {
                if (flatInfo != "")
                {
                    listFlats.Items.Add(flatInfo);
                }
            }

            foreach(string clientInfo in clientList)
            {
                if (clientInfo != "")
                {
                    listClients.Items.Add(clientInfo);
                }
            }
        }

        private void userForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        // Кнопка оформления аренды
        private void btnRent_Click(object sender, EventArgs e)
        {
            string selClient = listClients.Text; // Текстовое описание выбранного клиента
            string[] selClientInfo = selClient.Split(':'); // Разделяем на части по двоеточию
            string selClientID = selClientInfo[0]; // Таким образом получаем № п/п

            string selFlat = listFlats.Text;
            string[] selFlatInfo = selFlat.Split(':'); // Тут то же самое, но с квартирами
            string selFlatID = selFlatInfo[0];

            // Читаем данные о клиенте
            using (StreamReader srClDataRaw = new StreamReader(clientDataRaw))
            {
                string clientContent = srClDataRaw.ReadToEnd();
                string[] lines = clientContent.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                foreach (string line in lines)
                {
                    if (line != "")
                    {
                        string[] clientAtoms = line.Split(',');
                        clientName = clientAtoms[1];
                        clientBirthday = clientAtoms[2];
                        clientPhone = clientAtoms[3];
                    }
                }
                srClDataRaw.Close();
            }

            // Создаём нового клиента
            curClient = new Client(clientName, clientBirthday, clientPhone);
            curClient.id = selClientID;

            // Читаем данные о квартире
            using (StreamReader srFlDataRaw = new StreamReader(flatDataRaw))
            {
                string fileContent = srFlDataRaw.ReadToEnd();
                string[] lines = fileContent.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                foreach (string line in lines)
                {
                    if (line != "")
                    {
                        if (line.StartsWith(selFlatID))
                        {
                            string[] flatAtoms = line.Split(',');
                            flatAddress = flatAtoms[1];
                            flatArea = flatAtoms[2];
                            flatRooms = flatAtoms[3];
                            flatRentDaily = flatAtoms[4];
                            break;
                        }
                    }
                }
                srFlDataRaw.Close();
            }

            // Создаём новую квартиру
            curFlat = new Flat(flatAddress, Convert.ToDecimal(flatArea), Convert.ToDecimal(flatRooms), Convert.ToDecimal(flatRentDaily)); //класс выбранная квартира
            curFlat.id = Convert.ToInt32(selFlatID);

            // Добавляем заявку в очередь
            reqQueue.pushFlat(curFlat);

            // Задаём срок аренды значением из поля
            rentLength = Convert.ToInt32(numRentLength.Value);

            // Информируем пользователя о подаче заявки
            MessageBox.Show("Заявка на аренду отправлена менеджеру", "Заявка оформлена", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void listFlats_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Включаем кноку аренды только если выбраны клиент и квартира
            if ((listClients.SelectedIndex > -1) && (listFlats.SelectedIndex > - 1))
            {
                btnRent.Enabled = true;
            } else
            {
                btnRent.Enabled = false;
            }
        }
    }
}
