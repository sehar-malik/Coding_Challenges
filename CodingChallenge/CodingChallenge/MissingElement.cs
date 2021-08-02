using System;
using System.Collections.Generic;

namespace CodingChallenge
{
    public class MissingElement
    {
        public void MissingElementMethod()
        {
            List<int> arrList = new List<int>{
                5,3,1,2
            };
            List<int> missingElements = new List<int>();
            arrList.Sort();
            Console.WriteLine($"Smallest element: {arrList[0]}");
            Console.WriteLine($"Largest element: {arrList[arrList.Count - 1]}");
            for (int i = 0; i < arrList.Count - 1; i++)
            {
                if (arrList[i + 1] != arrList[i] + 1)
                    missingElements.Add(arrList[i] + 1);
            }
            Console.WriteLine($"\n Missing numbers: {String.Join(' ', missingElements)}");
        }
    }
}
