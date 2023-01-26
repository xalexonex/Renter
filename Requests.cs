using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renter
{
    // Класс: Очередь заявок
    public class Requests
    {
        // Сама очередь - список квартир
        List<Flat> requestQueue = new List<Flat>();

        // Добавление заявки в очередь
        public void pushFlat(Flat flat)
        {
            requestQueue.Add(flat);
        }

        // Удаление заявки
        public Flat popFlat()
        {
            Flat flat = requestQueue[0];
            requestQueue.RemoveAt(0);
            return flat;
        }

        // Переопределяем метод - выводим список в текстовом формате
        public override string ToString()
        {
            string flatInfo = "";
            foreach(Flat flat in requestQueue)
            {
                flatInfo += $" {flat.ToString()} ";
            }
            return flatInfo;
        }
    }
}
