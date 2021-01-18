using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Facturation.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace Facturation.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DashboardController : ControllerBase
    {
        private readonly ILogger<FacturesController> _logger;
        private readonly IBusinessData _data;

        public DashboardController(ILogger<FacturesController> logger, IBusinessData data)
        {
            _logger = logger;
            _data = data;
        }
        
        [HttpGet]
        public Dictionary<string, decimal> Get()
        {
            Dictionary<string, decimal> dataCA = new Dictionary<string, decimal>();
            dataCA.Add("CAfacture", _data.CAfacture);
            dataCA.Add("TresoEnAttente", _data.TresoEnAttente);
            return dataCA;
        }
    }
}