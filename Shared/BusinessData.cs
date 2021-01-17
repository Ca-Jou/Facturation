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
            this.Populate();
            this.AggregateData();
        }

        public void Populate()
        {
            Facture f1 = new Facture(001, "Jouan", new DateTime(2020, 11, 3), 1200, 1200);
            Facture f2 = new Facture(002, "Jato", new DateTime(2020, 11, 09), 500, 0);
            Facture f3 = new Facture(003, "Da Silva", new DateTime(2020, 11, 15), 1000, 900);
            Facture f4 = new Facture(004, "Jouan", new DateTime(2020, 12, 01), 500, 0);
            Facture f5 = new Facture(005, "Jato", new DateTime(2020, 12, 07), 500, 0);

            this.listeFactures.Add(f1);
            this.listeFactures.Add(f2);
            this.listeFactures.Add(f3);
            this.listeFactures.Add(f4);
            this.listeFactures.Add(f5);
        }

        public void AggregateData()
        {
            int mois = 1;
            float caFacture = 0;
            float caReel = 0;

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

        public float CAfacture => listeFactures.Sum(facture => facture.MontantDu);
        public float TresoEnAttente => listeFactures.Sum(facture => facture.MontantDu - facture.MontantRegle);
    }
}