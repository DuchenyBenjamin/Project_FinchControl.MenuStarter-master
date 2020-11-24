using System;
using System.Collections.Generic;
using System.IO;
using FinchAPI;

namespace Project_FinchControl
{

    //************************************
    //Title: Finch Control
    //Application Type: Console For finch Controle
    //Description: To Function As A Controle DiviceFor The Finch Robot.
    //Author: Benjamin Ducheny
    //Date Created: 10/1/2020
    //Last Modified:10/6/2020
    //*************************************

    class Program
    {
        /// <summary>
        /// first method run when the app starts up
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            SetTheme();

            DisplayWelcomeScreen();
            DisplayMenuScreen();
            DisplayClosingScreen();
        }

        /// <summary>
        /// setup the console theme
        /// </summary>
        static void SetTheme()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// *****************************************************************
        /// *                     Main Menu                                 *
        /// *****************************************************************
        /// </summary>
        static void DisplayMenuScreen()
        {
            Console.CursorVisible = true;

            bool quitApplication = false;
            string menuChoice;

            Finch finchRobot = new Finch();

            do
            {
                DisplayScreenHeader("Main Menu");

                //
                // get user menu choice
                //
                Console.WriteLine("\t--------------------------------");
                Console.WriteLine("\ta) Connect Finch Robot");
                Console.WriteLine("\tb) Talent Show");
                Console.WriteLine("\tc) Data Recorder");
                Console.WriteLine("\td) Alarm System");
                Console.WriteLine("\te) User Programming");
                Console.WriteLine("\tf) Disconnect Finch Robot");
                Console.WriteLine("\tq) Quit");
                Console.WriteLine("\t--------------------------------");
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                //
                // process user menu choice
                //
                switch (menuChoice)
                {
                    case "a":
                        DisplayConnectFinchRobot(finchRobot);
                        break;

                    case "b":
                        DisplayTalentShowMenuScreen(finchRobot);
                        break;

                    case "c":
                        DataRecorderDisplayMenuScreen(finchRobot);
                        break;

                    case "d":
                        AlarmSystemDisplayMenuScreen(finchRobot);
                        break;

                    case "e":
                        UserProgrammingDisplayMenuScreen(finchRobot);
                        break;

                    case "f":
                        DisplayDisconnectFinchRobot(finchRobot);
                        break;

                    case "q":
                        DisplayDisconnectFinchRobot(finchRobot);
                        quitApplication = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }

            } while (!quitApplication);
        }

      

        #region TALENT SHOW

