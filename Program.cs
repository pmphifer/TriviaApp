using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace TriviaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Greeeting
            Console.Write("What is your name? ");
            string username = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Welcome {username}! Let's play some trivia!");
            Console.WriteLine();
            Console.WriteLine();



            //Question 1
            Console.WriteLine("Select your first category: Choose 1 for science or 2 for literature");
            int category = Convert.ToInt16(Console.ReadLine());

            if (category == 1)
            {
                Console.WriteLine("You chose science!");
                Console.WriteLine();
                Console.WriteLine("Question 1: What is the process plants use to produce energy using sunlight? 1-Photosynthesis or 2-Cellular Respiration");
                int answer = Convert.ToInt16(Console.ReadLine());

                if (answer == 1)
                {
                    Console.WriteLine("Photosynthesis is correct!");
                }
                else if (answer == 2)
                {
                    Console.WriteLine("I'm sorry, the correct answer is 1-Photosynthesis");
                }
                else
                {
                    Console.WriteLine("That is not a valid choice, please try again.");
                }
            }
            else if (category == 2)
            {
                Console.WriteLine("Literature question coming right up.");
                Console.WriteLine();
                Console.WriteLine("Question 1:Who wrote Matilda and Fantatic Mr. Fox? 1- Dr. Seuss or 2- Roald Dahl?");
                int lit = Convert.ToInt16(Console.ReadLine());

                if (lit == 1)
                {
                    Console.WriteLine("Sorry, Dr. Seuss is great, but he did not write Matilda or Fantastic Mr. Fox");
                }
                else if (lit == 2)
                {
                    Console.WriteLine("Roald Dahl is the correct answer!");
                }

                else
                {
                    Console.WriteLine("That is not a valid choice, please try again.");
                }

            }


            //Question 2
            Console.WriteLine();
            Console.WriteLine("Select your next category: Choose 1 for math or 2 for sports");
            category = Convert.ToInt16(Console.ReadLine());


            if (category == 1)
            {
                Console.WriteLine("Ok, math whiz!");
                Console.WriteLine();
                Console.WriteLine("Question 2: What is the square root of 25? 1- 5 or 2- 125");
                int answer = Convert.ToInt16(Console.ReadLine());

                if (answer == 1)
                {
                    Console.WriteLine("5 is correct!");
                }
                else if (answer == 2)
                {
                    Console.WriteLine("I'm sorry, the correct answer is 5");
                }
                else
                {
                    Console.WriteLine("That is not a valid choice, please try again.");
                }
            }

            else if (category == 2)
            {
                Console.WriteLine("Sports");
                Console.WriteLine();
                Console.WriteLine("Question 2: How many minutes was the longest recorded point in the history of tennis? 1- 29 minutes or 2- 14 minutes");
                int sport = Convert.ToInt16(Console.ReadLine());

                if (sport == 1)
                {
                    Console.WriteLine("Correct! The rally, which happened in 1984 lasted 29 minutes. There were 643 shots made!");
                }

                else if (sport == 2)
                {
                    Console.WriteLine("Incorrect. The rally, which happened in 1984, lasted 29 minutes and is still hold the record for longest.");
                }

                else
                {
                    Console.WriteLine("That is not a valid choice, please try again.");
                }

            }


            //Question 3
            Console.WriteLine();
            Console.WriteLine("Select your next category: Choose 1 for movies or 2 for music");
            category = Convert.ToInt16(Console.ReadLine());

            if (category == 1)
            {
                Console.WriteLine("You chose movies!");
                Console.WriteLine();
                Console.WriteLine("Question 3: For which 1964 musical blockbuster did Julie Andrews win the Academy Award for Best Actress? 1- The Sound of Music or 2- Mary Poppins");
                int answer = Convert.ToInt16(Console.ReadLine());

                if (answer == 1)
                {
                    Console.WriteLine("Incorrect! The Sound of Music came out in 1965.");
                }
                else if (answer == 2)
                {
                    Console.WriteLine("Supercalifragilisticexpialidocious! You're right!");
                }
                else
                {
                    Console.WriteLine("That is not a valid choice, please try again.");
                }

            }
            else if (category == 2)
            {
                Console.WriteLine("You chose music");
                Console.WriteLine();
                Console.WriteLine("Question 3:What was the lead single from Prince's 1984 album, Purple Rain? 1- Purple Rain or 2- When Doves Cry");
                int answer = Convert.ToInt16(Console.ReadLine());

                if (answer == 1)
                {
                    Console.WriteLine("Oooh, sorry, let me guide you to the purple rain, I mean correct answer...When Doves Cry");
                }

                else if (answer == 2)
                {
                    Console.WriteLine("Correct! No Crying here!");
                }

                else
                {
                    Console.WriteLine("That is not a valid choice, please try again.");
                }

            }

            //Question 4
            Console.WriteLine();
            Console.WriteLine("Select your next category: Choose 1 for current events or 2 for history");
            category = Convert.ToInt16(Console.ReadLine());

            if (category == 1)
            {
                Console.WriteLine("Current events");
                Console.WriteLine();
                Console.WriteLine("Question 4: The number one pick in the NFL draft, Joe Burrow, was choseb by which team? 1- NY Giants or 2- Cincinnati Bengals");
                int answer = Convert.ToInt16(Console.ReadLine());

                if (answer == 1)
                {
                    Console.WriteLine("Sorry, it was not the Gaints!");
                }
                else if (answer == 2)
                {
                    Console.WriteLine("Cincinnati is correct");
                }
                else
                {
                    Console.WriteLine("That is not a valid choice, please try again.");
                }
            }

            else if (category == 2)
            {
                Console.WriteLine("History");
                Console.WriteLine();
                Console.WriteLine("Question 4: Who is remembered for his large and stylish signature on the United States Declaration of Independence? 1- John Hancock or 2- Thomas Jefferson");
                int sport = Convert.ToInt16(Console.ReadLine());

                if (sport == 1)
                {
                    Console.WriteLine("Correct!");
                }

                else if (sport == 2)
                {
                    Console.WriteLine("Incorrect. Jefferson was one of the 56 to sign, but John Hancock's signature is most iconic.");
                }

                else
                {
                    Console.WriteLine("That is not a valid choice, please try again.");
                }

            }

            //Question 5
            Console.WriteLine();
            Console.WriteLine("Select your next category: Choose 1 for 90s or 2 for 80s");
            category = Convert.ToInt16(Console.ReadLine());

            if (category == 1)
            {
                Console.WriteLine("90s Trivia it is!");
                Console.WriteLine();
                Console.WriteLine("Question 5: What is name of the beloved teacher on Boy Meets World? 1- Ms. Bliss or 2- Mr. Feeny ");
                int answer = Convert.ToInt16(Console.ReadLine());

                if (answer == 1)
                {
                    Console.WriteLine("Incorrect, Ms. Bliss was the influential teacher on Saved by the Bell");
                }
                else if (answer == 2)
                {
                    Console.WriteLine("fe-fe-fe-fe-feenay FEEEENYYYY! You are correct.");
                }
                else
                {
                    Console.WriteLine("That is not a valid choice, please try again.");
                }
            }

            else if (category == 2)
            {
                Console.WriteLine("80s Trivia!");
                Console.WriteLine();
                Console.WriteLine("Question 5: What song does Tom Cruise dance to in Risky Business? 1- Old Time Rock and Roll or 2- Don't Stop Believin");
                int answer = Convert.ToInt16(Console.ReadLine());

                if (answer == 1)
                {
                    Console.WriteLine("Correct!");
                }

                else if (answer == 2)
                {
                    Console.WriteLine("Incorrect");
                }

                else
                {
                    Console.WriteLine("That is not a valid choice, please try again.");
                }
            }

            //Question 6
            Console.WriteLine();
            Console.WriteLine("Select your next category: Choose 1 for Harry Potter or 2 for Disney");
            category = Convert.ToInt16(Console.ReadLine());

            if (category == 1)
            {
                Console.WriteLine("Harry Potter, great choice!");
                Console.WriteLine();
                Console.WriteLine("Question 6: What is name of Weasley's eldest sibling?  1- Charlie or 2- Bill ");
               int answer = Convert.ToInt16(Console.ReadLine());

                if (answer == 1)
                {
                    Console.WriteLine("Incorrect, Bill is the eldest.");
                }
                else if (answer == 2)
                {
                    Console.WriteLine("You are correct.");
                }
                else
                {
                    Console.WriteLine("That is not a valid choice, please try again.");
                }
            }

            else if (category == 2)
            {
                Console.WriteLine("Disney it is!");
                Console.WriteLine();
                Console.WriteLine("Question 6: Who was the fitst Disney princess? 1- Cinderella or 2- Snow White");
              int answer = Convert.ToInt16(Console.ReadLine());

                if (answer == 1)
                {
                    Console.WriteLine("Incorrect! Cinderella was second in line, though she came 13 years after Snow White.");
                }

                else if (answer == 2)
                {
                    Console.WriteLine("Incorrect");
                }

                else
                {
                    Console.WriteLine("That is not a valid choice, please try again.");
                }

            }

            //Question 7
            Console.WriteLine();
            Console.WriteLine("Select your next category: Choose 1 for biology or 2 for chemistry");
            category = Convert.ToInt16(Console.ReadLine());

            if (category == 1)
            {
                Console.WriteLine("Biology");
                Console.WriteLine();
                Console.WriteLine("Question 7: Who has more bones?  1- A human adult or 2- A human infant ");
              int answer = Convert.ToInt16(Console.ReadLine());

                if (answer == 1)
                {
                    Console.WriteLine("Incorrect, infants have about 300 bones, but some fuse together to form the 206 that adults have.");
                }
                else if (answer == 2)
                {
                    Console.WriteLine("You are correct. Adults have 206, while infantss have about 300.");
                }
                else
                {
                    Console.WriteLine("That is not a valid choice, please try again.");
                }
            }

            else if (category == 2)
            {
                Console.WriteLine("Chemistry");
                Console.WriteLine();
                Console.WriteLine("Question 7: Which element is represented by the symbol Co? 1- Cobalt or 2- Copper");
               int answer = Convert.ToInt16(Console.ReadLine());

                if (answer == 1)
                {
                    Console.WriteLine("Correct");
                }

                else if (answer == 2)
                {
                    Console.WriteLine("Incorrect, copper's symbol is Cu");
                }

                else
                {
                    Console.WriteLine("That is not a valid choice, please try again.");
                }
            }

            Console.ReadLine();
        }
    }
}


