using System;
using System.IO;

namespace Phase1Section3._13
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "student_data.txt";

            if (!File.Exists(filePath))
            {
                Console.WriteLine("The file 'student_data.txt' does not exist.");
                return;
            }

            string[] lines = File.ReadAllLines(filePath);

            if (lines.Length == 0)
            {
                Console.WriteLine("The file 'student_data.txt' is empty.");
                return;
            }

            Console.WriteLine("Student Data:");
            foreach (string line in lines)
            {
                string[] data = line.Split(',');
                if (data.Length >= 3)
                {
                    string name = data[0].Trim();
                    string age = data[1].Trim();
                    string fieldOfStudy = data[2].Trim();

                    Console.WriteLine($"Name: {name}, Age: {age}, Field of Study: {fieldOfStudy}");
                    Console.ReadKey();
                }
            }
        }
    }
}
