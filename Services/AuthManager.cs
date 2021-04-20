using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelListing.DTOs;

namespace HotelListing.Services
{
    public class AuthManager : IAuthManager
    {
        public Task<string> CraeteToken()
        {
            throw new NotImplementedException();
        }

        public Task<bool> ValidateUser(LoginUserDto userDto)
        {
            throw new NotImplementedException();
        }
    }
}