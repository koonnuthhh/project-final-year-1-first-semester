﻿
using System.ComponentModel.Design;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;

internal class Program
{
    static void Main(string[] args)
    {
        bool game = true;
        string n = null,reenternumber = "";
        while (game) 
        {
            Console.Write("==========================================================\n       Welcome to ULTIMATE OMEGA BUTTER!!\n                  (0.2)\n==========================================================\n");//title
            Console.Write("{0}\nDoraemon enter 1 (can't run properly)\n\nGuess number enter 2 (80%)\n\nhangman enter 3 (40%)*can't return to main page\n\nandrew game enter 4 (10%)*can't return to main page\n\nTo stop this program enter 5: ", reenternumber);//choice
            n = Console.ReadLine();
            switch (n)
            {
                case "1":
                    Doraemongame.Start();
                    Console.Clear();
                    break;
                case "2":
                    Console.Clear();
                    guessnumbergame.Start();
                    Console.Clear();
                    break;
                case "3":
                    Console.Clear();
                    hangman.starthangman();
                    Console.Clear();
                    break;
                case "4":
                    Console.Clear();
                    andrew.andrewstart();
                    break;
                case "5":
                    game = false;
                    break;
                default:
                    Console.Clear();
                    reenternumber = "Please reenter number";
                    break;
            }
        }
    }
}
class Doraemongame
{
    public static void Doraemon()
    {
        Console.WriteLine(" \n===================\n \nDORAEMON GAME\n \n===================\n ");
    }
    public static void Start()
    {
        string[] deck = {"Ace of Spades", "2 of Spades", "3 of Spades", "4 of Spades", "5 of Spades",
                          "6 of Spades", "7 of Spades", "8 of Spades", "9 of Spades", "10 of Spades",
                          "Jack of Spades", "Queen of Spades", "King of Spades",
                          "Ace of Hearts", "2 of Hearts", "3 of Hearts", "4 of Hearts", "5 of Hearts",
                          "6 of Hearts", "7 of Hearts", "8 of Hearts", "9 of Hearts", "10 of Hearts",
                          "Jack of Hearts", "Queen of Hearts", "King of Hearts",
                          "Ace of Diamonds", "2 of Diamonds", "3 of Diamonds", "4 of Diamonds", "5 of Diamonds",
                          "6 of Diamonds", "7 of Diamonds", "8 of Diamonds", "9 of Diamonds", "10 of Diamonds",
                          "Jack of Diamonds", "Queen of Diamonds", "King of Diamonds",
                          "Ace of Clubs", "2 of Clubs", "3 of Clubs", "4 of Clubs", "5 of Clubs",
                          "6 of Clubs", "7 of Clubs", "8 of Clubs", "9 of Clubs", "10 of Clubs",
                          "Jack of Clubs", "Queen of Clubs", "King of Clubs" };
        var random = new Random();

        List<string> King = new List<string>();

        int Kingcount = 0;

        string play;

        do
        {
            Doraemon();
            Console.WriteLine("\n--Rules--\n1. Player need to pick one card from the deck each card has different command that player need to follow.\n2. IF 4 king appear the game end and the player that the last king pick need to do as the previous king had commanded.\n3. If the player go to toilet that player loss and must do as the king command.\n \n----------");
            Console.Write("\nDO YOU WANT TO PROCEED ? (yes / no) : ");
            play = Console.ReadLine();
            Console.Clear();

            if (play == "yes")
            {
                for (int i = deck.Length - 1; i > 0; i--)
                {
                    int j = random.Next(i + 1);
                    string shuffleDeck = deck[i];
                    deck[i] = deck[j];
                    deck[j] = shuffleDeck;
                }

                Doraemon();

                string pick;
                do
                {
                    Console.WriteLine("\nPick one card press : 1\nGo to toilet press  : 2\n");
                    Console.Write("Your answer : ");
                    pick = Console.ReadLine();

                    if (pick == "1")
                    {
                        string card = deck[0];
                        char first = card.ToCharArray()[0];
                        string Fcard = first.ToString(); //Short of facing card

                        string act;
                        string place;
                        string time;
                        string name;

                        Console.Clear();
                        Doraemon();
                        Console.WriteLine("\nYour card: " + deck[0] + "\nKing card count : " + King.Count + "\n");

                        switch (Fcard)
                        {
                            case "A":
                                Fcard = "A";
                                Console.WriteLine("Drink one glass of water !");
                                break;

                            case "2":
                                Fcard = "2";
                                Console.WriteLine("Drink two glass of water !");
                                break;

                            case "3":
                                Fcard = "3";
                                Console.WriteLine("Drink three glass of water !");
                                break;

                            case "4":
                                Fcard = "4";
                                Console.WriteLine("Drink four glass of water !");
                                break;

                            case "5":
                                Fcard = "5";
                                Console.WriteLine("Pair with a buddy. If you or your buddy get to drink from something, it doesn't matter. Another person must drink too.");
                                break;

                            case "6":
                                Fcard = "6";
                                Console.WriteLine("Play category games, for example the topic is animals and say the names of pigs, dogs, crows, chickens. If anyone can't answer, or if you respond late, you will have to drink 1 glass");
                                break;

                            case "7":
                                Fcard = "7";
                                Console.WriteLine("Play the number 7 game by saying the numbers in order and skipping numbers that end in 7 or are divisible by 7 (such as 7 14 17 21 27 28). Anyone who makes a mistake gets 1 glass.");
                                break;

                            case "8":
                                Fcard = "8";
                                Console.WriteLine("You can go to the toilet. You can use it yourself or give it to a friend to go to the toilet.");
                                break;

                            case "9":
                                Fcard = "9";
                                Console.WriteLine("Person on the left drink 1 glass");
                                break;

                            case "1":
                                Fcard = "1";
                                Console.WriteLine("Person on the right drink 1 glass");
                                break;

                            case "J":
                                Fcard = "J";
                                Console.WriteLine("The person who gets this card must do something.The last person in the circle to do the same gets 1 drink.");
                                break;

                            case "Q":
                                Fcard = "Q";
                                Console.WriteLine("Do not speak to the person who received this card. If you speak, you get 1 drink.");
                                break;

                            case "K":
                                Fcard = "K";
                                Console.WriteLine("The King's command : Action, Place, Duration, Who");
                                if (card == "King of Spades")
                                {
                                    Console.Write("Enter action : ");
                                    Kingcount++;
                                    act = Console.ReadLine();
                                    King.Add(act);
                                    if (Kingcount == 4)
                                    {
                                        Console.Clear();
                                        Doraemon();
                                        foreach (string command in King)
                                        {
                                            Console.WriteLine(command + "\n____________________");
                                        }
                                    }
                                }
                                else if (card == "King of Hearts")
                                {
                                    Console.Write("Enter place : ");
                                    Kingcount++;
                                    place = Console.ReadLine();
                                    King.Add(place);
                                    if (Kingcount == 4)
                                    {
                                        Console.Clear();
                                        Doraemon();
                                        foreach (string command in King)
                                        {
                                            Console.WriteLine(command + "\n____________________");
                                        }
                                    }
                                }
                                else if (card == "King of Diamonds")
                                {
                                    Console.Write("Enter duration : ");
                                    Kingcount++;
                                    time = Console.ReadLine();
                                    King.Add(time);
                                    if (Kingcount == 4)
                                    {
                                        Console.Clear();
                                        Doraemon();
                                        foreach (string command in King)
                                        {
                                            Console.WriteLine(command + "\n____________________");
                                        }
                                    }
                                }
                                else
                                {
                                    Console.Write("Enter Name : ");
                                    Kingcount++;
                                    name = Console.ReadLine();
                                    King.Add(name);
                                    if (Kingcount == 4)
                                    {
                                        Console.Clear();
                                        Doraemon();
                                        foreach (string command in King)
                                        {
                                            Console.WriteLine(command + "\n____________________");
                                        }
                                    }
                                }
                                break;
                        }

                        deck = deck.Skip(1).ToArray();

                    }
                    else if (pick == "2")
                    {
                        Console.Clear();
                        Console.WriteLine("\n\n\n=================== YOU LOSS ===================\nlet your friend decid what to punish the loser\n\n\n ");
                        break;
                    }

                    else
                    {
                        Console.Clear();
                        Doraemon();
                        Console.WriteLine("\nINVALID VALUE : Try Again\n");
                    }

                } while (Kingcount < 4);

                break;

            }
            else if (play == "no")
            {
                Console.WriteLine("\n\n\n===== GOOD BYE =====\n\n\n");
            }
        } while (play != "no");
    }
}
class guessnumbergame
{
    public static void Start()
    {
        string reround;
        int round = 1, playercount, maxnumber;
        //Introduce program let user design maximum , how many round they want and how many players
        Console.WriteLine("==========================================================\nThis is program guess random integer number\nIf insert 0 or 1 a number the maximum will set to 1000\n==========================================================");
    howmanyplayer:
        Console.Write("How many player(Enter only integer): ");
        if (int.TryParse(Console.ReadLine(), out playercount) == false)
        {
            Console.Write("==========================================================\nPlease reenter\n");
            goto howmanyplayer;
        }

        Console.Write("please Enter maximum number to generate :");
    reentermaxnumber:
        if ((int.TryParse(Console.ReadLine(), out maxnumber) == false))
        {
            Console.Write("==========================================================\nplease Reenter maximum number to generate (integer) :");
            goto reentermaxnumber;
        }
        else if (maxnumber == 0 || maxnumber == 1)
        {
            maxnumber = 1000;
        }
        Console.Clear();
        //separate way for one player and more than one
        if (playercount == 1)
        {
            int score = randomnumber(maxnumber);
            Console.WriteLine($"you win by guess {score} times");
            round++;
        }
        else
        {
            int[] playerscore = new int[playercount];
            //To call game method and collect data
            while (round <= playercount)
            {
                Console.WriteLine("person {0} play", round);
                playerscore[round - 1] = randomnumber(maxnumber);
                round++;
            }
            //to check who's the winner
            int count = 1, lowest = 2147483600, winner = 0;
            foreach (int score in playerscore)
            {
                if (score < lowest)
                {
                    lowest = score;
                    winner = count;
                }
                count++;
            }
            if (lowest == 1)
            {
                Console.WriteLine($"The winner is player {winner} in The First times");
            }
            else
            {
                Console.WriteLine($"The winner is player {winner} by guess {lowest} times");
            }
        }
        Console.Write("=============================\nDo you want to play again?\nY/N : ");
        reround = Console.ReadLine();
        reround.ToLower();
        while (reround != "n")
        {
            if (reround == "y")
            {
                Console.Clear();
                Start();
            }
            Console.WriteLine("Please answer only Y/N : ");
            reround = Console.ReadLine();
        }
    }

