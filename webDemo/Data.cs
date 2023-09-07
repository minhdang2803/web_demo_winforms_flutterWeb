using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webDemo
{
    internal class UserData
    {
        private string _token;
        public string token
        {
            get { return _token; }
            set { _token = value; }
        }
        public UserData(string token)
        {
            this._token = token;
        }

        public void GenerateNewToken()
        {
            //Simulating an action to make API call to get the new access_token here

            // Mock Data only (https://posmobile-api-uat.concung.vn/swagger/ui/index#/)
            // Please use the above URL to get the valid token ;D
            this.token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsIng1dCI6Il9HSDZrYllkZ3RxZDdLNHNrUW1uSGI4dUh6OCIsImtpZCI6Il9HSDZrYllkZ3RxZDdLNHNrUW1uSGI4dUh6OCJ9.eyJpc3MiOiJjb25jdW5nLmNvbSIsImF1ZCI6ImNvbmN1bmcuY29tL3Jlc291cmNlcyIsImV4cCI6MTY5Mjk0Nzc4MSwibmJmIjoxNjkyOTQ0MTgxLCJjbGllbnRfaWQiOiJTd2FnZ2VyLlBPU01PQklMRS5DbGllbnRDcmVkZW50aWFsIiwic2NvcGUiOiJwb3Ntb2JpbGUtYXBpLXVhdCIsInN1YiI6IjEwOTgiLCJhdXRoX3RpbWUiOjE2OTI5MzcyMzgsImlkcCI6Imlkc3J2IiwiL1VzZXJJRCI6IjEwOTgiLCIvVXNlcm5hbWUiOiIyMDk3IiwiL0F2YXRhciI6ImF2YS8yMDIxMTIvMzhkZGYwNTMtYjE2Yi00ODdkLTg4ZjUtOWEyZjZmNTg4YzAzLmpwZyIsIi9Vc2VyVHlwZUlEIjoiMSIsIi9TdXBwbGllcklEIjoiMCIsIi9GdWxsbmFtZSI6Ik5ndXnhu4VuIFbEg24gSOG6rXUiLCIvRGVwYXJ0bWVudElEIjoiNjMwIiwiL1Bvc2l0aW9uSUQiOiIxMjciLCIvU3RvcmVJRCI6IjI2NSIsIi9HZW5kZXIiOiIxIiwiL0VtcGxveWVlSUQiOiIxMDk3IiwiL1ZQTlVzZXJuYW1lIjoiMjA5NyIsIi9WUE5QYXNzd29yZCI6Ikt1YWpYQzl5YnoiLCIvUm9sZUlEcyI6IlszMTUzLDMxNzYsMzIyMCwzNDMwLDMxNDcsMzE5NCwzNDUxXSIsImFtciI6WyJwYXNzd29yZCJdfQ.WKu_KHZdU5McLsmMmJXKpHq_kqQt_WoWTftBZyroM2jxDApt-O8PHTXRh37J6Bn0nwDVsA16pDLy7YpVvQcWXuqGgmO8O5sa-KAGOw9OSv2zu8AmUwIWt7l-YzIZcMo1EEVsFV_MADw4Mk2QACF6aaHinvpH-UJJr_KAYjEEKpxs6WUeCFqhR7hjwYuBLOQWN-0LwDNT6du7O_wVlQbRS1l5UKX-hGSJ8qtGunyRTe3kGbceHV2PM-743dux2rZ-TLWA1meoLzL-MdCVP1Ycmw6CWfcacH19VNpjr9ArFmyRX6ut6FPc7lViHXFBGyEv8SZdOcClOKAdgbQH7JtyWQ";

        }
    }
}


