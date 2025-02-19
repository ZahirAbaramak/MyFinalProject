﻿using Core.DataAccsess;
using Entities.Concrate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
       List<ProductDetailDto> GetProductDetails();

    }
}
//Code Refactoring