        /// <summary>
        /// *****************************************************************
        /// *                     Talent Show Menu                          *
        /// *****************************************************************
        /// </summary>
        static void DisplayTalentShowMenuScreen(Finch finchRobot)
        {
            Console.CursorVisible = true;

            bool quitTalentShowMenu = false;
            string menuChoice;

            do
            {
                DisplayScreenHeader("Talent Show Menu");

                //
                // get user menu choice
                //
                Console.WriteLine("\t--------------------------------");
                Console.WriteLine("\ta) Light and Sound");
                Console.WriteLine("\tb) Full turn simulation");
                Console.WriteLine("\tc) SingWithMe");
                Console.WriteLine("\td) Mix It Up");
                Console.WriteLine("\tq) Main Menu");
                Console.Write("\t\tEnter Choice:");
                Console.WriteLine("\t--------------------------------");
                menuChoice = Console.ReadLine().ToLower();


                //
                // process user menu choice
                //
                switch (menuChoice)
                {
                    case "a":
                        FunWithLights(finchRobot);
                        break;

                    case "b":
                        SpinDance(finchRobot);
                        break;

                    case "c":
                        SingWithMe(finchRobot);
                        break;

                    case "d":
                        MixItUp(finchRobot);
                        break;

                    case "q":
                        quitTalentShowMenu = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }

            } while (!quitTalentShowMenu);

        }
        static void SingWithMe(Finch finchRobot)
        {
            DisplayScreenHeader("Sing a song with me");
            Console.WriteLine("\tThe finch will now play the birthday song.");
            for (int i = 0; i < 1; i++)
            {
                finchRobot.noteOn(784);
                finchRobot.wait(500);

                finchRobot.noteOn(880);
                finchRobot.wait(500);

                finchRobot.noteOn(784);
                finchRobot.wait(500);

                finchRobot.noteOn(1047);
                finchRobot.wait(500);

                finchRobot.noteOn(988);
                finchRobot.wait(800);

                finchRobot.noteOn(784);
                finchRobot.wait(500);

                finchRobot.noteOn(880);
                finchRobot.wait(500);

                finchRobot.noteOn(784);
                finchRobot.wait(500);

                finchRobot.noteOn(1200);
                finchRobot.wait(500);

                finchRobot.noteOn(1047);
                finchRobot.wait(800);

                finchRobot.noteOn(784);
                finchRobot.wait(500);

                finchRobot.noteOn(1500);
                finchRobot.wait(500);

                finchRobot.noteOn(1310);
                finchRobot.wait(500);

                finchRobot.noteOn(1047);
                finchRobot.wait(500);

                finchRobot.noteOn(988);
                finchRobot.wait(500);

                finchRobot.noteOn(880);
                finchRobot.wait(1000);

                finchRobot.noteOn(1400);
                finchRobot.wait(500);

                finchRobot.noteOn(1310);
                finchRobot.wait(500);

                finchRobot.noteOn(1047);
                finchRobot.wait(500);

                finchRobot.noteOn(1200);
                finchRobot.wait(500);

                finchRobot.noteOn(1047);
                finchRobot.wait(1200);

                finchRobot.noteOff();
                finchRobot.wait(200);

                DisplayContinuePrompt();
            }
        }

        static void MixItUp(Finch finchRobot)
        {
            DisplayScreenHeader("Dance!");
            Console.WriteLine("\tThe Finch robot will now dance.");

            DisplayContinuePrompt();
            Console.Clear();

            finchRobot.setMotors(255, -255);

            finchRobot.setLED(144, 111, 111);
            finchRobot.noteOn(784);
            finchRobot.wait(500);

            finchRobot.noteOn(880);
            finchRobot.wait(500);

            finchRobot.noteOn(784);
            finchRobot.wait(500);

            finchRobot.noteOn(1047);
            finchRobot.wait(500);

            finchRobot.noteOn(988);
            finchRobot.wait(800);
            finchRobot.setLED(31, 255, 76);
            finchRobot.noteOn(784);
            finchRobot.wait(500);

            finchRobot.noteOn(880);
            finchRobot.wait(500);

            finchRobot.noteOn(784);
            finchRobot.wait(500);

            finchRobot.noteOn(1200);
            finchRobot.wait(500);

            finchRobot.noteOn(1047);
            finchRobot.wait(800);

            finchRobot.noteOn(784);
            finchRobot.wait(500);
            finchRobot.setLED(156, 234, 77);
            finchRobot.noteOn(1500);
            finchRobot.wait(500);

            finchRobot.noteOn(1310);
            finchRobot.wait(500);

            finchRobot.noteOn(1047);
            finchRobot.wait(500);

            finchRobot.noteOn(988);
            finchRobot.wait(500);

            finchRobot.noteOn(880);
            finchRobot.wait(1000);

            finchRobot.noteOn(1400);
            finchRobot.wait(500);

            finchRobot.noteOn(1310);
            finchRobot.wait(500);
            finchRobot.setLED(67, 114, 235);
            finchRobot.noteOn(1047);
            finchRobot.wait(500);

            finchRobot.noteOn(1200);
            finchRobot.wait(500);

            finchRobot.noteOn(1047);
            finchRobot.wait(1200);

            finchRobot.noteOff();
            finchRobot.wait(200);

            finchRobot.setMotors(0, 0);
            finchRobot.setLED(0, 0, 0);
            DisplayContinuePrompt();

        }

