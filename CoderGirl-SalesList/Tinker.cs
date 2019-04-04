﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoderGirl_SalesList
{
    class Tinker : ISalesRecordAnalyzer
    {
        public bool AreOrderDatesBefore(DateTime cutoffDate, List<SalesRecord> salesRecords)
        {
            throw new NotImplementedException();
        }

        public List<string> GetCountries(List<SalesRecord> salesRecords)
        {
            List<string> countries = salesRecords.Select(record => record.Country).Distinct().ToList();
            return countries;
        }

        public int GetCountryCount(List<SalesRecord> salesRecords)
        {
            throw new NotImplementedException();
        }

        public decimal GetMaxProfit(List<SalesRecord> salesRecords)
        {
            throw new NotImplementedException();
        }

        public decimal GetTotalRevenue(List<SalesRecord> salesRecords)
        {
            throw new NotImplementedException();
        }

        public List<SalesRecord> OrderByShipDate(List<SalesRecord> salesRecords)
        {
            throw new NotImplementedException();
        }

        public List<SalesRecord> OrderByUnitsSoldDescending(List<SalesRecord> salesRecords)
        {
            throw new NotImplementedException();
        }
    }
}