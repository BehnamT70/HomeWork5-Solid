using MainConsole.QuestionTwo;
using MainConsole.QuestionThree;
using MainConsole.QuestionFour;
using Microsoft.Extensions.DependencyInjection;


namespace MainConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //****************** Qusetion Two **********************************//
            QuestionTwo.IProductDataSource dataSource = new QuestionTwo.DatabaseProductDataSource();
            QuestionTwo.ProductService service = new QuestionTwo.ProductService(dataSource);
             service.DisplayProducts();

            //***************** Qusetion Three *********************************//
            string sourceType = "api";
            QuestionThree.IProductDataSource dataSource1 = ProductDataSourceFactory.Create(sourceType);
            QuestionThree.ProductService service1 = new QuestionThree.ProductService(dataSource1);
            service1.DisplayProducts();

            //***************** Qusetion Four *********************************//
            var services = new ServiceCollection();
            services.AddSingleton<QuestionFour.IProductDataSource,QuestionFour.DatabaseProductDataSource>();
            services.AddTransient<QuestionFour.ProductService>();
            var serviceProvider = services.BuildServiceProvider();
            QuestionFour.ProductService service2 = serviceProvider.GetRequiredService<QuestionFour.ProductService>();
            service2.DisplayProducts();

        }
    }
}
