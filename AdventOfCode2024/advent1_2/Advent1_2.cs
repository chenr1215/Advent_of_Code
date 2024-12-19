using System;
using System.IO;

class Advent1_2
{
    static void Main(string[] args)
    {
        string line;
        int total = 0;
        int current;
        List<String> row = new List<String>();
        List<int> col1 = new List<int>();
        List<int> col2 = new List<int>();

        using (StreamReader sr = new StreamReader("Data11.txt"))
        {
            line = sr.ReadLine();

            while (line != null)
            {
                row.Add(line);

                line = sr.ReadLine();
            }
        }

        Console.WriteLine("Done Reading");

        for(int i = 0; i < row.Count; i++)
        {
            if (row[i] == "!")
            {
                break;
            }
            String one = row[i].Substring(0, 5);
            String two = row[i].Substring(8);
            col1.Add(int.Parse(one));
            col2.Add(int.Parse(two));
        }
        
        col1.Sort();
        col2.Sort();

        for(int i = 0; i < col1.Count; i++)
        {
            current= col1[i];
            for (int j = 0; j < col2.Count; j++)
            {
                if (col2[j] == current)
                {
                    total += current;
                }
            }
        }

        System.Console.WriteLine(total);
    }
}