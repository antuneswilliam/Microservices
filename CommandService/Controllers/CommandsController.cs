using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace CommandService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly IMapper _mapper;

        public CommandsController(IMapper mapper)
        {
            _mapper = mapper;
        }
    }
}