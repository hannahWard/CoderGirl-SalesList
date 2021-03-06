﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace CoderGirl_SalesList
{
    public class Program
    {
        private string filePath = @"1000 Sales Records.csv";

        public static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
            Console.ReadLine();
        }

        private void Run()
        {
            


            //List<SalesRecord> salesRecords = GetSalesRecordsFromFileData();
            //int countNorthAmerica = GetCountForNorthAmerica(salesRecords);
            //Console.WriteLine(countNorthAmerica);
        }

        //private int GetCountForNorthAmerica(List<SalesRecord> salesRecords)
        //{
        //    int count = 0;
        //    foreach (SalesRecord record in salesRecords)
        //    {
        //        if (record.Region == "North America")
        //        {
        //            count++;
        //        }
        //    }
        //    int[] something = new int[5];
        //    something.TakeLast(4);

        //    List<string> stringList = new List<string>();
        //    stringList.Select(item => int.Parse(item)).ToList();
        //    return count;
        //}

        private List<SalesRecord> GetSalesRecordsFromCsvFile()
        {
            List<SalesRecord> salesRecords = new List<SalesRecord>();
            bool isFirstRow = true;
            foreach (string line in File.ReadLines(@"1000 Sales Records.csv"))
            {
                if (isFirstRow)
                {
                    isFirstRow = false;
                    continue;
                }

                SalesRecord salesRecord = CreateSalesRecord(line);
                salesRecords.Add(salesRecord);
            }
            return salesRecords;
        }

        private SalesRecord CreateSalesRecord(string line)
        {

            SalesRecord salesRecord = new SalesRecord();
            string[] properties = line.Split(",");
            salesRecord.Region = properties[0];
            salesRecord.Country = properties[1];
            salesRecord.ItemType = properties[2];
            salesRecord.SalesChannel = properties[3];
            salesRecord.OrderPriority = properties[4];
            salesRecord.OrderDate = DateTime.Parse(properties[5]);
            salesRecord.OrderID = decimal.Parse(properties[6]);
            salesRecord.ShipDate = DateTime.Parse(properties[7]);
            salesRecord.UnitsSold = int.Parse(properties[8]);
            salesRecord.UnitPrice = decimal.Parse(properties[9]);
            salesRecord.UnitCost = decimal.Parse(properties[10]);
            salesRecord.TotalRevenue = decimal.Parse(properties[11]);
            salesRecord.TotalCost = decimal.Parse(properties[12]);
            salesRecord.TotalProfit = decimal.Parse(properties[13]);


            return salesRecord;
        }
    }
}