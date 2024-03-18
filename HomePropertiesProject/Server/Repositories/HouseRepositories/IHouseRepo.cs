using HomePropertiesProject.Shared.DTOs;
using HomePropertiesProject.Shared.Responses;

namespace HomePropertiesProject.Server.Repositories.HouseRepositories
{
    public interface IHouseRepo
    {
        Task<Response> AddHouseData(HouseRequestDTO model);
        Task<Response> UpdateHouseData(HouseRequestDTO model);
        Task<Response> DeleteHouseData(int id);
        Task<HouseResponseDto> GetSingeHouseData(int id);
        Task<List<HouseResponseDto>> GetAllHouseData();
    }
}
