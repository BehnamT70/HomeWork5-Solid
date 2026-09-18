using System;
using System.Collections.Generic;
using System.Text;

namespace MainConsole.QuestionThree
{
    public static class ProductDataSourceFactory
    {
        public static IProductDataSource Create(string sourceType)
        {
            switch (sourceType.ToLower())
            {
                case "database":
                    return new DatabaseProductDataSource();

                case "api":
                    return new ApiProductDataSource();

                case "file":
                    return new FileProductDataSource();

                default:
                    throw new ArgumentException("Invalid data source type");
            }
        }
    }
}
