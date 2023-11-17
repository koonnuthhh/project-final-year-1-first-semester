
using System.ComponentModel.Design;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;

internal class Program
{
    public static void Main()
    {
        bool game = true;
        string n = null,reenternumber = null;
        while (game) 
        {
            Console.Write("==========================================================\n\n            Welcome to ULTIMATE OMEGA BUTTER!!\n                          (0.4)\n\n==========================================================\n");//title
            Console.Write("{0}\nDoraemon enter 1 (Need to improve)\n\nGuess number enter 2 (80%)\n\nhangman enter 3 (40%)*can't return to main page\n\nandrew game enter 4 (finish but in debugging process)\n\nsi-de? enter 5 (testting)\n\n==========================================================\n\n\nTo exit this program enter 6 : ", reenternumber);//choice
            reenternumber = null;
            n = Console.ReadLine();
            switch (n)
            {
                case "1":
                    Console.Clear();
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
                    //Console.Clear();
                    break;
                case "5":
                    Console.Clear();
                    butter.start();
                    break;
                case "6":
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


            again = Again(again);


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
    static int EnemyGoldValue = 200;

    static bool PlayerAlive = true;
    static bool EnemyAlive = true;
    static bool GameOver = false;
    static bool CombatStatus = true;

    public static void CombatMethod()
    {
        int CombatEnemyRemainingHP = EnemyRemainingHP;
        int CombatPlayerRemainingHP = PlayerRemainingHP;

        while (CombatStatus) //Combat method where hero attacks enemy first by subtracting attack damage from opposing health and vice versa in a loop
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
                Gold = Gold + EnemyGoldValue;
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

    public static void ShopMethod() //This is where the hero can increase his/her power to defeat more powerful enemies using gold
    {
        bool ShopClosed = false;
        string[] PowerUps = { "Hamburger", "Apple", "Fire Pepper", "Piece of Paper" }; //Items to purchase
        int[] Price = { 200, 150, 150, 100 }; //Item prices in order

        Console.WriteLine("[]---------Welcome to the shop!---------[]");
        while (!ShopClosed)
        {
            Console.WriteLine("Here are the available items: \n-200 gold || 1. Hamburger (+3 attack +10 health)\n-150 gold || 2. Apple (+5 Health)\n-150 gold || 3. Fire Pepper (+5 attack)\n-100 gold || 4. Piece of paper\n------------------\nyour gold: " + Gold + "\nTo buy an item type the number of the item or type 5 to leave");
            int SelectedItem = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            {
                if (SelectedItem == 5)
                {
                    ShopClosed = true;
                    Console.Clear();
                    break;
                }
                else if (SelectedItem > 0 && SelectedItem <= PowerUps.Length)
                {
                    if (Gold >= Price[SelectedItem - 1])
                    {
                        Gold -= Price[SelectedItem - 1];
                        Console.WriteLine("You have purchased: " + PowerUps[SelectedItem - 1] + " -" + Price[SelectedItem - 1] + " Gold\n------------------");
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
                        else if (SelectedItem == 4)
                        {
                            Console.WriteLine("You read the piece of paper it says: Arms, Legs, Brain, Heart\n");
                        }
                    }
                    else if (Gold <= Price[SelectedItem - 1])
                    {
                        Console.WriteLine("You don't have enough gold");
                    }
                }
            }
        }
    }


    public static void ChestMethod()
    {
        int attempts = 3;
        int[] correctCode = { 2, 2, 1, 1 };
        int[] guess = new int[4];

        while (attempts > 0)
        {
            for (int i = 0; i < correctCode.Length; i++)
            {
                Console.Write("You have {0} attemps left\nYou have " + (4 - i) + " more to guess! \nPlease guess the number: ", attempts);
                guess[i] = int.Parse(Console.ReadLine());
                if (guess[i] == correctCode[i])
                {
                    Console.Clear();
                    Console.WriteLine("You guessed correctly!");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You guessed incorrectly");
                    if (attempts == 1)
                    {
                        Console.WriteLine("The chest explodes!! -10 health\n------------------");
                        PlayerRemainingHP -= 10;
                    }
                    attempts--;
                    break;
                }
                if (guess[3] == correctCode[3])
                {
                    Console.WriteLine("You open the chest and get 500 Gold!!\n------------------");
                    Gold += 500;
                    attempts = 0;
                }
            }
        }

    }

    public static void CheckPlayerHealth()
    {
        if (PlayerRemainingHP <= 0)
        {
            Console.WriteLine("You died");
            GameOver = true;
            //return;
        }
    }

    public static void andrewstart()
    {
        int Choice = 0;
        //GameOver = false;
        while (!GameOver)
        {
            Console.Write("Welcome to your epic adventure!, what is your hero's name?: ");
            String Name = Console.ReadLine();
            Console.WriteLine("Welcome " + Name + " here is your profile: \n*********************");
            Console.WriteLine("Health: " + PlayerMaxHP + "\nDamage: " + PlayerDamage + "\nGold: " + Gold + "\n*********************");
            Console.WriteLine("You encounter a slime, what would you like to do?\n1: Fight\n2: Run\n*********************");
            Choice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            //Starting first enemy encounter
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
            Console.Clear();

            //Choices to choose after combat
            switch (Choice)
            {
                case 1: //continue
                    break;

                case 2: //shop
                    ShopMethod();
                    break;

                case 3: //rest
                    Console.WriteLine("Rest");
                    while (PlayerRemainingHP < PlayerMaxHP)
                    {
                        PlayerRemainingHP++;
                    }
                    Console.WriteLine("You've restored to full health " + PlayerRemainingHP + "/" + PlayerMaxHP + "HP");
                    break;
            }

            //Setting the stats for enemy number 2
            EnemyMaxHP = 20;
            EnemyRemainingHP = 20;
            EnemyDamage = 1;
            Console.WriteLine("*********************\nYou encounter a walking tree, what would you like to do?\n1: Fight\n2: Run\n3: Hug\n*********************");
            Choice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (Choice)
            {
                case 1:
                    Console.WriteLine("[]---------You choose to fight---------[]\n------------------");
                    CombatStatus = true;
                    EnemyGoldValue = 300;
                    CombatMethod();
                    break;

                case 2:
                    Console.WriteLine("You choose to run away");
                    break;

                case 3:
                    Console.WriteLine("You hug the tree, he gives you an apple! +5 Health");
                    PlayerMaxHP += 5;
                    PlayerRemainingHP += 5;
                    break;
            }

            CheckPlayerHealth();
            if (GameOver)
            {
                break;
            }

            Console.WriteLine("You find a mysterious chest with a lock, what do you do?\n1. Try to open it\n2. Ignore it\n");
            Choice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (Choice)
            {
                case 1:
                    Console.Clear();
                    ChestMethod();
                    break;

                case 2:
                    Console.WriteLine("Ignore it");
                    break;
            }

            CheckPlayerHealth();
            if (GameOver)
            {
                break;
            }

            Choice = 0;
            Console.WriteLine("You keep moving forward, what would you like to do next?\n1: Continue \n2: Shop \n3: Rest");
            Choice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (Choice)
            {
                case 1: //continue
                    break;

                case 2: //shop
                    ShopMethod();
                    break;

                case 3: //rest
                    while (PlayerRemainingHP < PlayerMaxHP)
                    {
                        PlayerRemainingHP++;
                    }
                    Console.WriteLine("You've restored to full health " + PlayerRemainingHP + "/" + PlayerMaxHP + "HP");
                    break;
            }

            Console.WriteLine("\n*********************\nYou hear loud stomps in the distance\nYou see a centaur charge towards you\nYou are about to enter a boss fight\n*********************");
            Console.WriteLine("Your Profile:\nHealth: " + PlayerRemainingHP + "/" + PlayerMaxHP + "\nDamage: " + PlayerDamage + "\nGold: " + Gold + "\n*********************");
            Console.Write("Proceed?: ");
            Console.ReadLine();
            EnemyMaxHP = 50;
            EnemyRemainingHP = 50;
            EnemyDamage = 7;
            EnemyGoldValue = 400;
            CombatStatus = true;
            Console.Clear();
            CombatMethod();
            CheckPlayerHealth();
            if (GameOver)
            {
                break;
            }
            Console.WriteLine("You win!!!");
            GameOver = true;
        }

    }


}

class butter
{
    static int blood = 10;

    static int x = 0;
    static int y = 0;
    static int z = 0;
    public static void cop()
    {
        Console.WriteLine("*================================================================*");
    }
    public static void endplay()
    {
    reenterplay:
        Console.WriteLine("You want to play again.\n1.Yes. \n2.No.");
        cop();
        Console.Write("You choose :");
        int playagain;
        if ((int.TryParse(Console.ReadLine(), out playagain) == false))
        {
            Console.Clear();
            Console.WriteLine("Please not enter string");
            goto reenterplay;
        }
        Console.Clear();
        if (playagain == 1)
        {
            start();
        }
        else if (playagain == 2)
        {
            Program.Main();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Please enter only 1 and 2");
            goto reenterplay;
        }
    }
    static void Bloodmethod()
    {
        Console.Clear();
        if (blood <= 0)
        {
            cop();
            Console.WriteLine("                 YOU DIE.                 \n                GAME OVER.               ");
            cop();
            endplay();

        }
        else
        {
            Console.WriteLine("Blood = " + blood);
        }
    }
    static void Left()
    {
        Console.Clear();
    reenterrunorhitsnake:
        cop();
        Console.WriteLine("You find a snake in front of you. You choose to \n1. run \n2. hit the snake.");
        cop();
        Console.Write("You choose to : ");
        int left1;
        if ((int.TryParse(Console.ReadLine(), out left1) == false))
        {
            Console.Clear();
            Console.WriteLine("Please not enter string.");
            goto reenterrunorhitsnake;

        }
        Console.Clear();
        cop();

        switch (left1)
        {
            case 1:
                if (y < 3) { blood -= 2; }
                Console.WriteLine("You choose to run.");
                Bloodmethod();

                break;
            case 2:
                if (z < 1) { blood -= 2; }
                Console.WriteLine("You choose to hit the snake.");
                Bloodmethod();

                break;
            default:
                Console.Clear();
                Console.WriteLine("Please enter only 1 and 2.");
                goto reenterrunorhitsnake;
        }

    reenterclimborwalk:
        cop();
        Console.WriteLine("You made it through but found that in front of you was a deep cliff." +
            "\nWhat do you do?\n1.Climb down the cliff. \n2.Walk back the same way.");
        cop();

        Console.Write("You do :");
        int left2;
        if ((int.TryParse(Console.ReadLine(), out left2) == false))
        {
            Console.Clear();
            Console.WriteLine("Please not enter string.");
            goto reenterclimborwalk;
        }
        Console.Clear();
        cop();
        if (left2 == 1)
        {
            if (y < 3) { blood -= 2; }
            Console.WriteLine("Climb down the cliff.");
            Bloodmethod();
            Right();
        }
        else if (left2 == 2)
        {
        reenterrunhit:
            Console.WriteLine("Walk back the same way.");
            Console.WriteLine("You  find a snake in front of you.You choose to \n1.run. \n2. hit the snake.");
            cop();
            Console.Write("You choose to : ");
            int left3 = int.Parse(Console.ReadLine());
            Console.Clear();
            cop();
            switch (left3)
            {
                case 1:
                    if (y < 3) { blood -= 2; }
                    Console.WriteLine("You  run.");
                    Bloodmethod();

                    break;
                case 2:
                    if (z < 1) { blood -= 2; }
                    Console.WriteLine("You hit the snake.");
                    Bloodmethod();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Please enter only 1 and 2.");
                    cop();
                    goto reenterrunhit;

            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Please enter only 1 and 2.");
            goto reenterclimborwalk;
        }
    }

    public static void Right()
    {
    reenterswimjump:
        cop();
        Console.Clear();
        Console.WriteLine("You go to  front of you is a stream with children's voices heard from the other side. " +
            "\nYou will.\n1.swim to the other side. \n2.jump over the rocks.");
        cop();
        Console.Write("You will :");
        int right;
        if ((int.TryParse(Console.ReadLine(), out right) == false))
        {
            Console.Clear();
            Console.WriteLine("Please not enter string.");
            goto reenterswimjump;

        }
        Console.Clear();
        cop();
        switch (right)
        {
            case 1:
                if (x < 4) { blood -= 3; }
                Console.WriteLine("You choose to swim to the other side.");
                Bloodmethod();
                break;
            case 2:
                if (y < 2) { blood -= 4; }
                Console.WriteLine("You choose to  jump over the rocks.");
                Bloodmethod();
                break;
            default:
                Console.Clear();
                Console.WriteLine("Please enter only 1 and 2.");
                goto reenterswimjump;

        }
    reenterexplorewalk:
        cop();
        Console.WriteLine("You made it across the stream only to find that there was no one on the other side.\nYou will " +
            "\n1.explore\n2.Walk into the bamboo pile in front.");
        cop();
        Console.Write("You will : ");
        int right1;
        if ((int.TryParse(Console.ReadLine(), out right1) == false))
        {
            Console.Clear();
            Console.WriteLine("Please not enter string.");
            goto reenterexplorewalk;
        }
        Console.Clear();
        cop();
        switch (right1)
        {
            case 1:
                if (z < 4) { blood -= 3; }
                Console.WriteLine("You will explore.");
                Bloodmethod();
                break;
            case 2:
                if (z < 3) { blood -= 2; }
                Console.WriteLine(" You will Walk into the bamboo pile in front.");
                Bloodmethod();
                break;
            default:
                Console.Clear();
                Console.WriteLine("Please enter only 1 and 2.");
                goto reenterexplorewalk;

        }
    }

    static void walkin()
    {
    reenterwalkkeep:
        cop();
        Console.WriteLine("You found the child's footprints so you continued to follow them. until finding a hut.\nSo you \n1.Walked in \n2.Keep an eye on the front.");
        cop();
        Console.Write("You will : ");
        int walk;
        if ((int.TryParse(Console.ReadLine(), out walk) == false))
        {
            Console.Clear();
            Console.WriteLine("Please not enter string.");
            goto reenterwalkkeep;

        }
        Console.Clear();
        cop();
        switch (walk)
        {
            case 1:
                if (x < 4 && y < 2 && z < 3) { blood -= 4; }
                Console.WriteLine("You walked in");
                Bloodmethod();
                break;
            case 2:
                Console.WriteLine("Keep an eye on the front.\nYou step on the leaves loudly and they can hear it.");
                break;
            default:
                Console.Clear();
                Console.WriteLine("Please enter only 1 and 2.");
                goto reenterwalkkeep;

        }

    }


    static void endbabdi()
    {
    reenterend:
        cop();
        Console.WriteLine("You are tied up in a hut along with the children you are looking for.\nYou must leave this place. There are 2 guards, who will you choose to fight?\n1.A tall person\n2.Small person");
        cop();
        Console.Write("You choose : ");
        int preson;
        if ((int.TryParse(Console.ReadLine(), out preson) == false))
        {
            Console.Clear();
            Console.WriteLine("Please not enter string.");
            goto reenterend;

        }
        Console.Clear();
        cop();
        switch (preson)
        {
            case 1:
                Console.WriteLine("A tall person.");
                if (blood < 5)
                {
                    cop();
                    Console.WriteLine("                 YOU DIE.                 \n                GAME OVER.               ");
                    cop();
                    endplay();
                }
                else if (blood >= 5)
                {
                    cop();
                    Console.WriteLine("You have defeated them and are out of the forest.");
                    cop();
                    endplay();
                }
                break;
            case 2:
                Console.WriteLine("2.Small person");
                if (blood >= 5)
                {
                    cop();
                    Console.WriteLine("You have defeated them and are out of the forest.");
                    cop();
                    endplay();
                }
                else if (blood < 5)
                {
                    cop();
                    Console.WriteLine("                 YOU DIE.                 \n                GAME OVER.               ");
                    cop();
                    endplay();
                }

                break;
            default:
                Console.Clear();
                Console.WriteLine("Please enter only 1 and 2");
                goto reenterend;


        }
    }

    public static void start()
    {

        Console.WriteLine("==========Welcome to Si-de===============");
        cop();
        Console.WriteLine("You are police. \nReceived a mission to rescue a kidnapped child with the following rules:");
        cop();
    resum:
        Console.WriteLine("-You have 5 extra points.\n-Points can be added to 3 qualities: +\n1. strength \n2. speed \n3. determination." +
            "\n-And has 10 units of blood " + "\n-Please divide your score into 3 characteristics well.");
        cop();

        int sum;
        sum = x + y + z;
        while (sum != 5)
        {
            Console.Write("1. strength = ");
            int x = 0;
            if ((int.TryParse(Console.ReadLine(), out x) == false))
            {
                Console.Clear();
                Console.WriteLine("Please not enter string");
                cop();
                goto resum;
            }
            Console.Write("2. speed = ");
            int y = 0;
            if ((int.TryParse(Console.ReadLine(), out y) == false))
            {
                Console.Clear();
                Console.WriteLine("Please not enter string");
                cop();
                goto resum;
            }
            Console.Write("3. determination. = ");
            int z = 0;
            if ((int.TryParse(Console.ReadLine(), out z) == false))
            {
                Console.Clear();
                Console.WriteLine("Please not enter string");
                cop();
                goto resum;
            }
            Console.Clear();
            sum = x + y + z;
            if (sum > 5)
            {
                Console.WriteLine("+You put more then 5 points.\n+You have 5 extra points.\n+Please enter the score again.");
                cop();
            }
            else if (sum < 5)
            {
                Console.WriteLine("+You put less then 5 points.\n+You have 5 extra points.\n+Please enter the score again.");
                cop();
            }

            else if (sum == 5)
            {

                cop();
            }

        }
    reenterleftlight:
        Console.WriteLine("You have been informed that a child has been kidnapped and taken deep into the forest.\n" +
                "After going to the deep forest, there is a fork in the road for you to split.\n You will go \n1. left. \n2. right.");
        cop();
        //5-6

        int choice1;

        Console.Write("You will go : ");
        if ((int.TryParse(Console.ReadLine(), out choice1) == false))
        {
            Console.Clear();
            Console.WriteLine("Please not enter string");
            cop();
            goto reenterleftlight;
        }

        switch (choice1)
        {
            case 1:
                Left();

                break;
            case 2:
                Right();
                break;
            default:
                Console.Clear();
                Console.WriteLine("Please enter only 1 and 2");
                cop();
                goto reenterleftlight;

        }
        Right();
        walkin();
        endbabdi();
    endbutter:;
    }
}

