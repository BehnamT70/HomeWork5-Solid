using System;
using System.Collections.Generic;
using System.Text;

namespace MainConsole.QuestionThree
{
    public interface IProductDataSource
    {
        List<Product> GetProducts();
    }
}
