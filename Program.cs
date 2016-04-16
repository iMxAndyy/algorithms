using System;
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
            double[] Year = new double[YearString.Length];
            double[] WS1DailyTempMax = new double[WS1DailyTempMaxString.Length];
            double[] WS1DailyTempMin = new double[WS1DailyTempMinsString.Length];
            double[] WS1DaysOfFrost = new double[WS1DaysOfFrostString.Length];
            double[] WS1TotalRain = new double[WS1TotalRainString.Length];
            double[] WS1TotalSun = new double[WS1TotalSunString.Length];
            double[] WS2DailyTempMax = new double[WS2DailyTempMaxString.Length];
            double[] WS2DailyTempMin = new double[WS2DailyTempMinString.Length];
            double[] WS2DaysOfFrost = new double[WS2DaysOfFrostString.Length];
            double[] WS2TotalRain = new double[WS2TotalRainString.Length];
            double[] WS2TotalSun = new double[WS2TotalSunString.Length];
            int input;//blank input variable for user input
            bool manager = true;

            for (int i = 0; i < YearString.Length; i++)//converts string to double
            {
                Double.TryParse(YearString[i], out Year[i]);
            }
            for (int i = 0; i < WS1DailyTempMaxString.Length; i++)
            {
                Double.TryParse(WS1DailyTempMaxString[i], out WS1DailyTempMax[i]);
            }
            for (int i = 0; i < WS1DailyTempMinsString.Length; i++)
            {
                Double.TryParse(WS1DailyTempMinsString[i], out WS1DailyTempMin[i]);
            }
            for (int i = 0; i < WS1DaysOfFrostString.Length; i++)
            {
                Double.TryParse(WS1DaysOfFrostString[i], out WS1DaysOfFrost[i]);
            }
            for (int i = 0; i < WS1TotalRainString.Length; i++)
            {
                Double.TryParse(WS1TotalRainString[i], out WS1TotalRain[i]);
            }
            for (int i = 0; i < WS1TotalSunString.Length; i++)
            {
                Double.TryParse(WS1TotalSunString[i], out WS1TotalSun[i]);
            }
            for (int i = 0; i < WS2DailyTempMaxString.Length; i++)
            {
                Double.TryParse(WS2DailyTempMaxString[i], out WS2DailyTempMax[i]);
            }
            for (int i = 0; i < WS2DailyTempMinString.Length; i++)
            {
                Double.TryParse(WS2DailyTempMinString[i], out WS2DailyTempMin[i]);
            }
            for (int i = 0; i < WS2DaysOfFrostString.Length; i++)
            {
                Double.TryParse(WS2DaysOfFrostString[i], out WS2DaysOfFrost[i]);
            }
            for (int i = 0; i < WS2TotalRainString.Length; i++)
            {
                Double.TryParse(WS2TotalRainString[i], out WS2TotalRain[i]);
            }
            for (int i = 0; i < WS2TotalSunString.Length; i++)
            {
                Double.TryParse(WS2TotalSunString[i], out WS2TotalSun[i]);
            }


            Console.WriteLine("Welcome to my weather data analysis program.");//Inital welcome message. Only seen when program starts
            while (manager == true)//manager to go back if user enters invalid number
            {
                try
                {
                    Console.WriteLine("\nMain Menu:\n\n Please select which function of this program you wish to use.\n\n1 - Search for data by year\n2 - Search for data by month\n3 - Analyse data\n4 - Exit Program");
                    input = Convert.ToInt32(Console.ReadLine());//Main menu selection
                    if (input == 1)//search for data by year
                    { 
                        Console.WriteLine("\nPlease enter the year you wish to search for.");
                        input = Convert.ToInt32(Console.ReadLine());




                        //search for data by year code goes here





                        manager = false;
                    }
                    else if (input == 2)//search for data by month
                    {
                        Console.WriteLine("\nPlease enter the month value you wish to search for.");
                        Console.WriteLine("\n\n1 - January\n2 - February\n3 - March\n4 - April\n5 - May\n6 - June\n7 - July\n8 - August\n9 - September\n10 - October\n11 - November\n12 - December");
                        input = Convert.ToInt32(Console.ReadLine());



                            //Search for data by month code goes here






                        manager = false;
                    }
                    else if (input == 3)//Analyse the data
                    {
                
                        Console.WriteLine("Please select which station you wish to analyse\n1 - Lerwick\n2 - Ross on Wye");//asking user to choose which array to use
                        input = Convert.ToInt32(Console.ReadLine());//read line for this
                        if (input == 1) //if user enter 1 use var WS1
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
                                    Quick_Sort(Year, 0, Year.Length - 1);
                                    for (int i = 0; i <= Year.Length - 1; i++)
                                    {
                                        Console.WriteLine(Year[i]);
                                    }
                                        manager = false;//set false so while loop ends allowing the program to end
                                }
                                else if (input == 2)
                                {
                                    Quick_Sort(Year, 0, Year.Length - 1);
                                    Array.Reverse(Year);//invert the array to make it descending
                                    for (int i = 0; i <= Year.Length - 1; i++)
                                    {
                                        Console.WriteLine(Year[i]);
                                    }
                                    manager = false;//set false so while loop ends allowing the program to end
                                }
                                else //if user enter anything else handle it
                                {
                                    Console.WriteLine("please enter a valid number (1 or 2)");
                                }      
                            }
                            else if (input == 2)//month
                            {
                                Console.WriteLine("Please Select which order you want the output\n1 - Ascending\n2 - Descending");//asking user to choose which array to use
                                input = Convert.ToInt32(Console.ReadLine());//read line for this
                                double[] dbMonth = monthToDouble(Month);
                                if (input == 1)
                                {
                                    Quick_Sort(dbMonth, 0, dbMonth.Length - 1);
                                    Month = doubleToMonth(dbMonth);
                                    for (int i = 0; i <= Month.Length - 1; i++)
                                    {
                                        Console.WriteLine(Month[i]);
                                    }
                                    manager = false;//set false so while loop ends allowing the program to end
                                }
                                else if (input == 2)
                                {
                                    Quick_Sort(dbMonth, 0, dbMonth.Length - 1);
                                    Month = doubleToMonth(dbMonth);
                                    Array.Reverse(Month);//invert the array to make it descending
                                    for (int i = 0; i <= Month.Length - 1; i++)
                                    {
                                        Console.WriteLine(Month[i]);
                                    }
                                    manager = false;//set false so while loop ends allowing the program to end
                                }
                                else //if user enter anything else handle it
                                {
                                    Console.WriteLine("please enter a valid number (1 or 2)");
                                }
                            }
                            else if (input == 3)//WS1DailyTempMax
                            {
                                Console.WriteLine("Please Select which order you want the output\n1 - Ascending\n2 - Descending");//asking user to choose which array to use
                                input = Convert.ToInt32(Console.ReadLine());//read line for this
                                if (input == 1)
                                {
                                    Quick_Sort(WS1DailyTempMax, 0, WS1DailyTempMax.Length - 1);
                                    for (int i = 0; i <= WS1DailyTempMax.Length - 1; i++)
                                    {
                                        Console.WriteLine(WS1DailyTempMax[i]);
                                    }
                                    manager = false;//set false so while loop ends allowing the program to end
                                }
                                else if (input == 2)
                                {
                                    Array.Reverse(WS1DailyTempMax);//invert the array to make it descending
                                    Quick_Sort(WS1DailyTempMax, 0, WS1DailyTempMax.Length - 1);
                                    for (int i = 0; i <= WS1DailyTempMax.Length - 1; i++)
                                    {
                                        Console.WriteLine(WS1DailyTempMax[i]);
                                    }
                                    manager = false;//set false so while loop ends allowing the program to end
                                }
                                else //if user enter anything else handle it
                                {
                                    Console.WriteLine("please enter a valid number (1 or 2)");
                                }
                            }
                            else if (input == 4)//WS1DailyTempMin
                            {
                                Console.WriteLine("Please Select which order you want the output\n1 - Ascending\n2 - Descending");//asking user to choose which array to use
                                input = Convert.ToInt32(Console.ReadLine());//read line for this
                                if (input == 1)
                                {
                                    Quick_Sort(WS1DailyTempMin, 0, WS1DailyTempMin.Length - 1);
                                    for (int i = 0; i <= WS1DailyTempMin.Length - 1; i++)
                                    {
                                        Console.WriteLine(WS1DailyTempMin[i]);
                                    }
                                    manager = false;//set false so while loop ends allowing the program to end
                                }
                                else if (input == 2)
                                {
                                    Quick_Sort(WS1DailyTempMin, 0, WS1DailyTempMin.Length - 1);
                                    Array.Reverse(WS1DailyTempMin);//invert the array to make it descending
                                    for (int i = 0; i <= WS1DailyTempMin.Length - 1; i++)
                                    {
                                        Console.WriteLine(WS1DailyTempMin[i]);
                                    }
                                    manager = false;//set false so while loop ends allowing the program to end
                                }
                                else //if user enter anything else handle it
                                {
                                    Console.WriteLine("please enter a valid number (1 or 2)");
                                }
                            }
                            else if (input == 5)//WS1DaysOfFrost
                            {
                                Console.WriteLine("Please Select which order you want the output\n1 - Ascending\n2 - Descending");//asking user to choose which array to use
                                input = Convert.ToInt32(Console.ReadLine());//read line for this
                                if (input == 1)
                                {
                                    Quick_Sort(WS1DaysOfFrost, 0, WS1DaysOfFrost.Length - 1);
                                    for (int i = 0; i <= WS1DaysOfFrost.Length - 1; i++)
                                    {
                                        Console.WriteLine(WS1DaysOfFrost[i]);
                                    }
                                    manager = false;//set false so while loop ends allowing the program to end
                                }
                                else if (input == 2)
                                {
                                    Quick_Sort(WS1DaysOfFrost, 0, WS1DaysOfFrost.Length - 1);
                                    Array.Reverse(WS1DaysOfFrost);//invert the array to make it descending
                                    for (int i = 0; i <= WS1DaysOfFrost.Length - 1; i++)
                                    {
                                        Console.WriteLine(WS1DaysOfFrost[i]);
                                    }
                                    manager = false;//set false so while loop ends allowing the program to end
                                }
                                else //if user enter anything else handle it
                                {
                                    Console.WriteLine("please enter a valid number (1 or 2)");
                                }
                            }
                            else if (input == 6)//WS1TotalRain
                            {
                                Console.WriteLine("Please Select which order you want the output\n1 - Ascending\n2 - Descending");//asking user to choose which array to use
                                input = Convert.ToInt32(Console.ReadLine());//read line for this
                                if (input == 1)
                                {
                                    Quick_Sort(WS1TotalRain, 0, WS1TotalRain.Length - 1);
                                    for (int i = 0; i <= WS1TotalRain.Length - 1; i++)
                                    {
                                        Console.WriteLine(WS1TotalRain[i]);
                                    }
                                    manager = false;//set false so while loop ends allowing the program to end
                                }
                                else if (input == 2)
                                {
                                    Quick_Sort(WS1TotalRain, 0, WS1TotalRain.Length - 1);
                                    Array.Reverse(WS1TotalRain);//invert the array to make it descending
                                    for (int i = 0; i <= WS1TotalRain.Length - 1; i++)
                                    {
                                        Console.WriteLine(WS1TotalRain[i]);
                                    }
                                    manager = false;//set false so while loop ends allowing the program to end
                                }
                                else //if user enter anything else handle it
                                {
                                    Console.WriteLine("please enter a valid number (1 or 2)");
                                }
                            }
                            else if (input == 7)//WS1TotalSun
                            {
                                Console.WriteLine("Please Select which order you want the output\n1 - Ascending\n2 - Descending");//asking user to choose which array to use
                                input = Convert.ToInt32(Console.ReadLine());//read line for this
                                if (input == 1)
                                {
                                    Quick_Sort(WS1TotalSun, 0, WS1TotalSun.Length - 1);
                                    for (int i = 0; i <= WS1TotalSun.Length - 1; i++)
                                    {
                                        Console.WriteLine(WS1TotalSun[i]);
                                    }
                                    manager = false;//set false so while loop ends allowing the program to end
                                }
                                else if (input == 2)
                                {
                                    Quick_Sort(WS1TotalSun, 0, WS1TotalSun.Length - 1);
                                    Array.Reverse(WS1TotalSun);//invert the array to make it descending
                                    for (int i = 0; i <= WS1TotalSun.Length - 1; i++)
                                    {
                                        Console.WriteLine(WS1TotalSun[i]);
                                    }
                                    manager = false;//set false so while loop ends allowing the program to end
                                }
                                else //if user enter anything else handle it
                                {
                                    Console.WriteLine("please enter a valid number (1 or 2)");
                                }
                            }
                            else
                            {
                                Console.WriteLine("please enter a valid number (1 to 7)");
                            }




                        }
                        else if (input == 2) //if user enter 2 use var WS2
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
                                    Quick_Sort(Year, 0, Year.Length - 1);
                                    for (int i = 0; i <= Year.Length - 1; i++)
                                    {
                                        Console.WriteLine(Year[i]);
                                    }
                                    manager = false;//set false so while loop ends allowing the program to end
                                }
                                else if (input == 2)
                                {
                                    Quick_Sort(Year, 0, Year.Length - 1);
                                    Array.Reverse(Year);//invert the array to make it descending
                                    for (int i = 0; i <= Year.Length - 1; i++)
                                    {
                                        Console.WriteLine(Year[i]);
                                    }
                                    manager = false;//set false so while loop ends allowing the program to end
                                }
                                else //if user enter anything else handle it
                                {
                                    Console.WriteLine("please enter a valid number (1 or 2)");
                                }
                            }
                            else if (input == 2)//month
                            {
                                Console.WriteLine("Please Select which order you want the output\n1 - Ascending\n2 - Descending");//asking user to choose which array to use
                                input = Convert.ToInt32(Console.ReadLine());//read line for this
                                double[] dbMonth = monthToDouble(Month);
                                if (input == 1)
                                {
                                    Quick_Sort(dbMonth, 0, dbMonth.Length - 1);
                                    Month = doubleToMonth(dbMonth);
                                    for (int i = 0; i <= Month.Length - 1; i++)
                                    {
                                        Console.WriteLine(Month[i]);
                                    }
                                    manager = false;//set false so while loop ends allowing the program to end
                                }
                                else if (input == 2)
                                {
                                    Quick_Sort(dbMonth, 0, dbMonth.Length - 1);
                                    Month = doubleToMonth(dbMonth);
                                    Array.Reverse(Month);//invert the array to make it descending
                                    for (int i = 0; i <= Month.Length - 1; i++)
                                    {
                                        Console.WriteLine(Month[i]);
                                    }
                                    manager = false;//set false so while loop ends allowing the program to end
                                }
                                else //if user enter anything else handle it
                                {
                                    Console.WriteLine("please enter a valid number (1 or 2)");
                                }
                            }
                            else if (input == 3)//WS1DailyTempMax
                            {
                                Console.WriteLine("Please Select which order you want the output\n1 - Ascending\n2 - Descending");//asking user to choose which array to use
                                input = Convert.ToInt32(Console.ReadLine());//read line for this
                                if (input == 1)
                                {
                                    Quick_Sort(WS2DailyTempMax, 0, WS2DailyTempMax.Length - 1);
                                    for (int i = 0; i <= WS2DailyTempMax.Length - 1; i++)
                                    {
                                        Console.WriteLine(WS2DailyTempMax[i]);
                                    }
                                    manager = false;//set false so while loop ends allowing the program to end
                                }
                                else if (input == 2)
                                {
                                    Array.Reverse(WS2DailyTempMax);//invert the array to make it descending
                                    Quick_Sort(WS2DailyTempMax, 0, WS2DailyTempMax.Length - 1);
                                    for (int i = 0; i <= WS2DailyTempMax.Length - 1; i++)
                                    {
                                        Console.WriteLine(WS2DailyTempMax[i]);
                                    }
                                    manager = false;//set false so while loop ends allowing the program to end
                                }
                                else //if user enter anything else handle it
                                {
                                    Console.WriteLine("please enter a valid number (1 or 2)");
                                }
                            }
                            else if (input == 4)//WS1DailyTempMin
                            {
                                Console.WriteLine("Please Select which order you want the output\n1 - Ascending\n2 - Descending");//asking user to choose which array to use
                                input = Convert.ToInt32(Console.ReadLine());//read line for this
                                if (input == 1)
                                {
                                    Quick_Sort(WS2DailyTempMin, 0, WS2DailyTempMin.Length - 1);
                                    for (int i = 0; i <= WS2DailyTempMin.Length - 1; i++)
                                    {
                                        Console.WriteLine(WS2DailyTempMin[i]);
                                    }
                                    manager = false;//set false so while loop ends allowing the program to end
                                }
                                else if (input == 2)
                                {
                                    Quick_Sort(WS2DailyTempMin, 0, WS2DailyTempMin.Length - 1);
                                    Array.Reverse(WS2DailyTempMin);//invert the array to make it descending
                                    for (int i = 0; i <= WS2DailyTempMin.Length - 1; i++)
                                    {
                                        Console.WriteLine(WS2DailyTempMin[i]);
                                    }
                                    manager = false;//set false so while loop ends allowing the program to end
                                }
                                else //if user enter anything else handle it
                                {
                                    Console.WriteLine("please enter a valid number (1 or 2)");
                                }
                            }
                            else if (input == 5)//WS1DaysOfFrost
                            {
                                Console.WriteLine("Please Select which order you want the output\n1 - Ascending\n2 - Descending");//asking user to choose which array to use
                                input = Convert.ToInt32(Console.ReadLine());//read line for this
                                if (input == 1)
                                {
                                    Quick_Sort(WS2DaysOfFrost, 0, WS2DaysOfFrost.Length - 1);
                                    for (int i = 0; i <= WS2DaysOfFrost.Length - 1; i++)
                                    {
                                        Console.WriteLine(WS2DaysOfFrost[i]);
                                    }
                                    manager = false;//set false so while loop ends allowing the program to end
                                }
                                else if (input == 2)
                                {
                                    Quick_Sort(WS2DaysOfFrost, 0, WS2DaysOfFrost.Length - 1);
                                    Array.Reverse(WS2DaysOfFrost);//invert the array to make it descending
                                    for (int i = 0; i <= WS2DaysOfFrost.Length - 1; i++)
                                    {
                                        Console.WriteLine(WS2DaysOfFrost[i]);
                                    }
                                    manager = false;//set false so while loop ends allowing the program to end
                                }
                                else //if user enter anything else handle it
                                {
                                    Console.WriteLine("please enter a valid number (1 or 2)");
                                }
                            }
                            else if (input == 6)//WS1TotalRain
                            {
                                Console.WriteLine("Please Select which order you want the output\n1 - Ascending\n2 - Descending");//asking user to choose which array to use
                                input = Convert.ToInt32(Console.ReadLine());//read line for this
                                if (input == 1)
                                {
                                    Quick_Sort(WS2TotalRain, 0, WS2TotalRain.Length - 1);
                                    for (int i = 0; i <= WS2TotalRain.Length - 1; i++)
                                    {
                                        Console.WriteLine(WS2TotalRain[i]);
                                    }
                                    manager = false;//set false so while loop ends allowing the program to end
                                }
                                else if (input == 2)
                                {
                                    Quick_Sort(WS2TotalRain, 0, WS2TotalRain.Length - 1);
                                    Array.Reverse(WS2TotalRain);//invert the array to make it descending
                                    for (int i = 0; i <= WS2TotalRain.Length - 1; i++)
                                    {
                                        Console.WriteLine(WS2TotalRain[i]);
                                    }
                                    manager = false;//set false so while loop ends allowing the program to end
                                }
                                else //if user enter anything else handle it
                                {
                                    Console.WriteLine("please enter a valid number (1 or 2)");
                                }
                            }
                            else if (input == 7)//WS1TotalSun
                            {
                                Console.WriteLine("Please Select which order you want the output\n1 - Ascending\n2 - Descending");//asking user to choose which array to use
                                input = Convert.ToInt32(Console.ReadLine());//read line for this
                                if (input == 1)
                                {
                                    Quick_Sort(WS2TotalSun, 0, WS2TotalSun.Length - 1);
                                    for (int i = 0; i <= WS2TotalSun.Length - 1; i++)
                                    {
                                        Console.WriteLine(WS2TotalSun[i]);
                                    }
                                    manager = false;//set false so while loop ends allowing the program to end
                                }
                                else if (input == 2)
                                {
                                    Quick_Sort(WS1TotalSun, 0, WS2TotalSun.Length - 1);
                                    Array.Reverse(WS2TotalSun);//invert the array to make it descending
                                    for (int i = 0; i <= WS2TotalSun.Length - 1; i++)
                                    {
                                        Console.WriteLine(WS2TotalSun[i]);
                                    }
                                    manager = false;//set false so while loop ends allowing the program to end
                                }
                                else //if user enter anything else handle it
                                {
                                    Console.WriteLine("please enter a valid number (1 or 2)");
                                }
                            }
                            else
                            {
                                Console.WriteLine("please enter a valid number (1 to 7)");
                            }



                        }
                        else //if user enter anything else handle it
                        { 
                            Console.WriteLine("please enter a valid number (1 or 2)");
                        }

                            
                            
                    }
                    else if (input == 4)
                    {
                        manager = false;
                    }
                    else
                    {
                        Console.WriteLine("please enter a valid number (1 to 4)");
                    }
                }
                catch (FormatException e)//Catch Format Exeptions
                {
                    Console.WriteLine("\n\n\n\n\nERROR: {0} Please try again.", e.Message);
                }
                catch (OverflowException e)//Catch overflow exeption
                {
                    Console.WriteLine("\n\n\n\n\nERROR: {0} Please try again", e.Message);
                }
           }
        }
        public static void Quick_Sort(double[] data, int left, int right)
            //Quick Sort Algorithm (Sorts into ascending order)
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
        public static double[] monthToDouble(string[] data)
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
        public static string[] doubleToMonth(double[] data)
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