﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class MatchingCharacters
    {
        public IList<string> Solution(string[] k)
        {
            IList<string> output = new List<string>();

            foreach(var a in k[0])
            {
                List<string> temp = new List<string>();
                bool isFound = false;
                for (int i = 1; i < k.Length; i++)
                {
                    if (k[i].Contains(a))
                    {                        
                        k[i] = k[i].Remove(k[i].IndexOf(a), 1);                       
                        isFound = true;
                    }
                    else
                    {
                        isFound = false;
                        break;
                    }
                        
                }
                if (isFound)
                    output.Add(a.ToString());
            }

            //foreach(var i in k)
            //{
            //    //Console.WriteLine(i);
            //    List<string> temp = new List<string>();
            //    foreach(var a in i)
            //    {
            //        int sum = 0;
            //        //Console.WriteLine(a);
            //        for (int x = 0; x < i.Length; x++)
            //        {
            //            if (a == i[x])
            //                sum += 1;
            //        }
            //        if (sum >= 2 && !temp.Contains(a.ToString()))
            //            temp.Add(a.ToString());
            //    }
            //    output.AddRange(temp);
            //}
            return output;
        }
    }
}