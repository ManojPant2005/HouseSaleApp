using HomePropertiesProject.Shared.DTOs;
using HomePropertiesProject.Shared.Entities;
using System.Threading.Tasks;

namespace HomePropertiesProject.Shared.Converters
{
    public interface IFromDtoToEntity
    {
        House ConvertToEntity(HouseRequestDTO model);
        Mode ConvertModeToEntity(ModeDto model);
    }
}