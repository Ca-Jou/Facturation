using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Facturation.Shared;
using Microsoft.Extensions.Logging;

namespace Facturation.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FacturesController : ControllerBase
    {
        private readonly ILogger<FacturesController> _logger;
        private readonly IBusinessData _data;

        public FacturesController(ILogger<FacturesController> logger, IBusinessData data)
        {
            _logger = logger;
            _data = data;
        }

        [HttpGet]
        public IEnumerable<Facture> Get()
        {
            return _data.Factures;
        }

        [HttpGet("{numero}")]
        public ActionResult<Facture> Get(int numero)
        {
            var facture = _data.Factures.Where(f => f.Numero == numero).FirstOrDefault();

            if (facture != null)
            {
                return facture;
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public ActionResult<Facture> Post([FromBody] Facture newFacture)
        {
            if (ModelState.IsValid)
            {
                _data.AddFacture(newFacture);
                return Created("/factures", newFacture);
            }
            else
            {
                return BadRequest(ModelState.Values);
            }
        }
    }
}