        static void SpinDance(Finch finchRobot)
        {
            DisplayScreenHeader("Dance!");

            Console.WriteLine("\tThe Finch robot will now dance.");
            DisplayContinuePrompt();

            finchRobot.setMotors(255, -255);

            finchRobot.setMotors(0, 0);

            DisplayContinuePrompt();
        }

        /// <summary>
        /// *****************************************************************
        /// *               Talent Show > Light and Sound                   *
        /// *****************************************************************
        /// </summary>
        /// <param name="finchRobot">finch robot object</param>
        static void FunWithLights(Finch finchRobot)
        {
            Console.CursorVisible = false;

            DisplayScreenHeader("A fun little ");

            Console.WriteLine("\tThe Finch robot will not show off its glowing talent!");
            DisplayContinuePrompt();

            for (int lightSoundLevel = 0; lightSoundLevel < 255; lightSoundLevel++)
            {
                finchRobot.setLED(lightSoundLevel, lightSoundLevel, lightSoundLevel);
                finchRobot.noteOn(lightSoundLevel * 100);
            }

            DisplayMenuPrompt("Talent Show Menu");
        }

        #endregion

        #region DataRecorder
        static void DataRecorderDisplayMenuScreen(Finch finchRobot)
        {
            string menuChoice;
            bool quitMenu = false;

            int numberOfDataPoints = 0;
            double dataPointFrequency = 0;
            double[] temperatures = null;
            do
            {
                DisplayScreenHeader("Data Recorder Menu");

                //
                // get user menu choice
                //
                Console.WriteLine("\t--------------------------------");
                Console.WriteLine("\ta) Number of Data points");
                Console.WriteLine("\tb) Frequency of Data points");
                Console.WriteLine("\tc) Get Data");
                Console.WriteLine("\td) Show Data");
                Console.WriteLine("\tq) Main Menu");
                Console.Write("\t\tEnter Choice:");
                Console.WriteLine();
                Console.WriteLine("\t--------------------------------");
                menuChoice = Console.ReadLine().ToLower();



                //
                // process user menu choice
                //
                switch (menuChoice)
                {
                    case "a":
                        numberOfDataPoints = DataRecorderDisplayGetNumberOfDataPoints();
                        break;

                    case "b":
                        dataPointFrequency = DataRecorderDisplayGetFrequencyOfDataPoints();
                        break;

                    case "c":
                        temperatures = DataRecorderDisplayGetDataSet(numberOfDataPoints, dataPointFrequency, finchRobot);
                        break;

                    case "d":
                        DataRecorderDisplayDataSet(temperatures);
                        break;

                    case "q":
                        quitMenu = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }
            } while (!quitMenu);
        }

        static void DataRecorderDisplayDataSet(double[] temperatures)
        {
            DisplayScreenHeader("Display Data");

            DataRecorderDisplayTable(temperatures);

            DisplayContinuePrompt();
        }

        /// <summary>
        /// Data Recorder Table
        /// </summary>
        /// <param name="temperatures"></param>
        static void DataRecorderDisplayTable(double[] temperatures)
        {
            double sum = 0, avg = 0;
            //
            //display table headers
            //
            Console.WriteLine(
                "Recording #  ".PadLeft(15) +
                "Temp".PadLeft(15)
                );
            Console.WriteLine(
                "-----------".PadLeft(15) +
                "-----------".PadLeft(15)
                );
            //
            //display table data
            //

            for (int index = 0; index < temperatures.Length; index++)
            {
                Console.WriteLine(
                (index + 1).ToString().PadLeft(15) + " | " +
                temperatures[index].ToString().PadLeft(15)
                );
            }
            DataRecorderDisplayAverageAndSum(temperatures);
        }

