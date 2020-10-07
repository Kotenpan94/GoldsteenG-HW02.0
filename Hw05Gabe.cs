using System;
using System.CodeDom;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using Microsoft.SqlServer.Server;

namespace GoldsteenGHW05
/* Name: Homework 5 - Text Adventure - GoldsteenGHW01
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
        public static void Main(string[] args)
        {

            //Player Attributes

            string PlayerName;
            string PlayerAge;
            int age;
            int StepsGiven =0;
            int Steps = 0;
            string PlayerInput;
            string Dragon = "A large, almost cyan colored dragon blocks your path. It's appearance comes across as majestic,\nand it's face is noble, like it's staring deep into your soul...";
            string Serpent = "On the other hand. a medium sized greenish serpent blocks your path as well. \nWhereas the dragon came across as respectable,\nthe serpent feels as if it is peer pressuring you into doing something you'll regret";
            // PlayerInputValue;
            //const int StepsNeeded = 75;
            //const int RollNeeded = 4;

            //Random Attributes
            Random MyDice = new Random();
            int die1 = MyDice.Next(1, 6);
            //int die2;
            //Color Attribute
            const string myColors = "Blue,Black,Cyan,Green,Purple,White,Red,Yellow";
           


            //Background Color
            Console.BackgroundColor = ConsoleColor.DarkBlue;




            //Player Stats
            string d = DateTime.Now.ToString();
            Console.WriteLine("This is the current date and time, press any key to continue");
            Console.WriteLine(d);
            Console.ReadKey();

            //Temp Slot
            //Console.WriteLine(myColors.Substring(myColors.IndexOf(, ));
            //Console.ReadLine();
            //string remove1 = myColors.Substring(myColors.IndexOf(",")+1);
            
           //string remove1 = Console.ReadLine();
            //string remove2 = remove1 
            //string remove2 = remove1.Substring(remove1.IndexOf(",")+1);
            
            //int end = remove2.IndexOf(",");
           //string remove3 = remove2.Substring(0, end);
            //Console.WriteLine(remove3);
            //Console.ReadLine();
            //string remove4 = remove3.Substring(remove2.IndexOf(","));
            //string remove3 = remove2.Substring(0, remove2.IndexOf(","));
            //Console.WriteLine("Your color is " + remove3);
            //Console.ReadLine();





            //Welcoming the player to game, introducing the rules, and asking the player for their name and age.
            Console.WriteLine("\t\t Welcome to The Laboratory of the Future!!\t\t");
            Console.WriteLine("\t\t ***************************************** \t\t\n");
            //Gives the player the lowdown on the rules.
            Console.WriteLine("Rules: \n ^^^^^^^^^^^");
            Console.WriteLine("The goal of this game is for you, as a budding reporter just out of college(but still in a ton of debt), \n to navigate a laboratory known as the Laboratory of the Future, \n and uncover the secrets that lay hidden in it.");
            //Asks the player for their name
            do
            {
                Console.WriteLine("What is your name?");
                PlayerName = Console.ReadLine();
            } while (PlayerName == "");
            /* if (PlayerName == "")
             {
                 Console.WriteLine("Your name is now The Difficult Player");
                 PlayerName = "The Difficult Player";
             }  */
            //Ask the player for their age
            do
            {
                Console.WriteLine("How old are you?");
                PlayerAge = Console.ReadLine();
            } while (PlayerAge == "");
            //Catch, to make sure they enter in an age
            try
            {
                //Testing to see if input was a number in fact
                age = Int32.Parse(PlayerAge);
            }

            catch (FormatException)
            {
                //Realize the player failed to give an actual number, give them an age.
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
            Console.WriteLine("You arrive at the Laboratory. The building itself is a massive white facility. \n It's lined with large glass windows and bright lights. \nThere are two large, shiny white doors ahead!");
            Console.WriteLine("The front doors don't look too far away, no more than a 100 steps. \nIf you do not give the right amount of steps,\nYou will be forced to try again!");
            Console.ReadLine();
            //Do While loop, only allows player to move forward if they guess the right amount of steps, perhaps the number is too large though currently...
            do
            { 
               
                Console.WriteLine("How many steps do you wish to move?");
                PlayerInput = Console.ReadLine();
                bool Success = Int32.TryParse(PlayerInput, out StepsGiven);
           
                Steps =StepsGiven;
           
            
            
                Console.WriteLine("You took " + Steps + " steps to the door");
                
                
                /*StepsGiven = Int32.TryParse(in PlayerInput, out PlayerInputValue);
                if (Steps == 75)
                {
                    Console.WriteLine("You walked 75 steps, and made it exactly to the door");
                    Console.ReadLine();
                    break;

                } */
                
            } while (Steps != 75);
            Console.WriteLine("You may continue");
            Console.ReadLine();
            // while (PlayerInput ==); */
            //Catch if format is wrong, not reading the directions

            /*  try
                 {
                     StepsGiven = Int32.Parse(PlayerInput);

                 }
                 catch (FormatException)
                 {
                     //Now this will always bring the player in, instead of kicking them out. However, the game won't be as nice in the future.
                     StepsGiven = 0;
                     Console.WriteLine("I just needed a number man");
                     Console.WriteLine("Sigh, I'll let you in this time, but next time, try to read okay? \n Gonna assume you walked 0 steps and somehow made it to the house, don't question how.");
                     Console.ReadLine();
                     Console.WriteLine("Press any key to continue");
                     Console.ReadLine();
                     //System.Environment.Exit(0); 
                 } */
            //Calculate the steps that they either overshot it by or needed more steps to make it.
            /*  if (StepsGiven == StepsNeeded)
              {
                  //The player is probably a witch if they guessed the number of steps on their first time
                  Console.WriteLine("Somehow you guessed the right amount of steps, suspicious");
                  Console.WriteLine("Press any key to continue");
                  Console.ReadLine();

              }
              else if (StepsGiven > StepsNeeded)
              {
                  //Bring the player to the door regardless of how much they miss it by
                  Console.WriteLine("You slammed right into the door... you overshot it by " + (StepsNeeded - StepsGiven).ToString() + " steps...\n That's gonna leave a mark... I'm not paying for your hospital bills! ");
                  Console.WriteLine("Press any key to continue");
                  Console.ReadLine();

              }
              else if (StepsGiven < StepsNeeded)
              {
                  //Bring the player to the door regardless of how many steps they were short of
                  Console.WriteLine("You barely missed the door by... " + (StepsNeeded - StepsGiven).ToString() + " steps. But it's okay!You tripped over your own legs somehow and slammed straight into the door. \n You're such a dummy!");
                  Console.WriteLine("Press any key to continue");
                  Console.ReadLine();
              }  */


            /*Door is locked, wait whattt??
            Console.WriteLine("Ha, you got all the way here, and yet the door is locked, " + PlayerName + ". Guess you'll need a key to get in!");
            Console.WriteLine("If you want in, you're gonna have to roll above a 4 with these two die... \nI know it's not necessarily a key, but it's what we've got.");
            Console.ReadLine();
            //Dice time, for the first die
            Console.WriteLine("Press any button to roll the first die");
            Console.ReadLine();
            Die1 = MyDice.Next(1, 6);
            Console.WriteLine("Your first die roll is " + Die1);
            Console.ReadLine();
            //Now the second die's turn
            Console.WriteLine("Press any button to roll the second die");
            Console.ReadLine();
            Die2 = MyDice.Next(1, 6);
            Console.WriteLine("Your second die roll is " + Die2);
            Console.ReadLine();
            //Remind them what they rolled
            Console.WriteLine("Your two rolls were " + Die1 + " and " + Die2);
            Console.ReadLine();
            int DieTotal = Die1 + Die2;
            //Similar to before, check to see if they fulfilled the criteria
            if (DieTotal >= RollNeeded)
            {
                //Tell the player that they passed the die game
                Console.WriteLine("Damn it, you rolled " + DieTotal + " I guess the door is unlocked now");
                Console.WriteLine("Press any key to continue");
                Console.ReadLine();
            }
            else if (DieTotal < RollNeeded)
            {
                //Tell the player that they failed the die game
                Console.WriteLine("You rolled " + DieTotal + " Ha, so you failed to get in");
                Console.ReadLine();
                Console.WriteLine("The lab is equipped with high tech security, whoops forgot to mention that. \n Because you failed to unlock the door... let's just say your death wasn't exactly pretty");
                Console.ReadLine();
                Console.WriteLine("Press any key to exit the game");
                Console.ReadLine();
                System.Environment.Exit(0);

            } */
            //Calling DieRoll(s) Method

            DieRoll();
            DieRoll(die1);


            //Return true or false, depends on what player does
            bool dieSuccess = FrontDoor(PlayerName);
            if (dieSuccess)
            {
                //Return true or false, depends on what player does
                bool Challenge = FrontDoorChallenge(Dragon,Serpent);
                if (Challenge)
                {
                    Console.WriteLine("You may continue forth");
                    Console.ReadLine();
                }
                else
                {
                    //Ends game
                    GameEnd();
                }
                
            }
            else
            {
                //Ends game
                GameEnd();
            }

            //Introduce the Lab to the player officially
            Console.WriteLine("Welcome to the Laboratory of the Future. It's a lot nicer than any other building you've prolly been in");
            Console.ReadLine();
            //Uses IndexOf to remove each comma, assigning a new string to it each time until it finds the right one
            string remove1 = myColors.Substring(myColors.IndexOf(",") + 1);
            string remove2 = remove1.Substring(remove1.IndexOf(",") + 1);
            string remove3 = remove2.Substring(0, remove2.IndexOf(","));
            Console.WriteLine("As you walk in you notice a " + remove3 + " colored statue of a dragon that is glowing quite brightly. \nMust be their mascot or something.");
            Console.ReadLine();
            
            
            //New Method
            BldgRooms();

          


            //Another New Method
             BasementRooms();

            /* static void BasementRooms()
             {
                 //Give the player some description of the new floor
                 Console.WriteLine("You enter the floor beneath the pillow fort, and it becomes clear how messed up this Laboratory is. \nThere's creepy paintings of kids frolicking together in bliss and harmony on the walls. \nThere are toys, broken and new scattered throughout the floor. \nAnd there even appears to be some type of goopy substance covering the floor. \nYou shutter to think what it could be, but decide to continue forth. \nYou've come this far, it's too late to go back now. \n...And too much effort, wandering through that pillow fort took a lot out of you.");
                 Console.ReadLine();
                 Console.WriteLine("Out of nowhere, you hear a voice ahead!! Your heart skips a beat.");
                 Console.ReadLine();
                 Console.WriteLine("'My my my, so you've made it this far. I'm shocked, really I am. \nMost goons give up before coming down here. They end up joining our team of researchers. \nThey love it here, and I'm sure you will too', the voice says with a cheerful tone.");
                 Console.ReadLine();
                 Console.WriteLine("You take a step forward in a defensive stance, however the voice says one last message before ending.");
                 Console.ReadLine();
                 Console.WriteLine("'This is a recording afterall, who knows if you'll make it to the end even. \nBut if you by chance do make it to the end, we'll be most shocked and pleased', \nThe voice giggles at such a loud tone that it makes you realize, they are not alone....");
                 Console.ReadLine();
                 Console.WriteLine("All of a sudden, the lights turn on. It reveals to you another map of the floor. \nIt's a much more simplified map than before, with a big red X on the map that says, \n'Come here if you dare!!'");
                 Console.ReadLine();
                 Console.WriteLine("With nothing else to lose, you continue moving forward through the floor");
                 Console.ReadLine();

             } */














        }

        static void GameEnd()
        {
            Console.WriteLine("You have died!! But surely you'll come back soon! \nAnd preferably not make the same mistakes again... ");
            Console.ReadLine();
            Console.WriteLine("Press any key to end the program");
            Console.ReadLine();
            System.Environment.Exit(0);
           

        }
        static void GameQuit()
        {
            Console.WriteLine("You decided to quit the game... for now. \nYou'll come back eventually... right?!");
            Console.ReadLine();
            Console.WriteLine("Press any key to end the program");
            Console.ReadLine();
            System.Environment.Exit(0);
        }
        static bool FrontDoor(String PlayerName)
        {
            //Random Attributes
            //Random MyDice = new Random();
           
            // PlayerInputValue;
            Console.WriteLine("Ha, you got all the way here, and yet the door is locked, " + PlayerName + ". Guess you'll need a key to get in!");
            Console.WriteLine("If you want in, you're gonna have to roll above a 10 with these two die... \nI know it's not necessarily a key, but it's what we've got.");
            Console.ReadLine();
            //Assinging int to the methods and what their die rolls end up equaling
            int Die1 = DieRoll();
            int Die2 = DieRoll(2);
            //Giving the total die roll
            Console.WriteLine("You rolled " + Die1 + " and " + Die2);
            const int RollNeeded = 10;
            int twoDie = Die1 + Die2;

            //Door is locked, wait whattt??
           
           /* //Dice time, for the first die
            Console.WriteLine("Press any button to roll the first die");
            Console.ReadLine();
            //Die1 = MyDice.Next(1, 6);
            Console.WriteLine("Your first die roll is " + Die1);
            Console.ReadLine();
            //Now the second die's turn
            Console.WriteLine("Press any button to roll the second die");
            Console.ReadLine();
            //Die2 = MyDice.Next(1, 6);
            Console.WriteLine("Your second die roll is " + Die2);
            Console.ReadLine();
            //Remind them what they rolled
            Console.WriteLine("Your two rolls were " + Die1 + " and " + Die2);
            Console.ReadLine();
            int DieTotal = Die1 + Die2; */
            //Similar to before, check to see if they fulfilled the criteria
            if (twoDie >= RollNeeded)
            {
                //Tell the player that they passed the die game
                Console.WriteLine("Damn it, you rolled " + twoDie + " I guess the door is unlocked now");
                Console.WriteLine("Press any key to continue");
                Console.ReadLine();
                return true;
                
            }
            else //DieTotal < RollNeeded
            {
                //Tell the player that they failed the die game
                Console.WriteLine("You rolled " + twoDie + " Ha, so you failed to get in");
                Console.ReadLine();
                return false;
                

            }

        }
        static bool FrontDoorChallenge(string Dragon, string Serpent)
        {
            Console.WriteLine("However, before you enter the door the Lab, two creatures block your path!");
            Console.ReadLine();
            Dragon = "A large, almost cyan colored dragon blocks your path. It's appearance comes across as majestic,\nand it's face is noble, like it's staring deep into your soul...";
           Serpent = "On the other hand. a medium sized greenish serpent blocks your path as well. \nWhereas the dragon came across as respectable,\nthe serpent feels as if it is peer pressuring you into doing something you'll regret";
            Console.WriteLine(Dragon);
            Console.ReadLine();
            Console.WriteLine(Serpent);
            /*Console.ReadLine();
            Console.WriteLine("The creatures ask you, which trial do you want to go through? \nThe Dragon's or the Serpent's?");
            Console.ReadLine(); */
            Console.WriteLine("The dragon asks you a question, and hopes that you look into your heart,\nand answer it truthfully.");
            Console.ReadLine();
            Console.WriteLine("Why did you come to this Lab?");
            Console.ReadLine();
            Console.WriteLine("Did you come here for fame and glory or for money? Answer (F)ame or (M)oney");
            string dragonAnswer = Console.ReadLine().Trim().ToUpper().Substring(0);

            switch (dragonAnswer)
            {


                //Choice Fame
                case "F":
                    Console.WriteLine("I came for fame and glory... though I know that's not true. \nI'm just out of college and I'm in need of funding");
                    Console.ReadLine();
                    Console.WriteLine("The dragon answers back to you,\n 'You have failed my trial, and for that the punishment is death");
                    Console.ReadLine();
                    return false;
                   
                    //Choice Money
                case "M":
                    Console.WriteLine("I came for money, as I am fresh out of college, and broke from college debt.");
                    Console.ReadLine();
                    Console.WriteLine("The dragon answers back to you,\n'I can sense that you are telling the truth,\nYou may proceed to the Serpent's Trial'");
                    Console.ReadLine();
                    break;
                    //Choice that results in none of the above
                default:
                    return false;

            }
            
            Console.WriteLine("The Serpent slithers up to you, and stares directly into your eyes,\nand asks you the following question");
            Console.ReadLine();
            Console.WriteLine("Do you think it's wrong to only want money in your life and nothing more? \n(O)nly Money or (S)omething more");
            string serpentAnswer = Console.ReadLine().Trim().ToUpper().Substring(0);

            switch (serpentAnswer)
            {
                //Choice Only Money
                case "O":
                    Console.WriteLine("Only money matters, that's all you need to live, nothing else!");
                    Console.ReadLine();
                    Console.WriteLine("The serpent answwers back,\n'While I enjoy your evil response,\nI can tell that this is not how you truly feel, as no one is as evil as myself");
                    Console.ReadLine();
                    Console.WriteLine("Your punishment is death");
                    Console.ReadLine();
                    return false;
                    //Choice Something Else
                case "S":
                    Console.WriteLine("There's something more to life than just money,\nAnd although I need money currently, I realize that I need more than it");
                    Console.ReadLine();
                    Console.WriteLine("The serpent answers back, \n'Sigh, what a boring, and yet truthful response. You may proceed'");
                    Console.ReadLine();
                    return true;
                //Choice that results in none of the above
                default:
                    return false;







            }




        }
        //Method for ending the game from the Nap Room
        static void NapEnd()
        {
            Console.WriteLine("Understandable, you're a bit too young to head towards the light. Guess you'll have to find another job then...");
            Console.WriteLine("Press any key to end the program");
            Console.ReadLine();
            System.Environment.Exit(0);
        }
        //Method for continuing the game from the Nap Room
        static void NapContinue()
        {

            Console.WriteLine("Oh you actually said yes? I totally thought you'd be too scared. \n.... Err, I mean, you head into the pillow fort...");
            Console.ReadLine();
            Console.WriteLine("You enter the pillow fort, and notice a large cushiony staircase. \nYou decide to head down below into the depths of the fort...");
            Console.ReadLine();

        }
        //Method for giving the Nap Prompt, instead of writing it each time, reduces character count
        static void NapPrompt()
        {
            Console.WriteLine("You enter the Nap Room. There's a bunch of beds and blankets everywhere, there's even a massive pillow fort. \nThe room makes you want to fall asleep... but you realize something! You're a young adult just out of college,\nyou never sleep! \nThis room has no effect on you! Though it does make you wonder if these scientists even get any work done with this room here...? ");
            Console.ReadLine();
            Console.WriteLine("There's a bright light glistening from the pillow fort, do you dare to head towards it?");
            Console.ReadLine();
            Console.WriteLine("Do you want to go into the pillow fort? Y/N");
        }
        //Method for the starting prompt for the Building Room Method itself
        static void BldgRoomStartUp()
        {
            Console.WriteLine("Inside of the Lab you notice many rooms that split off from the main central room. \nYou also notice a conveniently placed map that tells you which rooms are which.");
            Console.ReadLine();
            Console.WriteLine("The rooms that split off are as follows, The Game Room, The Common Room, The Research Facility, The Library, \nand The Nap Room.");
            Console.ReadLine();
            Console.WriteLine("Do you want to go to (G)ame, (C)ommon, (L)ibrary, (R)esearch or (N)ap or (Q)uit?");
        }
        //Method that gives the Game Room Prompt. This one is tentative, seeing how it looks before I decide if I want to keep it.
        static void GamePrompt()
        {
            Console.WriteLine("You enter the Game Room. Inside are a multitude of game consoles and table top games. You can see a Pool Table and Ping Pong Table. \n Other than that, the rest of the room is quite boring, as the walls completely black. \nSeems they really can't stand sunlight, though who could blame them.");
            Console.ReadLine();
        }
        //First DieRoll Method
        static int DieRoll()
        {
            Random MyDice = new Random();
            int die1 = MyDice.Next(1, 5);
           // Console.WriteLine(die1);
           // Console.ReadLine();
            return MyDice.Next(1, 5);
            
            



        }
        //Overloading the second DieRoll Method
        static int DieRoll(int die2)
        {
            Random MyDice = new Random();
            die2 = MyDice.Next(4, 8);
           // Console.WriteLine(die2);
           // Console.ReadLine();
            return MyDice.Next(4, 8);




        }
        static void NoInput()
        {

            Console.WriteLine("You gave no input, which shows you were not reading carefully...\nYou have to start over now.");
            Console.ReadLine();
            System.Environment.Exit(0);

        }
        //Method for the BldgRooms
        static void BldgRooms()
        {
            //Gives the player a sense of what rooms exist. Important that they are actually reading, and not just skipping through everything
            BldgRoomStartUp();
            string answer = Console.ReadLine().Trim().ToUpper().Substring(0);
            //Begins the long chain of switch and IF statements to make sure the player can go through each and every option
            //Always includes option to Quit
            switch (answer)
            {
                //Brings the player to the Game Room
                case "G":
                    GamePrompt();
                    //Console.WriteLine("There does not seem to be anything of note in here. I'd say head to another room, the closest room is the Common Room.");
                    //Console.ReadLine();
                    Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");
                    string answerG = Console.ReadLine().Trim().ToUpper().Substring(0);
                    if (answerG != "Y")
                    {
                        Console.WriteLine("Press any key to end the program");
                        Console.ReadLine();
                        System.Environment.Exit(0);
                    }

                    else if (answerG == "Y")
                    {
                        Console.WriteLine("Do you want to go to (C)ommon, (L)ibrary, (R)esearch or (N)ap or (Q)uit?");
                        string answerGNext = Console.ReadLine().Trim().ToUpper().Substring(0);
                        switch (answerGNext)
                        {
                            case "C":
                                Console.WriteLine("You enter the Common Room. There's not much in here other than a couple of tables and chairs in the center of the room. \nHowever, the room does smell amazing! It smells like the every single type of lunch food mixing together in a harmonious way! \nIt makes you want to come work here if you could be surrounded by this type of food every day. \n...Too bad you're in debt");
                                Console.ReadLine();
                                //Console.WriteLine("There does not seem to be anything of note in here. I'd say head to another room, the closest one is the Library");
                                //Console.ReadLine();
                                Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");
                                string answerGC = Console.ReadLine().Trim().ToUpper().Substring(0);
                                if (answerGC != "Y")
                                {
                                    Console.WriteLine("Press any key to end the program");
                                    Console.ReadLine();
                                    System.Environment.Exit(0);
                                }

                                else if (answerGC == "Y")
                                {
                                    Console.WriteLine("Do you want to go to (L)ibrary, (R)esearch, (N)ap or (Q)uit?");
                                    string answerGCNext = Console.ReadLine().Trim().ToUpper().Substring(0);
                                    switch (answerGCNext)
                                    {
                                        case "L":
                                            Console.WriteLine("You enter the Library. I hope you don't have a book obsession...because there are none in here! Yep, there appears to be no books, only a bunch of computers for use. \nIt is much easier to use them anyway. There used to be books here, but they all always disappeared and were never brought back, so the lab opted to get rid of them altogether. \nPeople suck");
                                            Console.ReadLine();
                                            //Console.WriteLine("There does not seem to be anything of note in here. I'd say head to another room,\nthe closest one is the Research Facility");
                                            //Console.ReadLine();
                                            Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");
                                            string answerGCL = Console.ReadLine().Trim().ToUpper().Substring(0);
                                            if (answerGCL != "Y")
                                            {
                                                Console.WriteLine("Press any key to end the program");
                                                Console.ReadLine();
                                                System.Environment.Exit(0);
                                            }

                                            else if (answerGCL == "Y")
                                            {
                                                Console.WriteLine("Do you want to go to (R)esearch, (N)ap, or (Q)uit?");
                                                string answerGCLNext = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                switch (answerGCLNext)
                                                {
                                                    case "R":
                                                        Console.WriteLine("You enter the Research Facility. The amount of white colored objects here hurts your eyes. \nThe tables are white, the walls are white, even the floor is completely white, with not a speck of dirt on it. \nThese scientists must be some type of super organisms, to be able to work without getting dirty...\nor they're actually responsible and know how to clean. \nHonestly, it could be either one");
                                                        Console.ReadLine();
                                                        //Console.WriteLine("There does not seem to be anything of note in here. I'd say head to another room, the closest one is the Nap Room");
                                                        //Console.ReadLine();
                                                        Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");
                                                        string answerGCLR = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                        if (answerGCLR != "Y")
                                                        {
                                                            Console.WriteLine("Press any key to end the program");
                                                            Console.ReadLine();
                                                            System.Environment.Exit(0);
                                                        }

                                                        else if (answerGCLR == "Y")
                                                        {
                                                            Console.WriteLine("Do you want to go to (N)ap, or (Q)uit?");
                                                            string answerGCLRNext = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                            switch (answerGCLRNext)
                                                            {
                                                                case "Q":
                                                                    GameQuit();
                                                                    break;
                                                                case "N":
                                                                    NapPrompt();
                                                                    string answer5 = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                                    //Determines whether the player is reading. Also determines what they selected.
                                                                    if (answer5 is not "Y")
                                                                    {
                                                                        Console.WriteLine("Understandable, you're a bit too young to head towards the light. Guess you'll have to find another job then...");
                                                                        Console.WriteLine("Press any key to end the program");
                                                                        Console.ReadLine();
                                                                        System.Environment.Exit(0);

                                                                    }
                                                                    //Sends the player to the next floor
                                                                    else if (answer5 is "Y")
                                                                    {
                                                                        Console.WriteLine("Oh you actually said yes? I totally thought you'd be too scared. \n.... Err, I mean, you head into the pillow fort...");
                                                                        Console.ReadLine();
                                                                        Console.WriteLine("You enter the pillow fort, and notice a large cushiony staircase. \nYou decide to head down below into the depths of the fort...");
                                                                        Console.ReadLine();
                                                                    }
                                                                    break;
                                                            }


                                                        }
                                                        break;
                                                    case "Q":
                                                        GameQuit();
                                                        break;
                                                    case "N":
                                                        NapPrompt();
                                                        string answer4 = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                        //Determines whether the player is reading. Also determines what they selected.
                                                        if (answer4 is not "Y")
                                                        {
                                                            NapEnd();

                                                        }
                                                        //Sends the player to the next floor
                                                        else if (answer4 is "Y")
                                                        {
                                                            NapContinue();
                                                        }
                                                        break;
                                                }
                                            }
                                            break;
                                        case "R":
                                            Console.WriteLine("You enter the Research Facility. The amount of white colored objects here hurts your eyes. \nThe tables are white, the walls are white, even the floor is completely white, with not a speck of dirt on it. \nThese scientists must be some type of super organisms, to be able to work without getting dirty...\nor they're actually responsible and know how to clean. \nHonestly, it could be either one");
                                            Console.ReadLine();
                                            //Console.WriteLine("There does not seem to be anything of note in here. I'd say head to another room, the closest one is the Nap Room");
                                            //Console.ReadLine();
                                            Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");
                                            string answerGCR = Console.ReadLine().Trim().ToUpper().Substring(0);
                                            if (answerGCR != "Y")
                                            {
                                                Console.WriteLine("Press any key to end the program");
                                                Console.ReadLine();
                                                System.Environment.Exit(0);
                                            }

                                            else if (answerGCR == "Y")
                                            {
                                                Console.WriteLine("Do you want to go to (L)ibrary, (N)ap, or (Q)uit?");
                                                string answerGCRNext = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                switch (answerGCRNext)
                                                {
                                                    case "L":

                                                        Console.WriteLine("You enter the Library. I hope you don't have a book obsession...because there are none in here! Yep, there appears to be no books, only a bunch of computers for use. \nIt is much easier to use them anyway. There used to be books here, but they all always disappeared and were never brought back, so the lab opted to get rid of them altogether. \nPeople suck");
                                                        Console.ReadLine();
                                                        Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");
                                                        string answerGCRL = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                        if (answerGCRL != "Y")
                                                        {
                                                            Console.WriteLine("Press any key to end the program");
                                                            Console.ReadLine();
                                                            System.Environment.Exit(0);
                                                        }

                                                        else if (answerGCRL == "Y")
                                                        {

                                                            Console.WriteLine("Do you want to go to (N)ap, or (Q)uit?");
                                                            string answerGCRLNext = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                            switch (answerGCRLNext)
                                                            {
                                                                case "Q":
                                                                    GameQuit();
                                                                    break;
                                                                case "N":
                                                                    NapPrompt();
                                                                    string answerGCRLBreakout = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                                    //Determines whether the player is reading. Also determines what they selected.
                                                                    if (answerGCRLBreakout is not "Y")
                                                                    {
                                                                        NapEnd();
                                                                    }
                                                                    //Sends the player to the next floor
                                                                    else if (answerGCRLBreakout is "Y")
                                                                    {
                                                                        NapContinue();

                                                                    }
                                                                    break;
                                                            }

                                                        }
                                                        break;

                                                    case "Q":
                                                        GameQuit();
                                                        break;
                                                    case "N":
                                                        NapPrompt();
                                                        string answerGLRBreakout = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                        //Determines whether the player is reading. Also determines what they selected.
                                                        if (answerGLRBreakout is not "Y")
                                                        {
                                                            NapEnd();
                                                        }
                                                        //Sends the player to the next floor
                                                        else if (answerGLRBreakout is "Y")
                                                        {
                                                            NapContinue();

                                                        }
                                                        break;

                                                }

                                            }

                                                break;
                                        case "Q":
                                            GameQuit();
                                            break;
                                        case "N":
                                            NapPrompt();
                                            string answer3 = Console.ReadLine().Trim().ToUpper().Substring(0);
                                            //Determines whether the player is reading. Also determines what they selected.
                                            if (answer3 is not "Y")
                                            {
                                                NapEnd();

                                            }
                                            //Sends the player to the next floor
                                            else if (answer3 is "Y")
                                            {
                                                NapContinue();

                                            }
                                            break;


                                    }

                                }
                                break;
                            case "L":
                                Console.WriteLine("You enter the Library. I hope you don't have a book obsession...because there are none in here! Yep, there appears to be no books, only a bunch of computers for use. \nIt is much easier to use them anyway. There used to be books here, but they all always disappeared and were never brought back, so the lab opted to get rid of them altogether. \nPeople suck");
                                Console.ReadLine();
                                //Console.WriteLine("There does not seem to be anything of note in here. I'd say head to another room,\nthe closest one is the Research Facility");
                                //Console.ReadLine();
                                Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");
                                string answerGL = Console.ReadLine().Trim().ToUpper().Substring(0);
                                if (answerGL != "Y")
                                {
                                    Console.WriteLine("Press any key to end the program");
                                    Console.ReadLine();
                                    System.Environment.Exit(0);
                                }

                                else if (answerGL == "Y")
                                {
                                    Console.WriteLine("Do you want to go to (C)ommon, (R)esearch, (N)ap, or (Q)uit?");
                                    string answerGLNext = Console.ReadLine().Trim().ToUpper().Substring(0);
                                    switch (answerGLNext)
                                    {
                                        case "C":
                                            Console.WriteLine("You enter the Common Room. There's not much in here other than a couple of tables and chairs in the center of the room. \nHowever, the room does smell amazing! It smells like the every single type of lunch food mixing together in a harmonious way! \nIt makes you want to come work here if you could be surrounded by this type of food every day. \n...Too bad you're in debt");
                                            Console.ReadLine();
                                            Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");
                                            string answerGLC = Console.ReadLine().Trim().ToUpper().Substring(0);
                                            if (answerGLC != "Y")
                                            {
                                                Console.WriteLine("Press any key to end the program");
                                                Console.ReadLine();
                                                System.Environment.Exit(0);
                                            }

                                            else if (answerGLC == "Y")
                                            {
                                                Console.WriteLine("Do you want to go to (R)esearch, (N)ap, or (Q)uit?");
                                                string answerGLCNext = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                switch (answerGLCNext)
                                                {
                                                    case "R":
                                                        Console.WriteLine("You enter the Research Facility. The amount of white colored objects here hurts your eyes. \nThe tables are white, the walls are white, even the floor is completely white, with not a speck of dirt on it. \nThese scientists must be some type of super organisms, to be able to work without getting dirty...\nor they're actually responsible and know how to clean. \nHonestly, it could be either one");
                                                        Console.ReadLine();
                                                        Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");
                                                        string answerGLCR = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                        if (answerGLCR != "Y")
                                                        {
                                                            Console.WriteLine("Press any key to end the program");
                                                            Console.ReadLine();
                                                            System.Environment.Exit(0);
                                                        }

                                                        else if (answerGLCR == "Y")
                                                        {

                                                            Console.WriteLine("Do you want to go to (N)ap, or (Q)uit?");
                                                            string answerGLCRNext = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                            switch (answerGLCRNext)
                                                            {
                                                                case "Q":
                                                                    GameQuit();
                                                                    break;
                                                                case "N":
                                                                    NapPrompt();
                                                                    string answerGLCRBreakout = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                                    //Determines whether the player is reading. Also determines what they selected.
                                                                    if (answerGLCRBreakout is not "Y")
                                                                    {
                                                                        NapEnd();

                                                                    }
                                                                    //Sends the player to the next floor
                                                                    else if (answerGLCRBreakout is "Y")
                                                                    {
                                                                        NapContinue();

                                                                    }
                                                                    break;


                                                            }


                                                        }
                                                        break;
                                                    case "Q":
                                                        GameQuit();
                                                        break;
                                                    case "N":
                                                        NapPrompt();
                                                        string answerGLCBreakout = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                        //Determines whether the player is reading. Also determines what they selected.
                                                        if (answerGLCBreakout is not "Y")
                                                        {
                                                            NapEnd();


                                                        }
                                                        //Sends the player to the next floor
                                                        else if (answerGLCBreakout is "Y")
                                                        {
                                                            NapEnd();
                                                        }
                                                        break;



                                                }


                                            }
                                            break;
                                        case "R":
                                            Console.WriteLine("You enter the Research Facility. The amount of white colored objects here hurts your eyes. \nThe tables are white, the walls are white, even the floor is completely white, with not a speck of dirt on it. \nThese scientists must be some type of super organisms, to be able to work without getting dirty...\nor they're actually responsible and know how to clean. \nHonestly, it could be either one");
                                            Console.ReadLine();
                                            string answerGR = Console.ReadLine().Trim().ToUpper().Substring(0);
                                            if (answerGR != "Y")
                                            {
                                                Console.WriteLine("Press any key to end the program");
                                                Console.ReadLine();
                                                System.Environment.Exit(0);
                                            }

                                            else if (answerGR == "Y")
                                            {

                                                Console.WriteLine("Do you want to go to (C)ommon, (L)ibrary, (N)ap, or (Q)uit?");
                                                string answerGRNext = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                switch (answerGRNext)
                                                {

                                                    case "C":

                                                        Console.WriteLine("You enter the Common Room. There's not much in here other than a couple of tables and chairs in the center of the room. \nHowever, the room does smell amazing! It smells like the every single type of lunch food mixing together in a harmonious way! \nIt makes you want to come work here if you could be surrounded by this type of food every day. \n...Too bad you're in debt");
                                                        Console.ReadLine();
                                                        Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");
                                                        string answerGRC = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                        if (answerGRC != "Y")
                                                        {
                                                            Console.WriteLine("Press any key to end the program");
                                                            Console.ReadLine();
                                                            System.Environment.Exit(0);
                                                        }

                                                        else if (answerGRC == "Y")
                                                        {

                                                            Console.WriteLine("Do you want to go to (L)ibrary, (N)ap, or (Q)uit?");
                                                            string answerGRCNext = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                            switch (answerGRCNext)
                                                            {

                                                                case "L":
                                                                    Console.WriteLine("You enter the Library. I hope you don't have a book obsession...because there are none in here! Yep, there appears to be no books, only a bunch of computers for use. \nIt is much easier to use them anyway. There used to be books here, but they all always disappeared and were never brought back, so the lab opted to get rid of them altogether. \nPeople suck");
                                                                    Console.ReadLine();
                                                                    string answerGRCL = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                                    if (answerGRCL != "Y")
                                                                    {
                                                                        Console.WriteLine("Press any key to end the program");
                                                                        Console.ReadLine();
                                                                        System.Environment.Exit(0);
                                                                    }

                                                                    else if (answerGRCL == "Y")
                                                                    {
                                                                        Console.WriteLine("Do you want to go to (N)ap, or (Q)uit?");
                                                                        string answerGRCLNext = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                                        switch (answerGRCLNext)
                                                                        {

                                                                            case "Q":
                                                                                GameQuit();
                                                                                break;
                                                                            case "N":
                                                                                NapPrompt();
                                                                                string answerGRCLBreakout = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                                                //Determines whether the player is reading. Also determines what they selected.
                                                                                if (answerGRCLBreakout is not "Y")
                                                                                {
                                                                                    NapEnd();

                                                                                }
                                                                                //Sends the player to the next floor
                                                                                else if (answerGRCLBreakout is "Y")
                                                                                {
                                                                                    NapContinue();

                                                                                }
                                                                                break;
                                                                        }

                                                                    }
                                                                    break;

                                                                case "Q":
                                                                    GameQuit();
                                                                    break;
                                                                case "N":
                                                                    NapPrompt();
                                                                    string answerGRCBreakout = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                                    //Determines whether the player is reading. Also determines what they selected.
                                                                    if (answerGRCBreakout is not "Y")
                                                                    {
                                                                        NapEnd();


                                                                    }
                                                                    //Sends the player to the next floor
                                                                    else if (answerGRCBreakout is "Y")
                                                                    {
                                                                        NapContinue();

                                                                    }
                                                                    break;



                                                            }

                                                        }
                                                        break;
                                                    case "L":

                                                        Console.WriteLine("You enter the Library. I hope you don't have a book obsession...because there are none in here! Yep, there appears to be no books, only a bunch of computers for use. \nIt is much easier to use them anyway. There used to be books here, but they all always disappeared and were never brought back, so the lab opted to get rid of them altogether. \nPeople suck");
                                                        Console.ReadLine();
                                                        string answerGRL = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                        if (answerGRL != "Y")
                                                        {
                                                            Console.WriteLine("Press any key to end the program");
                                                            Console.ReadLine();
                                                            System.Environment.Exit(0);
                                                        }

                                                        else if (answerGRL == "Y")
                                                        {
                                                            Console.WriteLine("Do you want to go to (C)ommon, (N)ap, or (Q)uit?");
                                                            string answerGRLNext = Console.ReadLine().Trim().ToUpper().Substring(0);

                                                            switch (answerGRLNext)
                                                            {
                                                                case "C":
                                                                    Console.WriteLine("You enter the Common Room. There's not much in here other than a couple of tables and chairs in the center of the room. \nHowever, the room does smell amazing! It smells like the every single type of lunch food mixing together in a harmonious way! \nIt makes you want to come work here if you could be surrounded by this type of food every day. \n...Too bad you're in debt");
                                                                    Console.ReadLine();
                                                                    Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");
                                                                    string answerGRLC = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                                    if (answerGRLC != "Y")
                                                                    {
                                                                        Console.WriteLine("Press any key to end the program");
                                                                        Console.ReadLine();
                                                                        System.Environment.Exit(0);
                                                                    }

                                                                    else if (answerGRLC == "Y")
                                                                    {

                                                                        Console.WriteLine("Do you want to go to (C)ommon, (N)ap, or (Q)uit?");
                                                                        string answerGRLCNext = Console.ReadLine().Trim().ToUpper().Substring(0);

                                                                        switch (answerGRLCNext)
                                                                        {
                                                                            case "Q":
                                                                                GameQuit();
                                                                                break;
                                                                            case "N":
                                                                                NapPrompt();
                                                                                string answerGRLCBreakout = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                                                //Determines whether the player is reading. Also determines what they selected.
                                                                                if (answerGRLCBreakout is not "Y")
                                                                                {
                                                                                    NapEnd();


                                                                                }
                                                                                //Sends the player to the next floor
                                                                                else if (answerGRLCBreakout is "Y")
                                                                                {
                                                                                    NapContinue();

                                                                                }
                                                                                break;


                                                                        }

                                                                    }
                                                                    break;
                                                                case "Q":
                                                                    GameQuit();
                                                                    break;
                                                                case "N":
                                                                    NapPrompt();
                                                                    string answerGRLBreakout = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                                    //Determines whether the player is reading. Also determines what they selected.
                                                                    if (answerGRLBreakout is not "Y")
                                                                    {
                                                                        NapEnd();


                                                                    }
                                                                    //Sends the player to the next floor
                                                                    else if (answerGRLBreakout is "Y")
                                                                    {
                                                                        NapContinue();

                                                                    }
                                                                    break;

                                                            }
                                                        }
                                                        break;
                                                    case "Q":
                                                        GameQuit();
                                                        break;
                                                    case "N":
                                                        NapPrompt();
                                                        string answerGRBreakout = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                        //Determines whether the player is reading. Also determines what they selected.
                                                        if (answerGRBreakout is not "Y")
                                                        {
                                                            NapEnd();


                                                        }
                                                        //Sends the player to the next floor
                                                        else if (answerGRBreakout is "Y")
                                                        {
                                                            NapContinue();

                                                        }
                                                        break;

                                                }

                                            }
                                            break;
                                        case "Q":
                                            GameQuit();
                                            break;
                                        case "N":
                                            NapPrompt();
                                            string answerGLBreakout = Console.ReadLine().Trim().ToUpper().Substring(0);
                                            //Determines whether the player is reading. Also determines what they selected.
                                            if (answerGLBreakout is not "Y")
                                            {
                                                NapEnd();


                                            }
                                            //Sends the player to the next floor
                                            else if (answerGLBreakout is "Y")
                                            {
                                                NapContinue();

                                            }
                                            break;
                                    }
                                }
                                break;
                            case "R":
                                Console.WriteLine("You enter the Research Facility. The amount of white colored objects here hurts your eyes. \nThe tables are white, the walls are white, even the floor is completely white, with not a speck of dirt on it. \nThese scientists must be some type of super organisms, to be able to work without getting dirty...\nor they're actually responsible and know how to clean. \nHonestly, it could be either one");
                                Console.ReadLine();
                                //Console.WriteLine("There does not seem to be anything of note in here. I'd say head to another room, the closest one is the Nap Room");
                                //Console.ReadLine();
                                break;
                            case "Q":
                                GameQuit();
                                break;
                            case "N":
                                NapPrompt();
                                string answer2 = Console.ReadLine().Trim().ToUpper().Substring(0);
                                //Determines whether the player is reading. Also determines what they selected.
                                if (answer2 is not "Y")
                                {
                                    NapEnd();

                                }
                                //Sends the player to the next floor
                                else if (answer2 is "Y")
                                {
                                    NapContinue();

                                }
                                break;

                        }
                    }
                    break;
                //goto case "C";
                //Brings the player to the Common Room
                case "C":
                    Console.WriteLine("You enter the Common Room. There's not much in here other than a couple of tables and chairs in the center of the room. \nHowever, the room does smell amazing! It smells like the every single type of lunch food mixing together in a harmonious way! \nIt makes you want to come work here if you could be surrounded by this type of food every day. \n...Too bad you're in debt");
                    Console.ReadLine();
                    //Console.WriteLine("There does not seem to be anything of note in here. I'd say head to another room, the closest one is the Library");
                    //Console.ReadLine();
                    Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");
                    string answerC = Console.ReadLine().Trim().ToUpper().Substring(0);
                    if (answerC != "Y")
                    {
                        Console.WriteLine("Press any key to end the program");
                        Console.ReadLine();
                        System.Environment.Exit(0);
                    }

                    else if (answerC == "Y")
                    {
                        Console.WriteLine("Do you want to go to (G)ame, (L)ibrary, (R)esearch or (N)ap or (Q)uit?");
                        string answerCNext = Console.ReadLine().Trim().ToUpper().Substring(0);

                        switch (answerCNext)
                        {
                            case "L":
                                Console.WriteLine("You enter the Library. I hope you don't have a book obsession...because there are none in here! Yep, there appears to be no books, only a bunch of computers for use. \nIt is much easier to use them anyway. There used to be books here, but they all always disappeared and were never brought back, so the lab opted to get rid of them altogether. \nPeople suck");
                                Console.ReadLine();
                                Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");
                                string answerCL = Console.ReadLine().Trim().ToUpper().Substring(0);

    
                                if (answerCL != "Y")
                                {
                                    Console.WriteLine("Press any key to end the program");
                                    Console.ReadLine();
                                    System.Environment.Exit(0);
                                }

                                else if (answerCL == "Y")
                                {

                                    Console.WriteLine("Do you want to go to (G)ame, (R)esearch, (N)ap, or (Q)uit?");
                                    string answerCLNext = Console.ReadLine().Trim().ToUpper().Substring(0);

                                    switch (answerCLNext)
                                    {
                                        case "G":

                                            GamePrompt();

                                            Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");
                                            string answerCLG = Console.ReadLine().Trim().ToUpper().Substring(0);

                                            if (answerCLG != "Y")
                                            {
                                                Console.WriteLine("Press any key to end the program");
                                                Console.ReadLine();
                                                System.Environment.Exit(0);
                                            }

                                            else if (answerCLG == "Y")
                                            {
                                                Console.WriteLine("Do you want to go to (R)esearch, (N)ap, or (Q)uit?");
                                                string answerCLGNext = Console.ReadLine().Trim().ToUpper().Substring(0);
                                               
                                                switch (answerCLGNext)
                                                {

                                                    case "R":
                                                        Console.WriteLine("You enter the Research Facility. The amount of white colored objects here hurts your eyes. \nThe tables are white, the walls are white, even the floor is completely white, with not a speck of dirt on it. \nThese scientists must be some type of super organisms, to be able to work without getting dirty...\nor they're actually responsible and know how to clean. \nHonestly, it could be either one");
                                                        Console.ReadLine();
                                                        Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");
                                                        string answerCLGR = Console.ReadLine().Trim().ToUpper().Substring(0);

                                                        if (answerCLGR != "Y")
                                                        {
                                                            Console.WriteLine("Press any key to end the program");
                                                            Console.ReadLine();
                                                            System.Environment.Exit(0);
                                                        }

                                                        else if (answerCLGR == "Y")
                                                        {

                                                            Console.WriteLine("Do you want to go to (N)ap, or (Q)uit?");
                                                            string answerCLGRNext = Console.ReadLine().Trim().ToUpper().Substring(0);

                                                            switch (answerCLGRNext)
                                                            {
                                                                case "Q":
                                                                    GameQuit();
                                                                    break;
                                                                case "N":
                                                                    NapPrompt();
                                                                    string answerCLGRBreakout = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                                    //Determines whether the player is reading. Also determines what they selected.
                                                                    if (answerCLGRBreakout is not "Y")
                                                                    {
                                                                        NapEnd();


                                                                    }
                                                                    //Sends the player to the next floor
                                                                    else if (answerCLGRBreakout is "Y")
                                                                    {
                                                                        NapContinue();
                                                                    }
                                                                    break;


                                                            }
                                                        }
                                                        break;
                                                    case "Q":
                                                        GameQuit();
                                                        break;
                                                    case "N":
                                                        NapPrompt();
                                                        string answerCLGBreakout = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                        //Determines whether the player is reading. Also determines what they selected.
                                                        if (answerCLGBreakout is not "Y")
                                                        {
                                                            NapEnd();


                                                        }
                                                        //Sends the player to the next floor
                                                        else if (answerCLGBreakout is "Y")
                                                        {
                                                            NapContinue();

                                                        }
                                                        break;

                                                }
                                            }
                                            break;


                                        case "R":

                                            Console.WriteLine("You enter the Research Facility. The amount of white colored objects here hurts your eyes. \nThe tables are white, the walls are white, even the floor is completely white, with not a speck of dirt on it. \nThese scientists must be some type of super organisms, to be able to work without getting dirty...\nor they're actually responsible and know how to clean. \nHonestly, it could be either one");
                                            Console.ReadLine();
                                            Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");
                                            string answerCLR = Console.ReadLine().Trim().ToUpper().Substring(0);

                                            if (answerCLR != "Y")
                                            {
                                                Console.WriteLine("Press any key to end the program");
                                                Console.ReadLine();
                                                System.Environment.Exit(0);
                                            }

                                            else if (answerCLR == "Y")
                                            {
                                                Console.WriteLine("Do you want to go to (G)ame, (N)ap, or (Q)uit?");
                                                string answerCLRNext = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                
                                                switch (answerCLRNext)
                                                {
                                                    case "G":

                                                        GamePrompt();

                                                        Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");
                                                        string answerCLRG = Console.ReadLine().Trim().ToUpper().Substring(0);


                                                        if (answerCLRG != "Y")
                                                        {
                                                            Console.WriteLine("Press any key to end the program");
                                                            Console.ReadLine();
                                                            System.Environment.Exit(0);
                                                        }

                                                        else if (answerCLRG == "Y")
                                                        {
                                                            Console.WriteLine("Do you want to go to (N)ap, or (Q)uit?");
                                                            string answerCLRGNext = Console.ReadLine().Trim().ToUpper().Substring(0);

                                                            switch (answerCLRGNext)
                                                            {
                                                                case "Q":
                                                                    GameQuit();
                                                                    break;
                                                                case "N":
                                                                    NapPrompt();
                                                                    string answerCLRGBreakout = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                                    //Determines whether the player is reading. Also determines what they selected.
                                                                    if (answerCLRGBreakout is not "Y")
                                                                    {
                                                                        NapEnd();


                                                                    }
                                                                    //Sends the player to the next floor
                                                                    else if (answerCLRGBreakout is "Y")
                                                                    {
                                                                        NapContinue();

                                                                    }
                                                                    break;
                                                            }
                                                        }
                                                        break;

                                                    case "Q":

                                                        GameQuit();
                                                        break;
                                                    case "N":

                                                        NapPrompt();
                                                        string answerCLRBreakout = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                        //Determines whether the player is reading. Also determines what they selected.
                                                        if (answerCLRBreakout is not "Y")
                                                        {
                                                            NapEnd();


                                                        }
                                                        //Sends the player to the next floor
                                                        else if (answerCLRBreakout is "Y")
                                                        {
                                                            NapContinue();

                                                        }
                                                        break;
                                                }
                                              
                                            }
                                            break;


                                        case "Q":

                                            GameQuit();
                                            break;
                                        case "N":

                                            NapPrompt();
                                            string answerCLBreakout = Console.ReadLine().Trim().ToUpper().Substring(0);
                                            //Determines whether the player is reading. Also determines what they selected.
                                            if (answerCLBreakout is not "Y")
                                            {
                                                NapEnd();

                                            }
                                            //Sends the player to the next floor
                                            else if (answerCLBreakout is "Y")
                                            {
                                                NapContinue();

                                            }
                                            break;
                                    }


                                }
                                break;
                            case "R":
                                Console.WriteLine("You enter the Research Facility. The amount of white colored objects here hurts your eyes. \nThe tables are white, the walls are white, even the floor is completely white, with not a speck of dirt on it. \nThese scientists must be some type of super organisms, to be able to work without getting dirty...\nor they're actually responsible and know how to clean. \nHonestly, it could be either one");
                                Console.ReadLine();
                                Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");
                                string answerCR = Console.ReadLine().Trim().ToUpper().Substring(0);


                                if (answerCR != "Y")
                                {
                                    Console.WriteLine("Press any key to end the program");
                                    Console.ReadLine();
                                    System.Environment.Exit(0);
                                }
                                else if (answerCR == "Y")
                                {
                                    Console.WriteLine("Do you want to go to (G)ame, (L)ibrary, (N)ap or (Q)uit?");
                                    string answerCRNext = Console.ReadLine().Trim().ToUpper().Substring(0);

                                    switch (answerCRNext)
                                    {
                                        case "G":
                                            Console.WriteLine("You enter the Game Room. Inside are a multitude of game consoles and table top games. You can see a Pool Table and Ping Pong Table. \n Other than that, the rest of the room is quite boring, as the walls completely black. \nSeems they really can't stand sunlight, though who could blame them.");
                                            Console.ReadLine();
                                            Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");
                                            string answerCRG = Console.ReadLine().Trim().ToUpper().Substring(0);


                                            if (answerCRG != "Y")
                                            {
                                                Console.WriteLine("Press any key to end the program");
                                                Console.ReadLine();
                                                System.Environment.Exit(0);
                                            }
                                            else if (answerCRG == "Y")
                                            {
                                                Console.WriteLine("Do you want to go to (L)ibrary, (N)ap or (Q)uit?");
                                                string answerCRGNext = Console.ReadLine().Trim().ToUpper().Substring(0);




                                            }
                                            break;
                                        case "L":
                                            Console.WriteLine("You enter the Library. I hope you don't have a book obsession...because there are none in here! Yep, there appears to be no books, only a bunch of computers for use. \nIt is much easier to use them anyway. There used to be books here, but they all always disappeared and were never brought back, so the lab opted to get rid of them altogether. \nPeople suck");
                                            Console.ReadLine();
                                            Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");
                                            string answerCRL = Console.ReadLine().Trim().ToUpper().Substring(0);


                                            if (answerCRL != "Y")
                                            {
                                                Console.WriteLine("Press any key to end the program");
                                                Console.ReadLine();
                                                System.Environment.Exit(0);
                                            }
                                            else if (answerCRL == "Y")
                                            {
                                                Console.WriteLine("Do you want to go to (G)ame, (N)ap or (Q)uit?");
                                                string answerCRLNext = Console.ReadLine().Trim().ToUpper().Substring(0);

                                                switch (answerCRLNext)
                                                {
                                                    case "G":
                                                        GamePrompt();

                                                        Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");
                                                        string answerCRLG = Console.ReadLine().Trim().ToUpper().Substring(0);

                                                        if (answerCRLG != "Y")
                                                        {
                                                            Console.WriteLine("Press any key to end the program");
                                                            Console.ReadLine();
                                                            System.Environment.Exit(0);
                                                        }
                                                        else if (answerCRLG == "Y")
                                                        {
                                                            Console.WriteLine("Do you want to go to (N)ap or (Q)uit?");
                                                            string answerCRLGNext = Console.ReadLine().Trim().ToUpper().Substring(0);

                                                            switch (answerCRLGNext)
                                                            {
                                                                case "Q":
                                                                    GameQuit();
                                                                    break;
                                                                case "N":
                                                                    NapPrompt();
                                                                    string answerCRLGBreakout = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                                    //Determines whether the player is reading. Also determines what they selected.
                                                                    if (answerCRLGBreakout is not "Y")
                                                                    {
                                                                        NapEnd();


                                                                    }
                                                                    //Sends the player to the next floor
                                                                    else if (answerCRLGBreakout is "Y")
                                                                    {
                                                                        NapContinue();

                                                                    }
                                                                    break;
                                                            }
                                                        }
                                                        break;

                                                    case "Q":
                                                        GameQuit();
                                                        break;
                                                    case "N":
                                                        NapPrompt();
                                                        string answerCRLBreakout = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                        //Determines whether the player is reading. Also determines what they selected.
                                                        if (answerCRLBreakout is not "Y")
                                                        {
                                                            NapEnd();


                                                        }
                                                        //Sends the player to the next floor
                                                        else if (answerCRLBreakout is "Y")
                                                        {
                                                            NapContinue();

                                                        }
                                                        break;


                                                }


                                            }
                                                break;

                                        case "Q":
                                            GameQuit();
                                            break;
                                        case "N":
                                            NapPrompt();
                                            string answerCRN = Console.ReadLine().Trim().ToUpper().Substring(0);
                                            //Determines whether the player is reading. Also determines what they selected.
                                            if (answerCRN is not "Y")
                                            {
                                                NapEnd();


                                            }
                                            //Sends the player to the next floor
                                            else if (answerCRN is "Y")
                                            {
                                                NapContinue();

                                            }
                                            break;
                                    }
                                }
                                break;

                                    


                            case "Q":
                                GameQuit();
                                break;
                            case "G":
                                GamePrompt();

                                Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");
                                string answerCG = Console.ReadLine().Trim().ToUpper().Substring(0);

                                if (answerCG != "Y")
                                {
                                    Console.WriteLine("Press any key to end the program");
                                    Console.ReadLine();
                                    System.Environment.Exit(0);
                                }

                                else if (answerCG == "Y")
                                {
                                    Console.WriteLine("Do you want to go to (L)ibrary, (R)esearch or (N)ap or (Q)uit?");
                                    string answerCGNext = Console.ReadLine().Trim().ToUpper().Substring(0);

                                    switch (answerCGNext)
                                    {
                                        case "L":
                                            Console.WriteLine("You enter the Library. I hope you don't have a book obsession...because there are none in here! Yep, there appears to be no books, only a bunch of computers for use. \nIt is much easier to use them anyway. There used to be books here, but they all always disappeared and were never brought back, so the lab opted to get rid of them altogether. \nPeople suck");
                                            Console.ReadLine();
                                            Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");
                                            string answerCGL = Console.ReadLine().Trim().ToUpper().Substring(0);


                                            if (answerCGL != "Y")
                                            {
                                                Console.WriteLine("Press any key to end the program");
                                                Console.ReadLine();
                                                System.Environment.Exit(0);
                                            }
                                            else if (answerCGL == "Y")
                                            {

                                            }
                                            break;
                                        case "R":
                                            Console.WriteLine("You enter the Research Facility. The amount of white colored objects here hurts your eyes. \nThe tables are white, the walls are white, even the floor is completely white, with not a speck of dirt on it. \nThese scientists must be some type of super organisms, to be able to work without getting dirty...\nor they're actually responsible and know how to clean. \nHonestly, it could be either one");
                                            Console.ReadLine();
                                            Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");
                                            string answerCGR = Console.ReadLine().Trim().ToUpper().Substring(0);

                                            if (answerCGR != "Y")
                                            {
                                                Console.WriteLine("Press any key to end the program");
                                                Console.ReadLine();
                                                System.Environment.Exit(0);
                                            }
                                            else if (answerCGR == "Y")
                                            {

                                            }
                                            break;

                                        case "Q":
                                            GameQuit();
                                            break;
                                        case "N":
                                            NapPrompt();
                                            string answerCGN = Console.ReadLine().Trim().ToUpper().Substring(0);
                                            //Determines whether the player is reading. Also determines what they selected.
                                            if (answerCGN is not "Y")
                                            {
                                                NapEnd();


                                            }
                                            //Sends the player to the next floor
                                            else if (answerCGN is "Y")
                                            {
                                                NapContinue();

                                            }
                                            break;
                                    }


                                    


                                }
                                break;

                            case "N":
                                NapPrompt();
                                string answerCG1Breakout = Console.ReadLine().Trim().ToUpper().Substring(0);
                                //Determines whether the player is reading. Also determines what they selected.
                                if (answerCG1Breakout is not "Y")
                                {
                                    NapEnd();


                                }
                                //Sends the player to the next floor
                                else if (answerCG1Breakout is "Y")
                                {
                                    NapContinue();

                                }
                                break;

                        }
                    }
                    break;
                //START OF ACTUAL CASE L
                case "L":
                    Console.WriteLine("You enter the Library. I hope you don't have a book obsession...because there are none in here! Yep, there appears to be no books, only a bunch of computers for use. \nIt is much easier to use them anyway. There used to be books here, but they all always disappeared and were never brought back, so the lab opted to get rid of them altogether. \nPeople suck");
                    Console.ReadLine();
                    Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");
                    string answerL = Console.ReadLine().Trim().ToUpper().Substring(0);
                    if (answerL != "Y")
                    {
                        Console.WriteLine("Press any key to end the program");
                        Console.ReadLine();
                        System.Environment.Exit(0);
                    }

                    else if (answerL == "Y")
                    {
                        Console.WriteLine("Do you want to go to (G)ame (C)ommon, (R)esearch or (N)ap or (Q)uit?");
                        string answerLNext = Console.ReadLine().Trim().ToUpper().Substring(0);

                        switch (answerLNext)
                        {
                            case "G":

                                GamePrompt();

                                Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");

                                string answerLG = Console.ReadLine().Trim().ToUpper().Substring(0);


                                if (answerLG != "Y")
                                {
                                    Console.WriteLine("Press any key to end the program");
                                    Console.ReadLine();
                                    System.Environment.Exit(0);
                                }

                                else if (answerLG == "Y")
                                {

                                    Console.WriteLine("Do you want to go to (C)ommon, (R)esearch, (N)ap, or (Q)uit?");
                                    string answerLGNext = Console.ReadLine().Trim().ToUpper().Substring(0);

                                    switch (answerLGNext)
                                    {
                                        case "C":

                                            Console.WriteLine("You enter the Common Room. There's not much in here other than a couple of tables and chairs in the center of the room. \nHowever, the room does smell amazing! It smells like the every single type of lunch food mixing together in a harmonious way! \nIt makes you want to come work here if you could be surrounded by this type of food every day. \n...Too bad you're in debt");
                                            Console.ReadLine();
                                            Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");

                                            string answerLGC = Console.ReadLine().Trim().ToUpper().Substring(0);


                                            if (answerLGC != "Y")
                                            {
                                                Console.WriteLine("Press any key to end the program");
                                                Console.ReadLine();
                                                System.Environment.Exit(0);
                                            }

                                            else if (answerLGC == "Y")
                                            {
                                                Console.WriteLine("Do you want to go to (R)esearch, (N)ap, or (Q)uit?");
                                                string answerLGCNext = Console.ReadLine().Trim().ToUpper().Substring(0);

                                                switch (answerLGCNext)
                                                {
                                                    case "R":

                                                        Console.WriteLine("You enter the Research Facility. The amount of white colored objects here hurts your eyes. \nThe tables are white, the walls are white, even the floor is completely white, with not a speck of dirt on it. \nThese scientists must be some type of super organisms, to be able to work without getting dirty...\nor they're actually responsible and know how to clean. \nHonestly, it could be either one");
                                                        Console.ReadLine();
                                                        Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");

                                                        string answerLGCR = Console.ReadLine().Trim().ToUpper().Substring(0);

                                                        if (answerLGCR != "Y")
                                                        {
                                                            Console.WriteLine("Press any key to end the program");
                                                            Console.ReadLine();
                                                            System.Environment.Exit(0);
                                                        }

                                                        else if (answerLGCR == "Y")
                                                        {

                                                            Console.WriteLine("Do you want to go to (N)ap, or (Q)uit?");
                                                            string answerLGCRNext = Console.ReadLine().Trim().ToUpper().Substring(0);

                                                            switch (answerLGCRNext)
                                                            {
                                                                case "Q":
                                                                    GameQuit();
                                                                    break;
                                                                case "N":
                                                                    NapPrompt();
                                                                    string answerLGCRBreakout = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                                    //Determines whether the player is reading. Also determines what they selected.
                                                                    if (answerLGCRBreakout is not "Y")
                                                                    {
                                                                        NapEnd();


                                                                    }
                                                                    //Sends the player to the next floor
                                                                    else if (answerLGCRBreakout is "Y")
                                                                    {
                                                                        NapContinue();

                                                                    }
                                                                    break;

                                                            }

                                                        }
                                                        break;

                                                    case "Q":
                                                        GameQuit();
                                                        break;
                                                    case "N":
                                                        NapPrompt();
                                                        string answerLGCBreakout = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                        //Determines whether the player is reading. Also determines what they selected.
                                                        if (answerLGCBreakout is not "Y")
                                                        {
                                                            NapEnd();


                                                        }
                                                        //Sends the player to the next floor
                                                        else if (answerLGCBreakout is "Y")
                                                        {
                                                            NapContinue();

                                                        }
                                                        break;


                                                }

                                            }
                                            break;

                                        case "R":

                                            Console.WriteLine("You enter the Research Facility. The amount of white colored objects here hurts your eyes. \nThe tables are white, the walls are white, even the floor is completely white, with not a speck of dirt on it. \nThese scientists must be some type of super organisms, to be able to work without getting dirty...\nor they're actually responsible and know how to clean. \nHonestly, it could be either one");
                                            Console.ReadLine();
                                            Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");

                                            string answerLGR = Console.ReadLine().Trim().ToUpper().Substring(0);


                                            if (answerLGR != "Y")
                                            {
                                                Console.WriteLine("Press any key to end the program");
                                                Console.ReadLine();
                                                System.Environment.Exit(0);
                                            }

                                            else if (answerLGR == "Y")
                                            {
                                                Console.WriteLine("Do you want to go to (C)ommon, (N)ap, or (Q)uit?");
                                                string answerLGRNext = Console.ReadLine().Trim().ToUpper().Substring(0);

                                                switch (answerLGRNext)
                                                {
                                                    case "C":
                                                        Console.WriteLine("You enter the Common Room. There's not much in here other than a couple of tables and chairs in the center of the room. \nHowever, the room does smell amazing! It smells like the every single type of lunch food mixing together in a harmonious way! \nIt makes you want to come work here if you could be surrounded by this type of food every day. \n...Too bad you're in debt");
                                                        Console.ReadLine();
                                                        Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");

                                                        string answerLGRC = Console.ReadLine().Trim().ToUpper().Substring(0);

                                                        if (answerLGRC != "Y")
                                                        {
                                                            Console.WriteLine("Press any key to end the program");
                                                            Console.ReadLine();
                                                            System.Environment.Exit(0);
                                                        }

                                                        else if (answerLGRC == "Y")
                                                        {

                                                            Console.WriteLine("Do you want to go to (N)ap, or (Q)uit?");
                                                            string answerLGRCNext = Console.ReadLine().Trim().ToUpper().Substring(0);

                                                            switch (answerLGRCNext)
                                                            {
                                                                case "Q":
                                                                    GameQuit();
                                                                    break;
                                                                case "N":
                                                                    NapPrompt();
                                                                    string answerLGRCBreakout = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                                    //Determines whether the player is reading. Also determines what they selected.
                                                                    if (answerLGRCBreakout is not "Y")
                                                                    {
                                                                        NapEnd();


                                                                    }
                                                                    //Sends the player to the next floor
                                                                    else if (answerLGRCBreakout is "Y")
                                                                    {
                                                                        NapContinue();

                                                                    }
                                                                    break;

                                                            }


                                                        }
                                                        break;

                                                    case "Q":
                                                        GameQuit();
                                                        break;
                                                    case "N":
                                                        NapPrompt();
                                                        string answerLGRBreakout = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                        //Determines whether the player is reading. Also determines what they selected.
                                                        if (answerLGRBreakout is not "Y")
                                                        {
                                                            NapEnd();


                                                        }
                                                        //Sends the player to the next floor
                                                        else if (answerLGRBreakout is "Y")
                                                        {
                                                            NapContinue();

                                                        }
                                                        break;

                                                }

                                            }
                                            break;


                                        case "Q":
                                            GameQuit();
                                            break;
                                        case "N":
                                            NapPrompt();
                                            string answerLGBreakout = Console.ReadLine().Trim().ToUpper().Substring(0);
                                            //Determines whether the player is reading. Also determines what they selected.
                                            if (answerLGBreakout is not "Y")
                                            {
                                                NapEnd();


                                            }
                                            //Sends the player to the next floor
                                            else if (answerLGBreakout is "Y")
                                            {
                                                NapContinue();

                                            }
                                            break;



                                    }
                                }
                                break;


                            case "C":

                                Console.WriteLine("You enter the Common Room. There's not much in here other than a couple of tables and chairs in the center of the room. \nHowever, the room does smell amazing! It smells like the every single type of lunch food mixing together in a harmonious way! \nIt makes you want to come work here if you could be surrounded by this type of food every day. \n...Too bad you're in debt");
                                Console.ReadLine();
                                Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");

                                string answerLC = Console.ReadLine().Trim().ToUpper().Substring(0);


                                if (answerLC != "Y")
                                {
                                    Console.WriteLine("Press any key to end the program");
                                    Console.ReadLine();
                                    System.Environment.Exit(0);
                                }

                                else if (answerLC == "Y")
                                {

                                    Console.WriteLine("Do you want to go to (G)ame, (R)esearch, (N)ap, or (Q)uit?");
                                    string answerLCNext = Console.ReadLine().Trim().ToUpper().Substring(0);

                                    switch (answerLCNext)
                                    {
                                        case "G":
                                            GamePrompt();

                                            Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");

                                            string answerLCG = Console.ReadLine().Trim().ToUpper().Substring(0);

                                            if (answerLCG != "Y")
                                            {
                                                Console.WriteLine("Press any key to end the program");
                                                Console.ReadLine();
                                                System.Environment.Exit(0);
                                            }

                                            else if (answerLCG == "Y")
                                            {
                                                Console.WriteLine("Do you want to go to (R)esearch, (N)ap, or (Q)uit?");
                                                string answerLCGNext = Console.ReadLine().Trim().ToUpper().Substring(0);

                                                switch (answerLCGNext)
                                                {
                                                    case "R":
                                                        Console.WriteLine("You enter the Research Facility. The amount of white colored objects here hurts your eyes. \nThe tables are white, the walls are white, even the floor is completely white, with not a speck of dirt on it. \nThese scientists must be some type of super organisms, to be able to work without getting dirty...\nor they're actually responsible and know how to clean. \nHonestly, it could be either one");
                                                        Console.ReadLine();
                                                        Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");

                                                        string answerLCGR = Console.ReadLine().Trim().ToUpper().Substring(0);

                                                        if (answerLCGR != "Y")
                                                        {
                                                            Console.WriteLine("Press any key to end the program");
                                                            Console.ReadLine();
                                                            System.Environment.Exit(0);
                                                        }

                                                        else if (answerLCGR == "Y")
                                                        {

                                                            Console.WriteLine("Do you want to go to (N)ap, or (Q)uit?");
                                                            string answerLCGRNext = Console.ReadLine().Trim().ToUpper().Substring(0);

                                                            switch (answerLCGRNext)
                                                            {

                                                                case "Q":
                                                                    GameQuit();
                                                                    break;
                                                                case "N":
                                                                    NapPrompt();
                                                                    string answerLCGRBreakout = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                                    //Determines whether the player is reading. Also determines what they selected.
                                                                    if (answerLCGRBreakout is not "Y")
                                                                    {
                                                                        NapEnd();


                                                                    }
                                                                    //Sends the player to the next floor
                                                                    else if (answerLCGRBreakout is "Y")
                                                                    {
                                                                        NapContinue();

                                                                    }
                                                                    break;


                                                            }

                                                        }
                                                        break;


                                                    case "Q":
                                                        GameQuit();
                                                        break;
                                                    case "N":
                                                        NapPrompt();
                                                        string answerLCGBreakout = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                        //Determines whether the player is reading. Also determines what they selected.
                                                        if (answerLCGBreakout is not "Y")
                                                        {
                                                            NapEnd();


                                                        }
                                                        //Sends the player to the next floor
                                                        else if (answerLCGBreakout is "Y")
                                                        {
                                                            NapContinue();

                                                        }
                                                        break;


                                                }

                                            }
                                            break;

                                        case "R":
                                            Console.WriteLine("You enter the Research Facility. The amount of white colored objects here hurts your eyes. \nThe tables are white, the walls are white, even the floor is completely white, with not a speck of dirt on it. \nThese scientists must be some type of super organisms, to be able to work without getting dirty...\nor they're actually responsible and know how to clean. \nHonestly, it could be either one");
                                            Console.ReadLine();
                                            Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");

                                            string answerLCR = Console.ReadLine().Trim().ToUpper().Substring(0);

                                            if (answerLCR != "Y")
                                            {
                                                Console.WriteLine("Press any key to end the program");
                                                Console.ReadLine();
                                                System.Environment.Exit(0);
                                            }

                                            else if (answerLCR == "Y")
                                            {

                                                Console.WriteLine("Do you want to go to (G)ame, (N)ap, or (Q)uit?");
                                                string answerLCRNext = Console.ReadLine().Trim().ToUpper().Substring(0);

                                                switch (answerLCRNext)
                                                {
                                                    case "G":
                                                        Console.WriteLine("You enter the Game Room. Inside are a multitude of game consoles and table top games. You can see a Pool Table and Ping Pong Table. \n Other than that, the rest of the room is quite boring, as the walls completely black. \nSeems they really can't stand sunlight, though who could blame them.");
                                                        Console.ReadLine();
                                                        Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");

                                                        string answerLCRG = Console.ReadLine().Trim().ToUpper().Substring(0);


                                                        if (answerLCRG != "Y")
                                                        {
                                                            Console.WriteLine("Press any key to end the program");
                                                            Console.ReadLine();
                                                            System.Environment.Exit(0);
                                                        }

                                                        else if (answerLCRG == "Y")
                                                        {

                                                            Console.WriteLine("Do you want to go to (N)ap, or (Q)uit?");
                                                            string answerLCRGNext = Console.ReadLine().Trim().ToUpper().Substring(0);

                                                            switch (answerLCRGNext)
                                                            {

                                                                case "Q":
                                                                    GameQuit();
                                                                    break;
                                                                case "N":
                                                                    NapPrompt();
                                                                    string answerLCRGBreakout = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                                    //Determines whether the player is reading. Also determines what they selected.
                                                                    if (answerLCRGBreakout is not "Y")
                                                                    {
                                                                        NapEnd();

                                                                    }
                                                                    //Sends the player to the next floor
                                                                    else if (answerLCRGBreakout is "Y")
                                                                    {
                                                                        NapContinue();

                                                                    }
                                                                    break;

                                                            }

                                                        }
                                                        break;

                                                    case "Q":
                                                        GameQuit();
                                                        break;
                                                    case "N":
                                                        NapPrompt();
                                                        string answerLCRBreakout = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                        //Determines whether the player is reading. Also determines what they selected.
                                                        if (answerLCRBreakout is not "Y")
                                                        {
                                                            NapEnd();


                                                        }
                                                        //Sends the player to the next floor
                                                        else if (answerLCRBreakout is "Y")
                                                        {
                                                            NapContinue();

                                                        }
                                                        break;

                                                }
                                            }
                                            break;

                                        case "Q":
                                            GameQuit();
                                            break;
                                        case "N":
                                            NapPrompt();
                                            string answerLCBreakout = Console.ReadLine().Trim().ToUpper().Substring(0);
                                            //Determines whether the player is reading. Also determines what they selected.
                                            if (answerLCBreakout is not "Y")
                                            {
                                                NapEnd();


                                            }
                                            //Sends the player to the next floor
                                            else if (answerLCBreakout is "Y")
                                            {
                                                NapContinue();

                                            }
                                            break;

                                    }
                                }
                                break;

                            case "R":

                                Console.WriteLine("You enter the Research Facility. The amount of white colored objects here hurts your eyes. \nThe tables are white, the walls are white, even the floor is completely white, with not a speck of dirt on it. \nThese scientists must be some type of super organisms, to be able to work without getting dirty...\nor they're actually responsible and know how to clean. \nHonestly, it could be either one");
                                Console.ReadLine();
                                Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");

                                string answerLR = Console.ReadLine().Trim().ToUpper().Substring(0);


                                if (answerLR != "Y")
                                {
                                    Console.WriteLine("Press any key to end the program");
                                    Console.ReadLine();
                                    System.Environment.Exit(0);
                                }

                                else if (answerLR == "Y")
                                {

                                    Console.WriteLine("Do you want to go to (G)ame, (C)ommon, (N)ap, or (Q)uit?");
                                    string answerLRNext = Console.ReadLine().Trim().ToUpper().Substring(0);

                                    switch (answerLRNext)
                                    {
                                        case "G":
                                            GamePrompt();

                                            Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");

                                            string answerLRG = Console.ReadLine().Trim().ToUpper().Substring(0);


                                            if (answerLRG != "Y")
                                            {
                                                Console.WriteLine("Press any key to end the program");
                                                Console.ReadLine();
                                                System.Environment.Exit(0);
                                            }

                                            else if (answerLRG == "Y")
                                            {

                                                Console.WriteLine("Do you want to go to (C)ommon, (N)ap, or (Q)uit?");
                                                string answerLRGNext = Console.ReadLine().Trim().ToUpper().Substring(0);

                                                switch (answerLRGNext)
                                                {
                                                    case "C":
                                                        Console.WriteLine("You enter the Common Room. There's not much in here other than a couple of tables and chairs in the center of the room. \nHowever, the room does smell amazing! It smells like the every single type of lunch food mixing together in a harmonious way! \nIt makes you want to come work here if you could be surrounded by this type of food every day. \n...Too bad you're in debt");
                                                        Console.ReadLine();
                                                        Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");

                                                        string answerLRGC = Console.ReadLine().Trim().ToUpper().Substring(0);


                                                        if (answerLRGC != "Y")
                                                        {
                                                            Console.WriteLine("Press any key to end the program");
                                                            Console.ReadLine();
                                                            System.Environment.Exit(0);
                                                        }

                                                        else if (answerLRGC == "Y")
                                                        {


                                                            Console.WriteLine("Do you want to go to (N)ap, or (Q)uit?");
                                                            string answerLRGCNext = Console.ReadLine().Trim().ToUpper().Substring(0);

                                                            switch (answerLRGCNext)
                                                            {
                                                                case "Q":
                                                                    GameQuit();
                                                                    break;
                                                                case "N":
                                                                    NapPrompt();
                                                                    string answerLRGCBreakout = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                                    //Determines whether the player is reading. Also determines what they selected.
                                                                    if (answerLRGCBreakout is not "Y")
                                                                    {
                                                                        NapEnd();


                                                                    }
                                                                    //Sends the player to the next floor
                                                                    else if (answerLRGCBreakout is "Y")
                                                                    {
                                                                        NapContinue();

                                                                    }
                                                                    break;


                                                            }

                                                        }
                                                        break;


                                                    case "Q":
                                                        GameQuit();
                                                        break;
                                                    case "N":
                                                        NapPrompt();
                                                        string answerLRGBreakout = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                        //Determines whether the player is reading. Also determines what they selected.
                                                        if (answerLRGBreakout is not "Y")
                                                        {
                                                            NapEnd();


                                                        }
                                                        //Sends the player to the next floor
                                                        else if (answerLRGBreakout is "Y")
                                                        {
                                                            NapContinue();

                                                        }
                                                        break;

                                                }

                                            }
                                            break;

                                        case "C":
                                            Console.WriteLine("You enter the Common Room. There's not much in here other than a couple of tables and chairs in the center of the room. \nHowever, the room does smell amazing! It smells like the every single type of lunch food mixing together in a harmonious way! \nIt makes you want to come work here if you could be surrounded by this type of food every day. \n...Too bad you're in debt");
                                            Console.ReadLine();
                                            Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");

                                            string answerLRC = Console.ReadLine().Trim().ToUpper().Substring(0);


                                            if (answerLRC != "Y")
                                            {
                                                Console.WriteLine("Press any key to end the program");
                                                Console.ReadLine();
                                                System.Environment.Exit(0);
                                            }

                                            else if (answerLRC == "Y")
                                            {


                                                Console.WriteLine("Do you want to go to (G)ame, (N)ap, or (Q)uit?");
                                                string answerLRCNext = Console.ReadLine().Trim().ToUpper().Substring(0);

                                                switch (answerLRCNext)
                                                {

                                                    case "G":

                                                        Console.WriteLine("You enter the Game Room. Inside are a multitude of game consoles and table top games. You can see a Pool Table and Ping Pong Table. \n Other than that, the rest of the room is quite boring, as the walls completely black. \nSeems they really can't stand sunlight, though who could blame them.");
                                                        Console.ReadLine();
                                                        Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");

                                                        string answerLRCG = Console.ReadLine().Trim().ToUpper().Substring(0);

                                                        if (answerLRCG != "Y")
                                                        {
                                                            Console.WriteLine("Press any key to end the program");
                                                            Console.ReadLine();
                                                            System.Environment.Exit(0);
                                                        }

                                                        else if (answerLRCG == "Y")
                                                        {
                                                            Console.WriteLine("Do you want to go to (N)ap, or (Q)uit?");
                                                            string answerLRCGNext = Console.ReadLine().Trim().ToUpper().Substring(0);

                                                            switch (answerLRCGNext)
                                                            {

                                                                case "Q":
                                                                    GameQuit();
                                                                    break;
                                                                case "N":
                                                                    NapPrompt();
                                                                    string answerLRCGNBreakout = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                                    //Determines whether the player is reading. Also determines what they selected.
                                                                    if (answerLRCGNBreakout is not "Y")
                                                                    {
                                                                        NapEnd();


                                                                    }
                                                                    //Sends the player to the next floor
                                                                    else if (answerLRCGNBreakout is "Y")
                                                                    {
                                                                        NapContinue();

                                                                    }
                                                                    break;
                                                            }

                                                        }
                                                        break;

                                                    case "Q":
                                                        GameQuit();
                                                        break;
                                                    case "N":
                                                        NapPrompt();
                                                        string answerLRCGBreakout = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                        //Determines whether the player is reading. Also determines what they selected.
                                                        if (answerLRCGBreakout is not "Y")
                                                        {
                                                            NapEnd();

                                                        }
                                                        //Sends the player to the next floor
                                                        else if (answerLRCGBreakout is "Y")
                                                        {
                                                            NapContinue();

                                                        }
                                                        break;

                                                }

                                            }
                                            break;

                                        case "Q":
                                            GameQuit();
                                            break;
                                        case "N":
                                            NapPrompt();
                                            string answerLRCBreakout = Console.ReadLine().Trim().ToUpper().Substring(0);
                                            //Determines whether the player is reading. Also determines what they selected.
                                            if (answerLRCBreakout is not "Y")
                                            {
                                                NapEnd();

                                            }
                                            //Sends the player to the next floor
                                            else if (answerLRCBreakout is "Y")
                                            {
                                                NapContinue();

                                            }
                                            break;


                                    }
                                }
                                break;


                            case "Q":

                                GameQuit();
                                break;
                            case "N":

                                NapPrompt();
                                string answerLBreakout = Console.ReadLine().Trim().ToUpper().Substring(0);
                                //Determines whether the player is reading. Also determines what they selected.
                                if (answerLBreakout is not "Y")
                                {
                                    NapEnd();


                                }
                                //Sends the player to the next floor
                                else if (answerLBreakout is "Y")
                                {
                                    NapContinue();

                                }
                                break;
                        }
                    }
                    break;
                //THIS IS THE START, THE ACTUAL START OF CASE R
                case "R":
                    Console.WriteLine("You enter the Research Facility. The amount of white colored objects here hurts your eyes. \nThe tables are white, the walls are white, even the floor is completely white, with not a speck of dirt on it. \nThese scientists must be some type of super organisms, to be able to work without getting dirty...\nor they're actually responsible and know how to clean. \nHonestly, it could be either one");
                    Console.ReadLine();
                    Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");
                    string answerR = Console.ReadLine().Trim().ToUpper().Substring(0);
                    if (answerR != "Y")
                    {
                        Console.WriteLine("Press any key to end the program");
                        Console.ReadLine();
                        System.Environment.Exit(0);
                    }

                    else if (answerR == "Y")
                    {
                        Console.WriteLine("Do you want to go to (G)ame, (C)ommon, (L)ibrary, (N)ap, or (Q)uit?");
                        string answerRNext = Console.ReadLine().Trim().ToUpper().Substring(0);

                        switch (answerRNext)
                        {
                            case "G":

                                GamePrompt();

                                Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");

                                string answerRG = Console.ReadLine().Trim().ToUpper().Substring(0);

                                if (answerRG != "Y")
                                {
                                    Console.WriteLine("Press any key to end the program");
                                    Console.ReadLine();
                                    System.Environment.Exit(0);
                                }

                                else if (answerRG == "Y")
                                {

                                    Console.WriteLine("Do you want to go to  (C)ommon, (L)ibrary, (N)ap, or (Q)uit?");
                                    string answerRGNext = Console.ReadLine().Trim().ToUpper().Substring(0);

                                    switch (answerRGNext)
                                    {

                                        case "C":

                                            Console.WriteLine("You enter the Common Room. There's not much in here other than a couple of tables and chairs in the center of the room. \nHowever, the room does smell amazing! It smells like the every single type of lunch food mixing together in a harmonious way! \nIt makes you want to come work here if you could be surrounded by this type of food every day. \n...Too bad you're in debt");
                                            Console.ReadLine();
                                            Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");

                                            string answerRGC = Console.ReadLine().Trim().ToUpper().Substring(0);

                                            if (answerRGC != "Y")
                                            {
                                                Console.WriteLine("Press any key to end the program");
                                                Console.ReadLine();
                                                System.Environment.Exit(0);
                                            }

                                            else if (answerRGC == "Y")
                                            {


                                                Console.WriteLine("Do you want to go to (L)ibrary, (N)ap, or (Q)uit?");
                                                string answerRGCNext = Console.ReadLine().Trim().ToUpper().Substring(0);

                                                switch (answerRGCNext)
                                                {
                                                    case "L":
                                                        Console.WriteLine("You enter the Library. I hope you don't have a book obsession...because there are none in here! Yep, there appears to be no books, only a bunch of computers for use. \nIt is much easier to use them anyway. There used to be books here, but they all always disappeared and were never brought back, so the lab opted to get rid of them altogether. \nPeople suck");
                                                        Console.ReadLine();
                                                        Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");

                                                        string answerRGCL = Console.ReadLine().Trim().ToUpper().Substring(0);

                                                        if (answerRGCL != "Y")
                                                        {
                                                            Console.WriteLine("Press any key to end the program");
                                                            Console.ReadLine();
                                                            System.Environment.Exit(0);
                                                        }

                                                        else if (answerRGCL == "Y")
                                                        {

                                                            Console.WriteLine("Do you want to go to (N)ap, or (Q)uit?");
                                                            string answerRGCLNext = Console.ReadLine().Trim().ToUpper().Substring(0);

                                                            switch (answerRGCLNext)
                                                            {

                                                                case "Q":
                                                                    GameQuit();
                                                                    break;
                                                                case "N":
                                                                    NapPrompt();
                                                                    string answerRGCLBreakout = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                                    //Determines whether the player is reading. Also determines what they selected.
                                                                    if (answerRGCLBreakout is not "Y")
                                                                    {
                                                                        NapEnd();


                                                                    }
                                                                    //Sends the player to the next floor
                                                                    else if (answerRGCLBreakout is "Y")
                                                                    {
                                                                        NapContinue();

                                                                    }
                                                                    break;

                                                            }

                                                        }
                                                        break;

                                                    case "Q":
                                                        GameQuit();
                                                        break;
                                                    case "N":
                                                        NapPrompt();
                                                        string answerRGCBreakout = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                        //Determines whether the player is reading. Also determines what they selected.
                                                        if (answerRGCBreakout is not "Y")
                                                        {
                                                            NapEnd();


                                                        }
                                                        //Sends the player to the next floor
                                                        else if (answerRGCBreakout is "Y")
                                                        {
                                                            NapContinue();

                                                        }
                                                        break;



                                                }

                                            }
                                            break;

                                        case "L":

                                            Console.WriteLine("You enter the Library. I hope you don't have a book obsession...because there are none in here! Yep, there appears to be no books, only a bunch of computers for use. \nIt is much easier to use them anyway. There used to be books here, but they all always disappeared and were never brought back, so the lab opted to get rid of them altogether. \nPeople suck");
                                            Console.ReadLine();
                                            Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");
                                            string answerRGL = Console.ReadLine().Trim().ToUpper().Substring(0);

                                            if (answerRGL != "Y")
                                            {
                                                Console.WriteLine("Press any key to end the program");
                                                Console.ReadLine();
                                                System.Environment.Exit(0);
                                            }

                                            else if (answerRGL == "Y")
                                            {


                                                Console.WriteLine("Do you want to go to (C)ommon, (N)ap, or (Q)uit?");
                                                string answerRGLNext = Console.ReadLine().Trim().ToUpper().Substring(0);

                                                switch (answerRGLNext)
                                                {
                                                    case "C":

                                                        Console.WriteLine("You enter the Common Room. There's not much in here other than a couple of tables and chairs in the center of the room. \nHowever, the room does smell amazing! It smells like the every single type of lunch food mixing together in a harmonious way! \nIt makes you want to come work here if you could be surrounded by this type of food every day. \n...Too bad you're in debt");
                                                        Console.ReadLine();
                                                        Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");

                                                        string answerRGLC = Console.ReadLine().Trim().ToUpper().Substring(0);

                                                        if (answerRGLC != "Y")
                                                        {
                                                            Console.WriteLine("Press any key to end the program");
                                                            Console.ReadLine();
                                                            System.Environment.Exit(0);
                                                        }

                                                        else if (answerRGLC == "Y")
                                                        {

                                                            Console.WriteLine("Do you want to go to (N)ap, or (Q)uit?");
                                                            string answerRGLCNext = Console.ReadLine().Trim().ToUpper().Substring(0);

                                                            switch (answerRGLCNext)
                                                            {

                                                                case "Q":
                                                                    GameQuit();
                                                                    break;
                                                                case "N":
                                                                    NapPrompt();
                                                                    string answerRGLCBreakout = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                                    //Determines whether the player is reading. Also determines what they selected.
                                                                    if (answerRGLCBreakout is not "Y")
                                                                    {
                                                                        NapEnd();


                                                                    }
                                                                    //Sends the player to the next floor
                                                                    else if (answerRGLCBreakout is "Y")
                                                                    {
                                                                        NapContinue();

                                                                    }
                                                                    break;

                                                            }
                                                        }
                                                        break;

                                                    case "Q":
                                                        GameQuit();
                                                        break;
                                                    case "N":
                                                        NapPrompt();
                                                        string answerRGLBreakout = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                        //Determines whether the player is reading. Also determines what they selected.
                                                        if (answerRGLBreakout is not "Y")
                                                        {
                                                            NapEnd();


                                                        }
                                                        //Sends the player to the next floor
                                                        else if (answerRGLBreakout is "Y")
                                                        {
                                                            NapContinue();

                                                        }
                                                        break;

                                                }

                                            }
                                            break;

                                        case "Q":
                                            GameQuit();
                                            break;
                                        case "N":
                                            NapPrompt();
                                            string answerRGBreakout = Console.ReadLine().Trim().ToUpper().Substring(0);
                                            //Determines whether the player is reading. Also determines what they selected.
                                            if (answerRGBreakout is not "Y")
                                            {
                                                NapEnd();


                                            }
                                            //Sends the player to the next floor
                                            else if (answerRGBreakout is "Y")
                                            {
                                                NapContinue();

                                            }
                                            break;

                                    }
                                }
                                break;

                            case "C":


                                Console.WriteLine("You enter the Common Room. There's not much in here other than a couple of tables and chairs in the center of the room. \nHowever, the room does smell amazing! It smells like the every single type of lunch food mixing together in a harmonious way! \nIt makes you want to come work here if you could be surrounded by this type of food every day. \n...Too bad you're in debt");
                                Console.ReadLine();
                                Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");

                                string answerRC = Console.ReadLine().Trim().ToUpper().Substring(0);

                                if (answerRC != "Y")
                                {
                                    Console.WriteLine("Press any key to end the program");
                                    Console.ReadLine();
                                    System.Environment.Exit(0);
                                }

                                else if (answerRC == "Y")
                                {

                                    Console.WriteLine("Do you want to go to (G)ame, (L)ibrary, (N)ap, or (Q)uit?");
                                    string answerRCNext = Console.ReadLine().Trim().ToUpper().Substring(0);

                                    switch (answerRCNext)
                                    {

                                        case "G":

                                            Console.WriteLine("You enter the Game Room. Inside are a multitude of game consoles and table top games. You can see a Pool Table and Ping Pong Table. \n Other than that, the rest of the room is quite boring, as the walls completely black. \nSeems they really can't stand sunlight, though who could blame them.");
                                            Console.ReadLine();
                                            Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");

                                            string answerRCG = Console.ReadLine().Trim().ToUpper().Substring(0);

                                            if (answerRCG != "Y")
                                            {
                                                Console.WriteLine("Press any key to end the program");
                                                Console.ReadLine();
                                                System.Environment.Exit(0);
                                            }

                                            else if (answerRCG == "Y")
                                            {


                                                Console.WriteLine("Do you want to go to (L)ibrary, (N)ap, or (Q)uit?");
                                                string answerRCGNext = Console.ReadLine().Trim().ToUpper().Substring(0);

                                                switch (answerRCGNext)
                                                {

                                                    case "L":

                                                        Console.WriteLine("You enter the Library. I hope you don't have a book obsession...because there are none in here! Yep, there appears to be no books, only a bunch of computers for use. \nIt is much easier to use them anyway. There used to be books here, but they all always disappeared and were never brought back, so the lab opted to get rid of them altogether. \nPeople suck");
                                                        Console.ReadLine();
                                                        Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");
                                                        string answerRCGL = Console.ReadLine().Trim().ToUpper().Substring(0);

                                                        if (answerRCGL != "Y")
                                                        {
                                                            Console.WriteLine("Press any key to end the program");
                                                            Console.ReadLine();
                                                            System.Environment.Exit(0);
                                                        }

                                                        else if (answerRCGL == "Y")
                                                        {

                                                            Console.WriteLine("Do you want to go to (N)ap, or (Q)uit?");
                                                            string answerRCGLNext = Console.ReadLine().Trim().ToUpper().Substring(0);

                                                            switch (answerRCGLNext)
                                                            {

                                                                case "Q":
                                                                    GameQuit();
                                                                    break;
                                                                case "N":
                                                                    NapPrompt();
                                                                    string answerRCGLBreakout = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                                    //Determines whether the player is reading. Also determines what they selected.
                                                                    if (answerRCGLBreakout is not "Y")
                                                                    {
                                                                        NapEnd();


                                                                    }
                                                                    //Sends the player to the next floor
                                                                    else if (answerRCGLBreakout is "Y")
                                                                    {
                                                                        NapContinue();

                                                                    }
                                                                    break;

                                                            }
                                                        }
                                                        break;

                                                    case "Q":
                                                        GameQuit();
                                                        break;
                                                    case "N":
                                                        NapPrompt();
                                                        string answerRCGBreakout = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                        //Determines whether the player is reading. Also determines what they selected.
                                                        if (answerRCGBreakout is not "Y")
                                                        {
                                                            NapEnd();


                                                        }
                                                        //Sends the player to the next floor
                                                        else if (answerRCGBreakout is "Y")
                                                        {
                                                            NapContinue();

                                                        }
                                                        break;


                                                }

                                            }
                                            break;
                                        case "L":
                                            Console.WriteLine("You enter the Library. I hope you don't have a book obsession...because there are none in here! Yep, there appears to be no books, only a bunch of computers for use. \nIt is much easier to use them anyway. There used to be books here, but they all always disappeared and were never brought back, so the lab opted to get rid of them altogether. \nPeople suck");
                                            Console.ReadLine();
                                            Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");
                                            string answerRCL = Console.ReadLine().Trim().ToUpper().Substring(0);

                                            if (answerRCL != "Y")
                                            {
                                                Console.WriteLine("Press any key to end the program");
                                                Console.ReadLine();
                                                System.Environment.Exit(0);
                                            }

                                            else if (answerRCL == "Y")
                                            {


                                                Console.WriteLine("Do you want to go to (G)ame, (N)ap, or (Q)uit?");
                                                string answerRCLNext = Console.ReadLine().Trim().ToUpper().Substring(0);

                                                switch (answerRCLNext)
                                                {

                                                    case "G":


                                                        Console.WriteLine("You enter the Game Room. Inside are a multitude of game consoles and table top games. You can see a Pool Table and Ping Pong Table. \n Other than that, the rest of the room is quite boring, as the walls completely black. \nSeems they really can't stand sunlight, though who could blame them.");
                                                        Console.ReadLine();
                                                        Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");

                                                        string answerRCLG = Console.ReadLine().Trim().ToUpper().Substring(0);

                                                        if (answerRCLG != "Y")
                                                        {
                                                            Console.WriteLine("Press any key to end the program");
                                                            Console.ReadLine();
                                                            System.Environment.Exit(0);
                                                        }

                                                        else if (answerRCLG == "Y")
                                                        {

                                                            Console.WriteLine("Do you want to go to (N)ap, or (Q)uit?");
                                                            string answerRCLGNext = Console.ReadLine().Trim().ToUpper().Substring(0);

                                                            switch (answerRCLGNext)
                                                            {

                                                                case "Q":
                                                                    GameQuit();
                                                                    break;
                                                                case "N":
                                                                    NapPrompt();
                                                                    string answerRCLGBreakout = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                                    //Determines whether the player is reading. Also determines what they selected.
                                                                    if (answerRCLGBreakout is not "Y")
                                                                    {
                                                                        NapEnd();


                                                                    }
                                                                    //Sends the player to the next floor
                                                                    else if (answerRCLGBreakout is "Y")
                                                                    {
                                                                        NapContinue();

                                                                    }
                                                                    break;

                                                            }

                                                        }
                                                        break;
                                                    case "Q":
                                                        GameQuit();
                                                        break;
                                                    case "N":
                                                        NapPrompt();
                                                        string answerRCLBreakout = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                        //Determines whether the player is reading. Also determines what they selected.
                                                        if (answerRCLBreakout is not "Y")
                                                        {
                                                            NapEnd();


                                                        }
                                                        //Sends the player to the next floor
                                                        else if (answerRCLBreakout is "Y")
                                                        {
                                                            NapContinue();

                                                        }
                                                        break;

                                                }

                                            }
                                            break;
                                        case "Q":
                                            GameQuit();
                                            break;
                                        case "N":
                                            NapPrompt();
                                            string answerRCBreakout = Console.ReadLine().Trim().ToUpper().Substring(0);
                                            //Determines whether the player is reading. Also determines what they selected.
                                            if (answerRCBreakout is not "Y")
                                            {
                                                NapEnd();


                                            }
                                            //Sends the player to the next floor
                                            else if (answerRCBreakout is "Y")
                                            {
                                                NapContinue();

                                            }
                                            break;


                                    }
                                }
                                break;

                            case "L":

                                Console.WriteLine("You enter the Library. I hope you don't have a book obsession...because there are none in here! Yep, there appears to be no books, only a bunch of computers for use. \nIt is much easier to use them anyway. There used to be books here, but they all always disappeared and were never brought back, so the lab opted to get rid of them altogether. \nPeople suck");
                                Console.ReadLine();
                                Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");
                                string answerRL = Console.ReadLine().Trim().ToUpper().Substring(0);

                                if (answerRL != "Y")
                                {
                                    Console.WriteLine("Press any key to end the program");
                                    Console.ReadLine();
                                    System.Environment.Exit(0);
                                }

                                else if (answerRL == "Y")
                                {

                                    Console.WriteLine("Do you want to go to (G)ame, (C)ommon, (N)ap, or (Q)uit?");
                                    string answerRLNext = Console.ReadLine().Trim().ToUpper().Substring(0);

                                    switch (answerRLNext)
                                    {

                                        case "G":

                                            Console.WriteLine("You enter the Game Room. Inside are a multitude of game consoles and table top games. You can see a Pool Table and Ping Pong Table. \n Other than that, the rest of the room is quite boring, as the walls completely black. \nSeems they really can't stand sunlight, though who could blame them.");
                                            Console.ReadLine();
                                            Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");

                                            string answerRLG = Console.ReadLine().Trim().ToUpper().Substring(0);

                                            if (answerRLG != "Y")
                                            {
                                                Console.WriteLine("Press any key to end the program");
                                                Console.ReadLine();
                                                System.Environment.Exit(0);
                                            }

                                            else if (answerRLG == "Y")
                                            {


                                                Console.WriteLine("Do you want to go to (C)ommon, (N)ap, or (Q)uit?");
                                                string answerRLGNext = Console.ReadLine().Trim().ToUpper().Substring(0);

                                                switch (answerRLGNext)
                                                {
                                                    case "C":

                                                        Console.WriteLine("You enter the Common Room. There's not much in here other than a couple of tables and chairs in the center of the room. \nHowever, the room does smell amazing! It smells like the every single type of lunch food mixing together in a harmonious way! \nIt makes you want to come work here if you could be surrounded by this type of food every day. \n...Too bad you're in debt");
                                                        Console.ReadLine();
                                                        Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");

                                                        string answerRLGC = Console.ReadLine().Trim().ToUpper().Substring(0);

                                                        if (answerRLGC != "Y")
                                                        {
                                                            Console.WriteLine("Press any key to end the program");
                                                            Console.ReadLine();
                                                            System.Environment.Exit(0);
                                                        }

                                                        else if (answerRLGC == "Y")
                                                        {

                                                            Console.WriteLine("Do you want to go to (N)ap, or (Q)uit?");
                                                            string answerRLGCNext = Console.ReadLine().Trim().ToUpper().Substring(0);

                                                            switch (answerRLGCNext)
                                                            {

                                                                case "Q":
                                                                    GameQuit();
                                                                    break;
                                                                case "N":
                                                                    NapPrompt();
                                                                    string answerRLGCBreakout = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                                    //Determines whether the player is reading. Also determines what they selected.
                                                                    if (answerRLGCBreakout is not "Y")
                                                                    {
                                                                        NapEnd();


                                                                    }
                                                                    //Sends the player to the next floor
                                                                    else if (answerRLGCBreakout is "Y")
                                                                    {
                                                                        NapContinue();

                                                                    }
                                                                    break;
                                                            }

                                                        }
                                                        break;

                                                    case "Q":
                                                        GameQuit();
                                                        break;
                                                    case "N":
                                                        NapPrompt();
                                                        string answerRLCBreakout = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                        //Determines whether the player is reading. Also determines what they selected.
                                                        if (answerRLCBreakout is not "Y")
                                                        {
                                                            NapEnd();


                                                        }
                                                        //Sends the player to the next floor
                                                        else if (answerRLCBreakout is "Y")
                                                        {
                                                            NapContinue();

                                                        }
                                                        break;

                                                }
                                            }
                                            break;

                                        case "C":

                                            Console.WriteLine("You enter the Common Room. There's not much in here other than a couple of tables and chairs in the center of the room. \nHowever, the room does smell amazing! It smells like the every single type of lunch food mixing together in a harmonious way! \nIt makes you want to come work here if you could be surrounded by this type of food every day. \n...Too bad you're in debt");
                                            Console.ReadLine();
                                            Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");

                                            string answerRLC = Console.ReadLine().Trim().ToUpper().Substring(0);
                                            
                                            if (answerRLC != "Y")
                                            {
                                                Console.WriteLine("Press any key to end the program");
                                                Console.ReadLine();
                                                System.Environment.Exit(0);
                                            }

                                            else if (answerRLC == "Y")
                                            {


                                                Console.WriteLine("Do you want to go to (G)ame, (N)ap, or (Q)uit?");
                                                string answerRLCNext = Console.ReadLine().Trim().ToUpper().Substring(0);

                                                switch (answerRLCNext)
                                                {

                                                    case "G":
                                                        Console.WriteLine("You enter the Game Room. Inside are a multitude of game consoles and table top games. You can see a Pool Table and Ping Pong Table. \n Other than that, the rest of the room is quite boring, as the walls completely black. \nSeems they really can't stand sunlight, though who could blame them.");
                                                        Console.ReadLine();
                                                        Console.WriteLine("Do you want to continue? Y/N (N will quit the game)");

                                                        string answerRLCG = Console.ReadLine().Trim().ToUpper().Substring(0);

                                                        if (answerRLCG != "Y")
                                                        {
                                                            Console.WriteLine("Press any key to end the program");
                                                            Console.ReadLine();
                                                            System.Environment.Exit(0);
                                                        }

                                                        else if (answerRLCG == "Y")
                                                        {


                                                            Console.WriteLine("Do you want to go to (N)ap, or (Q)uit?");
                                                            string answerRLCGNext = Console.ReadLine().Trim().ToUpper().Substring(0);

                                                            switch (answerRLCGNext)
                                                            {

                                                                case "Q":
                                                                    GameQuit();
                                                                    break;
                                                                case "N":
                                                                    Console.WriteLine("You enter the Nap Room. There's a bunch of beds and blankets everywhere, there's even a massive pillow fort. \nThe room makes you want to fall asleep... but you realize something! You're a young adult just out of college,\nyou never sleep! \nThis room has no effect on you! Though it does make you wonder if these scientists even get any work done with this room here...? ");
                                                                    Console.ReadLine();
                                                                    Console.WriteLine("There's a bright light glistening from the pillow fort, do you dare to head towards it?");
                                                                    Console.ReadLine();
                                                                    Console.WriteLine("Do you want to go into the pillow fort? Y/N");
                                                                    string answerRLCGBreakout = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                                    //Determines whether the player is reading. Also determines what they selected.
                                                                    if (answerRLCGBreakout is not "Y")
                                                                    {
                                                                        NapEnd();


                                                                    }
                                                                    //Sends the player to the next floor
                                                                    else if (answerRLCGBreakout is "Y")
                                                                    {
                                                                        NapContinue();

                                                                    }
                                                                    break;

                                                            }

                                                        }
                                                        break;
                                                    case "Q":
                                                        GameQuit();
                                                        break;
                                                    case "N":
                                                        NapPrompt();
                                                        string answerRLCBreakout = Console.ReadLine().Trim().ToUpper().Substring(0);
                                                        //Determines whether the player is reading. Also determines what they selected.
                                                        if (answerRLCBreakout is not "Y")
                                                        {
                                                            NapEnd();


                                                        }
                                                        //Sends the player to the next floor
                                                        else if (answerRLCBreakout is "Y")
                                                        {
                                                            NapContinue();

                                                        }
                                                        break;

                                                }
                                            }
                                            break;


                                        case "Q":
                                            GameQuit();
                                            break;
                                        case "N":
                                            NapPrompt();
                                            string answerRLBreakout = Console.ReadLine().Trim().ToUpper().Substring(0);
                                            //Determines whether the player is reading. Also determines what they selected.
                                            if (answerRLBreakout is not "Y")
                                            {
                                                NapEnd();


                                            }
                                            //Sends the player to the next floor
                                            else if (answerRLBreakout is "Y")
                                            {
                                                NapContinue();

                                            }
                                            break;



                                    }
                                }
                                break;

                            case "Q":
                                GameQuit();
                                break;
                            case "N":
                                NapPrompt();
                                string answerRBreakout = Console.ReadLine().Trim().ToUpper().Substring(0);
                                //Determines whether the player is reading. Also determines what they selected.
                                if (answerRBreakout is not "Y")
                                {
                                    NapEnd();


                                }
                                //Sends the player to the next floor
                                else if (answerRBreakout is "Y")
                                {
                                    NapContinue();

                                }
                                break;





                        }

                    }
                    break;
                case "Q":
                    GameQuit();
                    break;
                case "N":
                    NapPrompt();
                    string answerOG = Console.ReadLine().Trim().ToUpper().Substring(0);
                    //Determines whether the player is reading. Also determines what they selected.
                    if (answerOG is not "Y")
                    {
                        NapEnd();


                    }
                    //Sends the player to the next floor
                    else if (answerOG is "Y")
                    {
                        NapContinue();

                    }
                    break;
            }
        }
        static void BasementRooms()
        {
            //Give the player some description of the new floor
            Console.WriteLine("You enter the floor beneath the pillow fort, and it becomes clear how messed up this Laboratory is. \nThere's creepy paintings of kids frolicking together in bliss and harmony on the walls. \nThere are toys, broken and new scattered throughout the floor. \nAnd there even appears to be some type of goopy substance covering the floor. \nYou shutter to think what it could be, but decide to continue forth. \nYou've come this far, it's too late to go back now. \n...And too much effort, wandering through that pillow fort took a lot out of you.");
            Console.ReadLine();
            Console.WriteLine("Out of nowhere, you hear a voice ahead!! Your heart skips a beat.");
            Console.ReadLine();
            Console.WriteLine("'My my my, so you've made it this far. I'm shocked, really I am. \nMost goons give up before coming down here. They end up joining our team of researchers. \nThey love it here, and I'm sure you will too', the voice says with a cheerful tone.");
            Console.ReadLine();
            Console.WriteLine("You take a step forward in a defensive stance, however the voice says one last message before ending.");
            Console.ReadLine();
            Console.WriteLine("'This is a recording afterall, who knows if you'll make it to the end even. \nBut if you by chance do make it to the end, we'll be most shocked and pleased', \nThe voice giggles at such a loud tone that it makes you realize, they are not alone....");
            Console.ReadLine();
            Console.WriteLine("All of a sudden, the lights turn on. It reveals to you another map of the floor. \nIt's a much more simplified map than before, with a big red X on the map that says, \n'Come here if you dare!!'");
            Console.ReadLine();
            Console.WriteLine("With nothing else to lose, you continue moving forward through the floor");
            Console.ReadLine();
            Console.WriteLine("You continue moving forward and come across a large shiny metallic door blocking your way. \nThe door reads, to pass this massive door, you must answer truthfully to the door's riddle.");
            Console.ReadLine();
            Console.WriteLine("If I eat 10 Hamburgers, 14 Hot Dogs, 12 Ice Cream Sundaes, and 20 Meatloafs, \n What do I have?");
            Console.ReadLine();
            Console.WriteLine("(R)oom for more food, (N)o self control, (A) need to diversify eating habits or (Q)uit");
            string answerTrialOne = Console.ReadLine().Trim().ToUpper().Substring(0);
            //Switch statement for the options for the first challenge
            //Always includes option to Quit
            switch (answerTrialOne)
            {
                case "R":
                    Console.WriteLine("Yes but that's not the main problem..., next time think more carefully");
                    Console.ReadLine();
                    GameEnd();
                   /* Console.WriteLine("I'm gonna have to murder you now, Yay!");
                    Console.ReadLine();
                    Console.WriteLine("Press any key to end");
                    System.Environment.Exit(0); */
                    break;
                case "N":
                    Console.WriteLine("That is correct, and you should probably reconsider your life choices!");
                    Console.ReadLine();
                    Console.WriteLine("Press any key to continue");
                    Console.ReadLine();
                    break;
                case "A":
                    Console.WriteLine("Yes but that's not the main problem..., next time think more carefully");
                    Console.ReadLine();
                    GameEnd();
                    break;
                case "Q":
                    GameQuit();
                    break;
                default:
                    NoInput();
                    break;


            }
            Console.WriteLine("You actually made it huh, I'm surprised.");
            Console.ReadLine();

            Console.WriteLine("You know, most of our top minds always seem to fail at that question. \nGuess you're above the top percent?");
            Console.ReadLine();
            Console.WriteLine("Anyways, you continue moving forward only to find another door, \nhowever this one has a message that simply says don't enter, or else!!!");
            Console.ReadLine();
            Console.WriteLine("Do you, (W)ait for the door to open, (I)gnore the warning, or (Q)uit");
            string answerTrialTwo = Console.ReadLine().Trim().ToUpper().Substring(0);

            switch (answerTrialTwo)
            //Switch statement for the options for the second challenge
            //Always includes option to Quit
            {
                case "W":

                    Console.WriteLine("You decide to wait... how boring. \nThis is a social experiment, for being boring, your punishment is death");
                    Console.ReadLine();
                    GameEnd();
                    System.Environment.Exit(0);
                    break;

                case "I":

                    Console.WriteLine("You ignore the door's warning...and continue moving forward?! \nSeems it was just a veiled threat");
                    Console.ReadLine();
                    Console.WriteLine("Press any key to continue");
                    Console.ReadLine();
                    break;

                case "Q":

                    GameQuit();
                    break;
                default:
                    NoInput();
                    break;

            }

            Console.WriteLine("In case you haven't noticed so far, these tasks are designed for a.... \nless smart group of people. Of course not saying that they're dumb, \nbut that in time they'll grow smarter and smarter");
            Console.ReadLine();
            Console.WriteLine("As you continue walking, you prepare yourself for the inevitable door blocking your path once more. \n But to your surprise there is not a door blocking your path ahead, \n There are three doors!!! The Lab really likes locked doors okay? \n It's their special passion");
            Console.ReadLine();
            Console.WriteLine("The first door is a shiny, metallic door. \nThe second door is a colorful, glass stained door, \nAnd the third door is a shiny, white door. \nWhat door have you not seen yet?");
            Console.ReadLine();
            Console.WriteLine("The (F)irst Door, The (S)econd Door, or The (T)hird Door or (Q)uit?");
            string answerTrialThree = Console.ReadLine().Trim().ToUpper().Substring(0);
            //Switch statement for the options for the third challenge
            //Always includes option to Quit
            switch (answerTrialThree)
            {
                case "F":
                    Console.WriteLine("You chose the First Door... but you've already seen it! \nIt was from the first trial. \nYou've got a bad memory(or you can't be bothered to scroll up).");
                    Console.ReadLine();
                    GameEnd();
                   /* Console.WriteLine("You walk into the door, it's harder than it looks. \nMuch harder, so much that it cracks your skull and you die, whoops");
                    Console.ReadLine();
                    Console.WriteLine("Press any key to end");
                    Console.ReadLine();
                    System.Environment.Exit(0); */
                    break;
                case "S":
                    Console.WriteLine("You chose the Second Door.. and you're correct! There hasn't been a door like this until now!");
                    Console.ReadLine();
                    Console.WriteLine("Press any key to continue");
                    Console.ReadLine();
                    break;

                case "T":
                    Console.WriteLine("You chose the Third Door... but you've already seen it! \nIt is the same type door as the front doors. \nGranted they were from a while ago, assuming you haven't failed multiple times yet that is");
                    Console.ReadLine();
                    GameEnd();
                    /* Console.WriteLine("You walk into the door, and your bones all shatter at the same time. \nForgot to mention that this door, is like, the hardest there is. \nYou're dead now, better luck next time");
                     Console.WriteLine("You decided to quit the game... for now. \nYou'll come back eventually... right?!");
                     Console.ReadLine();
                     Console.WriteLine("Press any key to end");
                     Console.ReadLine();
                     System.Environment.Exit(0); */
                    break;
                case "Q":
                    GameQuit();
                    break;
                default:
                    NoInput();
                    break;


            }
            Console.WriteLine("You continue walking, for like, 20 seconds or so. And Boom, you come across a door with a giant X on it! \nJust like the one on the map! There's one last question it has for you... \nDon't you love doors?!! Agree with us, you better... ");
            Console.ReadLine();
            Console.WriteLine("(A)gree, (D)isagree, or (Q)uit");
            string answerTrialFour = Console.ReadLine().Trim().ToUpper().Substring(0);
            //Switch statement for the options for the fourth challenge
            //Always includes option to Quit
            switch (answerTrialFour)
            {
                case "A":
                    Console.WriteLine("OMG, WE DO TOO!!! You're like our favorite person right now. Proceed through the door <3 !!");
                    Console.ReadLine();
                    Console.WriteLine("Press any key to continue");
                    Console.ReadLine();
                    break;
                case "D":
                    GameEnd();
                   
                   /* Console.WriteLine("The door suddenly falls on you, crushing and killing you in an instant. \nSurely you won't disappoint us next time...");
                    Console.ReadLine();
                    Console.WriteLine("Press any key to end");
                    Console.ReadLine();
                    System.Environment.Exit(0); */
                    break;
                case "Q":
                    Console.WriteLine("You decided to quit the game... for now. \nYou'll come back eventually... right?!");
                    Console.ReadLine();
                    Console.WriteLine("Press any key to end the program");
                    Console.ReadLine();
                    System.Environment.Exit(0);
                    break;
                default:
                    NoInput();
                    break;

            }

            Console.WriteLine("You've made it through the door and to the exit?");
            Console.ReadLine();
        }
       
    }
}
    /* public static void BldgRooms()
    {
        Console.WriteLine("Inside of the Lab you notice many rooms that split off from the main central room. \nYou also notice a conveniently placed map that tells you which rooms are which.");
        Console.ReadLine();
        Console.WriteLine("The rooms that split off are as follows, The Game Room, The Common Room, The Research Facility, The Library, and The Nap Room.");
        Console.ReadLine();
        Console.WriteLine("Do you want to go to Game(G), Common(C), Library(L), Research(R) or Nap(N)?");
        string answer = Console.ReadLine().Trim().ToUpper().Substring(0);

        switch (answer)
        {
            case "G":
                Console.WriteLine("You enter the Game Room. Inside are a multitude of game consoles and table top games. You can see a Pool Table and Ping Pong Table. \n Other than that, the rest of the room is quite boring, as the walls completely black. \nSeems they really can't stand sunlight, though who could blame them.");
                Console.ReadLine();
                Console.WriteLine("There does not seem to be anything of note in here. I'd say head to another room, the closest room is the Common Room.");
                goto case "C";
            case "C":
                Console.WriteLine("You enter the Common Room. There's not much in here other than a couple of tables and chairs in the center of the room. \nHowever, the room does smell amazing! It smells like the every single type of lunch food mixing together in a harmonious way! \nIt makes you want to come work here if you could be surrounded by this type of food every day. \n...Too bad you're in debt");
                Console.ReadLine();
                Console.WriteLine("There does not seem to be anything of note in here. I'd say head to another room, the closest one is the Library");
                goto case "L";
            case "L":
                Console.WriteLine("You enter the Library. I hope you don't have a book obsession...because there are none in here! Yep, there appears to be no books, only a bunch of computers for use. \nIt is much easier to use them anyway. There used to be books here, but they all always disappeared and were never brought back, so the lab opted to get rid of them altogether. \nPeople suck");
                Console.ReadLine();
                Console.WriteLine("There does not seem to be anything of note in here. I'd say head to another room, the closest one is the Research Facility");
                goto case "R";
            case "R":
                Console.WriteLine("You enter the Research Facility. The amount of white colored objects here hurts your eyes. \nThe tables are white, the walls are white, even the floor is completely white, with not a speck of dirt on it. \nThese scientists must be some type of super organisms, to be able to work without getting dirty...or they're actually responsible and know how to clean. \nHonestly, it could be either one");
                Console.ReadLine();
                Console.WriteLine("There does not seem to be anything of note in here. I'd say head to another room, the closest one is the Nap Room");
                goto case "N";
            case "N":
                Console.WriteLine("You enter the Nap Room. There's a bunch of beds and blankets everywhere, there's even a massive pillow fort. \nThe room makes you want to fall asleep... but you realize something! You're a young adult just out of college, you never sleep! \nThis room has no effect on you! Though it does make you wonder if these scientists even get any work done with this room here...? ");
                Console.ReadLine();
                Console.WriteLine("There's a bright light glistening from the pillow fort, do you dare to head towards it?");
                Console.ReadLine();
                Console.WriteLine("Do you want to go into the pillow fort? Y/N");
                string ans = Console.ReadLine().Trim().ToUpper().Substring(0);
                if (answer is not "Y")
                {
                    Console.WriteLine("Understandable, you're a bit too young to head towards the light. Guess you'll have to find another job then...");
                    Console.WriteLine("Press any key to end the program");
                    Console.ReadLine();
                    System.Environment.Exit(0);

                }
                break;
            


           
        }
    }


} */

