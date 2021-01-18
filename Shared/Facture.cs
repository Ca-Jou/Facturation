using System;
using System.ComponentModel.DataAnnotations;

namespace Facturation.Shared
{
    public class Facture
    {
        private int _numero;
        private string _client;
        private DateTime _dateEmission;
        private DateTime _dateEcheance;
        private decimal _montantDu;
        private decimal _montantRegle;

        public Facture(int numero, string client, DateTime dateEmission, decimal montantDu, decimal montantRegle)
        {
            this.Numero = numero;
            this.Client = client;
            this.DateEmission = dateEmission;
            this.DateEcheance = dateEmission + TimeSpan.FromDays(30);
            this.MontantDu = montantDu;
            this.MontantRegle = montantRegle;
        }

        public bool estSoldee()
        {
            return MontantRegle == MontantDu;
        }

        public bool estEnRetard()
        {
            if (this.estSoldee())
            {
                return false;
            }
            return DateEcheance < DateTime.Now;
        }

        public void enregistrerPaiement(DateTime datePaiement, decimal montant)
        {
            if (datePaiement < DateEmission)
            {
                throw new ArgumentOutOfRangeException(
                    "Impossible d'enregistrer un paiement anterieur a la date d'emission de la facture.");
            }

            if (MontantDu - MontantRegle < montant)
            {
                throw new ArgumentOutOfRangeException("Impossible de payer plus que le montant facture.");
            }

            MontantRegle += montant;
        }
        
        
        public int? Id { get; set; }
        
        [Required(ErrorMessage = "Le numero de facture est obligatoire.")]
        public int Numero
        {
            get => _numero;
            set => _numero = value;
        }

        [Required(ErrorMessage = "Le nom du client est obligatoire.")]
        public string Client
        {
            get => _client;
            set => _client = value;
        }

        [Required(ErrorMessage = "La date d'emission de la facture est obligatoire.")]
        [DataType(DataType.DateTime)]
        public DateTime DateEmission
        {
            get => _dateEmission;
            set => _dateEmission = value;
        }

        [DataType(DataType.DateTime)]
        public DateTime DateEcheance
        {
            get => _dateEcheance;
            set => _dateEcheance = value;
        }

        [Required(ErrorMessage = "Le montant facture est obligatoire.")]
        public decimal MontantDu
        {
            get => _montantDu;
            set => _montantDu = value;
        }

        public decimal MontantRegle
        {
            get => _montantRegle;
            set => _montantRegle = value;
        }
    }
}