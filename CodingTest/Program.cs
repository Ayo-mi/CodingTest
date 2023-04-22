using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var obj = new MatchingCharacters();
            string[] a = { "nellie", "leslie", "stella" };
            //Console.WriteLine(obj.CalculatePoints(new List<string> { "5", "-2", "4", "C", "D", "9", "+", "+"}));
            foreach(var i in obj.Solution(a))
                Console.WriteLine(i);
            Console.ReadKey();


            /*int[] nums = { -1, 0, 1, 2, -1, -4 };
            
            var arrayResult = new List<int>();
            for (int i=0; i<nums.Length; i++)
            {
                int positionVal = nums[i];
                int x = i;
                int ind = 0;
                int j = ind + 1;
                while (x < nums.Length)
                {
                    //Console.WriteLine(j + "c " + ind);
                    int sum = 0;
                    if (ind == i)                
                    {                    
                        ind += 1;                
                    }                
                
                    if (j == x || j==ind)                
                    {                    
                        j += 1;                
                    }
                    try
                    {
                        if (!(j >= 6))
                        {
                        
                        sum = positionVal + nums[ind] + nums[j];
                       // Console.WriteLine(positionVal + " + " + nums[ind] + " + " + nums[j]);

                        if (sum == 0)
                        {
                            int[] elements = { positionVal, nums[ind], nums[j] };
                            arrayResult.AddRange(elements);
                        }
                            //Console.WriteLine("hey there positionval=" + positionVal + " ind=" + nums[ind] + " j=" + nums[j] + " ans=" + sum);
                        }

                    }
                    catch(IndexOutOfRangeException e)
                    {
                        Console.WriteLine(e.Message.ToString()+" val of j="+j);

                    }
                                                          
                    ind+=1;
                    j+=1;
                    x++;
                    
                }

            }

            //outputing final result
            int a = 0;
            for (int i = 0; i < arrayResult.Count; i++)
            {
                if (a == 0) Console.Write("[");

                if(a==2) Console.Write(arrayResult[i] + "");

                else Console.Write(arrayResult[i]+", ");
                
                if (a==2)
                {
                    Console.Write("] ");
                    a = 0;
                }else a += 1;
               
            }
                
         Console.ReadKey();
        */}
    }
}
