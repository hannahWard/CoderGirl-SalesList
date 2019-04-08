using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoderGirl_SalesList
{
    class SalesRecordAnalyzer : ISalesRecordAnalyzer
    {
        public bool AreOrderDatesBefore(DateTime cutoffDate, List<SalesRecord> salesRecords)
        {
            return salesRecords.Any(record => record.OrderDate < cutoffDate);

        }

        public List<string> GetCountries(List<SalesRecord> salesRecords)
        {
            return salesRecords.Select(p => p.Country).Distinct().ToList();
          
        }

        public int GetCountryCount(List<SalesRecord> salesRecords)
        {
            List<string> findCountries = salesRecords.Select(p => p.Country).Distinct().ToList();

            return findCountries.Count() - 1;

        }

        public decimal GetMaxProfit(List<SalesRecord> salesRecords)
        {

            return salesRecords.Max(p => p.TotalProfit);

            
        }

        public decimal GetTotalRevenue(List<SalesRecord> salesRecords)
        {

            return salesRecords.Sum(p => p.TotalRevenue);
            
        }

        public List<SalesRecord> OrderByShipDate(List<SalesRecord> salesRecords)
        {

            return salesRecords.OrderBy(p => p.ShipDate).ToList();

            
        }

        public List<SalesRecord> OrderByUnitsSoldDescending(List<SalesRecord> salesRecords)
        {

            return salesRecords.OrderByDescending(p => p.UnitsSold).ToList();

            
        }
    }
}
