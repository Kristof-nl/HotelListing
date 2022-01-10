using HotelListing.Core.DTOs;
using System.Threading.Tasks;

namespace HotelListing.Core.Services
{
    public interface IAuthManager
    {
        Task<bool> ValidateUser(LoginUserDto userDto);
        Task<string> CreateToken();

    }
}
