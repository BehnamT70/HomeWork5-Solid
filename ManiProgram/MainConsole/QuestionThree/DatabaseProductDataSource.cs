using System;
using System.Collections.Generic;
using System.Text;

namespace MainConsole.QuestionThree
{
    public class DatabaseProductDataSource : IProductDataSource
    {
        public List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Laptop",
                    Price = 1200
                },
                new Product
                {
                    Id = 2,
                    Name = "Mouse",
                    Price = 50
                }
            };
        }
    }
}
