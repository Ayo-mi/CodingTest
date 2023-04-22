using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class BaseballGame
    {

        public int CalculatePoints(List<string> options)
        {
            List<int> record = new List<int>();
            int a = 0;
            foreach (var i in options)
            {
                if (int.TryParse(i, out int num))
                    record.Add(num);
                else if (i.ToUpper() == "C")
                    record.Remove(record[record.Count - 1]);
                else if (i == "D")
                    record.Add(2 * record[record.Count - 1]);
                else if (i == "+")
                    record.Add(record[record.Count - 1] + record[record.Count - 2]);
                a++;
            }
            
            return record.Sum();
        }
    }
}