    static int randomnumber(int maxgenerate)
    {
        //declare and tell maxgenerate
        Console.WriteLine("The number will below {0}", maxgenerate + "\n=============================");
        Random generate = new Random();
        int number = generate.Next(maxgenerate), guess = -1, i = 0;
        while (number == 0) { number = generate.Next(maxgenerate); }

        //real guess program and count how many round user take
        while (guess != number)
        {
            Console.Write("guess :");
            if (int.TryParse(Console.ReadLine(), out guess) == false)
            {
                Console.WriteLine("please enter integer");
                continue;
            }

            switch (number - guess)
            {
                //case when guess less than random number
                case <= -20:
                    Console.WriteLine("less than {0}", guess);
                    break;
                case < 0:
                    Console.WriteLine("a little less!!");
                    break;
                case 0:
                    Console.WriteLine("you right!!");
                    break;

                //case when guess more than random number
                case <= 20:
                    Console.WriteLine("a little more!!", guess);
                    break;
                default:
                    Console.WriteLine("more than {0}", guess);
                    break;
            }
            i++;
        }
        return i;
    }
}
class hangman
{
    public static void starthangman()
    {
        bool again = true;
        while (again)
        {

            Console.WriteLine("---------Welcome to Hangman!---------");
            string[] secretWord = { "programming", "banana", "koonnuthhh" }; // The word to guess

            Console.Write("\nHow many player ? <int only> : ");
            string player = Console.ReadLine();

            if (!int.TryParse(player, out int player1))
            {
                while (!int.TryParse(player, out player1))
                {

                    Console.WriteLine("\n###### Hey! I told you INTIGER ONLY !!!! ######");
                    Console.Write("How many player ? <int only> : ");
                    player = Console.ReadLine();


                }

            }


            int[] rounds = new int[player1];
            player1 = 1;
            while (player1 <= rounds.Length)
            {
                Console.WriteLine("=========================== ");
                Console.WriteLine($"***** This is player {player1} round. *****");
                Random rand = new Random();
                int Word = rand.Next(secretWord.Length);//random word
                string real = secretWord[Word];
                char[] guessedWord = new char[real.Length];

                for (int i = 0; i < guessedWord.Length; i++)
                {
                    guessedWord[i] = '_';
                }

                int attempts = 6; // Number of incorrect attempts allowed

                while (attempts > 0)
                {
                    Console.WriteLine("===========================\n" + new string(guessedWord));
                    Console.WriteLine($"Attempts left: {attempts}");
                    Console.Write("Enter a letter: ");
                    char guess;
                    string an = Console.ReadLine();
                    an = an.ToLower();
                    if (!char.TryParse(an, out guess))
                    {
                        while (!char.TryParse(an, out guess))
                        {
                            Console.WriteLine("--------------------------------\nEnter only 1 Character per round\n--------------------------------");
                            Console.WriteLine("\n" + new string(guessedWord));
                            Console.WriteLine($"Attempts left: {attempts}");
                            Console.Write("Enter a letter: ");
                            an = Console.ReadLine();
                            an = an.ToLower();

                        }



                    }


                    bool found = false;
                    for (int i = 0; i < real.Length; i++)
                    {
                        if (real[i] == guess)
                        {
                            guessedWord[i] = guess;
                            found = true;
                        }
                    }

                    if (!found)
                    {
                        attempts--;
                    }

                    if (new string(guessedWord) == real)
                    {
                        Console.WriteLine("Congratulations! You guessed the word: " + real);
                        break;
                    }


                }


                if (attempts == 0)
                {
                    Console.WriteLine("You ran out of attempts. The word was: " + real);
                }
                rounds[player1 - 1] = attempts;
                player1++;
            }
            if (player1 > 1) { Check(rounds); }


            Again(again);


            static void Check(int[] rounds)
            {

                int a = 1;
                int b = rounds[0];
                Console.WriteLine("\n===========Scoreboard========== ");
                foreach (int i in rounds)
                {
                    Console.WriteLine($"Player {a} have rounds left {i} ");
                    a++;
                    b = Math.Max(b, i);

                }
                int index = Array.IndexOf(rounds, b);
                Console.WriteLine("================\nThe winner is player " + (index + 1));
                Console.WriteLine("================");
            }
            static bool Again(bool again)
            {
                Console.WriteLine("\nDo you want to play again ? <Y/N> : ");
                string gg = Console.ReadLine();
                gg = gg.ToUpper();
                while (gg != "Y" && gg != "N")
                {
                    Console.WriteLine("++++++++++++++++++++");
                    Console.WriteLine("Only <Y/N>");
                    Console.Write("Do you want to play again? <Y/N> : ");
                    gg = Console.ReadLine();
                    gg = gg.ToUpper();
                    Console.WriteLine("++++++++++++++++++++");
                }
                switch (gg)
                {
                    case "Y":
                        again = true;

                        break;

                    case "N":
                        again = false;

                        break;




                }
                return again;

            }
        }

    }
}
 class andrew
{
    static int PlayerMaxHP = 10;
    static int PlayerRemainingHP = 10;
    static int PlayerDamage = 2;
    static int Gold = 100;
    static int EnemyMaxHP = 5;
    static int EnemyRemainingHP = 5;
    static int EnemyDamage = 1;

