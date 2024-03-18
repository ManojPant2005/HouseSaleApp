using HomePropertiesProject.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomePropertiesProject.Shared.DTOs
{
    public class HouseResponseDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? Type { get; set; }
        public double Price { get; set; }
        public string? Location { get; set; }
        public int Size { get; set; }
        public int NOfBed { get; set; }
        public int NOfBath { get; set; }
        public string? Image { get; set; }
        public Mode? Modes { get; set; }
        public int ModeId { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
