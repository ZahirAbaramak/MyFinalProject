﻿using Core.DataAccsess;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess.Abstract
{
    public interface ICategoryDal :IEntityRepository<Category>
    {
       
    }
}
