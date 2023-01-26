using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renter
{
    // Класс: Договор
    public class Contract
    {
        // Поля класса
        private string _clientData; // Данные клиента
        private string _flatData; // Данные квартиры
        private double _rentDaily; // Стоимость в сутки
        private int _rentLength; // Длительность аренды
        private int _payment; // Сумма договора

        // Конструктор
        public Contract(Client client, Flat flat, int rentLength)
        {
            this._clientData = client.ToString();
            this._flatData = flat.ToString();
            this._rentDaily = flat.rentDaily;
            this._rentLength = rentLength;
            this._payment = (int)(_rentDaily * rentLength);
            
        }

        // Переопределяем метод - выводим договор в текстовом виде
        public override string ToString()
        {
            return $"Данные клиента:\r\n\r\n{this._clientData}\r\n\r\n---\r\n\r\nДанные квартиры:\r\n\r\n{this._flatData}\r\n\r\nCрок аренда: {this._rentLength} дней\r\n\r\nСтоимость аренды: {this._payment} руб";
        }
    }
}