        static void DataRecorderDisplayAverageAndSum(double[] temperatures)
        {
            double sum = 0, avg = 0;
            //
            //display table Average And Sum
            //

            for (int i = 0; i < temperatures.Length; i++)
            {
                sum += temperatures[i];
            }
            avg = sum / temperatures.Length;
            Console.WriteLine("The Sum is : " + sum);
            Console.WriteLine("The Average is : " + avg);
        }
        static double[] DataRecorderDisplayGetDataSet(int numberOfDataPoints, double dataPointFrequency, Finch finchRobot)
        {
            double[] temperatures = new double[numberOfDataPoints];
            DisplayScreenHeader("Get Data");

            Console.WriteLine($"\tNumber Of Data Points: {numberOfDataPoints}");
            Console.WriteLine($"\tfrequency Of Data Points: {dataPointFrequency}");
            Console.WriteLine();

            Console.WriteLine("\tThe finch robot is ready to record temperature data. Press any key to begin.");
            Console.ReadKey();

            double temperture;
            int frequencyOfDataPointsMilliseconds;
            for (int index = 0; index < numberOfDataPoints; index++)
            {
                temperture = finchRobot.getTemperature() * 1.8 + 32;
                Console.WriteLine($"Temperature Reading {index + 1}: | {temperture}");
                temperatures[index] = temperture;
                frequencyOfDataPointsMilliseconds = (int)(dataPointFrequency * 1000);
                finchRobot.wait(frequencyOfDataPointsMilliseconds);
                
            }
            DisplayContinuePrompt();
            DisplayScreenHeader("Get Data");
            Console.WriteLine();
            Console.WriteLine("Table of Temperatures");
            Console.WriteLine();
            DataRecorderDisplayTable(temperatures);

            DisplayContinuePrompt();

            return temperatures;
        }

        /// <summary>
        /// *****************************************************************
        /// *      Data Recorder > Get the Number of Data Points            *
        /// *****************************************************************
        /// </summary>
        /// <returns> Number of Data Points  </returns>
        static int DataRecorderDisplayGetNumberOfDataPoints()
        {
            bool exit = false;
            int numberOfDataPoints;
            string choice;
            Console.CursorVisible = false;

            DisplayScreenHeader("Number of data points");
            //get user input
            Console.WriteLine("\tNumber of data points:");
            int.TryParse(Console.ReadLine(), out numberOfDataPoints);

            //validate user input
            Console.WriteLine();
            Console.WriteLine($"\tNumber of data points: {numberOfDataPoints}");
            Console.WriteLine();
            do
            {


                Console.WriteLine("\tIs This the correct amount of data points?");
                Console.WriteLine("\t--------------------------------");
                Console.WriteLine("\tY) Yes");
                Console.WriteLine("\tN) No");
                Console.WriteLine("\t--------------------------------");
                choice = Console.ReadLine().ToLower();
                Console.Clear();
                switch (choice)
                {
                    case "y":
                        Console.WriteLine("\tNumber of data points has been confirmed");
                        exit = true;

                        break;

                    case "n":
                        Console.WriteLine("\tPlease re-enter");
                        DataRecorderDisplayGetNumberOfDataPoints();
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        Console.Clear();
                        break;
                }
            } while (!exit);

            DisplayMenuPrompt("Main Menu");
            return numberOfDataPoints;
        }

        /// <summary>
        /// *****************************************************************
        /// *      Data Recorder > Get the Frequency of Data Points         *
        /// *****************************************************************
        /// </summary>
        /// <returns> Frequency of Data Points </returns>
        static double DataRecorderDisplayGetFrequencyOfDataPoints()
        {
            bool exit = false;
            string choice;
            double dataPointFrequency;
            Console.CursorVisible = false;

            DisplayScreenHeader("Data Point Frequency");
            //get user input
            Console.WriteLine("\tFrequency of data Points:");
            double.TryParse(Console.ReadLine(), out dataPointFrequency);

            //validate user input
            Console.WriteLine();
            Console.WriteLine($"\tFrequency of data points: {dataPointFrequency}");
            do
            {


                Console.WriteLine("\tIs This the correct Frequency for your data points?");
                Console.WriteLine("\t--------------------------------");
                Console.WriteLine("\tY) Yes");
                Console.WriteLine("\tN) No");
                Console.WriteLine("\t--------------------------------");
                choice = Console.ReadLine().ToLower();
                Console.Clear();
                switch (choice)
                {
                    case "y":
                        Console.WriteLine("\tFrequency of data points has been confirmed");
                        exit = true;
                        break;

                    case "n":
                        Console.WriteLine("\tPlease re-enter");
                        DataRecorderDisplayGetFrequencyOfDataPoints();
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        Console.Clear();
                        break;
                }
            } while (!exit);

            DisplayMenuPrompt("Main Menu");
            return dataPointFrequency;
        }


