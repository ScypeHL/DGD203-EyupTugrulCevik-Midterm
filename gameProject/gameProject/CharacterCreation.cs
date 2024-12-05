using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Pro
{
    public class CharacterCreation : Game
    {
        Classes classes = new Classes();
        Yesno yesno = new Yesno();
        SaveGame saveGame = new SaveGame();

        bool regret = false;
        string birthplace = lands[rng.Next(0, 8)];

        // text boxes are in the start
        #region start
        public void start()
        {
            Console.WriteLine("Welcome to our fantastic world");
            Console.WriteLine("with all the things waiting to be discovered.");
            Console.WriteLine("You will be greeted by everything");
            Console.WriteLine("But i cant say that 'everthing' will treat you well");
            Console.WriteLine("We dont want something bad happens to you, right?");
            Console.WriteLine("");
            Console.WriteLine("Thats why i will be your guide");
            Console.WriteLine("But");
            Console.WriteLine("Since we will be sharing our some time together");
            Console.WriteLine("I thing addressing to you with your name would be better");
            Console.WriteLine("So could you please share your precious name with me?");
            getName();

            Console.WriteLine($"Okay then lets get to work {Name}");
            Console.WriteLine("Because we have things to prepare");
            Console.WriteLine($"Like you");
            Console.WriteLine("You cant just step outside like that");
            Console.WriteLine("And of course I, your greatest guide, have a plan");
            Console.WriteLine("But it will be better to ask you too");
            Console.WriteLine("");
            Console.WriteLine("If you want i have bunch of sets waiting for you");
            Console.WriteLine("You can choose one of them");
            Console.WriteLine("If not, you can build it yourself");
            Console.WriteLine("You will be using it after all");
            Console.WriteLine("So do you want to [create new] or [use preset]");
            create();
            saveGame.save();
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
                    Name = "";
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
                    Console.WriteLine("But i hope we get along well");
                    Console.WriteLine("");
                    Name = "";
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
            q1 = Console.ReadLine().ToLower();
            if (q1 == null ^ q1 == "")
            {
                Console.WriteLine(notAnswer[rng.Next(0, 5)]);
                create();
            }
            else if (q1 == "create new")
            {
                createClass();
            }
            else if (q1 == "use preset")
            {
                Console.WriteLine("");
                Console.WriteLine($"Now I advice you four options {Name}");
                Console.WriteLine("Please take a look at them and decide on one");
                printClass();
                chooseClass();
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
                Console.WriteLine(notAnswer[rng.Next(0, 5)]);
                chooseClass();
            }
            else if (q1 == "hunter" ^ q1 == "Hunter")
            {
                Character hunter = new Character(new Hunter(), new Dagger());
            }
            else if (q1 == "sorcerer" ^ q1 == "Sorcerer")
            {
                Character sorcerer = new Character(new Sorcerer(), new MagicWand());
            }
            else if (q1 == "warrior" ^ q1 == "Warrior")
            {
                Character warrior = new Character(new Warrior(), new Sword());
            }
            else if (q1 == "archer" ^ q1 == "Archer")
            {
                Character archer = new Character(new Archer(), new Bow());
            }
            else if (q1 == "dummy" ^ q1 == "Dummy")
            {
                Character dummy = new Character(new Dummy(), new Sword());
            }
            else
            {
                Console.WriteLine("Excuse me but i did not get it. Can you please come again?");
                chooseClass();
            }
        }
        #endregion

        #region createClass
        public void createClass()
        {
            bool repeat = true;
            
            Console.WriteLine("");
            Console.WriteLine($"So you want to create your own character, right {Name}");
            Console.WriteLine("Okay then, lets start with something simple");
            Console.WriteLine("I will be telling a story and you will be completing it");
            Console.WriteLine("Sounds good right?");
            while (repeat)
            {
                yesno.start();
                if (yesnoOut)
                {
                    repeat = false;
                    Console.WriteLine("");
                    Console.WriteLine("Hmm, lets see");
                    Console.WriteLine("Oh! This looks good");
                    Console.WriteLine("Then lets begin with this");
                    Console.WriteLine("");
                    tale();
                }
                else if (!yesnoOut) { Console.WriteLine("No? I thought you wanted to create your own story"); }
                else
                {
                    Console.WriteLine("bug");
                }
            }
        }

        void tale()
        {
            tale1();
            tale2();
            tale3();
            tale4();
            tale5();
            tale6();
            tale7();
            tale8();
        }

        void tale1()
        {
            string q1;

            Console.WriteLine($"You were born in {birthplace} as a child of ...");
            Console.Write("1 - [Retired Knight]\n2 - [Blacksmith]\n3 - [Gatherer]\n4 - [Farmer]\n5 - [Librarian]");
            Console.WriteLine("");
            q1 = Console.ReadLine().ToLower();

            if (q1 == "retired knight" ^ q1 == "1") { Ap += 3; Dp -= 1; ASpeed -= 0.1f; Hp -= 10; }
            else if (q1 == "blacksmith" ^ q1 == "2") { Ap += 2; Dp += 2; ASpeed += 0.05f; Sp -= 1; }
            else if (q1 == "gatherer" ^ q1 == "3") { Ap += 1; Sp += 1; ASpeed += 0.15f; Hp -= 10; }
            else if (q1 == "farmer" ^ q1 == "4") { Hp += 20; tale2(); }
            else if (q1 == "librarian" ^ q1 == "5") { Sp += 2; ASpeed -= 0.1f; Ap -= 2; Dp -= 1; }
            else { Console.WriteLine("Unfortunately this is not an option"); tale(); }
        }

        void tale2()
        {
            string q1;

            Console.WriteLine("");
            Console.WriteLine("In your childhood, you had a lot of friends");
            Console.WriteLine("You were not a quiet child and they were no diffrent");
            Console.WriteLine("You all were always doing some fun stuff like ...");
            Console.WriteLine("1 - [Climbing Trees]");
            Console.WriteLine("2 - [Hide 'n Seek]");
            Console.WriteLine("3 - [Watching residents cooking at the square and copying them]");
            Console.WriteLine("4 - [Sneakpeeking inside of the areas that we are not allowed]");
            
            q1 = Console.ReadLine();

            if (q1 == "1") { Hp -= 10; Sp += 1; ASpeed += 0.05f; }
            else if (q1 == "2") { ASpeed += 0.1f; Hp -= 5; }
            else if (q1 == "3") { Sp += 2; }
            else if (q1 == "4") { ASpeed += 0.1f; Sp += 1; }
            else { Console.WriteLine("Unfortunately this is not an option"); tale2(); }

        }

        void tale3()
        {
            string q1;

            Console.WriteLine("");
            Console.WriteLine("Your education life had so ups and downs");
            Console.WriteLine("You were never in good terms with the classes");
            Console.WriteLine("or were you?");
            
            yesno.start();
            if (yesnoOut) { Console.WriteLine("Wow really, you were? Thats a surprise"); Sp += 2; Ap -= 2; }
            else if (!yesnoOut) { Console.WriteLine("Yea right. I figured it out"); Sp -= 2; Ap += 2; }
            else { Console.WriteLine("bug"); }
        }

        void tale4()
        {
            string q1;

            Console.WriteLine("");
            Console.WriteLine("Okay, i was not talking about it anyway.");

            Console.WriteLine("While in your school years, you did quite a lot of thing");
            Console.WriteLine("But you have a regret about ...");
            Console.WriteLine("1 - [your love life]");
            Console.WriteLine("2 - [your grades]");
            Console.WriteLine("3 - [that thing happened to your friends because of you]");

            q1 = Console.ReadLine();

            if (q1 == "1") { Sp -= 2; Dp += 2; }
            else if (q1 == "2") { Sp -= 1; Hp += 10; }
            else if (q1 == "3") { ASpeed += 0.1f; Hp -= 10; Ap += 1; regret = true; }
            else { Console.WriteLine("Unfortunately this is not an option"); tale4(); }
        }

        void tale5()
        {
            string q1;
            bool repeat = true;

            Console.WriteLine("");
            Console.WriteLine("After the graduation your life was kind of boring");
            Console.WriteLine("You got a job and it was nothing but 9 - 5.");
            Console.WriteLine("But it was fun for you since you were doing your dream job");
            Console.WriteLine("For years you were dreaming of become a ...");
            Console.WriteLine("1 - [Warrior]");
            Console.WriteLine("2 - [Alchemist]");
            Console.WriteLine("3 - [Lecturer]");
            Console.WriteLine("4 - [Baker]");
            Console.WriteLine("5 - [Gardener]");

            while (repeat)
            {
                q1 = Console.ReadLine().ToLower();

                if (q1 == "1" ^ q1 == "warrior") { repeat = false; Ap += 3; Dp += 2; Hp += 20; }
                else if (q1 == "2" ^ q1 == "alchemist") { repeat = false; Sp += 4; Hp += 10; }
                else if (q1 == "3" ^ q1 == "lecturer") { repeat = false; ASpeed += 0.1f; Hp += 10; Sp += 2; }
                else if (q1 == "4" ^ q1 == "baker") { repeat = false; ASpeed += 0.2f; Ap += 2; Dp += 1; }
                else if (q1 == "5" ^ q1 == "gardener") { repeat = false; ASpeed += 0.1f; Ap += 2; Hp += 30; }
                else { Console.WriteLine("Unfortunately this is not an option"); tale5(); }
            }

        }

        void tale6()
        {
            string q1;
            string q2;
            bool repeat = true;
            bool repeat1 = true;

            Console.WriteLine("");
            Console.WriteLine("You were living your life casually until one day");
            Console.WriteLine("It was just an ordinary day");
            Console.WriteLine("All the shift staff was taking a break and you decided to get some coffee");
            Console.WriteLine("Headed up your favourite cafe and get your coffee");
            Console.WriteLine("You got a chair and took a look at the newspaper");
            Console.WriteLine("Then you heard a voice addressing you");

            Console.WriteLine("");
            Console.WriteLine("It was a casual looking woman");
            Console.WriteLine("Said that she knows you from somewhere");
            Console.WriteLine("You didn't recongise her but didn't want to down the mood so you got along");
            Console.WriteLine("She asked things about you over and over again");

            Console.WriteLine("");
            Console.WriteLine("'You beceme quite handsome, you know. Is this some sort of love effect? Do you have anyone in your life?'");
            yesno.start();
            if (yesnoOut) { Console.WriteLine("Oh really, good for you."); }
            else if (!yesnoOut) { Console.WriteLine("Come on you're lying, what do you mean no?"); }
            else { Console.WriteLine("bug"); }

            Console.WriteLine("");
            Console.WriteLine("Yet another question...");
            Console.WriteLine("'You were so annoying back in the day you know. It seems like you have changed. What were you doing after you graduated.'");
            Console.WriteLine("1 - I got a job right after the graduation and focused on my career");
            Console.WriteLine("2 - I didn't do something special");
            Console.WriteLine("3 - I got a farm and started growing things");
            Console.WriteLine("4 - I was advancing my academic career further.");
            while (repeat1)
            {
                q2 = Console.ReadLine();
                if (q2 == "1") { Console.WriteLine("You are a dependent guy"); Dp += 4; repeat1 = false; }
                else if (q2 == "2") { Console.WriteLine("..."); Console.WriteLine("You making it sound like nothing happened."); Hp -= 20; Sp += 1; Ap += 1; repeat1 = false; }
                else if (q2 == "3") { Console.WriteLine("Omg its so good. I always wanted to do something like that"); Hp += 20; Ap += 2; repeat1 = false; }
                else if (q2 == "4") { Console.WriteLine("Study ugh- stuying... I cant even stand hearing it."); Sp += 3; repeat1 = false; }
                else { Console.WriteLine("Stay focused bro this is not an option"); }
            }


            Console.WriteLine("After a stressful questioning she left");

            Console.WriteLine("");
            Console.WriteLine("Your break was about to end so you left as well");
            Console.WriteLine("But you were still thinking about that woman");
            Console.WriteLine("You were thinking about if she is really someone that you know");

            Console.WriteLine("");
            Console.WriteLine("After your shift ended, you spent some more time with your colleagues");
            Console.WriteLine("Drinking, talking behind people's backs... It was such a fuss");
            Console.WriteLine("Then you heard the same womans voice");
            Console.WriteLine("Turned your head back and saw her with someone");
            Console.WriteLine("That someone was someone that you know");

            Console.WriteLine("");
            Console.WriteLine("You were struggling remembering who is that guy");
            Console.WriteLine("Where do you know him from");
            Console.WriteLine("1 - Is he from your school");
            Console.WriteLine("2 - Is he your teacher");
            Console.WriteLine("3 - Is he from your hood");
            Console.WriteLine("4 - Is he from that thing");

            while (repeat)
            {
                q1 = Console.ReadLine();

                if (q1 == "1") { repeat = false; ASpeed += 0.1f; Hp -= 10; Dp -= 4; tale61(); }
                else if (q1 == "2") { repeat = false; Sp += 1; Hp -= 5; tale62(); }
                else if (q1 == "3") { repeat = false; Sp += 2; tale63(); }
                else if (q1 == "4")
                {
                    if (regret) { repeat = false; tale614(); }
                    else { repeat = false; tale64(); }
                }
                else { Console.WriteLine("Unfortunately this is not an option"); }
            }

        }

        void tale61()
        {   
            Console.WriteLine("");
            Console.WriteLine("You wanted to greet him and went to them");
            Console.WriteLine("She realised you coming and greeted you first. You greeted her back");
            Console.WriteLine($"'Oh my god {Name}, is that you?', he said.");
            Console.WriteLine("Seem like he remembered you as well");
            Console.WriteLine("You left your colleagues and sat at the table with them");

            Console.WriteLine("");
            Console.WriteLine("At first there were no problems");
            Console.WriteLine("You guys were talking casually");
            Console.WriteLine("but the conversation was getting weirder over time");
            Console.WriteLine("Atmosphere was a bit tense");
            Console.WriteLine("The woman jumped into the conversation and asked if you two were friends back then");
            
            yesno.start();
            if (yesnoOut) { tale611(); Ap += 2; Dp -= 2; }
            else if (!yesnoOut) { tale612(); Dp += 2; Ap -= 2; }
            else { Console.WriteLine("bug"); }
        }
        
        void tale611()
        {   
            Console.WriteLine("");
            Console.WriteLine("His anger was written all over his face.");
            Console.WriteLine("He did not forget what happened after all");
            Console.WriteLine("What did you do to him");
            
            Console.WriteLine("");
            Console.WriteLine("...");
            Console.WriteLine("Uuugh");
            Console.WriteLine("This suddenly turnet into something dramatic");
            Console.WriteLine("Im cutting it from here.");
            //end

        }

        void tale612()
        {
            Console.WriteLine("");
            Console.WriteLine("Guy seemed a bit offended");
            Console.WriteLine("but didn't make it out loud");
            Console.WriteLine("You guys talked for a little while longer.");
            Console.WriteLine("Then you took your leave and headed up to the home");
            //end
        }
        
        void tale62()
        {
            Console.WriteLine("");
            Console.WriteLine("You wanted to greet your teacher and went to them");
            Console.WriteLine("She realised you coming and greeted you first. You greeted her back");
            Console.WriteLine($"'Oh my god {Name}, is that you?', your teacher said.");
            Console.WriteLine("Seem like he remembered you as well");
            Console.WriteLine("You left your colleagues and sat at the table with them");
            
            Console.WriteLine("");
            Console.WriteLine("Some time had passed. You guys talked about stuff like");
            Console.WriteLine("How is it going now, How was it back then.. You know, good old days thing");
            Console.WriteLine("But it seems like she interested in you a bit too much");
            
            Console.WriteLine("");
            Console.WriteLine("After some chit chat with them. You left and headed up to home");
            //end

        }

        void tale63()
        {
            Console.WriteLine("");
            Console.WriteLine("You wanted to greet him and went to them");
            Console.WriteLine("He realised you and smiled");
            Console.WriteLine("He remembered you as well");
            Console.WriteLine("You spent such a wonderful time together");
            Console.WriteLine("After so many years it was pretty fun");

            Console.WriteLine("");
            Console.WriteLine("Time flied, the conversation felt you so re");
            Console.WriteLine("but that woman didn't even say a word, was watching you with a emotionless expression");
            Console.WriteLine("You just let it slide so the mood wont be spoiled");
            Console.WriteLine("Then you shaked hands with your friend and headed up to home");
            //end
        }
        
        void tale64()
        {
            Console.WriteLine("Something happened?");
            yesno.start();
            if (yesnoOut) { Console.WriteLine("What is it? Want to tell me?"); tale641(); }
            else if (!yesnoOut) { Console.WriteLine("Okay, i will continue then"); }
            else { Console.WriteLine("bug"); }
            //end

            void tale641()
            {
                string q1;
                bool repeat = true;

                Console.WriteLine("");
                Console.WriteLine("1 - Okay. I will tel you");
                Console.WriteLine("2 - Its nothing important. Lets keep going.");
                //end

                while (repeat)
                {
                    q1 = Console.ReadLine();
                    if (q1 == "1") { repeat = false; tale615(); Ap += 1; Sp += 1; }
                    else if (q1 == "2") { repeat = false; Console.WriteLine("Okay."); Dp += 1; Hp += 10; }
                    else { Console.WriteLine("Come again"); }
                }
            }
        }

        void tale614()
        {
            string q1;
            bool repeat = true;

            Console.WriteLine("");
            Console.WriteLine("This story getting so boring you know");
            Console.WriteLine("What is that all about?");
            Console.WriteLine("Werent we creating your character?");
            Console.WriteLine("And what is 'that thing' anyway?");
            Console.WriteLine("Is it related to the thing you said you regret about?");

            Console.WriteLine("");
            Console.WriteLine("Are you hiding something?");
            Console.WriteLine("Can you just tell me what exactly have you done?");
            Console.WriteLine("");
            Console.WriteLine("1 - Okay. I will tell you");
            Console.WriteLine("2 - I wont tell you");
            Console.WriteLine("3 - I- I can't t- tell you");

            while (repeat)
            {
                q1 = Console.ReadLine();
                if (q1 == "1") { repeat = false; tale615(); }
                else if (q1 == "2") { Console.WriteLine("Then i wont give your thing. Good luck with that"); Dp -= 1; Hp -= 10; ASpeed -= 0.1f; }
                else if (q1 == "3") { Console.WriteLine("Not this time bro. Just spit it out."); Ap -= 1; Sp -= 1; ASpeed -= 0.1f; }
                else { Console.WriteLine("I want a proper answer"); }
            }
        }
        void tale615()
        {
            string q1;
            bool repeat = true;

            Ap -= 4;
            Dp += 1;

            Console.WriteLine("");
            Console.WriteLine("...");
            Console.WriteLine("WHAT!");
            Console.WriteLine("What do you mean you stabbed your friend");
            Console.WriteLine("and for a girl");
            Console.WriteLine("hell no bro, there is no way you did that");
            Console.WriteLine("just how stupid are you");

            Console.WriteLine("");
            Console.WriteLine("1 - There is more than that. I just don't want to explain");
            Console.WriteLine("2 - I was a child. Of course i regret it.");
            Console.WriteLine("3 - Werent we creating a new life? Can't we just change the past?");

            while (repeat)
            {
                q1 = Console.ReadLine();
                if (q1 == "1") { repeat = false; Console.WriteLine($"I am not believing even a bit but okay. This is none of my business after all. right {Name}?"); ASpeed -= 0.1f; }
                else if (q1 == "2")
                {
                    repeat = false;
                    Console.WriteLine("(Sarcastic Laugher) go fuck yourself");
                    Console.WriteLine("How can this happen. What tf are we even doing right now.");
                    Console.WriteLine("I really want to end this section an forget about everything");
                    Console.WriteLine("Lets just do it");
                    Hp -= 10;
                    //end
                }
                else if (q1 == "3") { repeat = false; Console.WriteLine("Are you for real? No, kick that guy admin."); Environment.Exit(0); }
                else { Console.WriteLine("Talk, NOW!"); }
            }


        }

        void tale7()
        {
            Console.WriteLine("");
            Console.WriteLine("On the way back, you decided to get something to eat");
            Console.WriteLine("Found a market and stepped in");
            Console.WriteLine("Suddenly the lights turnet off");
            Console.WriteLine("You were trying to find somewhere you can support yourself");
            Console.WriteLine("and then you felt someone's breath");
            Console.WriteLine("That someone held your arms and forced you to lay down");
            Console.WriteLine("You were narcotized and collapsed within seconds.");

            Console.WriteLine("");
            Console.WriteLine("...");
            Console.WriteLine("...");
            Console.WriteLine("...");

            Console.WriteLine("");
            Console.WriteLine("You opened your eyes in somewhere like a basement");
            Console.WriteLine("Smell of mose was filling the room");
            Console.WriteLine("Someone realised you came to");
            Console.WriteLine("Stared you for some time and asked if you know someone called Kaneae");
            Console.WriteLine("'Do you know him?'");
            
            yesno.start();
            if (yesnoOut) { tale71(); Ap += 1; Sp += 1; }
            else if (!yesnoOut) { tale72(); Hp -= 20; Dp += 1; }
            else { Console.WriteLine("bug"); }
        }

        void tale71()
        {
            Console.WriteLine("");
            Console.WriteLine("'So you know him'");
            Console.WriteLine("He punched you in the stomach");
            Console.WriteLine("'Would you like to be bothered to tell us where he is?'");
            
            Console.WriteLine("");
            Console.WriteLine("This questioning continued for some time but");
            Console.WriteLine("You didn't know where he is or what he is doing");
            Console.WriteLine("They realised that there is no use");
            Console.WriteLine("They beat you up and dragged you into a forest");
        }

        void tale72()
        {
            Console.WriteLine("");
            Console.WriteLine("He punched you in the stomach");
            Console.WriteLine("'Do you think this is a joke'");
            Console.WriteLine("'Talk NOW!'");
            
            Console.WriteLine("");
            Console.WriteLine("This questioning continued for some time but");
            Console.WriteLine("You didn't know anything about him");
            Console.WriteLine("They realised that there is no use");
            Console.WriteLine("They treated you 'well' and dragged you into a forest");

        }

        void tale8()
        {
            string q1;
            bool repeat = true;
            ClassName = Name;

            Console.WriteLine("");
            Console.WriteLine("And this was around the time I found you");
            Console.WriteLine("With that, your tale ends");
            Console.WriteLine("and probably a new one is about to start");
            Console.WriteLine("So, any questions?");
            Console.WriteLine("1 - Arent we creating a new life, what is this story?");
            Console.WriteLine("2 - Wait, so i was beaten up and you found me?");
            Console.WriteLine("3 - So this is not a parallel universe or a game and i am literally living?");
            Console.WriteLine("4 - So how was it?");

            while (repeat)
            {
                q1 = Console.ReadLine();
                if (q1 == "1") { repeat = false; tale81(); }
                else if (q1 == "2") { repeat = false; tale82(); }
                else if (q1 == "3") { repeat = false; tale83(); }
                else if (q1 == "4") { repeat = false; Console.WriteLine(""); Console.WriteLine("Well well, lets see"); }
                else { Console.WriteLine("Sorry, can you please come again?"); }
            }


        }

        void tale81()
        {
            Console.WriteLine("");
            Console.WriteLine($"This is life {Name}");
            Console.WriteLine("There are things you cant change");
            Console.WriteLine("Im just here to make things better... or maybe easier for you");
            Console.WriteLine("Hope you understand");
            
            Console.WriteLine("");
            Console.WriteLine("So Lets see the what we got, shall we?");
            classes.compare();
        }

        void tale82()
        {
            Console.WriteLine("");
            Console.WriteLine("Yes, That is exactly what happened");
            Console.WriteLine("You were in the bad shape and i simply...");
            Console.WriteLine("gave you another chance");
            Console.WriteLine("Not good but... not bad, huh?");

            Console.WriteLine("");
            Console.WriteLine("Okay, so lets take a look at the results");
            classes.compare();
        }

        void tale83()
        {
            Console.WriteLine("");
            Console.WriteLine("Exactly");
            Console.WriteLine("This expreience is indeed unique");
            Console.WriteLine("And this is the reason");
            Console.WriteLine("This is reality");

            Console.WriteLine("");
            Console.WriteLine("Okay then, those are the results");
            classes.compare();
        }
        #endregion
    }
}
