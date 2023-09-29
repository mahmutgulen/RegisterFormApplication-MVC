using RFA.CORE.DataAccess.EntityFramework;
using RFA.ENTITY.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFA.DAL.Abstract
{
    public interface IPaymentInfosDal : IEntityRepository<PaymentInfo>
    {
    }
}
