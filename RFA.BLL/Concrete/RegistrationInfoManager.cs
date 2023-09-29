using CvProject.CORE.Utilities.Result;
using RFA.BLL.Abstract;
using RFA.BLL.Constants;
using RFA.CORE.Entities;
using RFA.DAL.Abstract;
using RFA.ENTITY.Concrete;
using RFA.ENTITY.Dto.PaymentInfoDtos.RequestDtos;
using RFA.ENTITY.Dto.PaymentInfoDtos.ResponseDtos;
using RFA.ENTITY.Dto.RegistrationInfoDtos.RequestDtos;
using RFA.ENTITY.Enum.RegistrationInfoEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RFA.BLL.Concrete
{
    public class RegistrationInfoManager : IRegistrationInfoService
    {
        private IRegistrationInfoDal _registrationInfoDal;
        private IPaymentInfoService _paymentInfoService;

        public RegistrationInfoManager(IRegistrationInfoDal registrationInfoDal, IPaymentInfoService paymentInfoService)
        {
            _registrationInfoDal = registrationInfoDal;
            _paymentInfoService = paymentInfoService;
        }

        public IDataResult<bool> AddRegistrationInfo(AddRegistrationInfoRequestDto dto)
        {
            try
            {
                var userCheck = UserCheck(dto.Email, dto.PhoneNumber);
                if (!userCheck.Data)
                {
                    return new ErrorDataResult<bool>(false, userCheck.Message, userCheck.MessageCode);
                }

                var newRegistration = new RegistrationInfo
                {
                    AccomodationType = dto.AccomodationType,
                    CheckInDate = dto.CheckInDate,
                    Commitee = dto.Commitee,
                    CheckOutDate = dto.CheckOutDate,
                    CompanionType = dto.CompanionType,
                    CompanionGalaType = dto.CompanionGalaType,
                    CompoanionFullName = dto.CompoanionFullName,
                    Country = dto.Country,
                    Email = dto.Email,
                    FirstName = dto.FirstName,
                    GalaType = dto.GalaType,
                    LastName = dto.LastName,
                    PhoneNumber = dto.PhoneNumber,
                    PostCourseType = dto.PostCourseType,
                    PreCourseType = dto.PreCourseType,
                    RegistrationType = dto.RegistrationType,
                    Title = dto.Title,
                };
                _registrationInfoDal.Add(newRegistration);

                var paymentCalculatorDto = new PaymentCalculatorRequestDto
                {
                    AccommodationType = dto.AccomodationType,
                    CheckInDate = dto.CheckInDate,
                    CompanionGalaType = dto.CompanionGalaType,
                    GalaType = dto.GalaType,
                    CompanionType = dto.CompanionType,
                    PostCourseType = dto.PostCourseType,
                    PreCourseType = dto.PreCourseType,
                    CheckOutDate = dto.CheckOutDate,
                    RegistrationType = dto.RegistrationType
                };

                var paymentCalculator = PaymentCalculator(paymentCalculatorDto);

                var newPayment = new AddPaymentInfoRequestDto
                {
                    AccommodationFee = (int?)paymentCalculator.Data.AccommodationFee,
                    CourseFee = (int?)paymentCalculator.Data.CourseFee,
                    Discount = (int?)paymentCalculator.Data.Discount,
                    GalaFee = (int?)paymentCalculator.Data.GalaFee,
                    ParticipationFee = (int?)paymentCalculator.Data.ParticipationFee,
                    RegistrationInfoId = newRegistration.Id,
                    Total = (int?)paymentCalculator.Data.Total
                };

                var addPayment = _paymentInfoService.AddPaymentInfo(newPayment);
                return new SuccessDataResult<bool>(true, "registration_successfuly", Messages.registration_successfuly);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<bool>(false, e.Message, Messages.unk_err);
            }
        }

        public IDataResult<PaymentCalculatorResponseDto> PaymentCalculator(PaymentCalculatorRequestDto dto)
        {
            try
            {
                double accommodationFee = 0, courseFee = 0, discount = 0, galaFee = 106.20, participationFee = 0, totalFee = 0;
                //REGISTRATION TYPE
                switch (dto.RegistrationType)
                {
                    case 1:
                        totalFee = 519.20;
                        participationFee += 519.20;
                        break;
                    case 2:
                        totalFee = 678.50;
                        participationFee += 678.50;
                        break;
                    case 3:
                        totalFee = 584.10;
                        participationFee += 584.10;
                        break;
                    case 4:
                        totalFee = 247.80;
                        participationFee += 247.8;
                        break;
                    case 5:
                        totalFee = 413.00;
                        participationFee += 413.00;
                        break;
                    case 6:
                        totalFee = 224.20;
                        participationFee += 224.20;
                        break;
                }
                //GALA TYPE
                switch (dto.GalaType)
                {
                    case (int)GalaTypeEnum.No:
                        totalFee += 0;
                        break;
                    case (int)GalaTypeEnum.Yes:
                        totalFee += galaFee;
                        break;
                }
                //DATE 
                var accommodationDay = dto.CheckInDate.Day - dto.CheckOutDate.Day;
                //ACCOMMODATION TYPE
                switch (dto.AccommodationType)
                {
                    case (int)AccommodationTypeEnum.No:
                        accommodationFee += 0;
                        break;

                    case (int)AccommodationTypeEnum.OnePerson:
                        accommodationFee += 356.00;
                        break;

                    case (int)AccommodationTypeEnum.TwoPerson:
                        accommodationFee += 395.00;
                        break;
                }
                accommodationFee *= accommodationDay;
                totalFee += accommodationFee;
                //COMPANİON GALA TYPE
                switch (dto.CompanionGalaType)
                {
                    case (int)CompanionGalaType.No:
                        totalFee += 0;
                        break;
                    case (int)CompanionGalaType.Yes:
                        totalFee += 129.80;
                        galaFee += 129.80;
                        break;
                }
                //PRE COURSE
                switch (dto.PreCourseType)
                {
                    case (int)PreCourseTypeEnum.No:
                        totalFee += 0;
                        break;
                    case (int)PreCourseTypeEnum.Yes:
                        totalFee += 271.40;
                        courseFee += 271.40;
                        break;
                }
                //POST COURSE
                switch (dto.PreCourseType)
                {
                    case (int)PostCourseTypeEnum.No:
                        totalFee += 0;
                        break;
                    case (int)PostCourseTypeEnum.Yes:
                        totalFee += 271.40;
                        courseFee += 271.40;
                        break;
                }

                if (dto.PreCourseType == (int)PreCourseTypeEnum.Yes || dto.PostCourseType == (int)PostCourseTypeEnum.Yes)
                {
                    totalFee -= 40.00;
                    discount += 40.00;
                }

                var resultDto = new PaymentCalculatorResponseDto
                {
                    AccommodationFee = accommodationFee,
                    CourseFee = courseFee,
                    Discount = discount,
                    GalaFee = galaFee,
                    ParticipationFee = participationFee,
                    Total = totalFee
                };
                return new SuccessDataResult<PaymentCalculatorResponseDto>(resultDto);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<PaymentCalculatorResponseDto>(new PaymentCalculatorResponseDto(), e.Message, Messages.unk_err);
            }
        }

        public IDataResult<bool> UserCheck(string? email, string? phoneNumber)
        {
            try
            {
                var emailcheck = _registrationInfoDal.Get(x => x.Email == email);
                if (emailcheck != null)
                {
                    return new ErrorDataResult<bool>(false, "mail_already_exists", Messages.mail_already_exists);
                }

                var phoneNumberCheck = _registrationInfoDal.Get(x => x.Email == phoneNumber);
                if (phoneNumberCheck != null)
                {
                    return new ErrorDataResult<bool>(false, "phone_number_already_exists", Messages.phone_number_already_exists);
                }

                return new SuccessDataResult<bool>(true);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<bool>(false, e.Message, Messages.unk_err);
            }
        }
    }
}
