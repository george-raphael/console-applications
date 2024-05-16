//Empty date time: DateTime dt = new DateTime();

using System.Globalization;

DateTime dob = new DateTime();
Console.WriteLine(dob);

//Create a datetime from date and time 
DateTime dob2 = new DateTime(2000,5,25);
Console.WriteLine(dob2);
DateTime dob3 = new DateTime(2000,5,25,15,30,10);
Console.WriteLine(dob3);
Console.WriteLine(dob3.DayOfWeek);
Console.WriteLine(dob3.DayOfYear);
Console.WriteLine(dob3.TimeOfDay);
Console.WriteLine(dob3.Kind);

//Current datetime
Console.WriteLine("*******Current Time*******");
Console.WriteLine(DateTime.Now);

//Create date from user input string - Tell user about format

Console.WriteLine("*******Create Date from user input string*******");
var date = DateTime.Parse("12 January 2022 02:20 PM");
Console.WriteLine(date);

//- Format date d.ToString(”dd / MM / yyyy”)
Console.WriteLine(date.ToString("ddd d MMM yyyy"));

//Adding to date
Console.WriteLine("******Add Date*****");
var dateNow = DateTime.Now;
dateNow = dateNow.AddDays(3);
Console.WriteLine(dateNow);

//UTC
Console.WriteLine("******Coordinated Universal Time******");
var utc = DateTime.UtcNow; 
Console.WriteLine(utc);

//Display time zone infor
Console.WriteLine(TimeZoneInfo.Local.GetUtcOffset(utc));
Console.WriteLine(utc.ToLocalTime()); //convert utc to local time.

//DateOnly
Console.WriteLine("******Date Only******");
var dateOnly = new DateOnly(1999, 5, 1);
Console.WriteLine(dateOnly);
Console.WriteLine(DateOnly.FromDateTime(utc));

//TimeOnly
Console.WriteLine("******Time Only******");
var timeOnly = new TimeOnly(11,25);
Console.WriteLine(timeOnly);
Console.WriteLine($"{timeOnly:hh-mm-tt}");
int salary = 100000;
CultureInfo tanzaniaCulture = new CultureInfo("sw-TZ");
Console.WriteLine($"{salary.ToString("C",tanzaniaCulture)}");

//Date & Time Comparison
var now = DateTime.Now;
var tommorrow = now.AddDays(1);
var yesterday = now.AddDays(-1);

Console.WriteLine(now);
Console.WriteLine(tommorrow);
Console.WriteLine(yesterday);

Console.WriteLine(now > tommorrow);
Console.WriteLine(now > yesterday);

//Parse date input from User
var userDob = new DateOnly();
Console.WriteLine("Please enter your date of birth:(y/d/m) ");
userDob = DateOnly.ParseExact(Console.ReadLine(), "yyyy/dd/MM");

Console.WriteLine(userDob);


