using System;
using System.Collections.Generic;
using System.Text;

namespace MainConsole.QuestionFour
{
    public class FileProductDataSource : IProductDataSource
    {
        public List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    Id = 5,
                    Name = "Headphone",
                    Price = 80
                },
                new Product
                {
                    Id = 6,
                    Name = "Webcam",
                    Price = 150
                }
            };
        }
    }
}
