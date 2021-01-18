using System.Collections.Generic;

namespace Facturation.Shared
{
    public interface IBusinessData
    {
        IEnumerable<Facture> Factures { get; }
        public IEnumerable<Aggregate> Aggregats { get; }
        
        decimal CAfacture { get; }
        decimal TresoEnAttente { get; }
    }
}