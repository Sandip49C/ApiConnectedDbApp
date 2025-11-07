using ApiConnectedDbApp.Models;
using System.Collections.Generic;
using System.Net.Http;
using System;
using System.Text.Json;
using System.Threading.Tasks;

namespace ApiConnectedDbApp.Services;

public class ApiService : IApiService
{
    private readonly HttpClient _httpClient;

    public ApiService()
    {
        _httpClient = new HttpClient(); // Reuse one instance (best practice).
    }

    public async Task<List<User>> GetUsersAsync()
    {
        try
        {
            var response = await _httpClient.GetStringAsync("https://jsonplaceholder.typicode.com/users");
            var users = JsonSerializer.Deserialize<List<User>>(response, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true // Handles JSON case mismatches.
            });
            return users ?? new List<User>(); // Return empty list if null.
        }
        catch (Exception ex)
        {
            // In production, log this. For now, just return empty.
            Console.WriteLine($"API Error: {ex.Message}");
            return new List<User>();
        }
    }
}