using HomePropertiesProject.Shared.DTOs;
using HomePropertiesProject.Shared.Responses;

namespace HomePropertiesProject.Server.Repositories.ModeRepositories
{
    public interface IModeRepository
    {
        Task<Response> CreateMode(ModeDto model);
        Task<List<ModeDto>> GetAllModes();
    }
}
