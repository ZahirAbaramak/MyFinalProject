using Core.DataAccsess;
using Core.Entities;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess.Abstract
{
   public interface IOrderDal : IEntityRepository<Order>
    {

    }
}
