﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CoderGirl_SalesList
{
    interface ISalesRecordRepository
    {
        List<SalesRecord> SalesRecords { get; set; }

        void AddSalesRecord(SalesRecord salesRecord);

        void DeleteSalesRecord(SalesRecord salesRecord);
    }
}
