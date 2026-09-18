using System;
using System.Collections.Generic;
using System.Text;

namespace MainConsole.QuestionFour
{
    public interface IProductDataSource
    {
        List<Product> GetProducts();
    }
}
