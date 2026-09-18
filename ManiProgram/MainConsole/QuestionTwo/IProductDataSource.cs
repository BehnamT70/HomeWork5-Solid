using System;
using System.Collections.Generic;
using System.Text;

namespace MainConsole.QuestionTwo
{
    public interface IProductDataSource
    {
        List<Product> GetProducts();
    }
}
