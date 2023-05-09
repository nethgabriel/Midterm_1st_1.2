//Part 2

namespace Midterm_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;

            StreamReader sr = new StreamReader ("C:\\Users\\KENNETH GABRIEL\\source\\repos\\Midterm.txt");

            line = sr.ReadToEnd();

            while (line != null)
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            }

            sr.Close();

            StreamWriter sw = new StreamWriter("C:\\Users\\KENNETH GABRIEL\\source\\repos\\Midterm.txt", true);

            sw.WriteLine("Application Run Time " + DateTime.Now);
            
            sw.Close();
        }
    }
}