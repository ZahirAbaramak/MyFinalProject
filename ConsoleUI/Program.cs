// See https://aka.ms/new-console-template for more information
using Business.Concrate;
using DataAccsess.Concrate.EntityFramework;
using DataAccsess.Concrate.InMemory;
//SOLID 
//oP
ProductManager productManager = new ProductManager(new EfProductDal());
foreach (var product in productManager.GetByUnitPrice(40,100))
{
    Console.WriteLine(product.ProductName);
}
