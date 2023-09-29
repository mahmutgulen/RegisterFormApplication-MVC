using CvProject.CORE.Utilities.Result;
using RFA.ENTITY.Dto.PaymentInfoDtos.RequestDtos;
using RFA.ENTITY.Dto.PaymentInfoDtos.ResponseDtos;
using RFA.ENTITY.Dto.RegistrationInfoDtos.RequestDtos;

namespace RFA.BLL.Abstract
{
    public interface IRegistrationInfoService
    {
        IDataResult<bool> AddRegistrationInfo(AddRegistrationInfoRequestDto dto);
        IDataResult<bool> UserCheck(string email,string phoneNumber);
        IDataResult<PaymentCalculatorResponseDto> PaymentCalculator(PaymentCalculatorRequestDto dto);
    }
}
