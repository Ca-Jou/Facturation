using System;
using System.Collections.Generic;
using System.Linq;

namespace Facturation.Shared
{
    public class BusinessData : IBusinessData
    {
        private List<Facture> listeFactures;
        private List<Aggregate> facturesAgregees;

        public BusinessData()
        {
            this.listeFactures = new List<Facture>();
            this.facturesAgregees = new List<Aggregate>();
            this.AggregateData();
        }
        
        public void AggregateData()
        {
            int mois = 1;
            decimal caFacture = 0;
            decimal caReel = 0;

            while (mois <= 12)
            {
                foreach (var facture in this.Factures)
                {
                    if (facture.DateEcheance.Month == mois)
                    {
                        caFacture += facture.MontantDu;
                        caReel += facture.MontantRegle;
                    }
                }
                this.facturesAgregees.Add(new Aggregate(mois, caFacture, caReel));
                caFacture = 0;
                caReel = 0;
                mois++;
            }
        }

        public IEnumerable<Facture> Factures => listeFactures;
        public IEnumerable<Aggregate> Aggregats => facturesAgregees;

        public decimal CAfacture => listeFactures.Sum(facture => facture.MontantDu);
        public decimal TresoEnAttente => listeFactures.Sum(facture => facture.MontantDu - facture.MontantRegle);
    }
}