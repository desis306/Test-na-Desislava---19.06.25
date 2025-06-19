namespace Zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Dictionary<string, int> letterCounts = new Dictionary<string, int>();
                string name;
                while ((name = Console.ReadLine()) != "stop")
                {
                    if (letterCounts.ContainsKey(name))
                    {
                        letterCounts[name]++;
                    }
                    else
                    {
                        letterCounts.Add(name, 1);
                    }
                }
                foreach (var entry in letterCounts)
                {
                    Console.WriteLine($"{entry.Key} -> {entry.Value}");
                }
            }
        }
    }
    

