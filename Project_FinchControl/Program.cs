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
                        DisplayDataRecorderDisplayMenuScreen(finchRobot);
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

        static void DisplayDataRecorderDisplayMenuScreen(Finch finchrobot)
        {
            Console.Clear();
            DisplayScreenHeader("Data Screen Recorder");
            Console.WriteLine();
            Console.WriteLine("\t\tThis module is under development");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

        static void AlarmSystemDisplayMenuScreen(Finch finchrobot)
        {
            Console.Clear();
            DisplayScreenHeader("Alarm System");
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tThis module is under development");
            Console.WriteLine();

            DisplayContinuePrompt();
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
