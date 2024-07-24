using System;

namespace Main
{
    internal class Program
    {

        static void Main(string[] args)
        {

            //number of 100-nanosecond intervals that have elapsed
            //since January 1, 0001, at 00:00:00.000 in the Gregorian calendar. 

            //DateTime dt = new DateTime();
            //Console.WriteLine(DateTime.MinValue.Ticks);  //min value of ticks
            //Console.WriteLine(DateTime.MaxValue.Ticks); // max value of ticks
            //Console.WriteLine(DateTime.Now.Ticks); // max value of ticks


            //DateTime currentDateTime = DateTime.Now;  //returns current date and time
            //DateTime todaysDate = DateTime.Today; // returns today's date
            //DateTime currentDateTimeUTC = DateTime.UtcNow;// returns current UTC date and time
            //DateTime maxDateTimeValue = DateTime.MaxValue; // returns max value of DateTime
            //DateTime minDateTimeValue = DateTime.MinValue; // returns min value of DateTime

            //Console.WriteLine("currentDateTime: " + currentDateTime);
            //Console.WriteLine("Today: " + todaysDate);
            //Console.WriteLine("currentDateTimeUTC: " + currentDateTimeUTC);
            //Console.WriteLine("minDateTimeValue: " + minDateTimeValue);
            //Console.WriteLine("maxDateTimeValue: " + maxDateTimeValue);

            //DateTime dt = new DateTime(2023, 2, 21);

            //// Hours, Minutes, Seconds
            //TimeSpan ts = new TimeSpan(49, 25, 34);
            //Console.WriteLine(ts);
            //Console.WriteLine(ts.Days);
            //Console.WriteLine(ts.Hours);
            //Console.WriteLine(ts.Minutes);
            //Console.WriteLine(ts.Seconds);

            ////this will add time span to the date.
            //DateTime newDate = dt.Add(ts);

            //Console.WriteLine(newDate);


            //DateTime dt1 = new DateTime(2023, 2, 21);
            //DateTime dt2 = new DateTime(2023, 2, 28);
            //TimeSpan result = dt2.Subtract(dt1);

            //Console.WriteLine(result.Days);

            //DateTime dt1 = new DateTime(2015, 12, 20);
            //DateTime dt2 = new DateTime(2016, 12, 31, 5, 10, 20);
            //TimeSpan time = new TimeSpan(10, 5, 25, 50);

            //Console.WriteLine(dt2 + time); // 1/10/2017 10:36:10 AM
            //Console.WriteLine(dt2 - dt1); //377.05:10:20
            //Console.WriteLine(dt1 == dt2); //False
            //Console.WriteLine(dt1 != dt2); //True
            //Console.WriteLine(dt1 > dt2); //False
            //Console.WriteLine(dt1 < dt2); //True
            //Console.WriteLine(dt1 >= dt2); //False
            //Console.WriteLine(dt1 <= dt2);//True

            var str = "6/12/2023";
            DateTime dt;

            var isValidDate = DateTime.TryParse(str, out dt);

            if (isValidDate)
                Console.WriteLine(dt);
            else
                Console.WriteLine($"{str} is not a valid date string");

            //invalid string date
            var str2 = "6/65/2023";
            DateTime dt2;

            var isValidDate2 = DateTime.TryParse(str2, out dt2);

            if (isValidDate2)
                Console.WriteLine(dt2);
            else
                Console.WriteLine($"{str2} is not a valid date string");




            Console.ReadKey();

        }
    }
}

