using System;
using System.Collections.Generic;
using System.Text;

namespace MainConsole.QuestionTwo
{
    public class ProductService
    {
        private readonly IProductDataSource _dataSource;

        public ProductService(IProductDataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public void DisplayProducts()
        {
            List<Product> products = _dataSource.GetProducts();

            foreach (Product product in products)
            {
                Console.WriteLine(
                    $"{product.Id} - {product.Name} - ${product.Price}"
                );
            }
        }
    }
}
