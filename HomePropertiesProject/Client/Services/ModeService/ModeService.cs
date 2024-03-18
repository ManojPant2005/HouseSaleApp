using HomePropertiesProject.Shared.DTOs;
using HomePropertiesProject.Shared.Responses;
using System.Net.Http.Json;

namespace HomePropertiesProject.Client.Services.ModeService
{
    public class ModeService : IModeService
    {
        private readonly HttpClient httpClient;

        public ModeService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<Response> AddMode(ModeDto model)
        {
            var result = await httpClient.PostAsJsonAsync("api/mode", model);
            var response = await result.Content.ReadFromJsonAsync<Response>();
            return response!;
        }

        public async Task<List<ModeDto>> GetAllModes()
        {
            var results = await httpClient.GetAsync("api/mode");
            var responses = await results.Content.ReadFromJsonAsync<List<ModeDto>>();
            return responses!;
        }
    }
}

