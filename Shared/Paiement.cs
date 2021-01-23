using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Facturation.Shared
{
    public class Paiement
    {
        private Facture _facture;
        private DateTime _date;
        private decimal _montant;

        public Paiement()
        {
            
        }

        [Required(ErrorMessage = "Merci de selectionner la facture correspondant au paiement.")]
        public Facture Facture
        {
            get => _facture;
            set => _facture = value;
        }

        [Required(ErrorMessage = "La date de paiement est obligatoire.")]
        [DataType(DataType.DateTime)]
        public DateTime Date
        {
            get => _date;
            set => _date = value;
        }

        [Required(ErrorMessage = "Le montant est obligatoire.")]
        [DataType(DataType.Currency)]
        public decimal Montant
        {
            get => _montant;
            set => _montant = value;
        }
    }
}