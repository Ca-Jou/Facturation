using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Facturation.Shared;
using Microsoft.Extensions.Logging;

namespace Facturation.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AggregatesController : ControllerBase
    {
        private readonly ILogger<FacturesController> _logger;
        private readonly IBusinessData _data;

        public AggregatesController(ILogger<FacturesController> logger, IBusinessData data)
        {
            _logger = logger;
            _data = data;
        }

        [HttpGet]
        public IEnumerable<Aggregate> Get()
        {
            return _data.Aggregats;
        }
    }
}