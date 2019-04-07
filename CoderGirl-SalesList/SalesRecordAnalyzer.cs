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
            bool results = salesRecords.Any(record => record.OrderDate > cutoffDate);

            return results;
        }

        public List<string> GetCountries(List<SalesRecord> salesRecords)
        {
            return salesRecords.Select(p => p.Country).Distinct().ToList();
            //List<string> uniqueCountries = findCountries.ForEach(p => )
            //string country = "";
            //foreach (SalesRecord item in findCountries)
            //{
            //    country = item.ToString();
            //    uniqueCountries.Add(country);
            //}
            
            
        }

        public int GetCountryCount(List<SalesRecord> salesRecords)
        {
            List<string> findCountries = salesRecords.Select(p => p.Country).Distinct().ToList();

            return findCountries.Count();

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
