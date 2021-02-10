using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;
using DataAccess.Abstratc;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();
            //CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager category = new CategoryManager(new EfCategoryDal());

            foreach (var item in category.GetAll())
            {
                Console.WriteLine(item.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            var result = productManager.ProductDetails;

            if (result.Success == true)
            {



                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + "/" + product.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
