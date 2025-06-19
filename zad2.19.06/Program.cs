namespace zad2._19._06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> studentBooks = new Dictionary<string, List<string>>();
            List<string> studentOrder = new List<string>();
            string line;
            while ((line = Console.ReadLine()) != "end")
            {
                string[] parts = line.Split(new string[] { " -> " }, StringSplitOptions.None);
                string studentName = parts[0];
                string bookTitle = parts[1];
                if (!studentBooks.ContainsKey(studentName))
                {
                    studentBooks.Add(studentName, new List<string>());
                    studentOrder.Add(studentName);
                }
                    studentBooks[studentName].Add(bookTitle);
            }
            foreach (string studentName in studentOrder)
            {
                Console.WriteLine($"{studentName}: {string.Join(", ", studentBooks[studentName])}");
            }

        }

        }
    }