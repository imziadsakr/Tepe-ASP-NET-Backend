using Microsoft.AspNetCore.Mvc;
using Web_API.Models;

namespace Web_API.Controllers
{
    [ApiController]

    public class PatientController : ControllerBase
    {

        private readonly DbManagement _context;
        private readonly IWebHostEnvironment _env;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public PatientController(DbManagement context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        [HttpPost("Save")]
        public async Task<IActionResult> Save([FromForm]PatientViewModel patient)
        {
            if (ModelState.IsValid)
            {
                Patient temp = new Patient();

                temp.Email = patient.Email;
                temp.Phone = patient.Phone;
                temp.Comment = patient.Comment;
                temp.Recommendation = patient.Recommendation;
                temp.BridgeAndMissingTeeth = patient.BridgeAndMissingTeeth;

                var path = Path.Combine(_env.ContentRootPath, "images/");

                if ((!Directory.Exists(path)))
                {
                    Directory.CreateDirectory(path);
                }

                //getting file name and combine with path and save it
                string filename = patient.TeethPhoto.FileName;
                using (var fileStream = new FileStream(Path.Combine(path, filename), FileMode.Create))
                {
                    await patient.TeethPhoto.CopyToAsync(fileStream);
                }

                //save folder path 
                temp.TeethPhoto = "images/" + filename;

                _context.patients.Add(temp);
                await _context.SaveChangesAsync();

            }
            return Ok();
        }
    }
}