    static bool PlayerAlive = true;
    static bool EnemyAlive = true;
    static bool GameOver = false;
    static bool CombatStatus = true;

    public static void CombatMethod()
    {
        int CombatEnemyRemainingHP = EnemyRemainingHP;
        int CombatPlayerRemainingHP = PlayerRemainingHP;

        while (CombatStatus)
        {

            if (CombatPlayerRemainingHP > 0 && CombatEnemyRemainingHP > 0)
            {
                CombatEnemyRemainingHP = CombatEnemyRemainingHP - PlayerDamage;
                Console.WriteLine("Enemy took " + PlayerDamage + " Damage " + CombatEnemyRemainingHP + "/" + EnemyMaxHP + "HP");
                if (CombatEnemyRemainingHP > 0)
                {
                    CombatPlayerRemainingHP = CombatPlayerRemainingHP - EnemyDamage;
                    Console.WriteLine("You took " + EnemyDamage + " Damage " + CombatPlayerRemainingHP + "/" + PlayerMaxHP + "HP\n------------------");
                }
            }
            else if (CombatEnemyRemainingHP <= 0)
            {
                Console.WriteLine("------------------\nYou defeated the enemy! You gained 200 gold");
                Gold = Gold + 200;
                PlayerRemainingHP = CombatPlayerRemainingHP;
                Console.WriteLine("You have " + PlayerRemainingHP + "/" + PlayerMaxHP + "HP\n[]---------End of fight---------[]");
                CombatStatus = false;
                return;

            }
            else if (CombatPlayerRemainingHP <= 0)
            {
                Console.WriteLine("You died");
                CombatStatus = false;
                GameOver = true;
                return;
            }
        }

    }

