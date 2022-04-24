using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_17_DataStructureAndAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nHow many words you want to add : ");
            int noOfWords = Convert.ToInt32(Console.ReadLine());
            string[] words = new string[noOfWords];
            Console.WriteLine("\nEnter words one by one : ");
            for (int i = 0; i < noOfWords; i++)
            {
                words[i] = Console.ReadLine();
            }
            Console.WriteLine("\nWhich word you want to search : ");
            string w = Console.ReadLine();
            int pos = BinarySearch.searchWord(words, w);
            if (pos == -1)
            {
                Console.WriteLine($"\n\"{w}\" word not found");
            }
            else
                Console.WriteLine($"\n\"{w}\" word founded");
            
        }
    }
}
