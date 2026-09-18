using System;
using System.Collections.Generic;
using System.Text;

namespace MainConsole.QuestionTwo
{
    public class ApiProductDataSource : IProductDataSource
    {
        public List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    Id = 3,
                    Name = "Keyboard",
                    Price = 100
                },
                new Product
                {
                    Id = 4,
                    Name = "Monitor",
                    Price = 300
                }
            };
        }
    }
}
