using System.Collections.Generic;
using System.Threading.Tasks;
using ApiConnectedDbApp.Models;

namespace ApiConnectedDbApp.Services;

public interface IDatabaseRepository
{
    Task InsertAllAsync(List<User> users);
    Task<List<User>> GetAllAsync();
}