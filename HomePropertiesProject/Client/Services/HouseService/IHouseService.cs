using HomePropertiesProject.Shared.DTOs;
using HomePropertiesProject.Shared.Responses;

namespace HomePropertiesProject.Client.Services.HouseService
{
    public interface IHouseService
    {
        Task<Response> AdHouseData(HouseRequestDTO model);
        Task<Response> UpdateHouseData(HouseRequestDTO model);
        Task<List<HouseResponseDto>> GetAllHouseData();
        Task<HouseResponseDto> GetSingleHouseData(int id);
        Task<Response> DeleteHouseData(int id);
    }
}