     static void ShopMethod()
    {
        bool ShopClosed = false;
        string[] PowerUps = { "Hamburger", "Apple", "Fire Pepper" };
        int[] Price = { 200, 150, 150 };

        while (!ShopClosed)
        {
            Console.WriteLine("[]---------Welcome to the shop!---------[]");
            Console.WriteLine("Here are the available items: \n1. Hamburger (+3 attack +10 health)\n2. Apple (+5 Health)\n3. Fire Pepper (+5 attack)\n4. Leave shop");

            int SelectedItem = Convert.ToInt32(Console.ReadLine());
            {
                if (SelectedItem == 4)
                {
                    ShopClosed = true;
                    break;
                }
                else if (SelectedItem > 0 && SelectedItem <= PowerUps.Length)
                {
                    if (Gold >= Price[SelectedItem - 1])
                    {
                        Gold -= Price[SelectedItem - 1];
                        Console.WriteLine("You have purchased: " + PowerUps[SelectedItem - 1] + " -" + Price[SelectedItem - 1] + " Gold");
                        if (SelectedItem == 1)
                        {
                            PlayerMaxHP += 10;
                            PlayerRemainingHP += 10;
                            PlayerDamage += 3;
                        }
                        else if (SelectedItem == 2)
                        {
                            PlayerMaxHP += 5;
                            PlayerRemainingHP += 5;
                        }
                        else if (SelectedItem == 3)
                        {
                            PlayerDamage += 5;
                        }
                    }
                }
            }
        }
    }

