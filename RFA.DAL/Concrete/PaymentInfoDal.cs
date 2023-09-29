using RFA.CORE.DataAccess.EntityFramework;
using RFA.DAL.Abstract;
using RFA.DAL.Concrete.EntityFramework;
using RFA.ENTITY.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFA.DAL.Concrete
{
    public class PaymentInfoDal : EfEntityRepositoryBase<PaymentInfo, RFAContext>, IPaymentInfosDal
    {
    }
}
