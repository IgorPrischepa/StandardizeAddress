using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using StandardizeAddress.BLL.Contracts;

namespace StandardizeAddress.Controllers
{
    [Route("api/address")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly ILogger<AddressController> _logger;
        private readonly IDadataService _dadataService;

        public AddressController(IDadataService dadataService, ILogger<AddressController> logger)
        {
            _logger = logger;
            _dadataService = dadataService;
        }

        [HttpGet("find")]
        public async Task<IActionResult> ProccedAdress([FromQuery][Required][MaxLength(100)] string query)
        {
            return Ok(await _dadataService.CheckAdressAsync(query));
        }
    }
}