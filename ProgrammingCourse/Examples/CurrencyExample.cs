﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProgrammingCourse.Examples.CollectionExample;

namespace ProgrammingCourse.Examples
{
    internal class CurrencyExample
    {
        record Product(string name, string category, decimal price);

        public void RunExample()
        {
            var items = new List<Product>()
            {
                new Product("Phone", "AGD", 2234.05m),
                new Product("TV", "AGD", 4234.00m),
                new Product("Picture", "Home", 239.99m),
            };

            var filteredItems = items.Where(i => i.price > 1000);

            foreach (var item in filteredItems)
            {
                //if (item.price > 1000)
                //{
                //    Console.WriteLine(item);
                //}
                Console.WriteLine(item);
            }            
        }
    }
}
