
using Facturation.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Facturation.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaiementsController : ControllerBase
    {
        private readonly ILogger<PaiementsController> _logger;
        private readonly IBusinessData _data;

        public PaiementsController(ILogger<PaiementsController> logger, IBusinessData data)
        {
            _logger = logger;
            _data = data;
        }

        [HttpPost]
        public ActionResult<Paiement> Post([FromBody] Paiement paiement)
        {
            if (ModelState.IsValid)
            {
                paiement.Facture.enregistrerPaiement(paiement);
                _data.UpdateFacture(paiement.Facture);
                return Ok();
            }
            else
            {
                return BadRequest(ModelState.Values);
            }
        }
    }
}