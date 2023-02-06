using Microsoft.AspNetCore.Mvc;
using OTPVerificationApi.Controllers;
using OTPVerificationApi.Model.OptModel;
using static System.Net.WebRequestMethods;

namespace OTPVerificationApi.Services.OTPServices;

public class OtpServices : IOTPServices
{
    public static int Random { get; set; }
    public int GetOTP()
    {
        Random rnd = new Random();
        int Otp = rnd.Next(1000, 9000);
        OtpServices.Random = Otp;
        return Otp;
    }

    public string CheckOTP(int OTP)
    {
        if (OTP.Equals(OtpServices.Random))
        {
            return "You are verified";
        }
        else
        {
            return "Please Enter the Correct OTP";
        }
    }
}