using HomePropertiesProject.Server.Data;
using HomePropertiesProject.Server.Repositories.HouseRepositories;
using HomePropertiesProject.Shared.DTOs;
using HomePropertiesProject.Shared.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HomePropertiesProject.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HouseController : ControllerBase
    {
        private readonly IHouseRepo houseRepo;

        public HouseController(IHouseRepo houseRepo)
        {
            this.houseRepo = houseRepo;
        }


        [HttpGet]
        public async Task<ActionResult<List<HouseResponseDto>>> GetHouseList()
        {
            var result = await houseRepo.GetAllHouseData();
            return result == null ? NotFound("No data found from the database") : Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<HouseResponseDto>> GetSingleHouse(int id)
        {
            var result = await houseRepo.GetSingeHouseData(id);
            return result == null ? NotFound("No data found from the database") : Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Response>> DeleteData(int id)
        {
            var result = await houseRepo.DeleteHouseData(id);
            if (result.Success)
                return Ok(result);
            return NotFound(result);
        }

        [HttpPut]
        public async Task<ActionResult<Response>> UpdateData(HouseRequestDTO model)
        {
            if (model == null)
                return NoContent();

            var result = await houseRepo.UpdateHouseData(model);
            if (result.Success)
                return Ok(result);
            return NotFound(result);
        }

        [HttpPost]
        public async Task<ActionResult<Response>> AddData(HouseRequestDTO model)
        {
            if (model == null)
                return NoContent();

            var result = await houseRepo.AddHouseData(model);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

    }
}

