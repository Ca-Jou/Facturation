using System;

namespace Facturation.Shared
{
    public class Aggregate
    {
        private int _mois;
        private decimal _caFacture;
        private decimal _caReel;
        
        public Aggregate()
        {
            this.Mois = 0;
            this.CaFacture = 0;
            this.CaReel = 0;
        }
        public Aggregate(int mois, decimal caFacture, decimal caReel)
        {
            this.Mois = mois;
            this.CaFacture = caFacture;
            this.CaReel = caReel;
        }
        
        public int? Id { get; set; }

        public int Mois
        {
            get => _mois;
            set => _mois = value;
        }

        public decimal CaFacture
        {
            get => _caFacture;
            set => _caFacture = value;
        }

        public decimal CaReel
        {
            get => _caReel;
            set => _caReel = value;
        }
    }
}