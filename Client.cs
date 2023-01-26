using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renter
{
    // Класс: Клиент (пользователь)
    public class Client
    {
        // Поля класса
        private string _id; // № п/п
        private string _name; // ФИО
        private string _birthday; // Дата рождения
        private string _phone; // Телефон

        // Статические поля
        public static int nextID = 0;

        // Конструктор
        public Client(string name, string birthday, string phone)
        {
            this._name = name;
            this._birthday = birthday;
            this._phone = phone;
            this._id = nextID.ToString();

            nextID++; // Увеличиваем номер на 1
        }

        public string id // № п/п
        {
            get => _id;
            set => _id = Convert.ToString(Convert.ToInt32(value) + nextID); // это вам не javascript :(
        }

        
        public string saveData // Данные для экспорта в файл
        {
            get => $"{this._id},{this._name},{this._birthday},{this._phone}";
        }

        // Переопределенный метод - возвращаем текстовое описание клиента
        public override string ToString()
        {
            return $"{this._id}: {this._name} {this._birthday} г.р., тел. {this._phone}";
        }
    }
}