            #endregion

        #region ALARM SYSTEM
            static void AlarmSystemDisplayMenuScreen(Finch finchRobot)
        {
            string menuChoice;
            bool quitMenu = false;
            string sensorsToMonitor = "";
            string rangeType = "";
            int minMaxThresholdValue = 0;
            int timeToMonitor = 0;

            do
            {
                DisplayScreenHeader("Alarm System Menu");

                //
                // get user menu choice
                //
                Console.WriteLine("\t--------------------------------");
                Console.WriteLine("\ta) Set Sensors to Monitor");
                Console.WriteLine("\tb) Set Range Type");
                Console.WriteLine("\tc) Display current light sensor value");
                Console.WriteLine("\td) Set Minimum/Maximum Threshold Value");
                Console.WriteLine("\te) Set Time to Monitor");
                Console.WriteLine("\tf) Show alarm settings");
                Console.WriteLine("\tg) Set Alarm");
                Console.WriteLine("\th) Main Menu");
                Console.Write("\t\tEnter Choice:");
                Console.WriteLine();
                Console.WriteLine("\t--------------------------------");
                menuChoice = Console.ReadLine().ToLower();



                //
                // process user menu choice
                //
                switch (menuChoice)
                {
                    case "a":
                        sensorsToMonitor = AlarmSystemDisplaySetSensorsToMonitor(finchRobot, sensorsToMonitor);
                        break;

                    case "b":
                        rangeType = AlarmSystemDisplaySetRangeType();
                        break;

                    case "c":
                        DataRecorderDisplayCurrentLightSensorValue(finchRobot);
                        break;

                    case "d":
                        minMaxThresholdValue = AlarmSystemDisplaySetMinMaxThresholdValue(rangeType, finchRobot);
                        break;

                    case "e":
                        timeToMonitor = AlarmSystemDisplaySetTimeToMonitor();
                        break;

                    case "f":
                        DataRecorderDisplayAlarmParameters(finchRobot, sensorsToMonitor, rangeType, minMaxThresholdValue, timeToMonitor);
                        break;

                    case "g":
                        LightAlarmSetAlarm(finchRobot, sensorsToMonitor, rangeType, minMaxThresholdValue, timeToMonitor);
                        break;

                    case "h":
                        quitMenu = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }
            } while (!quitMenu);
            DisplayContinuePrompt();
        }

        private static void AlarmSystemDisplayElapsedTime(Finch finchRobot, int timeToMonitor, int secondsElapsed)
        {
            Console.SetCursorPosition(25, 10);
            Console.WriteLine($"Time Elapsed: {0} seconds", secondsElapsed);

        }

        static void DataRecorderDisplayCurrentSingleLightSensorValue(Finch finchRobot, string sensorsToMonitor)
        {

            switch (sensorsToMonitor)
            {
                case "left":
                    Console.WriteLine($"\tLeft light sensor ambient value: {finchRobot.getLeftLightSensor()}");
                    break;

                case "right":
                    Console.WriteLine($"\tRight light sensor ambient value: {finchRobot.getRightLightSensor()}");
                    break;

                case "both":
                    Console.WriteLine($"\tSensors ambient values: {finchRobot.getRightLightSensor() + finchRobot.getLeftLightSensor() / 2}");
                    break;
            }
            DisplayContinuePrompt();

        }
        static void DataRecorderDisplayCurrentLightSensorValue(Finch finchRobot)
        {
                Console.SetCursorPosition(2, 8);
                Console.WriteLine($"\tLeft light sensor ambient value: {finchRobot.getLeftLightSensor()}");
                Console.WriteLine("");
                Console.WriteLine($"\tRight light sensor ambient value: {finchRobot.getRightLightSensor()}");
        }

