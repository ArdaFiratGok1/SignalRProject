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
    public class EfSocialMediaDal : EfGenericDal<SocialMedia>, ISocialMediaDal
    {
        public EfSocialMediaDal(SignalRContext context) : base(context)
        {
        }
    }
}
