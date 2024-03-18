
using HomePropertiesProject.Shared.Entities;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace HomePropertiesProject.Shared.DTOs
{
    public class ModeDto
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public List<House>? Houses { get; set; }
    }
}
