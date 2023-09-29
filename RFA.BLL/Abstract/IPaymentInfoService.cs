using CvProject.CORE.Utilities.Result;
using RFA.ENTITY.Dto.PaymentInfoDtos.RequestDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFA.BLL.Abstract
{
    public interface IPaymentInfoService
    {
        IDataResult<bool> AddPaymentInfo(AddPaymentInfoRequestDto dto);
    }
}
