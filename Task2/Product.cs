using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Product //класс продукт
    {
        public string name {  get; set; } //поле имени товара
        public uint price { get; set; } //поле цена товара
        public string storeName { get; set; } //поле имя магазина товара


    }

    internal class Stock //класс склад товаров
    {
        private List<Product> products = new List<Product>(); //список товаров склада

        public void Add(Product product) //функция добавления товара на склад
        {
            products.Add(product);
        }

        public List<Product> GetProducts() { return products; } //функция получения текущих товаров 

        public List<Product> SearchByName(string name) //функция поиска по имени товара, возвращает список товаров с введенным именем
            {
            return products.Where(p => p.name == name).ToList();
        }
        public List<Product> SearchByPrice(uint price) //функция поиска по цене товара, возвращает список товаров с введеной ценой
        {
            return products.Where(p => p.price == price).ToList();
        }
        public List<Product> SearchByStoreName(string storeName) //функция поиска по имени магазина товара, возвращает список товаров с введенным именем
        {
            return products.Where(p => p.storeName == storeName).ToList();
        }
    }
}
