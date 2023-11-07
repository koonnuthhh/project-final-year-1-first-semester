
using System.ComponentModel.Design;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;

internal class Program
{
    static void Main(string[] args)
    {
        bool g = true;
        string n = null,reenternumber = "";
        while (g) 
        {
            Console.Write("==========================================================\n       Welcome to ULTIMATE OMEGA BUTTER!!\n                  (program)\n==========================================================\n");//title
            Console.Write("{0}\nDoraemon enter 1\nGuess number enter 2\nhangman enter 3\nandrew game enter 4\nto stop the program enter 5: ",reenternumber);//choice
            n = Console.ReadLine();
            switch (n)
            {
                case "1":

                    doraemon();
                    Console.Clear();
                    break;
                case "2":
                    Console.Clear();
                    guessnumbergame();
                    Console.Clear();
                    break;
                case "3":
                    Console.Clear();
                    hangman hangman = new hangman();
                    hangman.starthangman();
                    Console.Clear();
                    break;
                case "4":
                    Console.Clear();
                    andrew andrew = new andrew();
                    andrew.andrewstart();
                    break;
                case "5":
                    g = false;
                    break;
                default:
                    Console.Clear();
                    reenternumber = "Please reenter number";
                    break;
            }
        }
}

    static void doraemon()
    {
        //Declare variable and array
        string command;
        bool program = true;
        Random Card = new Random();
        int[] deck = { 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4 };
        //Enter penalty program
        Console.WriteLine("Please insert penalty for each card\n=============================");
        string[] penalty = new string[13];
        Insertpenalty(penalty);
        //Random card program
        while (program)
        {
            //random number
            int card = Card.Next(13);
            if (deck[card] == 0) { continue; }
            //text for user and make it can stop when user insert "stop"
            Console.WriteLine("Enter stop to stop\nPress Enter or Insert anything else to continue  : ");
            if (Console.ReadLine() == "stop") { program = false; break; }
            //Condition
            switch (card)
            {
                case <= 8:
                    Console.WriteLine("Card : " + (card + 2));
                    Console.WriteLine(penalty[card]);
                    break;
                case 9:
                    Console.WriteLine("Card : Jack");
                    Console.WriteLine(penalty[card]);
                    break;
                case 10:
                    Console.WriteLine("Card : Queen");
                    Console.WriteLine(penalty[card]);
                    break;
                case 11:
                    Console.WriteLine("Card : King");
                    Console.WriteLine(penalty[card]);
                    break;
                case 12:
                    Console.WriteLine("Card : A");
                    Console.WriteLine(penalty[card]);//we can change Console.WriteLine(penalty[card]); to the lower line but I dont know why I'm not done it
                    break;
            }
            //To make The deck can be empty
            deck[card]--;
            //When ran out of condition card
            if (deck[11] == 0)
            {
                Console.WriteLine("=============================\nEnd of round lol");
                Console.Write("Enter anything to replay or stop to stop : ");//\n or reset to set new penalty
                if ((command = (Console.ReadLine())) == "stop") { program = false; break; }
                else
                {
                    if (command == "reset")
                    {
                        Insertpenalty(penalty);
                    }
                    else
                    {
                        for (int refill = 0; refill < 12; refill++)
                        { deck[refill] = 4; }
                    }
                }
            }
        }
    }

    static void Insertpenalty(string[] Insert)
    {
        int i = 0;
        do
        {
            switch (i)
            {
                case <= 8:
                    Console.WriteLine("Penalty for card {0} : ", i + 2);
                    Insert[i] = Console.ReadLine();
                    break;
                case 9:
                    Console.WriteLine("Penalty for card Jack : ");
                    Insert[i] = Console.ReadLine();
                    break;
                case 10:
                    Console.WriteLine("Penalty for card Queen : ");
                    Insert[i] = Console.ReadLine();
                    break;
                case 11:
                    Console.WriteLine("Penalty for card King : ");
                    Insert[i] = Console.ReadLine();
                    break;
                case 12:
                    Console.WriteLine("Penalty for card A : ");
                    Insert[i] = Console.ReadLine();
                    break;
            }
            if (Insert[i] == "") { Console.Write("Please reenter "); continue; }
            if (Insert[i] == "reenter") 
            { 
                Console.Write("Please reenter "); 
                i--; 
                if (i == -1) { i++; }
                continue; 
            }
            i++;
        } while (i <= 12);
    }











        static void guessnumbergame()
        {
        string reround;
        int round = 1, playercount, maxnumber;
        //Introduce program let user design maximum , how many round they want and how many players
        Console.WriteLine("==========================================================\nThis is program guess random integer number\nIf insert 0 or not a number the maximum will set to 1000\n==========================================================");
        do {
            Console.Write("How many player(Enter only integer): ");
        } while (int.TryParse(Console.ReadLine(), out playercount) == false) ;
            Console.Write("please Enter maximum number to generate :");
        if (int.TryParse(Console.ReadLine(), out maxnumber) == false || maxnumber == 0 || maxnumber == 1) { maxnumber = 1000; }
        Console.Clear();
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
        while (reround != "N")
        {
            
            if (reround == "Y")
            {
                guessnumbergame();
            }
            Console.WriteLine("Please answer only Y/N : ");
            reround = Console.ReadLine();
        }
    }
    static int randomnumber(int maxgenerate)
    {
        //declare and tell maxgenerate
        Console.WriteLine("The number will below {0}",maxgenerate +"\n=============================");
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
