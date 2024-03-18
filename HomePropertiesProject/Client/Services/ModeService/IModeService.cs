using HomePropertiesProject.Shared.DTOs;
using HomePropertiesProject.Shared.Responses;

namespace HomePropertiesProject.Client.Services.ModeService
{
    public interface IModeService
    {
        Task<Response> AddMode(ModeDto model);
        Task<List<ModeDto>> GetAllModes();
    }
}
