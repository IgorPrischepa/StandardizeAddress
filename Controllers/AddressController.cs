using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StandardizeAddress.BLL.Contracts;
using StandardizeAddress.BLL.Models;
using StandardizeAddress.Dtos;
using System.ComponentModel.DataAnnotations;

namespace StandardizeAddress.Controllers
{
    [Route("api/address")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly ILogger<AddressController> _logger;
        private readonly IDadataService _dadataService;
        private readonly IMapper _mapper;

        public AddressController(IDadataService dadataService, IMapper mapper, ILogger<AddressController> logger)
        {
            _logger = logger;
            _dadataService = dadataService;
            _mapper = mapper;
        }

        [HttpGet("find")]
        public async Task<IActionResult> ProccedAdressAsync([FromQuery][Required][MaxLength(250)] string query)
        {
            try
            {
                AddressInfoModel addressInfo = await _dadataService.CheckAdressAsync(query);
                return Ok(_mapper.Map<AddressDto>(addressInfo));
            }
            catch (Exception ex)
            {

                _logger.LogError($"{ex.Message} {Environment.NewLine} {ex.StackTrace}");
                return Problem();
            }
        }
    }
}