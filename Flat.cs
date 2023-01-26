using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renter
{
    // Класс: Квартира
    public class Flat
    {
        // Поля класса
        private int _id; // № п/п
        private string _address; // Адрес
        private double _area; // Площадь
        private int _rooms; // Комнаты
        private int _rentDaily; // Стоимость в сутки

        public bool isRented = false; // Квартира занята?
        public double rating = 0; // Оценка

        // Статические поля
        public static int nextID = 0; // Следующий № п/п

        // Конструктор
        public Flat(string address, decimal area, decimal rooms, decimal rentDaily)
        {
            this._address = address;
            this._area = Convert.ToDouble(area);
            this._rooms = Convert.ToInt32(rooms);
            this._rentDaily = Convert.ToInt32(rentDaily);
            nextID++;
            this._id = nextID;
        }

        // Общедоступные поля
        public int id  // № п/п
        {
            get => _id;
            set => _id = value;
        }

        public int rentDaily // Стоимость в сутки
        {
            get => _rentDaily;
        }

        public string saveData // Данные для экспорта
        {
            get => $"{this._id},{this._address},{this._rooms},{this._area},{this._rentDaily}";
        }

        // Переопределяем метод - выводим текстовое описание квартиры
        public override string ToString()
        {
            return $"{this._id}: {this._address}, {this._rooms} ком, {this._area} кв.м., {this._rentDaily} руб";
        }
    }
}
