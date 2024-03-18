using HomePropertiesProject.Server.Data;
using HomePropertiesProject.Shared.Converters;
using HomePropertiesProject.Shared.DTOs;
using HomePropertiesProject.Shared.Responses;
using Microsoft.EntityFrameworkCore;

namespace HomePropertiesProject.Server.Repositories.ModeRepositories
{
    public class ModeRepository : IModeRepository
    {
        private readonly AppDbContext appDbContext;
        private readonly IFromDtoToEntity fromDtoToEntity;
        private readonly IFromEntityToDto fromEntityToDto;

        public ModeRepository(AppDbContext appDbContext, IFromDtoToEntity fromDtoToEntity, IFromEntityToDto fromEntityToDto)
        {
            this.appDbContext = appDbContext;
            this.fromDtoToEntity = fromDtoToEntity;
            this.fromEntityToDto = fromEntityToDto;
        }

        public async Task<Response> CreateMode(ModeDto model)
        {
            if (model == null)
                return new Response { Success = false, Message = "No content" };

            if (await CheckName(model.Name!))
                return new Response { Success = false, Message = "Mode added already" };

            var result = fromDtoToEntity.ConvertModeToEntity(model);
            appDbContext.Modes.Add(result);
            await appDbContext.SaveChangesAsync();
            return new Response { Message = "Mode Added successfully!" };
        }

        public async Task<List<ModeDto>> GetAllModes()
        {
            var result = await appDbContext.Modes.ToListAsync();
            return fromEntityToDto.ConvertModeToDtoList(result);
        }


        private async Task<bool> CheckName(string name)
        {
            var DoesExist = await appDbContext.Houses.Where(h => h.Name!.ToLower().Equals(name.ToLower())).FirstOrDefaultAsync();
            return DoesExist == null ? false : true;
        }
    }
}

