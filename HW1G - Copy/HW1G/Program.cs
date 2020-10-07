using System;

namespace GoldsteenGHW01
    /* Name: Homework 1 - Text Adventure - GoldsteenGHW01
     * 
     * Created by Gabe Goldsteen
     * 
     */


/*Brainstorming
 * 
 * How many levels are in my game: I want there to be at least 3 levels to go through. 
 * They will be the outside, the inside, and then to the dungeon itself.
 * 
 * What is the setting of my game: It's a laboratory that is rumored to be experimenting on humans.
 * There's no concrete proof this is true, but there has been countless stories of the horrors of this lab.
 * The player is a news reporter who is determined to uncover the proof of the lab.
 * 
 * The ultimate goal of the game is to find the lab's database and learn the truth of the lab from its papers.
 * 
 */
 
{
class Program
{
    static void Main(string[] args)
    {
        //Player Attributes

        string PlayerName;
        string PlayerAge;
        int age;
        int StepsGiven;
            string PlayerInput;
            const int StepsNeeded = 75;


            //Background Color
            Console.BackgroundColor = ConsoleColor.DarkBlue;




            //Player Stats
            string d = DateTime.Now.ToString();
        Console.WriteLine("This is the current date and time, press any key to continue");
        Console.WriteLine(d);
        Console.ReadKey();
        




            //Welcoming the player to game, introducing the rules, and asking the player for their name and age.
            Console.WriteLine("\t\t Welcome to The Laboratory of the Future!!\t\t");
            Console.WriteLine("\t\t ***************************************** \t\t\n");
            //Gives the player the lowdown on the rules.
            Console.WriteLine("Rules: \n ^^^^^^^^^^^");
            Console.WriteLine("The goal of this game is for you, as a budding reporter just out of college(but still in a ton of debt), \n to navigate a laboratory known as the Laboratory of the Future, \n and uncover the secrets that lay hidden in it.");
            //Asks the player for their name
            Console.WriteLine("What is your name?");
            PlayerName = Console.ReadLine();
            if (PlayerName == "")
            {
                Console.WriteLine("Your name is now The Difficult Player");
                PlayerName = "The Difficult Player";
            }
            //Ask the player for their age
            Console.WriteLine("How old are you?");
            PlayerAge = Console.ReadLine();
            //Catch, to make sure they enter in an age
            try
            {
                age = Int32.Parse(PlayerAge);
            }

            catch (FormatException)
            {
                Console.WriteLine("You failed to give your age, how embarassing. You are now 44 years old, the perfect age for a midlife crisis");
                age = 44;
            }
            //Show final message before starting the game
            Console.WriteLine("\nMay you " + PlayerName + "(" + age + ") succeed in learning the truth of the lab. And you better not die in there!! \n You still owe the company a ton of money!!");
            Console.WriteLine("Press any key to Continue");
            Console.WriteLine(d);
            Console.ReadLine();
            //Confirmation message that the player wants to play the game.
            Console.WriteLine("Now then, are you ready to play the game? (Y/N)?");
            string answer = Console.ReadLine().Trim().ToUpper().Substring(0);
            //Make sure they are reading, press only Y
            if (answer is not "Y")
            {
                Console.WriteLine("You had one job to do... and you failed it. I'm not mad, just disappointed.");
                Console.WriteLine("Press any key to end the program");
                Console.ReadLine();
                System.Environment.Exit(0);

            }
            //Giving some story to the land
            Console.WriteLine("You arrive at the Laboratory. The building itself is a massive white facility. \n It's lined with large glass windows and bright lights.");
            Console.WriteLine("The front doors don't look too far away, no more than a 100 steps. \nHow many steps do you wish to move?");
            PlayerInput = Console.ReadLine();
            //Catch if format is wrong, not reading the directions
            try
            {
                StepsGiven = Int32.Parse(PlayerInput);

            }
            catch (FormatException)
            {
                StepsGiven = 0;
                Console.WriteLine("I just needed a number man");
                Console.WriteLine("Press any key to exit to start again, ha ha ha");
                Console.ReadLine();
                System.Environment.Exit(0);
            }
            //Calculate the steps that they either overshot it by or needed more steps to make it.
            if (StepsGiven == StepsNeeded)
            {
        
                Console.WriteLine("Somehow you guessed the right amount of steps, suspicious");
                Console.WriteLine("Press any key to continue");
                Console.ReadLine();

            }
            else if (StepsGiven > StepsNeeded)
            {
                Console.WriteLine("You slammed right into the door... you overshot it by " + (StepsNeeded - StepsGiven).ToString() + " steps...\n That's gonna leave a mark... I'm not paying for your hospital bills! ");
                Console.WriteLine("Press any key to continue");
                Console.ReadLine(); 

            }
            else if (StepsGiven < StepsNeeded)
            {
                Console.WriteLine("You barely missed the door by... " + (StepsNeeded - StepsGiven).ToString() + " steps. But it's okay!You tripped over your own legs somehow and slammed straight into the door. \n You're such a dummy!");
                Console.WriteLine("Press any key to continue");
                Console.ReadLine();
            }

           



        }
    }
}
