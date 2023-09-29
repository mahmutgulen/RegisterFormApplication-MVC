using CvProject.CORE.Utilities.Result;
using RFA.BLL.Abstract;
using RFA.BLL.Constants;
using RFA.DAL.Abstract;
using RFA.ENTITY.Concrete;
using RFA.ENTITY.Dto.PaymentInfoDtos.RequestDtos;

namespace RFA.BLL.Concrete
{
    public class PaymentInfoManager : IPaymentInfoService
    {
        private IPaymentInfosDal _paymentInfosDal;

        public PaymentInfoManager(IPaymentInfosDal paymentInfosDal)
        {
            _paymentInfosDal = paymentInfosDal;
        }

        public IDataResult<bool> AddPaymentInfo(AddPaymentInfoRequestDto dto)
        {
            try
            {
                var newPayment = new PaymentInfo
                {
                    AccommodationFee = dto.AccommodationFee,
                    CourseFee = dto.CourseFee,
                    Discount = dto.Discount,
                    GalaFee = dto.GalaFee,
                    ParticipationFee = dto.ParticipationFee,
                    RegistrationInfoId = dto.RegistrationInfoId,
                    Total = dto.Total
                };

                _paymentInfosDal.Add(newPayment);
                return new SuccessDataResult<bool>(true);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<bool>(false, e.Message, Messages.unk_err);
            }
        }
    }
}
