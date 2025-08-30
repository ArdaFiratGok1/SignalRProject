using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.EntityLayer.Entitites;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EfDiscountDal : EfGenericDal<Discount>, IDiscountDal
    {
        public EfDiscountDal(SignalRContext context) : base(context)
        {
        }
    }
}
