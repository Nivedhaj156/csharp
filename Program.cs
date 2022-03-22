using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace concepts_of_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "dog", "cat", "animal", "1", "2", "3" };
            for(int i=0;i<name.Length;i++)
            {
                Console.WriteLine(name[i]);
            }
            Console.WriteLine("\n");
            foreach(string names in name)  //array values are stored in string variable
            {
                Console.WriteLine(names);   
            }

            string[] name1 = { "dog", "cat", "animal", "1", "2", "3" };
            int j = 0;
            while(j<name1.Length)
            {
                Console.WriteLine(name1[j]);
                j++;
            }

        }
    }
}
