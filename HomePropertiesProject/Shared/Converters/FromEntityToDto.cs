using HomePropertiesProject.Shared.DTOs;
using HomePropertiesProject.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomePropertiesProject.Shared.Converters
{
    public class FromEntityToDto : IFromEntityToDto
    {
        public List<ModeDto> ConvertModeToDtoList(List<Mode> model)
        {
            {
                var newList = new List<ModeDto>();
                foreach (var item in model)
                {
                    var tempData = new ModeDto()
                    {
                        Id = item.Id,
                        Name = item.Name
                    };
                    newList.Add(tempData);
                }
                return newList;
            }
        }
        public HouseResponseDto ConvertToDto(House model)
        {
            var r = new HouseResponseDto()
            {
                Id = model.Id,
                Name = model.Name,
                Price = model.Price,
                Image = model.Image,
                Type = model.Type,
                Size = model.Size,
                NOfBath = model.NOfBath,
                NOfBed = model.NOfBed,
                Location = model.Location,
                ModeId = model.ModeId
            };
            return r;
        }

        public List<HouseResponseDto> ConvertToDtoList(List<House> models)
        {
            var newList = new List<HouseResponseDto>();
            foreach (var item in models)
            {
                var tempData = new HouseResponseDto()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Price = item.Price,
                    Image = item.Image,
                    Type = item.Type,
                    Size = item.Size,
                    NOfBath = item.NOfBath,
                    NOfBed = item.NOfBed,
                    Location = item.Location,
                    ModeId = item.ModeId,
                    Modes = new Mode() { Id = item.ModeId, Name = item.Mode!.Name }
                };
                newList.Add(tempData);
            }
            return newList;
        }
    }
}

