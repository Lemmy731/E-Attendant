using Attendee.Application.Interface;
using E_Attendant.Domain.View_Model;
using Microsoft.AspNetCore.Mvc;

namespace E_Attendant.Controllers
{
    //[Route("")]
    //[Route("Attendance")]
    //[Route("Attendance/Index")]
    public class AttendanceController : Controller
    {
        private readonly IService _service;

        public AttendanceController(IService service)
        {
            _service = service;
        }
        
        public IActionResult Index()
        {
            return View();
        }
        
      
        [HttpPost]  
        public async Task<IActionResult> Index([FromForm]AttendeeVM model)
        {
            try
            {

                if (!ModelState.IsValid)
                {
                    BadRequest("fill all fields");
                    return View();
                }


                var result = await _service.CreateAttendee(model);
                if (!result)
                {
                    BadRequest("could not create user");
                }
                else
                {
                    StatusCode(200, "User created successfully");
                }
            }
            catch (Exception ex)
            {
                BadRequest(ex.Message);
            }


            return View();

     

        }

    }
}
