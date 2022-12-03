// See https://aka.ms/new-console-template for more information
using Business.Concrate;
using DataAccsess.Abstract;
using DataAccsess.Concrate.EntityFramework;
using DataAccsess.Concrate.InMemory;
//SOLID 
//oP



ProductTest();
//CategoryTest();









static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());
    foreach (var product in productManager.GetProductDetails())
    {
        Console.WriteLine(product.ProductName+"/"+product.CategoryName);
    }
}

static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    foreach (var category in categoryManager.GetAll())
    {
        Console.WriteLine(category.CategoryName);
    }
}