        private static void DataRecorderDisplayAlarmParameters(
            Finch finchRobot,
            string sensorsToMonitor,
            string rangeType,
            int minMaxThresholdValue,
            int timeToMonitor)
        {
            Console.Clear();
            Console.WriteLine($"\tSensors To Monitor {sensorsToMonitor}");
            Console.WriteLine($"\tRange Type: {rangeType}");
            Console.WriteLine($"\tMin/Max threshold value: {minMaxThresholdValue}");
            Console.WriteLine($"\tTime to monitor: {timeToMonitor}");
            DisplayContinuePrompt();
        }

        static void LightAlarmSetAlarm(
            Finch finchRobot,
            string sensorsToMonitor,
            string rangeType,
            int minMaxThresholdValue,
            int timeToMonitor)
        {
            int secondsElapsed = 0;
            bool thresholdExceeded = false;
            int currentLightSensorValue = 0;

            DisplayScreenHeader("Set Alarm");

            Console.WriteLine($"\tSensors To Monitor {sensorsToMonitor}");
            Console.WriteLine($"\tRange Type: {rangeType}");
            Console.WriteLine($"\tMin/Max threshold value: {minMaxThresholdValue}");
            Console.WriteLine($"\tTime to monitor: {timeToMonitor}");
            Console.WriteLine();

            Console.WriteLine("\tPress any key to begin monitoring");
            Console.ReadKey();
            Console.WriteLine();

            while ((secondsElapsed < timeToMonitor) && !thresholdExceeded)
            {
                switch (rangeType)
                {
                    case "left":
                            currentLightSensorValue = finchRobot.getLeftLightSensor();
                    break;

                    case "right":
                            currentLightSensorValue = finchRobot.getRightLightSensor();
                        break;

                    case "both":
                        currentLightSensorValue = (finchRobot.getRightLightSensor() + finchRobot.getLeftLightSensor()) / 2;
                        break;
                }
                
                switch (rangeType)
                {
                   
                    case "minimum":
                        if (currentLightSensorValue < minMaxThresholdValue)
                        {
                            thresholdExceeded = true;
                        }
                        break;

                    case "maximum":
                        if (currentLightSensorValue > minMaxThresholdValue)
                        {
                            thresholdExceeded = true;
                        }
                        break;
                }
                finchRobot.wait(1000);
                secondsElapsed++;
                AlarmSystemDisplayElapsedTime(finchRobot, timeToMonitor, secondsElapsed);
            }

            if (thresholdExceeded)
            {
                Console.WriteLine($"\tThe {rangeType} threshold value of {minMaxThresholdValue} was exceeded by the current light sensor value of {currentLightSensorValue}.");
            }
            else
            {
                Console.WriteLine($"\tThe {rangeType} threshold value of {minMaxThresholdValue} was not exceeded.");
            }
            DisplayMenuPrompt("Alarm system");
        }

