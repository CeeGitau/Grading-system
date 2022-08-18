// See https://aka.ms/new-console-template for more information
namespace Assignment1
{
    class Progam
    {
        static void Main(string[] args)
        {
            int size;

            Console.Write("Enter the number of students: ");
            size = Convert.ToInt32(Console.ReadLine());

            string[] name = new string[size];
            int[] marks = new int[size];
            string[] grade = new string[size];

            Console.WriteLine("Enter the name of the student, press Enter, and then input their marks and press Enter again");
            Console.WriteLine("Perform that operation for all {0} students: ", size);

            for (int i = 0; i < size; i++)
            {
                name[i] = Console.ReadLine();
                marks[i] = Convert.ToInt32(Console.ReadLine());
                while (marks[i] < 0 || marks[i] > 100)
                {
                    Console.WriteLine("Enter a mark in the range 0 - 100.");
                    marks[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("-----------------------");

                if (marks[i] >= 60 && marks[i] <= 100)
                {
                    grade[i] = "A";
                }
                else if (marks[i] >= 40 && marks[i] <= 59)
                {
                    grade[i] = "B";
                }
                else
                {
                    grade[i] = "C";
                }
            }
            Console.WriteLine("Here are the results: ");

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("{0} | {1} | {2}", name[i], marks[i], grade[i]);
            }
            Console.ReadLine();
        }
    }
}
