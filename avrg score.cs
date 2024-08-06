using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lastExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This app Show Your Average Grade.");
            bool exit = true;

            do
            {

                Console.Write("Please Enter Number of Lesson: ");
                int numberOfScore = 0;
                while (!int.TryParse(Console.ReadLine(), out numberOfScore))
                {
                    Console.Write("Error, Please Enter Number of Lessons, Again:");
                }
                double[] ScoreArray = new double[numberOfScore];
                int i = 0;
                while (i < numberOfScore)
                {
                    try
                    {
                        Console.Write("Please Enter Score of Lesson {0}: ", i + 1);
                        double score = Convert.ToDouble(Console.ReadLine());
                        if (score <= 20 && score >= 0)
                        {
                            ScoreArray[i] = score;
                            i++;
                        }
                        else
                        {
                            Console.WriteLine("The Score Should be between 0 and 20. ");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Wrong Score Format!!!");
                    }
                }
                double sum = 0;
                foreach (double grade in ScoreArray)
                {
                    sum += grade;
                }
                Console.WriteLine("Your Scores are: " + string.Join(",", ScoreArray));
                Console.WriteLine("Your Average Grade is : {0}", sum / ScoreArray.Length);
                Console.WriteLine("---------------End------------------");
                Console.Write("If you want to exit the program, type \"E\", otherwise enter: ");

                var exitString = Console.ReadLine();
                if (!string.IsNullOrEmpty(exitString) && exitString.Trim().ToLower() == "e")
                    exit = true;
                else
                {
                    exit = false;
                    Console.Clear();
                    Console.WriteLine("--------------Start Again-------------");
                }

            } while (!exit);
        }
    }
}