        static int AlarmSystemDisplaySetTimeToMonitor()
        {
            int TimeToMonitor;
            string choice;
            bool exit = false;

            DisplayScreenHeader("Time To Monitor");

            //User input

            Console.Write($"\tTime To Monitor:");
            int.TryParse(Console.ReadLine(), out TimeToMonitor);

            // echo value 

            Console.WriteLine($"\tyour Time to monitor is:{TimeToMonitor}");
            Console.WriteLine();
            do
            {
                Console.WriteLine("\tIs this the correct time?");
                Console.WriteLine("\t--------------------------------");
                Console.WriteLine("\tY) Yes");
                Console.WriteLine("\tN) No");
                Console.WriteLine("\t--------------------------------");
                choice = Console.ReadLine().ToLower();
                Console.Clear();
                switch (choice)
                {
                    case "y":
                        Console.WriteLine("\tTime value has been confirmed");
                        exit = true;

                        break;

                    case "n":
                        Console.WriteLine("\tPlease re-enter time value");
                        AlarmSystemDisplaySetTimeToMonitor();
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        Console.Clear();
                        break;
                }
            } while (!exit);

            DisplayMenuPrompt("Alarm system");


            return TimeToMonitor;
        }
        static int AlarmSystemDisplaySetMinMaxThresholdValue(string rangeType, Finch finchRobot)
        {
            int minMaxThresholdValue;
            string choice;
            bool exit = false;

            DisplayScreenHeader("Min/Maximum Threshold Value");

            Console.WriteLine($"\tLeft light sensor ambient value: {finchRobot.getLeftLightSensor()}");
            Console.WriteLine($"\tRight light sensor ambient value: {finchRobot.getRightLightSensor()}");
            Console.WriteLine();

            Console.Write($"\tEnter the {rangeType} light sensor value: ");
            int.TryParse(Console.ReadLine(), out minMaxThresholdValue);

            Console.WriteLine($"\tYour {rangeType} light sensor value is {minMaxThresholdValue}.");
            Console.WriteLine();
            do
            {
                Console.WriteLine($"\tIs {minMaxThresholdValue} The correct light sensor value");
                Console.WriteLine("\t--------------------------------");
                Console.WriteLine("\tY) Yes");
                Console.WriteLine("\tN) No");
                Console.WriteLine("\t--------------------------------");
                choice = Console.ReadLine().ToLower();
                Console.Clear();
                switch (choice)
                {
                    case "y":
                        Console.WriteLine("\tValue has been confirmed");
                        exit = true;
                        break;

                    case "n":
                        Console.WriteLine("\tPlease re-enter value for light sensor");
                        AlarmSystemDisplaySetMinMaxThresholdValue(rangeType, finchRobot);
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        Console.Clear();
                        break;
                }
            } while (!exit);

            DisplayMenuPrompt("Alarm system");


            return minMaxThresholdValue;
        }

        static string AlarmSystemDisplaySetSensorsToMonitor(Finch finchRobot, string sensorsToMonitor)
        {
            string choice;
            bool exit = false;
            DisplayScreenHeader("Sensors to Monitor");

            Console.Write("\tSensors to Monitor [left, right, both]:");
            sensorsToMonitor = Console.ReadLine().ToLower();
            Console.WriteLine();
            Console.WriteLine($"\tyour input for Sensors to Monitor is {sensorsToMonitor}.");
            Console.WriteLine();
            DataRecorderDisplayCurrentSingleLightSensorValue(finchRobot, sensorsToMonitor);
            Console.WriteLine();
            do
            {
                Console.WriteLine($"\tIs '{sensorsToMonitor}' the correct sensor?");
                Console.WriteLine("\t--------------------------------");
                Console.WriteLine("\tY) Yes");
                Console.WriteLine("\tN) No");
                Console.WriteLine("\t--------------------------------");
                choice = Console.ReadLine().ToLower();
                Console.Clear();
                switch (choice)
                {
                    case "y":
                        Console.WriteLine("\tSensor has been confirmed");
                        exit = true;

                        break;

                    case "n":
                        Console.WriteLine("\tPlease re-enter sensor");
                        AlarmSystemDisplaySetSensorsToMonitor(finchRobot, sensorsToMonitor);
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        Console.Clear();
                        break;
                }
            } while (!exit);

            DisplayMenuPrompt("Alarm System");

            return sensorsToMonitor;
        }

