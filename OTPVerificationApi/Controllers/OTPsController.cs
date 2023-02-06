using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using OTPVerificationApi.Model.OptModel;
using OTPVerificationApi.Services.OTPServices;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace OTPVerificationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OTPsController : ControllerBase
    {
        private readonly IOTPServices _context;

        public OTPsController(IOTPServices context)
        {
            _context = context;
        }
        
        [HttpGet]
        public ActionResult<OtpModel> Get()
        {
            return Ok(_context.GetOTP());
        }

        [HttpPost("{OTP}")]
        public IActionResult Post(int OTP)
        {
            return Ok(_context.CheckOTP(OTP));
        } 
    }
}