using System;

namespace Facturation.Shared
{
    public class Aggregate
    {
        private int _mois;
        private float _caFacture;
        private float _caReel;

        public Aggregate()
        {
            this.Mois = 0;
            this.CaFacture = 0;
            this.CaReel = 0;
        }
        public Aggregate(int mois, float caFacture, float caReel)
        {
            this.Mois = mois;
            this.CaFacture = caFacture;
            this.CaReel = caReel;
        }

        public int Mois
        {
            get => _mois;
            set => _mois = value;
        }

        public float CaFacture
        {
            get => _caFacture;
            set => _caFacture = value;
        }

        public float CaReel
        {
            get => _caReel;
            set => _caReel = value;
        }
    }
}