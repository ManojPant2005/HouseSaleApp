using HomePropertiesProject.Shared.DTOs;
using HomePropertiesProject.Shared.Entities;
using System.Threading.Tasks;

namespace HomePropertiesProject.Shared.Converters
{
    public interface IFromEntityToDto
    {
        HouseResponseDto ConvertToDto(House model);
        List<HouseResponseDto> ConvertToDtoList(List<House> models);
        List<ModeDto> ConvertModeToDtoList(List<Mode> model);
    }
}
