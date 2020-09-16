using System;
using System.Collections.Generic;
using System.Linq;

namespace print_duplicate_nos_in_a_collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no's !");
            var input =  Console.ReadLine().Split(" ").Select(i=> Convert.ToInt32(i)).ToList();
            FindDuplicate(input);
            Console.WriteLine();
            FindDuplicateWOHash(input);
        }

        static void FindDuplicate(List<int> nos)
        {
            HashSet<int> set = new HashSet<int>();

            foreach(int i in nos)
            {
                if (set.Contains(i)) Console.WriteLine(i);
                else set.Add(i);
            }
                
        }

        static void FindDuplicateWOHash(List<int> nos)
        {
            int size = nos.Count;
            for (int i = 0; i < size; i++)
            {
                int j = i + 1;
                while(j < size)
                {
                    if (nos[i] == nos[j++]) Console.WriteLine(nos[i]);
                }
            }
        }

    }
}
