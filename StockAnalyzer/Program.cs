using System;
using System.Globalization;
using System.IO;
using System.Linq;

namespace StockAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            ////var lines = File.ReadAllLines(@"StockData.csv");
            ////foreach(var line in lines.Skip(1))
            ////{
            ////    var segments = line.Split(',');
            ////    var tradedate = DateTime.Parse(segments[1], CultureInfo.GetCultureInfo("en-GB"));
            ////    Console.WriteLine(tradedate.ToLongDateString());
            ////}

            //var now = DateTime.Now;
            //TimeZoneInfo syndneytimezone = TimeZoneInfo.FindSystemTimeZoneById("E. Australia Standard Time");
            //var sydneytime = TimeZoneInfo.ConvertTime(now, syndneytimezone);
            //Console.WriteLine(now);
            //Console.WriteLine(syndneytimezone);
            //Console.WriteLine(sydneytime);
             String location =null;
             DateTime time;

           
                Console.WriteLine(location ?? "location is null");
                Console.WriteLine(time == null ? "time is null" : time.ToString());
                Console.ReadLine();



        }
    }
}
