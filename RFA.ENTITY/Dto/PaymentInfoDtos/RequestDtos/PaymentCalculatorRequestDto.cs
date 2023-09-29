using RFA.CORE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFA.ENTITY.Dto.PaymentInfoDtos.RequestDtos
{
    public class PaymentCalculatorRequestDto:IDto
    {
        public byte RegistrationType { get; set; }
        public byte GalaType { get; set; }
        public byte AccommodationType { get; set; }
        public byte PreCourseType { get; set; }
        public byte PostCourseType { get; set; }
        public byte CompanionType { get; set; }
        public byte CompanionGalaType { get; set; }
        public DateTime  CheckInDate{ get; set; }
        public DateTime  CheckOutDate{ get; set; }
    }
}
