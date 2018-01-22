using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part one greetings statement

            string messageOne = "Hello World!";
            string messageTwo = "I am Spartacus";

            ////Part two set initial Spartacus attributes

            int ageOne = 35;
            //int ageTwo = 70;
            //int ageThree = 80;
            double heightOne = 72.50;
            //double heightTwo = 91.45;
            float weightOne = 210.0284606f;
            //float weightTwo = 331.12345678f;
            bool isGodLikeOne = true;
            //bool isGodLikeTwo = false;
            //char genderMale = 'M';
            //char genderFemale = 'F';

            ////Part three display variable values

            //Console.WriteLine(messageOne);
            //Console.WriteLine(messageTwo);
            //Console.WriteLine(ageOne + ageTwo);

            ////Part four mathematical operator, bool and char examples



            //Console.WriteLine(isGodLikeOne);
            //Console.WriteLine(genderMale);
            //ageTwo++;
            //Console.WriteLine(ageTwo);
            //ageTwo--;
            //Console.WriteLine(ageTwo);
            //Console.WriteLine();
            //Console.WriteLine("5" == "5");
            //Console.WriteLine(40 != 40);
            //Console.WriteLine(11 < 4);

            ////Part five variable reassignment
            //ageTwo = 70;
            //heightTwo = 35.12345f;
            //weightTwo = -429.1234573f;

            ////Part six mathematical operator examples

            //Console.WriteLine(ageOne + ageTwo);
            //Console.WriteLine(heightOne - heightTwo);

            //Console.WriteLine(heightOne - heightTwo);
            //Console.WriteLine(weightOne * weightTwo);

            //Console.WriteLine(weightOne * weightTwo);
            //Console.WriteLine(ageTwo / ageOne);
            //Console.WriteLine(ageTwo % ageOne);
            //Console.WriteLine(ageThree / ageOne);
            //Console.WriteLine(ageThree % ageOne);

            ////Part seven increment and decrement operator examples

            //ageTwo - ageTwo + 1;
            //Console.WriteLine(ageTwo);
            // ageTwo++;
            //Console.WriteLine(ageTwo);
            // ageTwo--;
            //Console.WriteLine(ageTwo);

            //Part eight concatenation example
            // Console.WriteLine(messageOne + "" + messageTwo + ".");
            //  Console.WriteLine("I am " + ageOne + "," + " and yes it's " + isGodLikeOne + "I am godlike.");
            //  Console.WriteLine("I weigh around " + weightOne + " pounds, and I am around " + heightOne + " inches tall.");
            //  Console.WriteLine("My father is {0} years old, and yes it's {1} he is a god.", ageOne, isGodLikeOne);
            //  Console.WriteLine("I weigh around {0} pounds, and I am around {1} inches tall.", ageOne, heightOne);


            //Part nine string equality examples
            //Console.WriteLine(messageTwo.Equals(messageOne));
            //Console.WriteLine(messageTwo.Equals("I am Spartacus"));


            //string myGreeting = "Hello";
            //Console.WriteLine(myGreeting.ToUpper()); // prints "HELLO"
            //Console.WriteLine(myGreeting.ToLower());// prints "hello"
            //Console.WriteLine(myGreeting); //prints "Hello"

            //Part ten string length examples
            //int messOneLength = messageOne.Length;
            //int messTwoLength = messageTwo.Length;

            //Console.WriteLine("The length of messageOne is " + messageOne.Length);
            //Console.WriteLine("The length of messageTwo is " + messageTwo.Length);
            //Console.WriteLine("The length of messageOne is " + messOneLength);
            //Console.WriteLine("The length of messageTwo is " + messTwoLength);

            //Part eleven conditional examples

            //string city1 = "Vesuvius";
            //string city2 = "Nola";
            //string city3 = "Nyceria";
            //int city1Distance, city2Distance, city3Distance;

            ////Solicit user input example
            //Console.WriteLine("What is the distance to {0}?", city1);
            //city1Distance = int.Parse(Console.ReadLine());
            //Console.WriteLine("What is the distance to " + city2 + "?");
            //city2Distance = int.Parse(Console.ReadLine());
            //Console.WriteLine("What is gthe distance to Nyceria?");
            //city3Distance = int.Parse(Console.ReadLine());

            //if ((city1Distance <= 125) && (city2Distance < city1Distance) && (city1Distance < city3Distance))
            //{
            //    Console.WriteLine("We will march to Vesuvius");

            //}

            //if ((city2Distance <= 125) && (city2Distance < city1Distance) && (city2Distance < city3Distance)) 
            //{
            //    Console.WriteLine("We will march to Nola");

            //}

            //if ((city3Distance <= 125) && (city3Distance < city1Distance) && (city3Distance < city2Distance)) 
            //{
            //    Console.WriteLine("We will march to Nyceria");

            //}

            //Section twelve conditionals

             Console.WriteLine("What is your rank soldier?");
             string rank = Console.ReadLine();
            //// rank.ToLower();

            Console.WriteLine("What is your age soldier?");
            int age = int.Parse(Console.ReadLine());

             Console.WriteLine("What is your job soldier?");
             string job = Console.ReadLine();

            // if ((rank == "officer") ||  (age <=26))
            // {
            //     Console.WriteLine("Get your gear, kiss your family goodbye, put on your marching boots.");
            // }
            // else if ((job == "cook") && (age >= 26))
            // {
            //     Console.WriteLine("My army has to eat, pack your pots and pans.");
            // }

            // else
            // {
            //     Console.WriteLine("Sorry, you are staying home.");
            // }


            //section thirteen switch case
            switch(job)
            {
                case "infantry":
                    Console.WriteLine("You will carry a sword");
                    break;

                case "archers":
                    Console.WriteLine("You will carry a bow and arrow");
                    break;

                default:
                    Console.WriteLine("You will operate the catapault");
                    break;
            }

        }




    }
}
