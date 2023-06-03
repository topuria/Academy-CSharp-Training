using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{

    class Games
    {
        static ConsoleColor defaultForeground = ConsoleColor.White;
        static ConsoleColor defaultBackGround = ConsoleColor.Black;
        

        private static void GreetingInfo()
        {
            Console.WriteLine("Now you can choose from this three options, please use 1,2,3 or Q symbol, others are not accepted");
            Console.WriteLine("1. Hot or Cold Game");
            Console.WriteLine("2. Rock Paper Scissor Game");
            Console.WriteLine("3. Chinese Calendar Game");
            Console.WriteLine();
            Console.WriteLine("For Exit Press Q");
        }

        public static void Main(string[] args)
        {
            Console.ForegroundColor = defaultForeground;
            Console.BackgroundColor = defaultBackGround;
            string userName = UserNameController();
            GreetingInfo();
            var input = Console.ReadLine();
            while (!input.ToLower().Equals("q"))
            {
                switch (input)
                {
                    case "1":
                        TempGame(false);
                        break;
                    case "2":
                        RockPaperScissorGame(false);
                        break;
                    case "3":
                        ChineseCalendarGame(false);
                        break;
                    default:
                        ErrorMessage("Only 1,2,3 or Q are allowed");
                        break;
                }
                Console.WriteLine("If you want to continue press 1,2,3 or press Q to stop");
                input = Console.ReadLine();
            }
            Console.WriteLine("Have A Nice Day " + userName);
        }

        private static string UserNameController()
        {
            var userName = "user";
            Console.WriteLine("Hello " + userName);
            Console.WriteLine("Before we start tell me what's you name? ");
            userName = Console.ReadLine();
            while (userName == "")
            {
                Console.WriteLine("Name can't be empty, write again...");
                userName = Console.ReadLine();
            }
            Console.WriteLine("Nice to meet you - " + userName);
            Console.WriteLine();
            return userName;
        }

        private static void ErrorMessage(string ErrorMessage)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(ErrorMessage);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

        }

        private static void TempGame(bool retry)
        {
            if (retry)
            {
                Console.WriteLine("Try Again");
            }
            else
            {
                Console.WriteLine("Temperature Game");
            }
            Console.WriteLine("Write Some Number...");
            var inputForFirst = Console.ReadLine();
            try
            {
                double val = Convert.ToDouble(inputForFirst);
                string answer = GetHotOrColdByTemp(val);
                Console.WriteLine(answer);
            }
            catch (Exception)
            {
                ErrorMessage("Only Numbers are Allowed, Your Input is Empty or Contains Other Symbols");
                TempGame(true);
            }
        }

        private static string GetHotOrColdByTemp(double temp)
        {
            if (temp > 0)
            {
                if (temp <= 30)
                {
                    return "Normal Weather";
                }
                else
                {
                    return "Hot";
                }
            }
            else
            {
                return "Cold";
            }
        }

        private static string RockPaperScissorGame(bool retry)
        {
            if (retry)
            {
                Console.WriteLine("Try Again");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Rock Paper Scissor Game");
                Console.WriteLine();
                Console.WriteLine("1 is Rock");
                Console.WriteLine("2 is Paper");
                Console.WriteLine("3 is Scissor");
            }
            Console.WriteLine("Choose from this 1,2,3");
            int randomValue = new Random().Next(1, 3);
            try
            {
                var inputValue = Console.ReadLine();
                int userValue = Convert.ToInt32(inputValue);
                if (userValue < 0 || userValue > 3)
                {
                    RockPaperScissorGame(true);
                }
                else
                {
                    GetWinnerForRps(randomValue, userValue);
                }
            }
            catch (Exception)
            {
                ErrorMessage("Only Numbers are Allowed");
                RockPaperScissorGame(true);
            }
            return "";
        }

        private static void GetWinnerForRps(int systemNumber, int userNumber)
        {
            Console.WriteLine("Your Choise - " + getTypeForRPS(userNumber));
            Console.WriteLine("My Choise - " + getTypeForRPS(systemNumber));
            if (systemNumber < userNumber)
            {
                Console.WriteLine("Congrats You Win!!!");
            }
            else
            {
                if (systemNumber == userNumber)
                {
                    Console.WriteLine("Its Draw !!!");
                }
                else
                {
                    Console.WriteLine("Ha ha you Lose)))");
                }
            }
        }

        private static string getTypeForRPS(int number)
        {
            string value = "";
            switch (number)
            {
                case 1:
                    value = "Rock";
                    break;
                case 2:
                    value = "Scissor";
                    break;
                case 3:
                    value = "Paper";
                    break;
            }
            return value;
        }

        private static string ChineseCalendarGame(bool retry)
        {
            if (retry)
            {
                Console.WriteLine("Try Again");
            }
            else
            {
                Console.WriteLine("Chinese Calendar Game");
            }
            Console.WriteLine("Write you birth year...");
            try
            {
                var inputYear = Console.ReadLine();
                int val = Convert.ToInt32(inputYear);
                if (val < 0)
                {
                    ChineseCalendarGame(true);
                }
                else
                {
                    string answer = GetAnimalBasedOnChineseAstrology(val);
                    Console.WriteLine(answer);
                }
            }
            catch (Exception)
            {
                ErrorMessage("I think that's not correct way to write year");
                ChineseCalendarGame(true);
            }
            return "";
        }

        private static string GetAnimalBasedOnChineseAstrology(int year)
        {
            int modulo = year % 12;
            string animalName = "Your Animal is - ";
            switch (modulo)
            {
                case 0:
                    animalName += "Monkey";
                    break;
                case 1:
                    animalName += "Rooster";
                    break;
                case 2:
                    animalName += "Dog";
                    break;
                case 3:
                    animalName += "Pig";
                    break;
                case 4:
                    animalName += "Rat";
                    break;
                case 5:
                    animalName += "Ox";
                    break;
                case 6:
                    animalName += "Tiger";
                    break;
                case 7:
                    animalName += "Rabbit";
                    break;
                case 8:
                    animalName += "Dragon";
                    break;
                case 9:
                    animalName += "Snake";
                    break;
                case 10:
                    animalName += "Horse";
                    break;
                case 11:
                    animalName += "Sheep";
                    break;
            }
            return animalName;
        }

    }

}
