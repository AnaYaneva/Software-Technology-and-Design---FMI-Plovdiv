using System;

namespace _1601682032_GUI
{
    [Serializable()]
    public class Data
    {
        public string currency;
        public DateTime date;
        public double exchangeRate;

        public Data(string currency, DateTime date, double exchangeRate)
        {
            this.currency = currency;
            this.date = date;
            this.exchangeRate = exchangeRate;
        }
    }
} 