using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    public class CharacterCreation : Game
    {
        Classes classes = new Classes();
        public CharacterCreation()
        {

        }

        #region start
        public void start()
        {
            Console.WriteLine("Welcome to our fantastic world");
            Console.WriteLine("with all the things waiting to be discovered.");
            Console.WriteLine("You will be greeted by everything");
            Console.WriteLine("But i cant say that 'everthing' will greet you in a good way");
            Console.WriteLine("We dont want something bad happens to you, right?");
            Console.WriteLine("");
            Console.WriteLine("Thats why i will be your guide");
            Console.WriteLine("But");
            Console.WriteLine("Since we will be sharing our some time together");
            Console.WriteLine("Calling you 'you' everytime might be a bit rude");
            Console.WriteLine("So could you please share your precious name with me?");
            getName();

            Console.WriteLine("Okay then lets get to work");
            Console.WriteLine("Because we have things to prepare");
            Console.WriteLine("Like you");
            Console.WriteLine("You cant just step outside like that");
            Console.WriteLine("And of course I, your greatest guide, have a plan");
            Console.WriteLine("But it will be better to ask you too");
            Console.WriteLine("");
            Console.WriteLine("If you want i prepared a kit like thing");
            Console.WriteLine("You can use it");
            Console.WriteLine("If not, you can build it yourself");
            Console.WriteLine("You will be using it after all");
            Console.WriteLine("So do you want to [create new] or [use preset]");
            create();
            Console.WriteLine("Please take a look at them and decide on one");
            printClass();
            chooseClass();
            classes.start();
        }
        #endregion

        #region getName
        public void getName()
        {
            string q1;
            string q2;
            Name = Console.ReadLine();
            if (Name == null ^ Name == "")
            {
                Console.WriteLine("Are you afraid of share your name with me?");
                q1 = Console.ReadLine();
                if (q1 == "yes" ^ q1 == "Yes" ^ q1 == "y" ^ q1 == "Y")
                {
                    Console.WriteLine("Actually i can't blame you");
                    Console.WriteLine("It has been only minutes since we met but I did ask this.");
                    Console.WriteLine("Its okay if you don't want to but I would be appericiated if you share your name with me");
                    Console.WriteLine("");
                    Name = "you";
                }
                else if (q1 == "no" ^ q1 == "No" ^ q1 == "n" ^ q1 == "N")
                {
                    Console.WriteLine("Okay than you name is?");
                    getName();
                }
                else if (q1 == null ^ q1 == "")
                {
                    Console.WriteLine("Okay, if you dont want you dont have to say.");
                    Console.WriteLine("I wont force you");
                    Console.WriteLine("But i hove we get along well");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("I dont get it");
                    getName();
                }
            }
            else
            {
                Console.WriteLine($"So your name is {Name}, right?");
                q2 = Console.ReadLine();
                if (q2 == "yes" ^ q2 == "Yes" ^ q2 == "y" ^ q2 == "Y")
                {
                    return;
                }
                else if (q2 == "no" ^ q2 == "No" ^ q2 == "n" ^ q2 == "N")
                {
                    Console.WriteLine("What is your name then");
                    getName();
                }
                else
                {
                    Console.WriteLine("I dont get it");
                    getName();
                }
            }
        }
        #endregion

        #region create
        public void create()
        {
            string q1;
            q1 = Console.ReadLine();
            if (q1 == null ^ q1 == "")
            {
                Console.WriteLine(notAnswer[rng.Next(0, 6)]);
                create();
            }
            else if (q1 == "create new")
            {

            }
            else if (q1 == "use preset")
            {
                Console.WriteLine("");
                Console.WriteLine("Now I advice you four options.");
            }
            else
            {
                Console.WriteLine("Okay but this is unfortunately not an option.");
                Console.WriteLine("You can [create new] or [use preset]");
                create();
            }
        }
        #endregion

        #region aboutClass
        public void printClass()
        {
            Console.WriteLine($"[Hunter] >   Health:100 | Attack:14 | Skill:8  | Defense: 10 | Attack Speed:1.4");
            Console.WriteLine($"[Sorcerer] > Health:90  | Attack:3  | Skill:19 | Defense: 6  | Attack Speed:0.6");
            Console.WriteLine($"[Archer] >   Health:100 | Attack:13 | Skill:13 | Defense: 5  | Attack Speed:1.2");
            Console.WriteLine($"[Warrior] >  Health:140 | Attack:16 | Skill:5  | Defense: 14 | Attack Speed:1.1");
        }
        public void chooseClass()
        {
            string q1;


            q1 = Console.ReadLine();
            if (q1 == null ^ q1 == "")
            {
                Console.WriteLine(notAnswer[rng.Next(0, 6)]);
                chooseClass();
            }
            else if (q1 == "hunter" ^ q1 == "Hunter")
            {
                Character hunter = new Character(new Hunter());
            }
            else if (q1 == "sorcerer" ^ q1 == "Sorcerer")
            {
                Character sorcerer = new Character(new Sorcerer());
            }
            else if (q1 == "warrior" ^ q1 == "Warrior")
            {
                Character warrior = new Character(new Warrior());
            }
            else if (q1 == "archer" ^ q1 == "Archer")
            {
                Character archer = new Character(new Archer());
            }
            else
            {
                Console.WriteLine("Excuse me but i did not get it. Can you please come again?");
                chooseClass();
            }
        }
        #endregion
    }
}
