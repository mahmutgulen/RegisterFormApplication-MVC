using Microsoft.AspNetCore.Mvc;
using RFA.BLL.Abstract;
using RFA.ENTITY.Dto.RegistrationInfoDtos.RequestDtos;

namespace RFA.UI.Controllers
{
    public class RegisterController : Controller
    {
        private IRegistrationInfoService _registrationInfoService;

        public RegisterController(IRegistrationInfoService registrationInfoService)
        {
            _registrationInfoService = registrationInfoService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(AddRegistrationInfoRequestDto dto)
        {
            var result=_registrationInfoService.AddRegistrationInfo(dto);
            return View(result);
        }
    }
}
