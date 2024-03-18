using HomePropertiesProject.Shared.DTOs;
using HomePropertiesProject.Shared.Responses;
using System.Net.Http.Json;

namespace HomePropertiesProject.Client.Services.HouseService
{
    public class HouseService : IHouseService
    {
        private readonly HttpClient httpClient;

        public HouseService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<Response> AdHouseData(HouseRequestDTO model)
        {
            var result = await httpClient.PostAsJsonAsync("api/house", model);
            var response = await result.Content.ReadFromJsonAsync<Response>();
            return response!;
        }

        public async Task<Response> DeleteHouseData(int id)
        {
            var result = await httpClient.DeleteAsync($"api/house/{id}");
            var response = await result.Content.ReadFromJsonAsync<Response>();
            return response!;
        }

        public async Task<List<HouseResponseDto>> GetAllHouseData()
        {
            var results = await httpClient.GetAsync("api/house");
            var responses = await results.Content.ReadFromJsonAsync<List<HouseResponseDto>>();
            return responses!;
        }

        public async Task<HouseResponseDto> GetSingleHouseData(int id)
        {
            var result = await httpClient.GetAsync($"api/house/{id}");
            var response = await result.Content.ReadFromJsonAsync<HouseResponseDto>();
            return response!;
        }

        public async Task<Response> UpdateHouseData(HouseRequestDTO model)
        {
            var result = await httpClient.PutAsJsonAsync("api/house", model);
            var response = await result.Content.ReadFromJsonAsync<Response>();
            return response!;
        }
    }
}

