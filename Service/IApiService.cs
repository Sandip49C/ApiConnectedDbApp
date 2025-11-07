using System.Collections.Generic;
using System.Threading.Tasks;
using ApiConnectedDbApp.Models;

namespace ApiConnectedDbApp.Services;

public interface IApiService
{
    Task<List<User>> GetUsersAsync();
}