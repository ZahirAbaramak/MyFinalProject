using Core.DataAccess.EntityFramework;
using DataAccsess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess.Concrate.EntityFramework
{
    public class EfOrderDal:EfEntityRepositoryBase<Order,NorthWindContext>,IOrderDal
    {

    }
}
