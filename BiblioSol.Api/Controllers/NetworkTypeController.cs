using BiblioSol.Application.Dtos.insurance;
using BiblioSol.Application.Interfaces.Services.insurance;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BiblioSol.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NetworkTypeController : ControllerBase
    {
        private readonly INetworkTypeService _networkTypeService;

        public NetworkTypeController(INetworkTypeService networkTypeService)
        {
            _networkTypeService = networkTypeService;
        }
        // GET: api/<NetworkTypeController>
        [HttpGet("GetAllNetworkTypes")]
        public async Task<IActionResult> Get()
        {
            var result = await _networkTypeService.GetAllNetworkTypesAsync();

            if (!result.IsSuccess)
            {
                return BadRequest(result);
            }

            return Ok(result);

        }

        // GET api/<NetworkTypeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<NetworkTypeController>
        [HttpPost("SaveNetworkType")]
        public async Task<IActionResult> Post([FromBody] NetworkTypeDto networkTypeDto)
        {
            var result = await _networkTypeService.AddNetworkTypeAsync(networkTypeDto);

            if (!result.IsSuccess)
            {
                return BadRequest(result);
            }

            return Ok(result);
        }

        // PUT api/<NetworkTypeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<NetworkTypeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
