using Business.Abstract;
using DataAccsess.Abstract;
using DataAccsess.Concrate.InMemory;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrate
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

      

        public List<Product> getAll()
        {
            //İş Kodları
            //yetkisi var mı?
            return _productDal.GetAll();    

        }

        public List<Product> getAllByCategoryId(int id)
        {
            return _productDal.GetAll(p => p.CategoryId == id);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice > min && p.UnitPrice < max);
        }
    }
}
