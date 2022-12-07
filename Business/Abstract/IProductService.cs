﻿using Core.Utilities.Results;
using Entities.Concrate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> getAll();
        IDataResult<List<Product>>    getAllByCategoryId(int id);

        IDataResult<List<Product>>  GetByUnitPrice(decimal min, decimal max);

        IDataResult<List<ProductDetailDto>>   GetProductDetails();

        IDataResult<Product>  GetById(int productId); 
        IResult Add(Product product);

    }
}
