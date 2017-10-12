using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANFIS.UI
{
    public static class FileReader
    {
        public static (double[][] input, double[][] output) ReadFile(string filepath)
        {
            var allLines = File.ReadAllLines(filepath);
            var lines = allLines.Except(allLines.Where(s => string.IsNullOrWhiteSpace(s) || s[0] == '#')).ToList();
            int numberOfClasses = Convert.ToInt32(NumParser.ParseDouble(lines.First(s => s[0] == '$').Remove(0, 1)));
            lines.Remove(lines.First(s => s[0] == '$'));

            var inputList = new List<List<double>>();
            var outputList = new List<double[]>();

            foreach (var line in lines)
            {
                var nums = line.Split(',').Select(s => NumParser.ParseDouble(s)).ToList();
                var list = new List<double>();
                for (int i = 0; i < nums.Count - 1; i++)
                    list.Add(nums[i]);
                inputList.Add(list);

                var outputAr = new double[numberOfClasses];
                outputAr[Convert.ToInt32(nums[nums.Count - 1])] = 1;
                outputList.Add(outputAr);
            }

            return (inputList.Select(l => l.ToArray()).ToArray(), outputList.ToArray());
        }
    }
}
