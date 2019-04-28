using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab9
{
    class Program
    {

        static void Main(string[] args)
        {
            string userContinue = null;

            var studentNames = new List<string>();
            studentNames.Add("Madison");
            studentNames.Add("Gregory");
            studentNames.Add("Sophia");
            studentNames.Add("Tyler");
            studentNames.Add("Ashley");

            var studentOneDetails = new List<string>();
            studentOneDetails.Add("taking naps and playing Monster Hunter");
            studentOneDetails.Add("Trenton, MI");
            studentOneDetails.Add("Sushi");

            var studentTwoDetails = new List<string>();
            studentTwoDetails.Add("playing video games and going to the gym");
            studentTwoDetails.Add("Troy, MI");
            studentTwoDetails.Add("Korean BBQ");

            var studentThreeDetails = new List<string>();
            studentThreeDetails.Add("going on walks");
            studentThreeDetails.Add("Saint Clair Shores, MI");
            studentThreeDetails.Add("Taco Bell");

            var studentFourDetails = new List<string>();
            studentFourDetails.Add("listening to podcasts");
            studentFourDetails.Add("Trenton, MI");
            studentFourDetails.Add("Pizza");

            var studentFiveDetails = new List<string>();
            studentFiveDetails.Add("storm chasing");
            studentFiveDetails.Add("Dearborn, MI");
            studentFiveDetails.Add("Ice Cream Sundaes");

            do
            {
                Console.WriteLine($"Welcome to our C# class. Would you like to add a new student to the roster?(y/n)");
                string userAddOption = Console.ReadLine();
                if (userAddOption.ToLower() != "y")
                {
                    Console.WriteLine($"Which student would you like to learn more about?(enter a number 1-{studentNames.Count})");
                    int userInt = Convert.ToInt32(Console.ReadLine());

                    if (userInt > studentNames.Count)
                    {
                        Console.WriteLine($"That student or option does not exist. ");
                    }
                    else if (userInt == 1)
                    {
                        Console.WriteLine($"Student 1 is {studentNames[0]}. What would you like to know about {studentNames[0]}? (\"hobbies\" or \"hometown\" or \"favorite food\")");
                        string studentOneInput = Console.ReadLine();
                        if (studentOneInput.ToLower() == "hobbies")
                        {
                            Console.WriteLine($"{studentNames[0]} enjoys {studentOneDetails[0]}.");

                        }
                        else if (studentOneInput.ToLower() == "hometown")
                        {
                            Console.WriteLine($"{studentNames[0]} is from {studentOneDetails[1]}");
                        }
                        else if (studentOneInput.ToLower() == "favorite food")
                        {
                            Console.WriteLine($"{studentNames[0]} love to eat {studentOneDetails[2]}");
                        }
                        else if (studentOneInput.ToLower() != "hobbies" || studentOneInput.ToLower() != "hometown" || studentOneInput.ToLower() != "favorite food")
                        {
                            Console.WriteLine("That is not an option, please try again.");
                        }
                    }

                    else if (userInt == 2)
                    {
                        Console.WriteLine($"Student 2 is {studentNames[1]}. What would you like to know about {studentNames[1]}? (\"hobbies\" or \"hometown\" or \"favorite food\")");
                        string studentTwoInput = Console.ReadLine();
                        if (studentTwoInput.ToLower() == "hobbies")
                        {
                            Console.WriteLine($"{studentNames[1]} enjoys {studentTwoDetails[0]}. ");

                        }
                        else if (studentTwoInput.ToLower() == "hometown")
                        {
                            Console.WriteLine($"{studentNames[1]} is from {studentTwoDetails[1]}");
                        }
                        else if (studentTwoInput.ToLower() == "favorite food")
                        {
                            Console.WriteLine($"{studentNames[1]} love to eat {studentTwoDetails[2]}");
                        }
                        else if (studentTwoInput.ToLower() != "hobbies" || studentTwoInput.ToLower() != "hometown" || studentTwoInput.ToLower() != "favorite food")
                        {
                            Console.WriteLine("That is not an option, please try again.");
                        }

                    }
                    else if (userInt == 3)
                    {
                        Console.WriteLine($"Student 3 is {studentNames[2]}. What would you like to know about {studentNames[2]}? (\"hobbies\" or \"hometown\" or \"favorite food\")");
                        string studentThreeInput = Console.ReadLine();
                        if (studentThreeInput.ToLower() == "hobbies")
                        {
                            Console.WriteLine($"{studentNames[2]} enjoys {studentThreeDetails[0]}.");

                        }
                        else if (studentThreeInput.ToLower() == "hometown")
                        {
                            Console.WriteLine($"{studentNames[2]} is from {studentThreeDetails[1]}");
                        }
                        else if (studentThreeInput.ToLower() == "favorite food")
                        {
                            Console.WriteLine($"{studentNames[2]} loves to eat {studentThreeDetails[2]}");
                        }
                        else if (studentThreeInput.ToLower() != "hobbies" || studentThreeInput.ToLower() != "hometown" || studentThreeInput.ToLower() != "favorite food")
                        {
                            Console.WriteLine("That is not an option, please try again.");
                        }
                    }
                    else if (userInt == 4)
                    {
                        Console.WriteLine($"Student 4 is {studentNames[3]}. What would you like to know about {studentNames[3]}? (\"hobbies\" or \"hometown\" or \"favorite food\")");
                        string studentFourInput = Console.ReadLine();
                        if (studentFourInput.ToLower() == "hobbies")
                        {
                            Console.WriteLine($"{studentNames[3]} enjoys {studentFourDetails[0]}.");

                        }
                        else if (studentFourInput.ToLower() == "hometown")
                        {
                            Console.WriteLine($"{studentNames[3]} is from {studentFourDetails[1]}.");
                        }
                        else if (studentFourInput.ToLower() == "favorite food")
                        {
                            Console.WriteLine($"{studentNames[3]} loves to eat {studentFourDetails[2]}.");
                        }
                        else if (studentFourInput.ToLower() != "hobbies" || studentFourInput.ToLower() != "hometown" || studentFourInput.ToLower() != "favorite food")
                        {
                            Console.WriteLine("That is not an option, please try again.");
                        }
                    }
                    else if (userInt == 5)
                    {


                        Console.WriteLine($"Student 5 is {studentNames[4]}. What would you like to know about {studentNames[4]}? (\"hobbies\" or \"hometown\" or \"favorite food\")");
                        string studentFiveInput = Console.ReadLine();
                        if (studentFiveInput.ToLower() == "hobbies")
                        {
                            Console.WriteLine($"{studentNames[4]} enjoys {studentFiveDetails[0]}.");

                        }
                        else if (studentFiveInput.ToLower() == "hometown")
                        {
                            Console.WriteLine($"{studentNames[4]} is from {studentFiveDetails[1]}.");
                        }
                        else if (studentFiveInput.ToLower() == "favorite food")
                        {
                            Console.WriteLine($"{studentNames[4]} loves to eat {studentFiveDetails[2]}.");
                        }
                        else if (studentFiveInput.ToLower() != "hobbies" || studentFiveInput.ToLower() != "hometown" || studentFiveInput.ToLower() != "favorite food")
                        {
                            Console.WriteLine("That is not an option, please try again.");
                        }

                    }
                }
                else if (userAddOption.ToLower() == "y" && studentNames.Count < 6)
                {


                    var studentSixDetails = new List<string>();

                    Console.WriteLine($"Please enter the students name you would like to add:");
                    string addStudent = Console.ReadLine();
                    studentNames.Add(addStudent);

                    Console.WriteLine($"Thank you! Please add {studentNames[5]}'s favorite hobby:");
                    string studentSixHobby = Console.ReadLine();

                    studentSixDetails.Add(studentSixHobby);

                    Console.WriteLine($"Thank you! Please add {studentNames[5]}'s hometown:");
                    string studentSixHometown = Console.ReadLine();
                    studentSixDetails.Add(studentSixHometown);

                    Console.WriteLine($"Thank you! Please add {studentNames[5]}'s favorite food:");
                    string studentSixFavFood = Console.ReadLine();
                    studentSixDetails.Add(studentSixFavFood);

                    Console.WriteLine($"Thank you! I will have student 6 added to the roster. We are now at max capacity for our class.");

                    Console.WriteLine($"Which student would you like to learn more about?(enter a number 1-{studentNames.Count})");
                    int userIntNewStudent = Convert.ToInt32(Console.ReadLine());

                    if (userIntNewStudent > studentNames.Count)
                    {
                        Console.WriteLine($"That student or option does not exist. ");
                    }
                    else if (userIntNewStudent == 1)
                    {
                        Console.WriteLine($"Student 1 is {studentNames[0]}. What would you like to know about {studentNames[0]}? (\"hobbies\" or \"hometown\" or \"favorite food\")");
                        string studentOneInput = Console.ReadLine();
                        if (studentOneInput.ToLower() == "hobbies")
                        {
                            Console.WriteLine($"{studentNames[0]} enjoys {studentOneDetails[0]}.");

                        }
                        else if (studentOneInput.ToLower() == "hometown")
                        {
                            Console.WriteLine($"{studentNames[0]} is from {studentOneDetails[1]}");
                        }
                        else if (studentOneInput.ToLower() == "favorite food")
                        {
                            Console.WriteLine($"{studentNames[0]} love to eat {studentOneDetails[2]}");
                        }
                        else if (studentOneInput.ToLower() != "hobbies" || studentOneInput.ToLower() != "hometown" || studentOneInput.ToLower() != "favorite food")
                        {
                            Console.WriteLine("That is not an option, please try again.");
                        }
                    }

                    else if (userIntNewStudent == 2)
                    {
                        Console.WriteLine($"Student 2 is {studentNames[1]}. What would you like to know about {studentNames[1]}? (\"hobbies\" or \"hometown\" or \"favorite food\")");
                        string studentTwoInput = Console.ReadLine();
                        if (studentTwoInput.ToLower() == "hobbies")
                        {
                            Console.WriteLine($"{studentNames[1]} enjoys {studentTwoDetails[0]}.");

                        }
                        else if (studentTwoInput.ToLower() == "hometown")
                        {
                            Console.WriteLine($"{studentNames[1]} is from {studentTwoDetails[1]}");
                        }
                        else if (studentTwoInput.ToLower() == "favorite food")
                        {
                            Console.WriteLine($"{studentNames[1]} love to eat {studentTwoDetails[2]}");
                        }
                        else if (studentTwoInput.ToLower() != "hobbies" || studentTwoInput.ToLower() != "hometown" || studentTwoInput.ToLower() != "favorite food")
                        {
                            Console.WriteLine("That is not an option, please try again.");
                        }

                    }
                    else if (userIntNewStudent == 3)
                    {
                        Console.WriteLine($"Student 3 is {studentNames[2]}. What would you like to know about {studentNames[2]}? (\"hobbies\" or \"hometown\" or \"favorite food\")");
                        string studentThreeInput = Console.ReadLine();
                        if (studentThreeInput.ToLower() == "hobbies")
                        {
                            Console.WriteLine($"{studentNames[2]} enjoys {studentThreeDetails[0]}. ");

                        }
                        else if (studentThreeInput.ToLower() == "hometown")
                        {
                            Console.WriteLine($"{studentNames[2]} is from {studentThreeDetails[1]}");
                        }
                        else if (studentThreeInput.ToLower() == "favorite food")
                        {
                            Console.WriteLine($"{studentNames[2]} loves to eat {studentThreeDetails[2]}");
                        }
                        else if (studentThreeInput.ToLower() != "hobbies" || studentThreeInput.ToLower() != "hometown" || studentThreeInput.ToLower() != "favorite food")
                        {
                            Console.WriteLine("That is not an option, please try again.");
                        }
                    }
                    else if (userIntNewStudent == 4)
                    {
                        Console.WriteLine($"Student 4 is {studentNames[3]}. What would you like to know about {studentNames[3]}? (\"hobbies\" or \"hometown\" or \"favorite food\")");
                        string studentFourInput = Console.ReadLine();
                        if (studentFourInput.ToLower() == "hobbies")
                        {
                            Console.WriteLine($"{studentNames[3]} enjoys {studentFourDetails[0]}.");

                        }
                        else if (studentFourInput.ToLower() == "hometown")
                        {
                            Console.WriteLine($"{studentNames[3]} is from {studentFourDetails[1]}.");
                        }
                        else if (studentFourInput.ToLower() == "favorite food")
                        {
                            Console.WriteLine($"{studentNames[3]} loves to eat {studentFourDetails[2]}.");
                        }
                        else if (studentFourInput.ToLower() != "hobbies" || studentFourInput.ToLower() != "hometown" || studentFourInput.ToLower() != "favorite food")
                        {
                            Console.WriteLine("That is not an option, please try again.");
                        }
                    }
                    else if (userIntNewStudent == 5)
                    {
                        Console.WriteLine($"Student 5 is {studentNames[4]}. What would you like to know about {studentNames[4]}? (\"hobbies\" or \"hometown\" or \"favorite food\")");
                        string studentFiveInput = Console.ReadLine();
                        if (studentFiveInput.ToLower() == "hobbies")
                        {
                            Console.WriteLine($"{studentNames[4]} enjoys {studentFiveDetails[0]}.");

                        }
                        else if (studentFiveInput.ToLower() == "hometown")
                        {
                            Console.WriteLine($"{studentNames[4]} is from {studentFiveDetails[1]}.");
                        }
                        else if (studentFiveInput.ToLower() == "favorite food")
                        {
                            Console.WriteLine($"{studentNames[4]} loves to eat {studentFiveDetails[2]}.");
                        }
                        else if (studentFiveInput.ToLower() != "hobbies" || studentFiveInput.ToLower() != "hometown" || studentFiveInput.ToLower() != "favorite food")
                        {
                            Console.WriteLine("That is not an option, please try again.");
                        }
                    }
                    else if (userIntNewStudent == 6)
                    {
                        Console.WriteLine($"Student 6 is {studentNames[5]}. What would you like to know about {studentNames[5]}? (\"hobbies\" or \"hometown\" or \"favorite food\")");
                        string studentSixInput = Console.ReadLine();
                        if (studentSixInput.ToLower() == "hobbies")
                        {
                            Console.WriteLine($"{studentNames[5]} enjoys {studentSixDetails[0]}.");

                        }
                        else if (studentSixInput.ToLower() == "hometown")
                        {
                            Console.WriteLine($"{studentNames[5]} is from {studentSixDetails[1]}.");
                        }
                        else if (studentSixInput.ToLower() == "favorite food")
                        {
                            Console.WriteLine($"{studentNames[5]} loves to eat {studentSixDetails[2]}.");
                        }
                        else if (studentSixInput.ToLower() != "hobbies" || studentSixInput.ToLower() != "hometown" || studentSixInput.ToLower() != "favorite food")
                        {
                            Console.WriteLine("That is not an option, please try again.");
                        }
                    }
                }
                else if (userAddOption.ToLower() == "y" && studentNames.Count == 6)
                {
                    Console.WriteLine($"Sorry, our classroom is at max capacity and cannot accept any new students at this time.");
                }

                Console.WriteLine($"Continue? (y/n)");
                userContinue = Console.ReadLine();

            } while (userContinue.ToLower() != "n");

            Console.ReadLine();

        }

    }
}


