using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Store
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public List<Product> products = new List<Product>();

        public void ShowAll()
        {
            Console.WriteLine($"Название склада: {Name}, Адрес: {Adress},\n Список товаров:");
            foreach (Product product in products)
            {
                product.Show();
            }
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public Product(string name, int num)
        {
            Name = name;
            Number = num;
        }
        public void Show()
        {
            Console.WriteLine($"Продукт: {Name}, Количество: {Number}");
        }
    }
}