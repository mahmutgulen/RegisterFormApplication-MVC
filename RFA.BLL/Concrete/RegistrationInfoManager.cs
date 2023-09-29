using CvProject.CORE.Utilities.Result;
using RFA.BLL.Abstract;
using RFA.BLL.Constants;
using RFA.CORE.Entities;
using RFA.DAL.Abstract;
using RFA.ENTITY.Concrete;
using RFA.ENTITY.Dto.PaymentInfoDtos.RequestDtos;
using RFA.ENTITY.Dto.PaymentInfoDtos.ResponseDtos;
using RFA.ENTITY.Dto.RegistrationInfoDtos.RequestDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFA.BLL.Concrete
{
    public class RegistrationInfoManager : IRegistrationInfoService
    {
        private IRegistrationInfoDal _registrationInfoDal;

        public RegistrationInfoManager(IRegistrationInfoDal registrationInfoDal)
        {
            _registrationInfoDal = registrationInfoDal;
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

            }
            catch (Exception e)
            {
                return new ErrorDataResult<PaymentCalculatorResponseDto>(new PaymentCalculatorResponseDto(), e.Message, Messages.unk_err);
            }
        }

        public IDataResult<bool> UserCheck(string email, string phoneNumber)
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
