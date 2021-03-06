﻿using System;
using System.IO;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] YearString = File.ReadAllLines("Files/Year.txt");
            string[] WS1DailyTempMaxString = File.ReadAllLines("Files/WS1_TMax.txt");
            string[] WS1DailyTempMinsString = File.ReadAllLines("Files/WS1_TMin.txt");
            string[] WS1DaysOfFrostString = File.ReadAllLines("Files/WS1_AF.txt");
            string[] WS1TotalRainString = File.ReadAllLines("Files/WS1_Rain.txt");
            string[] WS1TotalSunString = File.ReadAllLines("Files/WS1_Sun.txt");
            string[] WS2DailyTempMaxString = File.ReadAllLines("Files/WS2_TMax.txt");
            string[] WS2DailyTempMinString = File.ReadAllLines("Files/WS2_TMin.txt");
            string[] WS2DaysOfFrostString = File.ReadAllLines("Files/WS2_AF.txt");
            string[] WS2TotalRainString = File.ReadAllLines("Files/WS2_Rain.txt");
            string[] WS2TotalSunString = File.ReadAllLines("Files/WS2_Sun.txt");
            string[] Month = File.ReadAllLines("Files/Month.txt");
            double[] Year = stringToDouble(YearString);
            double[] WS1DailyTempMax = stringToDouble(WS1DailyTempMaxString);
            double[] WS1DailyTempMin = stringToDouble(WS1DailyTempMinsString);
            double[] WS1DaysOfFrost = stringToDouble(WS1DaysOfFrostString);
            double[] WS1TotalRain = stringToDouble(WS1TotalRainString);
            double[] WS1TotalSun = stringToDouble(WS1TotalSunString);
            double[] WS2DailyTempMax = stringToDouble(WS2DailyTempMaxString);
            double[] WS2DailyTempMin = stringToDouble(WS2DailyTempMinString);
            double[] WS2DaysOfFrost = stringToDouble(WS2DaysOfFrostString);
            double[] WS2TotalRain = stringToDouble(WS2TotalRainString);
            double[] WS2TotalSun = stringToDouble(WS2TotalSunString);
            int input = 0;//blank input variable for user input
            bool manager = true;
                                       
            Console.WriteLine("Welcome to my weather data analysis program.");//Inital welcome message. Only seen when program starts
            while (manager == true)//manager to go back if user enters invalid number
            {
                try
                {
                    Console.WriteLine("\nMain Menu:\n\n Please select which function of this program you wish to use.\n\n1 - Search for data by year\n2 - Search for data by month\n3 - Analyse data\n4 - Exit Program");//main menu
                    input = Convert.ToInt32(Console.ReadLine());//store answer in input
                    if (input == 1)//search for data by year
                    {
                        Console.WriteLine("Please select which station's data you wish to use\n1 - Lerwick\n2 - Ross on Wye");//asking user to choose which array to use
                        input = Convert.ToInt32(Console.ReadLine());//store answer in input
                        if (input == 1)//if user enter 1 use var WS1
                        {
                            searchYear(Year, Month, WS1DailyTempMax, WS1DailyTempMin, WS1DaysOfFrost, WS1TotalRain, WS1TotalSun, input);
                            Console.WriteLine("\nAre you finished using the program?\n\n1 - Yes. Close the program. \n2 - No. Go back to the Main Menu.");
                            input = Convert.ToInt32(Console.ReadLine());//store answer in input

                            if(input == 1)
                            {
                                manager = false;
                            }
                        }
                        else if (input == 2)//if user enter 2 use var WS2
                        {
                            searchYear(Year, Month, WS1DailyTempMax, WS1DailyTempMin, WS1DaysOfFrost, WS1TotalRain, WS1TotalSun, input);
                            Console.WriteLine("\nAre you finished using the program?\n\n1 - Yes. Close the program. \n2 - No. Go back to the Main Menu.");
                            input = Convert.ToInt32(Console.ReadLine());//store answer in input

                            if (input == 1)
                            {
                                manager = false;
                            }
                        }
                        else //if user enter anything else handle it
                        {
                            Console.WriteLine("\n|----------------------------------------------------|");
                            Console.WriteLine("|                                                    |");
                            Console.WriteLine("|  An invalid number was entered. Please Try Again   |");
                            Console.WriteLine("|                                                    |");
                            Console.WriteLine("|----------------------------------------------------|");
                        }
                    }
                    else if (input == 2)//search for data by month
                    {
                        Console.WriteLine("Please select which station's data you wish to use\n1 - Lerwick\n2 - Ross on Wye");//asking user to choose which array to use
                        input = Convert.ToInt32(Console.ReadLine());//store answer in input
                        if (input == 1)//if user enter 1 use var WS1
                        {
                            searchMonth(Year, Month, WS1DailyTempMax, WS1DailyTempMin, WS1DaysOfFrost, WS1TotalRain, WS1TotalSun, input);
                            Console.WriteLine("\nAre you finished using the program?\n\n1 - Yes. Close the program. \n2 - No. Go back to the Main Menu.");
                            input = Convert.ToInt32(Console.ReadLine());//store answer in input

                            if (input == 1)
                            {
                                manager = false;
                            }
                        }
                        else if (input == 2)//if user enter 2 use var WS2
                        {
                            searchMonth(Year, Month, WS1DailyTempMax, WS1DailyTempMin, WS1DaysOfFrost, WS1TotalRain, WS1TotalSun, input);
                            Console.WriteLine("\nAre you finished using the program?\n\n1 - Yes. Close the program. \n2 - No. Go back to the Main Menu.");
                            input = Convert.ToInt32(Console.ReadLine());//store answer in input

                            if (input == 1)
                            {
                                manager = false;
                            }
                        }
                        else //if user enter anything else handle it
                        {
                            Console.WriteLine("\n|----------------------------------------------------|");
                            Console.WriteLine("|                                                    |");
                            Console.WriteLine("|  An invalid number was entered. Please Try Again   |");
                            Console.WriteLine("|                                                    |");
                            Console.WriteLine("|----------------------------------------------------|");
                        }
                    }
                    else if (input == 3)//Analyse the data
                    {
                        Console.WriteLine("Please select which station you wish to analyse\n1 - Lerwick\n2 - Ross on Wye");//asking user to choose which array to use
                        input = Convert.ToInt32(Console.ReadLine());//store answer in input
                        if (input == 1) //if user enter 1 use var WS1
                        {
                            outputData(Year, Month, WS1DailyTempMax, WS1DailyTempMin, WS1DaysOfFrost, WS1TotalRain, WS1TotalSun, input);
                            Console.WriteLine("\nAre you finished using the program?\n\n1 - Yes. Close the program. \n2 - No. Go back to the Main Menu.");
                            input = Convert.ToInt32(Console.ReadLine());//store answer in input

                            if (input == 1)
                            {
                                manager = false;
                            }
                        }
                        else if (input == 2) //if user enter 2 use var WS2
                        {
                            outputData(Year, Month, WS2DailyTempMax, WS2DailyTempMin, WS2DaysOfFrost, WS2TotalRain, WS2TotalSun, input);
                            Console.WriteLine("\nAre you finished using the program?\n\n1 - Yes. Close the program. \n2 - No. Go back to the Main Menu.");
                            input = Convert.ToInt32(Console.ReadLine());//store answer in input

                            if (input == 1)
                            {
                                manager = false;
                            }
                        }
                        else //if user enter anything else handle it
                        {
                            Console.WriteLine("\n|----------------------------------------------------|");
                            Console.WriteLine("|                                                    |");
                            Console.WriteLine("|  An invalid number was entered. Please Try Again   |");
                            Console.WriteLine("|                                                    |");
                            Console.WriteLine("|----------------------------------------------------|");
                        }
                    }
                    else if (input == 4)
                    {
                        manager = false;
                    }
                    else
                    {
                        Console.WriteLine("\n|----------------------------------------------------|");
                        Console.WriteLine("|                                                    |");
                        Console.WriteLine("|  An invalid number was entered. Please Try Again   |");
                        Console.WriteLine("|                                                    |");
                        Console.WriteLine("|----------------------------------------------------|");
                    }
                }
                catch (FormatException e)//Catch Format Exeptions
                {
                    Console.WriteLine("\n|---------------------------------------------------------------------------------------|");
                    Console.WriteLine("|                                                                                       |");
                    Console.WriteLine("  ERROR: {0} Please try again", e.Message);
                    Console.WriteLine("|                                                                                       |");
                    Console.WriteLine("|---------------------------------------------------------------------------------------|");
                }
                catch (OverflowException e)//Catch overflow exeption
                {
                    Console.WriteLine("\n|---------------------------------------------------------------------------------------|");
                    Console.WriteLine("|                                                                                       |");
                    Console.WriteLine("  ERROR: {0} Please try again", e.Message);
                    Console.WriteLine("|                                                                                       |");
                    Console.WriteLine("|---------------------------------------------------------------------------------------|");
                }
           }
        }
        public static void Quick_Sort(double[] data, int left, int right)//Quick Sort Algorithm (Sorts into ascending order)
        {
            int i, j;
            double pivot, temp;
            i = left;
            j = right;
            pivot = data[(left + right) / 2];
            do
            {
                while ((data[i] < pivot) && (i < right)) i++;
                while ((pivot < data[j]) && (j > left)) j--;
                if (i <= j)
                {
                    temp = data[i];
                    data[i] = data[j];
                    data[j]= temp;
                    i++;
                    j--;
                }
            } while (i <= j);
            if (left < j) Quick_Sort(data, left, j);
            if (i < right) Quick_Sort(data, i, right);
        }
        public static void outputData(double[] year, string[] month, double[] DailyTempMax, double[] DailyTempMin, double[] DaysOfFrost, double[] TotalRain, double[] TotalSun, int input)//sorts and displays results of user input
        {
            Console.WriteLine("Please select which data you are interested in analysing");
            Console.WriteLine("1 - Year\n2 - Month\n3 - Daily Temp Max\n4 - Daily Temp Min\n5 - Days of Air Frost\n6 - Total Rainfall\n7 - Total Sunshine");//asking user to choose which array to use
            input = Convert.ToInt32(Console.ReadLine());
            if (input == 1)//year
            {
                Console.WriteLine("Please Select which order you want the output\n1 - Ascending\n2 - Descending");//asking user to choose which array to use
                input = Convert.ToInt32(Console.ReadLine());//read line for this
                if (input == 1)
                {
                    Quick_Sort(year, 0, year.Length - 1);
                    for (int i = 0; i <= year.Length - 1; i++)
                    {
                        Console.WriteLine(year[i]);
                    }
                }
                else if (input == 2)
                {
                    Quick_Sort(year, 0, year.Length - 1);
                    Array.Reverse(year);//invert the array to make it descending
                    for (int i = 0; i <= year.Length - 1; i++)
                    {
                        Console.WriteLine(year[i]);
                    }
                }
                else //if user enter anything else handle it
                {
                    Console.WriteLine("\n|----------------------------------------------------|");
                    Console.WriteLine("|                                                    |");
                    Console.WriteLine("|  An invalid number was entered. Please Try Again   |");
                    Console.WriteLine("|                                                    |");
                    Console.WriteLine("|----------------------------------------------------|");
                }
            }
            else if (input == 2)//month
            {
                Console.WriteLine("Please Select which order you want the output\n1 - Ascending\n2 - Descending");//asking user to choose which array to use
                input = Convert.ToInt32(Console.ReadLine());//read line for this
                double[] dbMonth = monthToDouble(month);
                if (input == 1)
                {
                    Quick_Sort(dbMonth, 0, dbMonth.Length - 1);
                    month = doubleToMonth(dbMonth);
                    for (int i = 0; i <= month.Length - 1; i++)
                    {
                        Console.WriteLine(month[i]);
                    }
                }
                else if (input == 2)
                {
                    Quick_Sort(dbMonth, 0, dbMonth.Length - 1);
                    month = doubleToMonth(dbMonth);
                    Array.Reverse(month);//invert the array to make it descending
                    for (int i = 0; i <= month.Length - 1; i++)
                    {
                        Console.WriteLine(month[i]);
                    }
                }
                else //if user enter anything else handle it
                {
                    Console.WriteLine("\n|----------------------------------------------------|");
                    Console.WriteLine("|                                                    |");
                    Console.WriteLine("|  An invalid number was entered. Please Try Again   |");
                    Console.WriteLine("|                                                    |");
                    Console.WriteLine("|----------------------------------------------------|");
                }
            }
            else if (input == 3)//DailyTempMax
            {
                Console.WriteLine("Please Select which order you want the output\n1 - Ascending\n2 - Descending");//asking user to choose which array to use
                input = Convert.ToInt32(Console.ReadLine());//read line for this
                if (input == 1)
                {
                    Quick_Sort(DailyTempMax, 0, DailyTempMax.Length - 1);
                    for (int i = 0; i <= DailyTempMax.Length - 1; i++)
                    {
                        Console.WriteLine(DailyTempMax[i]);
                    }
                }
                else if (input == 2)
                {
                    Array.Reverse(DailyTempMax);//invert the array to make it descending
                    Quick_Sort(DailyTempMax, 0, DailyTempMax.Length - 1);
                    for (int i = 0; i <= DailyTempMax.Length - 1; i++)
                    {
                        Console.WriteLine(DailyTempMax[i]);
                    }
                }
                else //if user enter anything else handle it
                {
                    Console.WriteLine("\n|----------------------------------------------------|");
                    Console.WriteLine("|                                                    |");
                    Console.WriteLine("|  An invalid number was entered. Please Try Again   |");
                    Console.WriteLine("|                                                    |");
                    Console.WriteLine("|----------------------------------------------------|");
                }
            }
            else if (input == 4)//DailyTempMin
            {
                Console.WriteLine("Please Select which order you want the output\n1 - Ascending\n2 - Descending");//asking user to choose which array to use
                input = Convert.ToInt32(Console.ReadLine());//read line for this
                if (input == 1)
                {
                    Quick_Sort(DailyTempMin, 0, DailyTempMin.Length - 1);
                    for (int i = 0; i <= DailyTempMin.Length - 1; i++)
                    {
                        Console.WriteLine(DailyTempMin[i]);
                    }
                }
                else if (input == 2)
                {
                    Quick_Sort(DailyTempMin, 0, DailyTempMin.Length - 1);
                    Array.Reverse(DailyTempMin);//invert the array to make it descending
                    for (int i = 0; i <= DailyTempMin.Length - 1; i++)
                    {
                        Console.WriteLine(DailyTempMin[i]);
                    }
                }
                else //if user enter anything else handle it
                {
                    Console.WriteLine("\n|----------------------------------------------------|");
                    Console.WriteLine("|                                                    |");
                    Console.WriteLine("|  An invalid number was entered. Please Try Again   |");
                    Console.WriteLine("|                                                    |");
                    Console.WriteLine("|----------------------------------------------------|");
                }
            }
            else if (input == 5)//DaysOfFrost
            {
                Console.WriteLine("Please Select which order you want the output\n1 - Ascending\n2 - Descending");//asking user to choose which array to use
                input = Convert.ToInt32(Console.ReadLine());//read line for this
                if (input == 1)
                {
                    Quick_Sort(DaysOfFrost, 0, DaysOfFrost.Length - 1);
                    for (int i = 0; i <= DaysOfFrost.Length - 1; i++)
                    {
                        Console.WriteLine(DaysOfFrost[i]);
                    }
                }
                else if (input == 2)
                {
                    Quick_Sort(DaysOfFrost, 0, DaysOfFrost.Length - 1);
                    Array.Reverse(DaysOfFrost);//invert the array to make it descending
                    for (int i = 0; i <= DaysOfFrost.Length - 1; i++)
                    {
                        Console.WriteLine(DaysOfFrost[i]);
                    }
                }
                else //if user enter anything else handle it
                {
                    Console.WriteLine("\n|----------------------------------------------------|");
                    Console.WriteLine("|                                                    |");
                    Console.WriteLine("|  An invalid number was entered. Please Try Again   |");
                    Console.WriteLine("|                                                    |");
                    Console.WriteLine("|----------------------------------------------------|");
                }
            }
            else if (input == 6)//TotalRain
            {
                Console.WriteLine("Please Select which order you want the output\n1 - Ascending\n2 - Descending");//asking user to choose which array to use
                input = Convert.ToInt32(Console.ReadLine());//read line for this
                if (input == 1)
                {
                    Quick_Sort(TotalRain, 0, TotalRain.Length - 1);
                    for (int i = 0; i <= TotalRain.Length - 1; i++)
                    {
                        Console.WriteLine(TotalRain[i]);
                    }
                }
                else if (input == 2)
                {
                    Quick_Sort(TotalRain, 0, TotalRain.Length - 1);
                    Array.Reverse(TotalRain);//invert the array to make it descending
                    for (int i = 0; i <= TotalRain.Length - 1; i++)
                    {
                        Console.WriteLine(TotalRain[i]);
                    }
                }
                else //if user enter anything else handle it
                {
                    Console.WriteLine("\n|----------------------------------------------------|");
                    Console.WriteLine("|                                                    |");
                    Console.WriteLine("|  An invalid number was entered. Please Try Again   |");
                    Console.WriteLine("|                                                    |");
                    Console.WriteLine("|----------------------------------------------------|");
                }
            }
            else if (input == 7)//TotalSun
            {
                Console.WriteLine("Please Select which order you want the output\n1 - Ascending\n2 - Descending");//asking user to choose which array to use
                input = Convert.ToInt32(Console.ReadLine());//read line for this
                if (input == 1)
                {
                    Quick_Sort(TotalSun, 0, TotalSun.Length - 1);
                    for (int i = 0; i <= TotalSun.Length - 1; i++)
                    {
                        Console.WriteLine(TotalSun[i]);
                    }
                }
                else if (input == 2)
                {
                    Quick_Sort(TotalSun, 0, TotalSun.Length - 1);
                    Array.Reverse(TotalSun);//invert the array to make it descending
                    for (int i = 0; i <= TotalSun.Length - 1; i++)
                    {
                        Console.WriteLine(TotalSun[i]);
                    }
                }
                else //if user enter anything else handle it
                {
                    Console.WriteLine("\n|----------------------------------------------------|");
                    Console.WriteLine("|                                                    |");
                    Console.WriteLine("|  An invalid number was entered. Please Try Again   |");
                    Console.WriteLine("|                                                    |");
                    Console.WriteLine("|----------------------------------------------------|");
                }
            }
            else
            {
                Console.WriteLine("\n|----------------------------------------------------|");
                Console.WriteLine("|                                                    |");
                Console.WriteLine("|  An invalid number was entered. Please Try Again   |");
                Console.WriteLine("|                                                    |");
                Console.WriteLine("|----------------------------------------------------|");
            }
        }
        public static void searchYear(double[] year, string[] month, double[] DailyTempMax, double[] DailyTempMin, double[] DaysOfFrost, double[] TotalRain, double[] TotalSun, int input)
        {
            Console.WriteLine("\nPlease enter the year you wish to search for.");//asking user what year to search for
            input = Convert.ToInt32(Console.ReadLine());//store answer input

            int counter = 0;

            for (int i = 0; i<year.Length; i++)//run the search once to find the required size for the storage array

            if (year[i] == input)
            {
                counter++;
            }
            if (counter == 0)
            {
                Console.WriteLine("No Results Found");
            }
            else
            {
                int[] Matched = new int[counter]; //initialize the array with the required size
                counter = 0;//reset the counter
                        
                for (int i = 0; i<year.Length; i++)//run the search again to populate the storage array

                if (year[i] == input)
                {
                    Matched[counter] = i;
                    counter++;
                }

                Console.Write("\n\nYear   ");
                Console.Write("Month  ");
                Console.Write("TempMax   ");
                Console.Write("TempMin   ");
                Console.Write("Frost   ");
                Console.Write("Rain   ");
                Console.Write("Sun   ");
                Console.WriteLine("\n");

                for (int i = 0; i<Matched.Length; i++)//loop through the storage array and output data from all arrays
                {
                    int result = Matched[i];

                    Console.Write("{0}   ", year[result]);
                    Console.Write("{0}   ", month[result]);
                    Console.Write("{0}   ", DailyTempMax[result]);
                    Console.Write("{0}   ", DailyTempMin[result]);
                    Console.Write("{0}   ", DaysOfFrost[result]);
                    Console.Write("{0}   ", TotalRain[result]);
                    Console.Write("{0}   ", TotalSun[result]);
                    Console.WriteLine();
                }
            }
            
        }
        public static void searchMonth(double[] year, string[] month, double[] DailyTempMax, double[] DailyTempMin, double[] DaysOfFrost, double[] TotalRain, double[] TotalSun, int input)
        {
            Console.WriteLine("\nPlease enter the month value you wish to search for.");
            Console.WriteLine("\n\n1 - January\n2 - February\n3 - March\n4 - April\n5 - May\n6 - June\n7 - July\n8 - August\n9 - September\n10 - October\n11 - November\n12 - December");
            input = Convert.ToInt32(Console.ReadLine());
            if (new[] { 1, 2, 3, 4, 5 ,6, 7, 8, 9 ,10 , 11, 12 }.Contains(input))
            {
                double[] dbMonth = monthToDouble(month);//convert month to double
                int counter = 0;

                for (int i = 0; i < month.Length; i++)//run the search once to find the required size for the storage array
                if (dbMonth[i] == input)
                {
                    counter++;
                }
                if (counter == 0)
                {
                    Console.WriteLine("No Results Found");
                }
                else
                {
                    int[] Matched = new int[counter]; //initialize the array with the required size
                    counter = 0;//reset the counter

                    for (int i = 0; i < month.Length; i++)//run the search again to populate the storage array

                        if (dbMonth[i] == input)
                        {
                            Matched[counter] = i;
                            counter++;
                        }
            
                    Console.Write("\n\nYear   ");
                    Console.Write("Month  ");
                    Console.Write("TempMax   ");
                    Console.Write("TempMin   ");
                    Console.Write("Frost   ");
                    Console.Write("Rain   ");
                    Console.Write("Sun   ");
                    Console.WriteLine("\n");
            
                    for (int i = 0; i < Matched.Length; i++)//loop through the storage array and output data from all arrays
                    {
                        int result = Matched[i];

                        Console.Write("{0}   ", year[result]);
                        Console.Write("{0}   ", month[result]);
                        Console.Write("{0}   ", DailyTempMax[result]);
                        Console.Write("{0}   ", DailyTempMin[result]);
                        Console.Write("{0}   ", DaysOfFrost[result]);
                        Console.Write("{0}   ", TotalRain[result]);
                        Console.Write("{0}   ", TotalSun[result]);
                        Console.WriteLine();
                    }
                }
            }
            else
            {
                Console.WriteLine("\n|----------------------------------------------------|");
                Console.WriteLine("|                                                    |");
                Console.WriteLine("|  An invalid number was entered. Please Try Again   |");
                Console.WriteLine("|                                                    |");
                Console.WriteLine("|----------------------------------------------------|");
            }
        }
        public static double[] stringToDouble(string[] data)//converts string array to double
        {
            double[] temp = new double[data.Length];

            for (int i = 0; i < data.Length; i++)//converts string to double
            {
                Double.TryParse(data[i], out temp[i]);
            }

            return temp;
        }
        public static double[] monthToDouble(string[] data)//converts the month array from string to number values as double
        {
            double[] temp = new double[data.Length];
            
             for (int i = 0; i <= data.Length - 1; i++)
            {
                switch(data[i])
                {
                    case "January":
                        temp[i] = 1;
                        break;
                    case "February":
                        temp[i] = 2;
                        break;
                    case "March":
                        temp[i] = 3;
                        break;
                    case "April":
                        temp[i] = 4;
                        break;
                    case "May":
                        temp[i] = 5;
                        break;
                    case "June":
                        temp[i] = 6;
                        break;
                    case "July":
                        temp[i] = 7;
                        break;
                    case "August":
                        temp[i] = 8;
                        break;
                    case "September":
                        temp[i] = 9;
                        break;
                    case "October":
                        temp[i] = 10;
                        break;
                    case "November":
                        temp[i] = 11;
                        break;
                    case "December":
                        temp[i] = 12;
                        break;
                    default:
                        break;
                }
            }
            return temp;
        }
        public static string[] doubleToMonth(double[] data)//converts the month array back from number values to month values as string
        {
            string[] temp = new string[data.Length];

            for (int i = 0; i <= data.Length - 1; i++)
            {
                if (data[i] == 1)
                    temp[i] = "January";
                else if (data[i] == 2)
                    temp[i] = "February";
                else if (data[i] == 3)
                    temp[i] = "March";
                else if (data[i] == 4)
                    temp[i] = "April";
                else if (data[i] == 5)
                    temp[i] = "May";
                else if (data[i] == 6)
                    temp[i] = "June";
                else if (data[i] == 7)
                    temp[i] = "July";
                else if (data[i] == 8)
                    temp[i] = "August";
                else if (data[i] == 9)
                    temp[i] = "September";
                else if (data[i] == 10)
                    temp[i] = "October";
                else if (data[i] == 11)
                    temp[i] = "November";
                else if (data[i] == 12)
                  temp[i] = "December";
                else
                    temp[i] = "Value not found";
            }
            return temp;
        }
    }
}