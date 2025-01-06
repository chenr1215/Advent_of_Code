using System;
using System.IO;
using System.Linq;

class Advent2_1
{
    static void Main(string[] args)
    {
        string line;
        bool increasing = true;
        bool keeping = true;
        int safe = 0;
        List<String> row = new List<String>();
        List<int> nums = new List<int>();
        using (StreamReader sr = new StreamReader("Data2.txt"))
        {
            line = sr.ReadLine();

            while (line != null)
            {
                row.Add(line);

                line = sr.ReadLine();
            }
        }

        for(int i = 0; i < row.Count; i++)
        {

            nums = row[i].Split(' ').Select(int.Parse).ToList();
            increasing = nums[0] < nums[1];
            keeping = true;

            for (int j = 0; j < nums.Count - 1; j++)
            {
                int diff = Math.Abs(nums[j] - nums[j + 1]);

                if (diff < 1 || diff > 3)
                {
                    keeping = false;
                    break;
                }

                if (increasing && nums[j] >= nums[j + 1])
                {
                    keeping = false;
                    break;
                }
                else if (!increasing && nums[j] <= nums[j + 1])
                {
                    keeping = false;
                    break;
                }
            }
            if (keeping)
            {
                safe++;
            }
        }
        System.Console.WriteLine(safe);
    }
}