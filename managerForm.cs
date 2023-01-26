using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Renter
{
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        // Кнопка "добавить клиента"
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            // Подключаем форму и выводим на экран
            ClientForm clForm = new ClientForm();
            clForm.Show();
        }

        // Кнопка "добавить квартиру"
        private void btnAddFlat_Click(object sender, EventArgs e)
        {
            // Подключаем форму и выводим на экран
            FlatForm flForm = new FlatForm();
            flForm.Show();
        }

        private void managerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        // При загрузке формы
        private void managerForm_Load(object sender, EventArgs e)
        {
            // Выводим в список очередь заявок на аренду
            listRequests.Items.Add(UserForm.reqQueue.ToString());
        }

        // Нажатие на кнопку "принять"
        private void btnAccept_Click(object sender, EventArgs e)
        {
            // Убираем заявку из очереди
            Flat flat = UserForm.reqQueue.popFlat();

            // Выводим сообщение об одобрении заявки
            MessageBox.Show($"Информация о клиенте:\r\n\r\n{UserForm.curClient.ToString()}\r\n\r\n---\r\n\r\nИнформация о квартире:\r\n\r\n{flat.ToString()}", "Заявка принята", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Формируем договор и выводим на экран
            Contract contract = new Contract(UserForm.curClient, flat, UserForm.rentLength);
            MessageBox.Show(contract.ToString(), "Договор об аренде", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            // Убираем заявку из списка в форме
            listRequests.Items.RemoveAt(listRequests.SelectedIndex);
        }

        // Нажатие на кнопку "отклонить"
        private void btnDecline_Click(object sender, EventArgs e)
        {
            // Убираем заявку из очереди
            Flat flat = UserForm.reqQueue.popFlat();

            // Выводим сообщение об отклонении
            MessageBox.Show($"Информация о клиенте:\r\n\r\n{UserForm.curClient.ToString()}\r\n\r\n---\r\n\r\nИнформация о квартире:\r\n\r\n{flat.ToString()}", "Заявка отклонена", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            // Убираем звявку из списка в форме
            listRequests.Items.RemoveAt(listRequests.SelectedIndex);
        }

        private void listRequests_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Включаем кнопки только если выбрана заявка
            if (listRequests.SelectedIndex > -1)
            {
                btnAccept.Enabled = true;
                btnDecline.Enabled = true;
            } else
            {
                btnAccept.Enabled = false;
                btnDecline.Enabled = false;
            }
        }
    }
}
