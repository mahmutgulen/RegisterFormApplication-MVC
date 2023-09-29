using RFA.CORE.Entities;

namespace RFA.ENTITY.Concrete
{
    public class RegistrationInfo : IEntity
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Title { get; set; }
        public string? Commitee { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Country { get; set; }
        public byte RegistrationType{ get; set; }
        public byte GalaType{ get; set; }
        public byte AccomodationType{ get; set; }
        public byte PreCourseType{ get; set; }
        public byte PostCourseType{ get; set; }
        public string? CompoanionFullName { get; set; }
        public byte CompanionType { get; set; }
        public byte CompanionGalaType { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
    }
}
