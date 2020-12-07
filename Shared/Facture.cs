using System;

namespace Facturation.Shared
{
    public class Facture
    {
        private int _numero;
        private string _client;
        private DateTime _dateEmission;
        private DateTime _dateEcheance;
        private float _montantDu;
        private float _montantRegle;

        public Facture(int numero, string client, DateTime dateEmission, DateTime dateEcheance, float montantDu, float montantRegle)
        {
            this.Numero = numero;
            this.Client = client;
            this.DateEmission = dateEmission;
            this.DateEcheance = dateEcheance;
            this.MontantDu = montantDu;
            this.MontantRegle = montantRegle;
        }

        public int Numero
        {
            get => _numero;
            set => _numero = value;
        }

        public string Client
        {
            get => _client;
            set => _client = value;
        }

        public DateTime DateEmission
        {
            get => _dateEmission;
            set => _dateEmission = value;
        }

        public DateTime DateEcheance
        {
            get => _dateEcheance;
            set => _dateEcheance = value;
        }

        public float MontantDu
        {
            get => _montantDu;
            set => _montantDu = value;
        }

        public float MontantRegle
        {
            get => _montantRegle;
            set => _montantRegle = value;
        }
    }
}