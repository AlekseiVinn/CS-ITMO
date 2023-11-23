using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatDay1
{
    class WhatDay
    {
        enum MonthName
        {   January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December    }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите год: ");
                int yearNum = int.Parse(Console.ReadLine());
                bool isLeapYear = (yearNum % 4 == 0) && (yearNum % 100 != 0 || yearNum % 400 == 0);
                /**if (isLeapYear)
                {
                    Console.WriteLine($"{yearNum} - високосный год");
                }
                else
                {
                    Console.WriteLine($"{yearNum} - невискосный год");
                }**/

                int maxDayNum = isLeapYear? 366 : 365;
                /**if (isLeapYear)
                {
                    maxDayNum = 366;
                }
                else
                {
                    maxDayNum = 365;
                }**/

                Console.Write($"Введите порядковый № дня (от 1 до {maxDayNum}): ");
                int dayNum = int.Parse(Console.ReadLine());
                if (dayNum < 1 || dayNum > maxDayNum)
                {
                    throw new System.ArgumentOutOfRangeException("Day out of range");
                }

                int monthNum = 0;

                if (isLeapYear)
                {
                    foreach (int daysInMonth in DaysInLeapMonths)
                    {
                        if (dayNum > daysInMonth)
                        {
                            dayNum -= daysInMonth;
                            monthNum++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    foreach (int daysInMonth in DaysInMonths)
                    {
                        if (dayNum > daysInMonth)
                        {
                            dayNum -= daysInMonth;
                            monthNum++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }

                

                /**
                //if (dayNum <= 31) { //January
                //    goto End;
                //} else {
                //    dayNum -= 31;
                //    monthNum++;
                //}

                //if (dayNum <= 28) { // February
                //    goto End;
                //} else {
                //    dayNum -= 28;
                //    monthNum++;
                //}

                //if (dayNum <= 31) { // March
                //    goto End;
                //} else {
                //    dayNum -= 31;
                //    monthNum++;
                //}

                //if (dayNum <= 30) { // April
                //    goto End;
                //} else {
                //    dayNum -= 30;
                //    monthNum++;
                //}

                //if (dayNum <= 31) { // May
                //    goto End;
                //} else {
                //    dayNum -= 31;
                //    monthNum++;
                //}

                //if (dayNum <= 30) { // June
                //    goto End;
                //} else {
                //    dayNum -= 30;
                //    monthNum++;
                //}

                //if (dayNum <= 31) { // July
                //    goto End;
                //} else {
                //    dayNum -= 31;
                //    monthNum++;
                //}

                //if (dayNum <= 31) { // August
                //    goto End;
                //} else {
                //    dayNum -= 31;
                //    monthNum++;
                //}

                //if (dayNum <= 30) { // September
                //    goto End;
                //} else {
                //    dayNum -= 30;
                //    monthNum++;
                //}

                //if (dayNum <= 31) { // October
                //    goto End;
                //} else {
                //    dayNum -= 31;
                //    monthNum++;
                //}

                //if (dayNum <= 30) { //November
                //    goto End;
                //} else {
                //    dayNum -= 30;
                //    monthNum++;
                //}

                //if (dayNum <= 31) { //December
                //    goto End;
                //} else {
                //    dayNum -= 31;
                //    monthNum++;
                //}
                **/

                /**foreach (int daysInMonth in DaysInMonths)
                {
                    if (dayNum > daysInMonth)
                    {
                        dayNum -= daysInMonth;
                        monthNum++;
                    }
                    else
                    {
                        break;
                    }
                }**/

                //End:
                //string monthName;
                MonthName temp = (MonthName)monthNum;
                string monthName = temp.ToString();


                /**switch (monthNum) {
                    case 0 :
                        monthName = "January"; break;
                    case 1 :
                        monthName = "February"; break;
                    case 2 :
                        monthName = "March"; break;
                    case 3 :
                        monthName = "April"; break;
                    case 4 :
                        monthName = "May"; break;
                    case 5 :
                        monthName = "June"; break;
                    case 6 :
                        monthName = "July"; break;
                    case 7 :
                        monthName = "August"; break;
                    case 8 :
                        monthName = "September"; break;
                    case 9 :
                        monthName = "October"; break;
                    case 10:
                        monthName = "November"; break;
                    case 11:
                        monthName = "December"; break;
                    default:
                        monthName = "Not done yet."; break;
                }**/
                Console.WriteLine($"Day {dayNum} of {monthName}");
            }
            catch (System.Exception caught)
            {
                Console.WriteLine(caught);
            }

          
        }

        static System.Collections.ICollection DaysInMonths = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        static System.Collections.ICollection DaysInLeapMonths = new int[12] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

    }
}
