using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using ApiConnectedDbApp.Models;
using SQLite;

namespace ApiConnectedDbApp.Services;

public class DatabaseRepository : IDatabaseRepository
{
    private readonly SQLiteAsyncConnection _database;

    public DatabaseRepository()
    {
        var dbPath = Path.Combine(FileSystem.AppDataDirectory, "users.db3");
        _database = new SQLiteAsyncConnection(dbPath);
        _database.CreateTableAsync<User>().Wait(); // Create table if not exists.
    }

    public async Task InsertAllAsync(List<User> users)
    {
        await _database.InsertAllAsync(users); // Bulk insert.
    }

    public async Task<List<User>> GetAllAsync()
    {
        return await _database.Table<User>().ToListAsync();
    }
}