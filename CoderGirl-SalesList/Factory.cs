using System;
using System.Collections.Generic;
using System.Text;

namespace CoderGirl_SalesList
{
    public class Factory
    {
        public ISalesRecordAdapter SalesRecordAdapter { get; private set; }
        public ISalesRecordAnalyzer SalesRecordAnalyzer { get; private set; }

        public Factory()
        {
            

            this.SalesRecordAdapter = new SalesRecordAdapter();

            this.SalesRecordAnalyzer = new SalesRecordAnalyzer();


            //TODO: Add specific implementation classes
            //this.SalesRecordAdapter = new ??
            //this.SalesRecordAnalyzer = new Tinker();
        }
    }
}
