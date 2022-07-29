// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.EntityFremework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

ProductTest();
//CategoryTest();

static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));
    var result = productManager.GetProductDetails();
    if (result.Success==true)
    {
        foreach (var item in result.Data)
        {
            Console.WriteLine(item.ProductName+"/"+item.CategoryName);
        }
    }
    else
    {
        Console.WriteLine(result.Message);
    }

    foreach (var item in productManager.GetProductDetails().Data)
    {
        Console.WriteLine(item.ProductName + "/" + item.CategoryName);
    }
    Console.ReadLine();
}

static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    foreach (var category in categoryManager.GetAll().Data)
    {
        Console.WriteLine(category.CategoryName);
    }
}