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
        
        public IEnumerable<Aggregate> Aggregats =>
            db.Query<Aggregate>("SELECT MONTH(DateEcheance) as Mois, SUM(MontantDu) as CaFacture, SUM(MontantRegle) as CaReel FROM factures GROUP BY Mois ORDER BY Mois ASC");

        public decimal CAfacture =>
            db.QuerySingle<decimal>("SELECT SUM(MontantDu) FROM factures");
        public decimal TresoEnAttente =>
            db.QuerySingle<decimal>("SELECT SUM(MontantDu) - SUM(MontantRegle) FROM factures");

        public void AddFacture(Facture facture)
        {
            var sql =
                "INSERT INTO factures (Numero, Client, DateEmission, DateEcheance, MontantDu, MontantRegle) VALUES (@Numero, @Client, @DateEmission, @DateEcheance, @MontantDu, @MontantRegle);" +
                "SELECT LAST_INSERT_ID() FROM factures";
            var returnId = db.ExecuteScalar<int>(sql, facture);
        }

        public void UpdateFacture(Facture facture)
        {
            var sql = "UPDATE factures SET MontantRegle = @MontantRegle WHERE Id = @Id";
            db.Execute(sql, facture);
        }
    }
}