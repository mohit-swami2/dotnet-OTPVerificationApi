using Microsoft.AspNetCore.Mvc;
using OTPVerificationApi.Model.OptModel;

namespace OTPVerificationApi.Services.OTPServices
{
   
    public interface IOTPServices
    {
       public int GetOTP();
       public string CheckOTP(int OTP);
    }
}