        static string AlarmSystemDisplaySetRangeType()
        {
            string choice;
            bool exit = false;
            string rangeType;

            DisplayScreenHeader("Range Type");


            Console.Write("\tRange Type [minimum, maximum]:");
            rangeType = Console.ReadLine();

            Console.WriteLine($"\tyour range type is:{rangeType}.");
            Console.WriteLine();
            do
            {
                Console.WriteLine($"\tIs {rangeType} correct range?");
                Console.WriteLine("\t--------------------------------");
                Console.WriteLine("\tY) Yes");
                Console.WriteLine("\tN) No");
                Console.WriteLine("\t--------------------------------");
                choice = Console.ReadLine().ToLower();
                Console.Clear();
                switch (choice)
                {
                    case "y":
                        Console.WriteLine("\tSensor has been confirmed");
                        exit = true;

                        break;

                    case "n":
                        Console.WriteLine("\tPlease re-enter sensor");
                        AlarmSystemDisplaySetRangeType();
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        Console.Clear();
                        break;
                }
            } while (!exit);

            DisplayMenuPrompt("Alarm System");

            return rangeType;
        }
        #endregion

        #region FINCH ROBOT MANAGEMENT

        /// <summary>
        /// *****************************************************************
        /// *               Disconnect the Finch Robot                      *
        /// *****************************************************************
        /// </summary>
        /// <param name="finchRobot">finch robot object</param>
        static void DisplayDisconnectFinchRobot(Finch finchRobot)
        {
            Console.CursorVisible = false;

            DisplayScreenHeader("Disconnect Finch Robot");

            Console.WriteLine("\tAbout to disconnect from the Finch robot.");
            DisplayContinuePrompt();

            finchRobot.disConnect();

            Console.WriteLine("\tThe Finch robot is now disconnect.");

            DisplayMenuPrompt("Main Menu");
        }

        /// <summary>
        /// *****************************************************************
        /// *                  Connect the Finch Robot                      *
        /// *****************************************************************
        /// </summary>
        /// <param name="finchRobot">finch robot object</param>
        /// <returns>notify if the robot is connected</returns>
        static bool DisplayConnectFinchRobot(Finch finchRobot)
        {
            Console.CursorVisible = false;

            bool robotConnected;

            DisplayScreenHeader("Connect Finch Robot");

            Console.WriteLine("\tAbout to connect to Finch robot. Please be sure the USB cable is connected to the robot and computer now.");
            DisplayContinuePrompt();

            robotConnected = finchRobot.connect();

            if (robotConnected)
            {
                Console.WriteLine("Connect Finch Robot");
                finchRobot.setLED(0, 255, 0);
                finchRobot.noteOn(261);
                finchRobot.wait(1000);
                finchRobot.setLED(0, 0, 0);
                finchRobot.setLED(0, 0, 0);
            }

            // TODO test connection and provide user feedback - text, lights, sounds

            DisplayMenuPrompt("Main Menu");

            //
            // reset finch robot
            //
            finchRobot.setLED(0, 0, 0);
            finchRobot.noteOff();

            return robotConnected;
        }

        #endregion

        #region USER INTERFACE

        /// <summary>
        /// *****************************************************************
        /// *                     Welcome Screen                            *
        /// *****************************************************************
        /// </summary>
        static void DisplayWelcomeScreen()
        {
            Console.CursorVisible = false;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tFinch Control");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

        /// <summary>
        /// *****************************************************************
        /// *                     Closing Screen                            *
        /// *****************************************************************
        /// </summary>
        static void DisplayClosingScreen()
        {
            Console.CursorVisible = false;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tThank you for using Finch Control!");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

        /// <summary>
        /// display continue prompt
        /// </summary>
        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("\tPress any key to continue.");
            Console.ReadKey();
        }

        /// <summary>
        /// display menu prompt
        /// </summary>
        static void DisplayMenuPrompt(string menuName)
        {
            Console.WriteLine();
            Console.WriteLine($"\tPress any key to return to the {menuName} Menu.");
            Console.ReadKey();
        }

        /// <summary>
        /// display screen header
        /// </summary>
        static void DisplayScreenHeader(string headerText)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t" + headerText);
            Console.WriteLine();
        }

        static void UserProgrammingDisplayMenuScreen(Finch finchrobot)
        {
            Console.Clear();
            DisplayScreenHeader("User program");
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tThis module is under development");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

        #endregion
    }
}

