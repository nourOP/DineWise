using DineWise.Data.Models;

namespace DineWise.Repositories.Interfaces
{
    public interface ITokenHandler
    {
        Task<string> CreateTokenAsync(User user);
    }
}
