using System;
using System.Collections.Generic;
using Facturation.Shared;
using MySql.Data.MySqlClient;
using Dapper;

namespace Facturation.Server.Models
{
    public class BusinessDataRepository : IBusinessData, IDisposable
    {
        private MySqlConnection db;

        public BusinessDataRepository(string connectionString)
        {
            db = new MySqlConnection(connectionString);
        }
        
        public void Dispose()
        {
            db.Dispose();
        }

        public IEnumerable<Facture> Factures =>
            db.Query<Facture>("SELECT * FROM factures");
        
        //TODO requete SQL
        public IEnumerable<Aggregate> Aggregats { get; }

        public decimal CAfacture =>
            db.QuerySingle<decimal>("SELECT SUM(MontantDu) FROM factures");
        public decimal TresoEnAttente =>
            db.QuerySingle<decimal>("SELECT SUM(MontantDu) - SUM(MontantRegle) FROM factures");

    }
}