using System;
using System.Collections.Generic;

namespace _1601682032_GUI
{
    public class Vars
    {
        public static List<Data> data = new List<Data>();
        public static string fileNameSerialized = "serData.txt";
        public static string fileNameUnserialized = "data.txt";

        public static Data curentData = new Data("", new DateTime(), 0);
        public static Data selectedData = new Data("", new DateTime(), 0);
        //public static Data editedData = new Data("", new DateTime(), 0);

        public static string fileNameCurrecyList = "currencyList.txt";//
        public static List<string> currencyList = new List<string> { };//
    }  
}