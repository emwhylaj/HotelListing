﻿using System.Threading.Tasks;
using HotelListing.DTOs;

namespace HotelListing.Services
{
    public interface IAuthManager
    {
        Task<bool> ValidateUser(LoginUserDto userDto);

        Task<string> CreateToken();
    }
}