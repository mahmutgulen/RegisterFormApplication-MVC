using RFA.CORE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFA.ENTITY.Concrete
{
    public class PaymentInfos : IEntity
    {
        public int Id { get; set; }
        public int RegistrationInfoId { get; set; }
        public int ParticipationFee { get; set; }
        public int GalaFee { get; set; }
        public int AccommodationFee { get; set; }
        public int CourseFee { get; set; }
        public int Discount { get; set; }
        public int Total { get; set; }
    }
}