    public static void andrewstart()
    {
        int Choice = 0;

        while (!GameOver)
        {
            Console.Write("Welcome to your epic adventure!, what is your hero's name?: ");
            String Name = Console.ReadLine();
            Console.WriteLine("Welcome " + Name + " here is your profile: \n*********************");
            Console.WriteLine("Health: " + PlayerMaxHP + "\nDamage: " + PlayerDamage + "\nGold: " + Gold + "\n*********************");
            Console.WriteLine("You encounter a slime, what would you like to do?\n1: Fight\n2: Run\n*********************");
            Choice = Convert.ToInt32(Console.ReadLine());


            switch (Choice)
            {
                case 1:
                    Console.WriteLine("[]---------You choose to fight---------[]\n------------------");
                    CombatMethod();
                    break;

                case 2:
                    Console.WriteLine("You choose to run away");
                    break;
            }


            Console.WriteLine("What would you like to do next?\n1: Continue \n2: Shop \n3: Rest");
            Choice = Convert.ToInt32(Console.ReadLine());


            switch (Choice)
            {
                case 1:
                    Console.WriteLine("Next combat");
                    break;

                case 2:
                    ShopMethod();
                    Console.WriteLine("[TESTING] PlayerMaxHP: " + PlayerMaxHP);
                    Console.WriteLine("[TESTING] PlayerRemainingHP: " + PlayerRemainingHP);
                    Console.WriteLine("[TESTING] PlayerDamage: " + PlayerDamage);
                    Console.WriteLine("[TESTING] PlayerGold: " + Gold);

                    break;

                case 3:
                    Console.WriteLine("Rest");
                    while (PlayerRemainingHP < PlayerMaxHP)
                    {
                        PlayerRemainingHP++;
                    }
                    Console.WriteLine("[TESTING] PlayerRemainingHealth: " + PlayerRemainingHP);
                    break;
            }
        }
    }
}
