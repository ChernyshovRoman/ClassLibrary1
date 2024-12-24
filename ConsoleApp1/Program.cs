using System;
using ClassLibrary1;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("Картошка", 200);
            Product product1 = new Product("Свёкла", 400);
            Product product2 = new Product("Мороженное", 150);
            Product product3 = new Product("Соль", 300);

            Store store = new Store();
            store.Name = "Склад Москвы №1";
            store.Adress = "Ул. Первая, строение 2";

            store.products.Add(product);
            store.products.Add(product1);
            store.products.Add(product2);
            store.products.Add(product3);

            store.ShowAll();
            Console.ReadLine();
        }
    }
}
