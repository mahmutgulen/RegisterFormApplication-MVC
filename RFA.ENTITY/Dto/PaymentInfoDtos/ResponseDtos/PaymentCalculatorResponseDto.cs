using RFA.CORE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFA.ENTITY.Dto.PaymentInfoDtos.ResponseDtos
{
    public class PaymentCalculatorResponseDto : IDto
    {
        public double? ParticipationFee { get; set; }
        public double? GalaFee { get; set; }
        public double? AccommodationFee { get; set; }
        public double? CourseFee { get; set; }
        public double? Discount { get; set; }
        public double? Total { get; set; }
    }
}
