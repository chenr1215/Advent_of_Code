using System;
using System.IO;

class Advent1_1
{
    static void Main(string[] args)
    {
        string line;
        int total = 0;
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
            int num = Math.Abs(col1[i] - col2[i]);
            total += num;
        }

        System.Console.WriteLine(total);
    }
}