using HomePropertiesProject.Server.Repositories.ModeRepositories;
using HomePropertiesProject.Shared.DTOs;
using HomePropertiesProject.Shared.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HomePropertiesProject.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModeController : ControllerBase
    {
        private readonly IModeRepository modeRepository;

        public ModeController(IModeRepository modeRepository)
        {
            this.modeRepository = modeRepository;
        }

        [HttpPost]
        public async Task<ActionResult<Response>> AddMode(ModeDto model)
        {
            if (model == null)
                return BadRequest(new Response() { Success = false, Message = "No content specified" });

            var result = await modeRepository.CreateMode(model);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpGet]
        public async Task<ActionResult<List<ModeDto>>> GetAllModes() => Ok(await modeRepository.GetAllModes());
    }
}