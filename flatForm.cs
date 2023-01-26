using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Renter
{
    public partial class FlatForm : Form
    {
        // Файлы данных
        string flatDataRaw = @"flats.csv"; // "Сырые" данные
        string flatDataPretty = @"flatsPretty.txt"; // Данные для списка в GUI

        // Создаём список квартир
        internal static List<Flat> flatList = new List<Flat>();

        public FlatForm()
        {
            InitializeComponent();
        }

        // Нажатие на кнопку "Добавить"
        private void btnAddFlat_Click(object sender, EventArgs e)
        {
            // Открываем запись в файлы данных
            StreamWriter swFlDataRaw = new StreamWriter(flatDataRaw, true);
            StreamWriter swFlDataPretty = new StreamWriter(flatDataPretty, true);

            // Создаём новую квартиру с помощью данных из файла
            Flat flat = new Flat(boxFlatAddress.Text, numArea.Value, numRooms.Value, numRentDaily.Value);

            // Добавляем квартиру в список
            flatList.Add(flat);

            // Записываем в файл
            swFlDataRaw.WriteLine(flat.saveData);
            swFlDataPretty.WriteLine(flat.ToString());

            // Выводим в список в форме
            listFlats.Items.Add(flat.ToString());

            // Освобождаем файлы
            swFlDataRaw.Close();
            swFlDataPretty.Close();
        }

        private void flatForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void FlatForm_Load(object sender, EventArgs e)
        {
            // Загружаем данные из файла и выводим их в список в форме
            using (StreamReader srFlDataPretty = new StreamReader(flatDataPretty))
            {
                string fileContent = srFlDataPretty.ReadToEnd();
                string[] lines = fileContent.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                foreach (string line in lines)
                {
                    if (line != "")
                    {
                        listFlats.Items.Add(line);
                    }
                }
                srFlDataPretty.Close();
            }
        }
    }
}
